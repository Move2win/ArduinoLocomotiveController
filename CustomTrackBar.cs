using System.Windows.Forms;

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