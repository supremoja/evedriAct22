using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evedriAct2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            lblNumMale.Text = showCount(2, "Male").ToString();
            lblNumFemale.Text = showCount(2, "Female").ToString();
            lblNumBasketball.Text = showCount(3, "Basketball").ToString();
            lblNumVolleyball.Text = showCount(3, "Volleyball").ToString();
            lblNumSoccer.Text = showCount(3, "Soccer").ToString();
            lblNumBsit.Text = showCount(11, "BSIT").ToString();
            lblNumBeed.Text = showCount(11, "BEED").ToString();
            lblNumPink.Text = showCount(10, "Pink").ToString();
            lblNumBlue.Text = showCount(10, "Blue").ToString();
            lblNumRed.Text = showCount(10, "Red").ToString();
            lblNumActive.Text = showCount(12, "1").ToString();
            lblNumInactive.Text = showCount(12, "0").ToString();

        }


        


        private void lblName_Click(object sender, EventArgs e)
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\DesktopSemenseArrayExcel.xlsx");
            Worksheet sheet = book.Worksheets[0];
            int row = sheet.Rows.Length;

            for (int i = 2; i <= row; i++)
            {
            }
            

                




               
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        public void ShowCount(string status)
        {
            Workbook book = new Workbook();

            
        }



        private void btnActiveStudents_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.showStudent("1");
            fm2.Show();
        }

        private void btnInactiveStudents_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.showStudent("0");
            fm2.Show();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            Logs logs = new Logs();
            logs.Show();
            this.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
