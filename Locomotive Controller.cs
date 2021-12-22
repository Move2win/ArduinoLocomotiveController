using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ArduinoLocomotiveController
{
    public partial class ControlPanel : Form
    {
        bool ReverserLock = false;
        bool PantagraphState = false;
        bool SCC_NeedHide = false;

        public ControlPanel()
        {
            InitializeComponent();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            
        }
        
        private void ControlPanel_Shown(object sender, EventArgs e)
        {
            DirectionActivibility.ForeColor = Color.Black;
            Application.DoEvents();
            Thread.Sleep(500);
            Direction.BackColor = Color.DarkOrange;
            Thread.Sleep(250);
            Direction.BackColor = SystemColors.Control;
            Power.BackColor = Color.OliveDrab;
            Thread.Sleep(250);
            Power.BackColor = SystemColors.Control;
            AutoBrake.BackColor = Color.Red;
            Thread.Sleep(250);
            AutoBrake.BackColor = SystemColors.Control;
            IndeBrake.BackColor = Color.DarkMagenta;
            Thread.Sleep(250);
            IndeBrake.BackColor = SystemColors.Control;
            Direction.BackColor = Color.DarkOrange;
            Thread.Sleep(250);
            Direction.BackColor = SystemColors.Control;
            Power.BackColor = Color.OliveDrab;
            Thread.Sleep(250);
            Power.BackColor = SystemColors.Control;
            AutoBrake.BackColor = Color.Red;
            Thread.Sleep(250);
            AutoBrake.BackColor = SystemColors.Control;
            IndeBrake.BackColor = Color.DarkMagenta;
            Thread.Sleep(250);
            IndeBrake.BackColor = SystemColors.Control;
            Thread.Sleep(250);
            Direction.BackColor = Color.DarkOrange;
            Power.BackColor = Color.OliveDrab;
            AutoBrake.BackColor = Color.Red;
            IndeBrake.BackColor = Color.DarkMagenta;
            Thread.Sleep(500);
            Direction.BackColor = SystemColors.Control;
            Power.BackColor = SystemColors.Control;
            AutoBrake.BackColor = SystemColors.Control;
            IndeBrake.BackColor = SystemColors.Control;
            SCing_Hide();
            PowerNum.Text = "0";
            NeutralL.BackColor = NeutralR.BackColor = Color.Yellow;
            IDLE.BackColor = Color.SpringGreen;
            Application.DoEvents();
            Direction_Enter(sender, e);
        }

        private void SCing_Hide()
        {
            SCing.Visible = false;
            SCC_Cover.Visible = false;
            SCC_NeedHide = true;
        }

        #region Focus Indicator via TextColor

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
         }

        private void Power_Scroll(object sender, EventArgs e)
        {
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

            #region Power底色

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

            switch (Power.Value)
            {
                case var expression when Power.Value > 0:
                    break;
            }
        }

        private void AutoBrake_Scroll(object sender, EventArgs e)
        {

        }

        private void IndeBrake_Scroll(object sender, EventArgs e)
        {

        }
    }
}
