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
            Application.DoEvents();
            Direction.Focus();
            Thread.Sleep(500);
            Power.Focus();
            Thread.Sleep(500);
            AutoBrake.Focus();
            Thread.Sleep(500);
            IndeBrake.Focus();
            Thread.Sleep(500);
            Direction.Focus();
            //SCC.Visible = true;
            //Thread.Sleep(1000);
            //SCC.Visible = false;
        }

        #region Focus Indicator via Color

        private void Direction_Enter(object sender, EventArgs e)
        {
            Direction.BackColor = Color.DarkOrange;
        }

        private void Direction_Leave(object sender, EventArgs e)
        {
            Direction.BackColor = SystemColors.Control;
        }

        private void Power_Enter(object sender, EventArgs e)
        {
            Power.BackColor = Color.SlateBlue;
        }

        private void Power_Leave(object sender, EventArgs e)
        {
            Power.BackColor = SystemColors.Control;
        }

        private void AutoBrake_Enter(object sender, EventArgs e)
        {
            AutoBrake.BackColor = Color.OrangeRed;
        }

        private void AutoBrake_Leave(object sender, EventArgs e)
        {
            AutoBrake.BackColor = SystemColors.Control;
        }

        private void IndeBrake_Enter(object sender, EventArgs e)
        {
            IndeBrake.BackColor = Color.DarkOrchid;
        }

        private void IndeBrake_Leave(object sender, EventArgs e)
        {
            IndeBrake.BackColor = SystemColors.Control;
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

        //private void CheckNow_Paint(object sender, PaintEventArgs e)
        //{
        //    Direction.Focus();
        //    Thread.Sleep(500);
        //    Power.Focus();
        //    Thread.Sleep(500);
        //    AutoBrake.Focus();
        //    Thread.Sleep(500);
        //    IndeBrake.Focus();
        //    Thread.Sleep(500);
        //    Direction.Focus();
        //}
    }
}
