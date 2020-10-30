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

            TimeZoneInfo cst = TimeZoneInfo.FindSystemTimeZoneById(Config.Timezones.List.Data[0].Zone);
            TimeZoneInfo ind = TimeZoneInfo.FindSystemTimeZoneById(Config.Timezones.List.Data[1].Zone);
            TimeZoneInfo est = TimeZoneInfo.FindSystemTimeZoneById(Config.Timezones.List.Data[3].Zone);

            var cst1 = utcOffSet.ToOffset(cst.GetUtcOffset(utcOffSet)).DateTime;
            var ind1 = utcOffSet.ToOffset(cst.GetUtcOffset(utcOffSet)).DateTime;
            var est1 = utcOffSet.ToOffset(cst.GetUtcOffset(utcOffSet)).DateTime;

            var format = "HH:mm";
            var list = new List<MeetingTime>();
            for (int i = 0; i < 24; i++)
            {
                list.Add(new MeetingTime
                {
                    HK = cst1.AddHours(i).ToString(format),
                    IN = ind1.AddHours(i).ToString(format),
                    LN = utcOffSet.LocalDateTime.AddHours(i).ToString(format),
                    NY = est1.AddHours(i).ToString(format)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
