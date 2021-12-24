using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ArduinoLocomotiveController.Properties;

namespace ArduinoLocomotiveController
{
    public partial class ControlPanel : Form
    {
        //bool ReverserLock = false;  //False = Unlocked, True = Locked
        bool PantagraphState = false;   //False = Lower, True = Upper
        bool SCC_NeedHide = false;
        bool AutoFlashFirstTime = true;
        bool IndeFlashFirstTime = true;
        bool EBrakeStatus = false;

        #region FontEmbed

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private readonly PrivateFontCollection fonts = new PrivateFontCollection();

        readonly Font DigitalFont;
        readonly Font EBrakeFont;

        public ControlPanel()
        {
            InitializeComponent();

            byte[] fontData = Resources.digifaw;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Resources.digifaw.Length);
            AddFontMemResourceEx(fontPtr, (uint)Resources.digifaw.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);

            DigitalFont = new Font(fonts.Families[0], 75.0F, FontStyle.Italic);
            EBrakeFont = new Font(fonts.Families[0], 75.0F, FontStyle.Italic | FontStyle.Underline);
        }

        #endregion

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            PowerNum.Font = DigitalFont;
            CheckForIllegalCrossThreadCalls = false;    //Unsafe

            #region Arduino Support Initialization

            try
            {
                string[] Ports = SerialPort.GetPortNames();
                PortList.Items.AddRange(Ports);
                PortList.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("您未插入任何设备！");
            }

            string[] Baud = { "9600", "19200", "38400", "57600", "115200" };
            BaudList.Items.AddRange(Baud);
            BaudList.SelectedIndex = 0;
            serialPort.BaudRate = 9600;

            #endregion
        }

        #region SCA

        private void ControlPanel_Shown(object sender, EventArgs e)
        {
            DirectionActivibility.ForeColor = Color.Black;
            PortList.Enabled = BaudList.Enabled = LinkStart.Enabled = EBrake.Enabled  = Power.Enabled = false;
            Application.DoEvents();
            //
            //111
            //
            Thread.Sleep(500);
            Direction.BackColor = Color.DarkOrange;
            PowerNum.Text = "1";
            Application.DoEvents();
            //
            //222
            //
            Thread.Sleep(250);
            Direction.BackColor = SystemColors.Control;
            Power.BackColor = Color.OliveDrab;
            PowerNum.Text = "2";
            Application.DoEvents();
            //
            //333
            //
            Thread.Sleep(250);
            Power.BackColor = SystemColors.Control;
            //AutoBrake.BackColor = Color.Red;
            AHL.BackColor = AHR.BackColor = AFL.BackColor = AFR.BackColor = Color.Red;
            PowerNum.Text = "3";
            Application.DoEvents();
            //
            //444
            //
            Thread.Sleep(250);
            //AutoBrake.BackColor = SystemColors.Control;
            //IndeBrake.BackColor = Color.DarkMagenta;
            AHL.BackColor = AHR.BackColor = AFL.BackColor = AFR.BackColor = SystemColors.Control;
            IHL.BackColor = IHR.BackColor = IFL.BackColor = IFR.BackColor = Color.DarkMagenta;
            PowerNum.Text = "4";
            Application.DoEvents();
            //
            //555
            //
            Thread.Sleep(250);
            //IndeBrake.BackColor = SystemColors.Control;
            Direction.BackColor = Color.DarkOrange;
            IHL.BackColor = IHR.BackColor = IFL.BackColor = IFR.BackColor = SystemColors.Control;
            PowerNum.Text = "5";
            Application.DoEvents();
            //
            //666
            //
            Thread.Sleep(250);
            Direction.BackColor = SystemColors.Control;
            Power.BackColor = Color.OliveDrab;
            PowerNum.Text = "6";
            Application.DoEvents();
            //
            //777
            //
            Thread.Sleep(250);
            Power.BackColor = SystemColors.Control;
            //AutoBrake.BackColor = Color.Red;
            AHL.BackColor = AHR.BackColor = AFL.BackColor = AFR.BackColor = Color.Red;
            PowerNum.Text = "7";
            Application.DoEvents();
            //
            //888
            //
            Thread.Sleep(250);
            //AutoBrake.BackColor = SystemColors.Control;
            //IndeBrake.BackColor = Color.DarkMagenta;
            AHL.BackColor = AHR.BackColor = AFL.BackColor = AFR.BackColor = SystemColors.Control;
            IHL.BackColor = IHR.BackColor = IFL.BackColor = IFR.BackColor = Color.DarkMagenta;
            PowerNum.Text = "8";
            Application.DoEvents();
            //
            //Clean Up
            //
            Thread.Sleep(250);
            //IndeBrake.BackColor = SystemColors.Control;
            IHL.BackColor = IHR.BackColor = IFL.BackColor = IFR.BackColor = SystemColors.Control;
            Application.DoEvents();
            //
            //Flash Show
            //
            Thread.Sleep(250);
            Direction.BackColor = Color.DarkOrange;
            Power.BackColor = Color.OliveDrab;
            //AutoBrake.BackColor = Color.Red;
            //IndeBrake.BackColor = Color.DarkMagenta;
            AHL.BackColor = AHR.BackColor = AFL.BackColor = AFR.BackColor = Color.Red;
            IHL.BackColor = IHR.BackColor = IFL.BackColor = IFR.BackColor = Color.DarkMagenta;
            PowerNum.Text = "";
            Application.DoEvents();
            //
            //Flash Hide
            //
            Thread.Sleep(500);
            Direction.BackColor = SystemColors.Control;
            Power.BackColor = SystemColors.Control;
            //AutoBrake.BackColor = SystemColors.Control;
            //IndeBrake.BackColor = SystemColors.Control;
            AHL.BackColor = AHR.BackColor = AFL.BackColor = AFR.BackColor = SystemColors.Control;
            IHL.BackColor = IHR.BackColor = IFL.BackColor = IFR.BackColor = SystemColors.Control;
            PowerNum.Text = "8";
            AutoApp.Visible = IndeApp.Visible = false;
            PowerLock.Visible = false;
            DirectionLock.Visible = false;
            Application.DoEvents();
            //
            //SCC
            //
            SCing_Hide();
            Application.DoEvents();
            NeutralL.BackColor = NeutralR.BackColor = Color.Yellow;
            IDLE.BackColor = Color.SpringGreen;
            Direction_Enter(sender, e);
            Application.DoEvents();
            PowerNum.Text = "0";
            PowerLock.Visible = true;
            Power.Enabled = false;
            Application.DoEvents();
            PortList.Enabled = BaudList.Enabled = LinkStart.Enabled = EBrake.Enabled = true;
        }

        private void SCing_Hide()
        {
            SCing.Visible = false;
            SCC_Cover.Visible = false;
            SCC_NeedHide = true;
            Application.DoEvents();
        }

        #endregion

        #region Connection Establishied

        public void ConnectionVerified()
        {
            LblCE.Visible = true;
            Thread.Sleep(3000);
            LblCE.Visible = false;
        }

        #endregion

        #region Focus Indication via TextColor

        private void Direction_Enter(object sender, EventArgs e)
        {
            DirectionActivibility.ForeColor = Color.LightSeaGreen;
            if (SCC_NeedHide == true)
            {
                SCC.Visible = true;
                Application.DoEvents();
                Thread.Sleep(1000);
                SCC.Visible = false;
                SCC_NeedHide = false;
            }
        }

        private void Direction_Leave(object sender, EventArgs e)
        {
            DirectionActivibility.ForeColor = Color.Black;
        }

        private void Power_Enter(object sender, EventArgs e)
        {
            PowerActivibility.ForeColor = Color.LightSeaGreen;
        }

        private void Power_Leave(object sender, EventArgs e)
        {
            PowerActivibility.ForeColor= Color.Black;
        }

        private void AutoBrake_Enter(object sender, EventArgs e)
        {
            AutoActivibility.ForeColor = Color.LightSeaGreen;
        }

        private void AutoBrake_Leave(object sender, EventArgs e)
        {
            AutoActivibility.ForeColor = Color.Black;
        }

        private void IndeBrake_Enter(object sender, EventArgs e)
        {
            IndeActivibility.ForeColor = Color.LightSeaGreen;
        }

        private void IndeBrake_Leave(object sender, EventArgs e)
        {
            IndeActivibility.ForeColor = Color.Black;
        }

        #endregion

        private void Direction_Scroll(object sender, EventArgs e)
         {
            #region dBar Label Color Change

            switch (Direction.Value)
            {
                case 1:
                    Direction.BackColor = Color.DarkOrange;
                    ForwardL.BackColor = Color.Yellow;
                    ForwardR.BackColor = Color.Yellow;
                    NeutralL.BackColor = SystemColors.ControlLight;
                    NeutralR.BackColor = SystemColors.ControlLight;
                    ReverseL.BackColor = SystemColors.ControlLight;
                    ReverseR.BackColor = SystemColors.ControlLight;
                    break;
                case 0:
                    Direction.BackColor = SystemColors.Control;
                    ForwardL.BackColor = SystemColors.ControlLight;
                    ForwardR.BackColor = SystemColors.ControlLight;
                    NeutralL.BackColor = Color.Yellow;
                    NeutralR.BackColor = Color.Yellow;
                    ReverseL.BackColor = SystemColors.ControlLight;
                    ReverseR.BackColor = SystemColors.ControlLight;
                    break;
                case -1:
                    Direction.BackColor = Color.DarkOrange;
                    ForwardL.BackColor = SystemColors.ControlLight;
                    ForwardR.BackColor =SystemColors.ControlLight;
                    NeutralL.BackColor = SystemColors.ControlLight;
                    NeutralR.BackColor = SystemColors.ControlLight;
                    ReverseL.BackColor = Color.Yellow;
                    ReverseR.BackColor = Color.Yellow;
                    break;
            }

            #endregion

            #region pBarLock

            if (Direction.Value != 0)
            {
                Power.Enabled = true;
                PowerLock.Visible = false;
            }
            else
            {
                Power.Enabled = false;
                PowerLock.Visible = true;
            }

            #endregion
        }

        private void Power_Scroll(object sender, EventArgs e)
        {
            #region pBar Color Change

            switch (Power.Value)
            {
                case 5:
                    P1.Show();
                    P2.Show();
                    P3.Show();
                    P4.Show();
                    P5.Show();
                    break;
                case 4:
                    P1.Show();
                    P2.Show();
                    P3.Show();
                    P4.Show();
                    P5.Hide();
                    break;
                case 3:
                    P1.Show();
                    P2.Show();
                    P3.Show();
                    P4.Hide();
                    P5.Hide();
                    break;
                case 2:
                    P1.Show();
                    P2.Show();
                    P3.Hide();
                    P4.Hide();
                    P5.Hide();
                    break;
                case 1:
                    P1.Show();
                    P2.Hide();
                    P3.Hide();
                    P4.Hide();
                    P5.Hide();
                    break;
                case 0:
                    P1.Hide();
                    P2.Hide();
                    P3.Hide();
                    P4.Hide();
                    P5.Hide();
                    B1.Hide();
                    B2.Hide();
                    B3.Hide();
                    B4.Hide();
                    B5.Hide();
                    break;
                case -1:
                    B1.Show();
                    B2.Hide();
                    B3.Hide();
                    B4.Hide();
                    B5.Hide();
                    break;
                case -2:
                    B1.Show();
                    B2.Show();
                    B3.Hide();
                    B4.Hide();
                    B5.Hide();
                    break;
                case -3:
                    B1.Show();
                    B2.Show();
                    B3.Show();
                    B4.Hide();
                    B5.Hide();
                    break;
                case -4:
                    B1.Show();
                    B2.Show();
                    B3.Show();
                    B4.Show();
                    B5.Hide();
                    break;
                case -5:
                    B1.Show();
                    B2.Show();
                    B3.Show();
                    B4.Show();
                    B5.Show();
                    break;
            }

            #endregion

            #region pBar Label Color Change

            if (Power.Value == 5)
            {
                FULLTHROTTLE.BackColor = Color.Red;
                FULLTHROTTLE.ForeColor = Color.LimeGreen;
                IDLE.BackColor = SystemColors.ControlLight;
                DYNAMICBRAKE.BackColor = SystemColors.ControlLight;
                DYNAMICBRAKE.ForeColor = Color.Black;
            }
            else if (Power.Value > 0 & Power.Value < 5)
            {
                FULLTHROTTLE.BackColor = SystemColors.ControlLight;
                FULLTHROTTLE.ForeColor = Color.LimeGreen;
                IDLE.BackColor = SystemColors.ControlLight;
                DYNAMICBRAKE.BackColor = SystemColors.ControlLight;
                DYNAMICBRAKE.ForeColor = Color.Black;
            }
            else if (Power.Value == 0)
            {
                FULLTHROTTLE.BackColor = SystemColors.ControlLight;
                FULLTHROTTLE.ForeColor = Color.Black;
                IDLE.BackColor = Color.SpringGreen;
                DYNAMICBRAKE.BackColor = SystemColors.ControlLight;
                DYNAMICBRAKE.ForeColor = Color.Black;
            }
            else if (Power.Value < 0 & Power.Value > -5)
            {
                FULLTHROTTLE.BackColor = SystemColors.ControlLight;
                FULLTHROTTLE.ForeColor = Color.Black;
                IDLE.BackColor = SystemColors.ControlLight;
                DYNAMICBRAKE.BackColor = SystemColors.ControlLight;
                DYNAMICBRAKE.ForeColor = Color.DarkOrange;
            }
            else if (Power.Value == -5)
            {
                FULLTHROTTLE.BackColor = SystemColors.ControlLight;
                FULLTHROTTLE.ForeColor = Color.Black;
                IDLE.BackColor = SystemColors.ControlLight;
                DYNAMICBRAKE.BackColor = Color.Red;
                DYNAMICBRAKE.ForeColor = Color.DarkOrange;
            }

            #endregion

            #region dBar Lock & pBar/pNum Color Change

            switch (Power.Value)
            {
                case var _ when Power.Value > 0:
                    Direction.Enabled = false;
                    DirectionLock.Visible = true;
                    Power.BackColor = Color.DarkOliveGreen;
                    PowerNum.ForeColor = Color.LimeGreen;
                    break;
                case 0:
                    Direction.Enabled = true;
                    DirectionLock.Visible = false;
                    Power.BackColor = SystemColors.Control;
                    PowerNum.ForeColor = SystemColors.Info;
                    break;
                case var _ when Power.Value < 0:
                    Direction.Enabled = false;
                    DirectionLock.Visible = true;
                    Power.BackColor = Color.DarkGoldenrod;
                    PowerNum.ForeColor = Color.Gold;
                    break;
            }

            #endregion

            #region pNum Display

            switch (Power.Value)
            {
                case 0:
                    PowerNum.Text = "0";
                    break;
                case 1:
                case -1:
                    PowerNum.Text = "1";
                    break;
                case 2:
                case -2:
                    PowerNum.Text = "2";
                    break;
                case 3:
                case -3:
                    PowerNum.Text = "3";
                    break;
                case 4:
                case -4:
                    PowerNum.Text = "4";
                    break;
                case 5:
                case -5:
                    PowerNum.Text = "5";
                    break;
            }

            #endregion
        }

        private void AutoBrake_Scroll(object sender, EventArgs e)
        {
            #region BrakeLevel Indicator

            switch (AutoBrake.Value)
            {
                case 0:
                    AHL.BackColor = AHR.BackColor = AFL.BackColor = AFR.BackColor = SystemColors.Control;
                    AutoApp.Visible = false;
                    break;
                case 1:
                    AHL.BackColor = AHR.BackColor = Color.Red;
                    AFL.BackColor = AFR.BackColor = SystemColors.Control;
                    AutoApp.Visible = true;
                    AFL.Size = new Size(13, 139);
                    AFR.Size = new Size(14, 139);
                    break;
                case 2:
                    AHL.BackColor = AHR.BackColor = Color.Red;
                    AFL.BackColor = AFR.BackColor = Color.Red;
                    AutoApp.Visible = true;
                    AFL.Size = new Size(13, 159);
                    AFR.Size = new Size(14, 159);
                    break;
            }

            #endregion

            #region AutoFlash

            //bool AFStopCode = false;
            ThreadStart threadStart = new ThreadStart(BrakeFlash);
            Thread BrakeFlashThread = new Thread(threadStart);
            //Thread AutoFlashThread = new Thread(() =>
            //{
                //for (int i = 0; i < 2; i++)
                //{
                //    if (AutoBrake.InvokeRequired)
                //    {
                //        AutoBrake.Invoke(new Action<TrackBarNoBorder, int>(SetABValue), AutoBrake, i);
                //    }
                //    else
                //    {
                //        AutoBrake.Value = i;
                //    }
                //}

                //if (AutoBrake.Value != 0)
                //{
                //    AFStopCode = false;
                //}
                //else if (AutoBrake.Value == 0)
                //{
                //    AFStopCode = true;
                //}
            //});

            //AutoFlashThread.Priority = ThreadPriority.Highest;
            if (AutoBrake.Value != 0)
            {
                if (AutoFlashFirstTime == true)
                {
                    BrakeFlashThread.Start();
                    AutoFlashFirstTime = false;
                }
            }
            else if (AutoBrake.Value == 0)
            {
                //while (AutoFlashThread.ThreadState != ThreadState.Stopped)
                //{
                //    AutoFlashThread.Abort();
                //}
                AutoFlashFirstTime = true;
                LblAuto.ForeColor = Color.Black;
                BrakeFlashThread.Start();
            }

            #endregion
        }

        #region _! Deprecated !_ AutoFlashFunction

        //public void AutoFlash()
        //{
        //    while (AutoBrake.Value != 0)
        //    {
        //        //if (AutoBrake.InvokeRequired)
        //        //{
        //        //    Action<int> action = new Action<int>(AutoFlash);
        //        //    Invoke(action, new object[] { ABValue });
        //        //}
        //        //else
        //        //{
        //        //    AutoBrake.Value = ABValue;
        //        //}


        //        //if (AutoBrake.Value != 0)
        //        //{
        //            LblAuto.ForeColor = Color.Red;
        //            Thread.Sleep(500);
        //            LblAuto.ForeColor = Color.Black;
        //            Thread.Sleep(500);
        //        //}
        //        //else
        //        //{
        //        //LblAuto.ForeColor = Color.Black;
        //        //break;
        //        //}
        //    }
        //    //LblAuto.ForeColor = Color.Black;
        //}

        ////private void SetABValue(TrackBarNoBorder tBar, int value)
        ////{
        ////    tBar.Value = value;
        ////}

        #endregion

        private void IndeBrake_Scroll(object sender, EventArgs e)
        {
            #region BrakeLevel Indicator

            switch (IndeBrake.Value)
            {
                case 0:
                    IHL.BackColor = IHR.BackColor = IFL.BackColor = IFR.BackColor = SystemColors.Control;
                    IndeApp.Visible = false;
                    break;
                case 1:
                    IHL.BackColor = IHR.BackColor = Color.DarkMagenta;
                    IFL.BackColor = IFR.BackColor = SystemColors.Control;
                    IndeApp.Visible = true;
                    IFL.Size = new Size(13, 139);
                    IFR.Size = new Size(14, 139);
                    break;
                case 2:
                    IHL.BackColor = IHR.BackColor = Color.DarkMagenta;
                    IFL.BackColor = IFR.BackColor = Color.DarkMagenta;
                    IndeApp.Visible = true;
                    IFL.Size = new Size(13, 159);
                    IFR.Size = new Size(14, 159);
                    break;
            }

            #endregion

            #region IndeFlash

            ThreadStart threadStart = new ThreadStart(BrakeFlash);
            Thread BrakeFlashThread = new Thread(threadStart);
            if (IndeBrake.Value != 0)
            {
                if (IndeFlashFirstTime == true)
                {
                    BrakeFlashThread.Start();
                    IndeFlashFirstTime = false;
                }
            }
            else if (IndeBrake.Value == 0)
            {
                IndeFlashFirstTime = true;
                LblInde.ForeColor = Color.Black;
                BrakeFlashThread.Start();
            }
            #endregion
        }

        #region _! Deprecated !_ IndeFlashFunction

        //public void IndeFlash()
        //{
        //    while (IndeBrake.Value != 0)
        //    {
        //        LblInde.ForeColor = Color.Red;
        //        Thread.Sleep(500);
        //        LblInde.ForeColor = Color.Black;
        //        Thread.Sleep(500);
        //    }
        //}

        #endregion

        #region BrakeFlash Function

        public void BrakeFlash()
        {
            while (AutoBrake.Value != 0 & IndeBrake.Value == 0)
            {
                LblAuto.ForeColor = Color.Red;
                Thread.Sleep(500);
                LblAuto.ForeColor = Color.Black;
                Thread.Sleep(500);
            }

            while (AutoBrake.Value == 0 & IndeBrake.Value != 0)
            {
                LblInde.ForeColor = Color.Red;
                Thread.Sleep(500);
                LblInde.ForeColor = Color.Black;
                Thread.Sleep(500);
            }

            while (AutoBrake.Value != 0 & IndeBrake.Value != 0)
            {
                LblAuto.ForeColor = Color.Red;
                LblInde.ForeColor = Color.Red;
                Thread.Sleep(500);
                LblAuto.ForeColor = Color.Black;
                LblInde.ForeColor = Color.Black;
                Thread.Sleep(500);
            }
        }

        #endregion

        #region Avoid Focus

        private void PowerNum_Enter(object sender, EventArgs e)
        {
            #region Disable Mouse Pointer Focus for PowerNum
            if (Power.Enabled == false)
            {
                Direction.Focus();
            }
            else
            {
                Power.Focus();
            }
            #endregion
        }

        private void DirectionActivibility_Click(object sender, EventArgs e)
        {
            Direction.Focus();
        }

        private void PowerActivibility_Click(object sender, EventArgs e)
        {
            #region Power.Focus();

            if (Power.Enabled == false)
            {
                Direction.Focus();
            }
            else
            {
                Power.Focus();
            }

            #endregion
        }

        private void AutoActivibility_Click(object sender, EventArgs e)
        {
            AutoBrake.Focus();
        }

        private void IndeActivibility_Click(object sender, EventArgs e)
        {
            IndeBrake.Focus();
        }

        #endregion

        private void EBrake_Click(object sender, EventArgs e)
        {
            if (EBrakeStatus == false)
            {
                AutoBrake.Value = IndeBrake.Value = 2;
                Power.Value = 0;
                AutoBrake_Scroll(sender, e);
                IndeBrake_Scroll(sender, e);
                Direction.Value = 0;
                Direction_Scroll(sender, e);
                Power_Scroll(sender, e);
                PowerNum.Font = EBrakeFont;
                PowerNum.ForeColor = Color.Red;
                Direction.Enabled = AutoBrake.Enabled = IndeBrake.Enabled = false;
                EBrake.Image = Resources.EB_Reset;
                EBrakeStatus = true;
                Thread.Sleep(100);
            }
            else if (EBrakeStatus == true)
            {
                AutoBrake.Value = IndeBrake.Value = 0;
                AutoBrake_Scroll(sender, e);
                IndeBrake_Scroll(sender, e);
                PowerNum.Font = DigitalFont;
                PowerNum.ForeColor = SystemColors.Info;
                Direction.Enabled = AutoBrake.Enabled = IndeBrake.Enabled = true;
                EBrake.Image = Resources.EB_Applied;
                EBrakeStatus = false;
            }
        }

        private void ControlPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            AutoBrake.Value = 0;
            IndeBrake.Value = 0;
        }

        #region serialPort Connect & Disconnect & Connection Verification

        private void LinkStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    LinkStart.Text = "Connect";
                    PortList.Enabled = true;
                    BaudList.Enabled = true;
                }
                else
                {
                    PortList.Enabled = false;
                    BaudList.Enabled = false;
                    serialPort.PortName = PortList.Text;
                    serialPort.BaudRate = Convert.ToInt32 (BaudList.Text);
                    serialPort.Open();
                    LinkStart.Text = "Disconnect";
                }
            }
            catch (Exception ex)
            {
                serialPort.Close();
                PortList.Items.Clear();
                PortList.Items.AddRange(SerialPort.GetPortNames());
                LinkStart.Text = "Connect";
                MessageBox.Show(ex.Message);
                PortList.Enabled = true;
                BaudList.Enabled = true;
            }

            string CV = serialPort.ReadExisting();
            if (CV.Contains("PING"))
            {
                ThreadStart threadStart = new ThreadStart(ConnectionVerified);
                Thread CVThread = new Thread(threadStart);
                CVThread.Start();
            }
            else
            {
                serialPort.Close();
                PortList.Items.Clear();
                PortList.Items.AddRange(SerialPort.GetPortNames());
                LinkStart.Text = "Connect";
                PortList.Enabled = true;
                BaudList.Enabled = true;
            }
        }

        #endregion

    }
}
