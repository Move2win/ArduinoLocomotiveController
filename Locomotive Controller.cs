using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection;
using System.IO;

namespace ArduinoLocomotiveController
{
    public partial class ControlPanel : Form
    {
        //bool ReverserLock = false;  //False = Unlocked, True = Locked
        bool PantagraphState = false;   //False = Lower, True = Upper
        bool SCC_NeedHide = false;

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font DigitalFont;

        public ControlPanel()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.digifaw;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.digifaw.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.digifaw.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            DigitalFont = new Font(fonts.Families[0], 75.0F, FontStyle.Italic);
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            PowerNum.Font = DigitalFont;
        }

        #region SCA

        private void ControlPanel_Shown(object sender, EventArgs e)
        {
            DirectionActivibility.ForeColor = Color.Black;
            Application.DoEvents();
            Thread.Sleep(500);
            Direction.BackColor = Color.DarkOrange;
            PowerNum.Text = "1";
            Application.DoEvents();
            Thread.Sleep(250);
            Direction.BackColor = SystemColors.Control;
            Power.BackColor = Color.OliveDrab;
            PowerNum.Text = "2";
            Application.DoEvents();
            Thread.Sleep(250);
            Power.BackColor = SystemColors.Control;
            AutoBrake.BackColor = Color.Red;
            PowerNum.Text = "3";
            Application.DoEvents();
            Thread.Sleep(250);
            AutoBrake.BackColor = SystemColors.Control;
            IndeBrake.BackColor = Color.DarkMagenta;
            PowerNum.Text = "4";
            Application.DoEvents();
            Thread.Sleep(250);
            IndeBrake.BackColor = SystemColors.Control;
            Direction.BackColor = Color.DarkOrange;
            PowerNum.Text = "5";
            Application.DoEvents();
            Thread.Sleep(250);
            Direction.BackColor = SystemColors.Control;
            Power.BackColor = Color.OliveDrab;
            PowerNum.Text = "6";
            Application.DoEvents();
            Thread.Sleep(250);
            Power.BackColor = SystemColors.Control;
            AutoBrake.BackColor = Color.Red;
            PowerNum.Text = "7";
            Application.DoEvents();
            Thread.Sleep(250);
            AutoBrake.BackColor = SystemColors.Control;
            IndeBrake.BackColor = Color.DarkMagenta;
            PowerNum.Text = "8";
            Application.DoEvents();
            Thread.Sleep(250);
            IndeBrake.BackColor = SystemColors.Control;
            Thread.Sleep(250);
            Direction.BackColor = Color.DarkOrange;
            Power.BackColor = Color.OliveDrab;
            AutoBrake.BackColor = Color.Red;
            IndeBrake.BackColor = Color.DarkMagenta;
            PowerNum.Text = "";
            Application.DoEvents();
            Thread.Sleep(500);
            Direction.BackColor = SystemColors.Control;
            Power.BackColor = SystemColors.Control;
            AutoBrake.BackColor = SystemColors.Control;
            IndeBrake.BackColor = SystemColors.Control;
            PowerNum.Text = "8";
            Application.DoEvents();
            SCing_Hide();
            NeutralL.BackColor = NeutralR.BackColor = Color.Yellow;
            IDLE.BackColor = Color.SpringGreen;
            Direction_Enter(sender, e);
            PowerNum.Text = "0";
            Power.Enabled = false;
            Application.DoEvents();
        }

        private void SCing_Hide()
        {
            SCing.Visible = false;
            SCC_Cover.Visible = false;
            SCC_NeedHide = true;
        }

        #endregion

        #region Focus Indication via TextColor

        private void Direction_Enter(object sender, EventArgs e)
        {
            DirectionActivibility.ForeColor = Color.LightSeaGreen;
            if (SCC_NeedHide == true)
            {
                SCC.Visible = true;
                Thread.Sleep(800);
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
            #region Label Color Change

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
            }
            else
            {
                Power.Enabled = false;
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

            #region ReverserLock & pBar/pNum Color Change

            switch (Power.Value)
            {
                case var expression when Power.Value > 0:
                    Direction.Enabled = false;
                    Power.BackColor = Color.DarkOliveGreen;
                    PowerNum.ForeColor = Color.LimeGreen;
                    break;
                case 0:
                    Direction.Enabled = true;
                    Power.BackColor = SystemColors.Control;
                    PowerNum.ForeColor = SystemColors.Info;
                    break;
                case var expression when Power.Value < 0:
                    Direction.Enabled = false;
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

        }

        private void IndeBrake_Scroll(object sender, EventArgs e)
        {

        }

        private void PowerNum_Enter(object sender, EventArgs e)
        {
            Power.Focus();
        }
    }
}
