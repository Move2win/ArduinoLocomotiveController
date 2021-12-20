using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoLocomotiveController
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        class CustomTrackBar : System.Windows.Forms.TrackBar
        {
            protected override bool ShowFocusCues
            {
                get
                {
                    return false;
                }
            }
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            bool ReverserLock = false;
            bool PantagraphState = false;
            ShowFocusCues = false;
        }
    }
}
