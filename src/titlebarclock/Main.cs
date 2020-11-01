using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitleBarClock
{
    public partial class Main : Form
    {
        private Point _dragCursorPoint;
        private Point _dragFormPoint;
        private bool _dragging;
        private bool _popped;

        public Main()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
            BackColor = Color.FromArgb(
                Utils.GetConfigInt("BackColorR"),
                Utils.GetConfigInt("BackColorG"),
                Utils.GetConfigInt("BackColorB"));
            
            SetPositioning();
            LoadTimes();
        }

        private void SetPositioning()
        {
            Height = 16;
            SetLocation();
        }

        private void SetLocation()
        {
            Top = Screen.PrimaryScreen.Bounds.Height - Utils.GetConfigInt("startLocationTop");
            Left =  Screen.PrimaryScreen.Bounds.Width - Utils.GetConfigInt("startLocationLeft");

            //Config.Application

        }

        private void LoadTimes()
        {
            var now = DateTime.UtcNow;
            var utcOffSet = new DateTimeOffset(now, TimeSpan.Zero);

            TimeZoneInfo cst = TimeZoneInfo.FindSystemTimeZoneById(Config.Timezones.List.Data[0].Zone);
            TimeZoneInfo ind = TimeZoneInfo.FindSystemTimeZoneById(Config.Timezones.List.Data[1].Zone);
            TimeZoneInfo gst = TimeZoneInfo.FindSystemTimeZoneById(Config.Timezones.List.Data[2].Zone);
            TimeZoneInfo est = TimeZoneInfo.FindSystemTimeZoneById(Config.Timezones.List.Data[3].Zone);

            lblOne.Text = utcOffSet.ToOffset(cst.GetUtcOffset(utcOffSet)).DateTime.ToString(Config.Timezones.List.Data[0].Format);
            toolTip.SetToolTip(lblOne, Config.Timezones.List.Data[0].Name);

            lblTwo.Text = utcOffSet.ToOffset(ind.GetUtcOffset(utcOffSet)).DateTime.ToString(Config.Timezones.List.Data[1].Format);
            toolTip.SetToolTip(lblTwo, Config.Timezones.List.Data[1].Name);

            lblThree.Text = utcOffSet.ToOffset(gst.GetUtcOffset(utcOffSet)).DateTime.ToString(Config.Timezones.List.Data[2].Format);
            toolTip.SetToolTip(lblThree, Config.Timezones.List.Data[2].Name);
            toolTip.SetToolTip(pbThree, now.ToString("dddd dd MMMM yyyy"));

            lblFour.Text = utcOffSet.ToOffset(est.GetUtcOffset(utcOffSet)).DateTime.ToString(Config.Timezones.List.Data[3].Format);
            toolTip.SetToolTip(lblFour, Config.Timezones.List.Data[3].Name);

        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            LoadTimes();
            AlwaysOnTop();

            NearingReminderTime(55, 22);
            NearingReminderTime(55, 42);

            NearingReminderTime(24, 22);
            NearingReminderTime(20, 42);
        }

        private void NearingReminderTime(int minute, int second)
        {
            if (DateTime.Now.Minute == minute && DateTime.Now.Second == second)
            {
                HourReminder hourReminder = new HourReminder();
                hourReminder.Show();

            }
        }

        private void AlwaysOnTop()
        {
            TopMost = true;
            Show();
            BringToFront();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = Location;

        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point newLocation = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
                Location = Point.Add(_dragFormPoint, new Size(newLocation));
            }

        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void lblMeetingPlanner_Click(object sender, EventArgs e)
        {
            var planner = new MeetingPlanner();
            planner.Top = this.Top - planner.Height - 12;
            planner.Left = this.Left;
            planner.Show();
        }
    }
}

