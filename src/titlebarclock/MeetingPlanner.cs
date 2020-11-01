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
    public partial class MeetingPlanner : Form
    {
        public MeetingPlanner()
        {
            InitializeComponent();
        }

        private void MeetingPlanner_Load(object sender, EventArgs e)
        {
            IntializeUI();
        }

        private void IntializeUI()
        {
            BackColor = Color.FromArgb(
                Utils.GetConfigInt("BackColorR"),
                Utils.GetConfigInt("BackColorG"),
                Utils.GetConfigInt("BackColorB"));

            LoadGrid();
        }

        private void LoadGrid()
        {
            var now = DateTime.UtcNow;
            var utcOffSet = new DateTimeOffset(now, TimeSpan.Zero);

            var startTime = new DateTime(utcOffSet.Year,
                utcOffSet.Month,
                utcOffSet.Day,
                6,
                0,
                0);

            LoadGrid(startTime);
        }

        private void LoadGrid(DateTime startTime)
        {
            var utcOffSet = new DateTimeOffset(startTime, TimeSpan.Zero);

            var cst = utcOffSet.ToOffset(TimeZoneInfo.FindSystemTimeZoneById(Config.Timezones.List.Data[0].Zone).GetUtcOffset(utcOffSet)).DateTime;
            var ind = utcOffSet.ToOffset(TimeZoneInfo.FindSystemTimeZoneById(Config.Timezones.List.Data[1].Zone).GetUtcOffset(utcOffSet)).DateTime;
            var est = utcOffSet.ToOffset(TimeZoneInfo.FindSystemTimeZoneById(Config.Timezones.List.Data[3].Zone).GetUtcOffset(utcOffSet)).DateTime;

            var format = "HH:mm";
            var list = new List<MeetingTime>();
            for (int i = 0; i < 24; i++)
            {
                list.Add(new MeetingTime
                {
                    HK = cst.AddHours(i).ToString(format),
                    IN = ind.AddHours(i).ToString(format),
                    LN = utcOffSet.LocalDateTime.AddHours(i).ToString(format),
                    NY = est.AddHours(i).ToString(format)
                }) ;
            }

            var bindingList = new BindingList<MeetingTime>(list);
            var source = new BindingSource(bindingList, null);
            dgvTimes.DataSource = source;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
