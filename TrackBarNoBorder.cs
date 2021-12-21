using System;
using System.Windows.Forms;

namespace ArduinoLocomotiveController
{
    public partial class TrackBarNoBorder : TrackBar
    {
        public TrackBarNoBorder()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public extern static int SendMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        private static int MakeParam(int loWord, int hiWord)
        {
            return (hiWord << 16) | (loWord & 0xffff);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            SendMessage(this.Handle, 0x0128, MakeParam(1, 0x1), 0);
        }
    }
}
