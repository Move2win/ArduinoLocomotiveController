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
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            bool ReverserLock = false;
            bool PantagraphState = false;
            
        }

        private void ControlPanel_Shown(object sender, EventArgs e)
        {
            DirectionActivibility.ForeColor = Color.Black;
            Application.DoEvents();
            Thread.Sleep(500);
            Direction.BackColor = Color.DarkOrange;
            Thread.Sleep(300);
            Direction.BackColor = SystemColors.Control;
            Power.BackColor = Color.OliveDrab;
            Thread.Sleep(300);
            Power.BackColor = SystemColors.Control;
            AutoBrake.BackColor = Color.Red;
            Thread.Sleep(300);
            AutoBrake.BackColor = SystemColors.Control;
            IndeBrake.BackColor = Color.DarkMagenta;
            Thread.Sleep(300);
            IndeBrake.BackColor = SystemColors.Control;
            Direction.BackColor = Color.DarkOrange;
            Thread.Sleep(300);
            Direction.BackColor = SystemColors.Control;
            Power.BackColor = Color.OliveDrab;
            Thread.Sleep(300);
            Power.BackColor = SystemColors.Control;
            AutoBrake.BackColor = Color.Red;
            Thread.Sleep(300);
            AutoBrake.BackColor = SystemColors.Control;
            IndeBrake.BackColor = Color.DarkMagenta;
            Thread.Sleep(300);
            IndeBrake.BackColor = SystemColors.Control;
            Thread.Sleep(300);
            Direction.BackColor = Color.DarkOrange;
            Power.BackColor = Color.OliveDrab;
            AutoBrake.BackColor = Color.Red;
            IndeBrake.BackColor = Color.DarkMagenta;
            Thread.Sleep(500);
            Direction.BackColor = SystemColors.Control;
            Power.BackColor = SystemColors.Control;
            AutoBrake.BackColor = SystemColors.Control;
            IndeBrake.BackColor = SystemColors.Control;
            DirectionActivibility.ForeColor = Color.LightSeaGreen;
            SSC_Display();
        }

        private void SSC_Display()
        {
            SCing.Visible = false;
            SCC.Visible = true;
            Thread.Sleep(500);
            SCC.Visible = false;
        }

        #region Focus Indicator via TextColor

        private void Direction_Enter(object sender, EventArgs e)
        {
            DirectionActivibility.ForeColor = Color.LightSeaGreen;
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
        }

    }
}
