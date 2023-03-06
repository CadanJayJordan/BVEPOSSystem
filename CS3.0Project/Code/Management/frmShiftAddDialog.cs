using CS3._0Project.Forms.Utility;
using CS3._0Project.Forms.Utility.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3._0Project.Code.Management {
    public partial class frmShiftAddDialog : Form {

        private frmClock frmClock;
        private int userID;

        public DateTime startTime;
        public DateTime endTime;

        public frmShiftAddDialog(frmClock frmClock, int userID) {
            InitializeComponent();
            this.frmClock = frmClock;
            this.userID = userID;
            new ControlDragger(this, false, false);
        }

        private void frmShiftAddDialog_Load(object sender, EventArgs e) {
            this.tblEPOSUsersTableAdapter.Fill(this.ePOSDBDataSet.tblEPOSUsers);
            cbxUser.SelectedValue = userID;
            eventInit();
            setDateTimeNow();
        }

        private void btnAddShift_Click(object sender, EventArgs e) {
            // TODO: CHECK IF VALID DATE

            frmClock.clockIn(userID, startTime);
            frmClock.clockOut(userID, endTime);
            this.Close();
        }

        private void eventInit() {
            txtStartDay.TextChanged += OnTwoCharTextChange;
            txtStartMonth.TextChanged += OnTwoCharTextChange;
            txtStartHour.TextChanged += OnTwoCharTextChange;
            txtStartMin.TextChanged += OnTwoCharTextChange;

            txtStartYear.TextChanged += OnFourCharTextChange;

            txtEndDay.TextChanged += OnTwoCharTextChange;
            txtEndMonth.TextChanged += OnTwoCharTextChange;
            txtEndHour.TextChanged += OnTwoCharTextChange;
            txtEndMin.TextChanged += OnTwoCharTextChange;

            txtEndYear.TextChanged += OnFourCharTextChange;
        }

        private void OnTextChanged(Object sender, EventArgs e) {
            // TODO: Make work
            TextBox tb = (TextBox)sender;

            string start = String.Format("{0}/{1}/{2} {3}:{4}:00", txtStartDay.Text, txtStartMonth.Text, txtStartYear.Text, txtStartHour.Text, txtStartMin.Text);
            string end = String.Format("{0}/{1}/{2} {3}:{4}:00", txtEndDay.Text, txtEndMonth.Text, txtEndYear.Text, txtEndHour.Text, txtEndMin.Text);

            try {
                startTime = Convert.ToDateTime(start);
                endTime = Convert.ToDateTime(end);
            } catch (System.FormatException) {
                return;
            }

            TimeSpan timeDiff = endTime - startTime;

            lblDuration.Text = String.Format("Duration: {0}:{1}:{2}", Math.Truncate(timeDiff.TotalHours).ToString("00"), timeDiff.Minutes.ToString("00"), timeDiff.Seconds.ToString("00"));
        }

        private void OnTwoCharTextChange(Object sender, EventArgs e) {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 2) {
                tb.Text = tb.Text.Substring(0, 2);
            }
        }

        private void OnFourCharTextChange(Object sender, EventArgs e) {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 4) {
                tb.Text = tb.Text.Substring(0, 4);
            }
        }

        private void btnReset_Click(object sender, EventArgs e) {
            setDateTimeNow();
        }

        private void setDateTimeNow() {
            DateTime now = DateTime.Now;
            setStartDateTime(now);
            setEndDateTime(now);
        }

        private void setStartDateTime(DateTime startTime) {
            txtStartDay.Text = startTime.Day.ToString("00");
            txtStartMonth.Text = startTime.Month.ToString("00");
            txtStartYear.Text = startTime.Year.ToString("0000");
            txtStartHour.Text = startTime.Hour.ToString("00");
            txtStartMin.Text = startTime.Minute.ToString("00");
        }

        private void setEndDateTime(DateTime endTime) {
            txtEndDay.Text = endTime.Day.ToString("00");
            txtEndMonth.Text = endTime.Month.ToString("00");
            txtEndYear.Text = endTime.Year.ToString("0000");
            txtEndHour.Text = endTime.Hour.ToString("00");
            txtEndMin.Text = endTime.Minute.ToString("00");
        }

        private void cbxUser_SelectedIndexChanged(object sender, EventArgs e) {
            userID = Convert.ToInt32(cbxUser.SelectedValue);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txt2Chars_Click(object sender, EventArgs e) {
            TextBox tb = (TextBox)sender;

            frmNumPad frmNumPad = new frmNumPad(2);
            tb.Text = Convert.ToInt32(frmNumPad.getInput()).ToString("00");
        }

        private void txt4Chars_Click(object sender, EventArgs e) {
            TextBox tb = (TextBox)sender;

            frmNumPad frmNumPad = new frmNumPad(4);
            tb.Text = Convert.ToInt32(frmNumPad.getInput()).ToString("00");
        }
    }
}
