using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitleBarClock
{
    public partial class HourReminder : Form
    {
        public HourReminder()
        {
            InitializeComponent();
        }

        private void HourReminder_Load(object sender, EventArgs e)
        {
            Width = 90;
            Height = 40;
            Top = Screen.PrimaryScreen.Bounds.Height - 80;
            Left = Screen.PrimaryScreen.Bounds.Width - 120;

            blinkLabel1.Text - DateTime.Now.ToString("HH:mm");
            AlwaysOnTop();

        }

        private void AlwaysOnTop()
        {
            TopMost = true;
            Show();
            BringToFront();
        }
    }
}
