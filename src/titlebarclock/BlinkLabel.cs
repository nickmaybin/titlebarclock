using System;
using System.Drawing;
using System.Windows.Forms;

namespace TitleBarClock
{
    public partial class BlinkLabel : Label
    {

        private const int _maxNumberOfBlinks = 8;
        private int _blinkCount = 0;
        private Timer _timer;
        private Color _oldColor;

        public BlinkLabel()
        {
            this._timer = new Timer();
            this._timer.Tick += new EventHandler(_timer_Tick);
            this._timer.Interval = 621;
            this._timer.Enabled = true;
            StartBlink();
        }

        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            if (!this._timer.Enabled && base.IsHandleCreated) StartBlink();
        }

        public void StartBlink()
        {
            this._blinkCount = 0;
            base.Visible = true;
            this._oldColor = base.ForeColor;
            base.ForeColor = System.Drawing.Color.Purple;
            this._timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            base.Visible = !base.Visible;
            this._blinkCount++;
            if (this._blinkCount >= _maxNumberOfBlinks)
            {
                this._timer.Stop();
                base.Visible = true;
                base.ForeColor = _oldColor;

                var form = base.FindForm();
                form.Close();
            }
        }
    }
}
