using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace evedriAct2
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            LoadExcelFile();
        }

        private void LoadExcelFile()
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\DesktopSemenseArrayExcel.xlsx");
            Worksheet sheet = book.Worksheets[0];

            DataTable dt = sheet.ExportDataTable();
            dgvDisplay.DataSource = dt;
        }
        
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void insert(string name, string gender, string hobbies, string favColor, string saying)
        {
            //int i = dgvDisplay.Rows.Add();
            //dgvDisplay.Rows[i].Cells[0].Value = name;
            //dgvDisplay.Rows[i].Cells[1].Value = gender;
            //dgvDisplay.Rows[i].Cells[2].Value = hobbies;
            //dgvDisplay.Rows[i].Cells[3].Value = favColor;
            //dgvDisplay.Rows[i].Cells[4].Value = saying;


        }
        public void update(int data, string name, string gender, string hobbies, string favColor, string saying)
        {
            dgvDisplay.Rows[data].Cells[0].Value = name;
            dgvDisplay.Rows[data].Cells[1].Value = gender;
            dgvDisplay.Rows[data].Cells[2].Value = hobbies;
            dgvDisplay.Rows[data].Cells[3].Value = favColor;
            dgvDisplay.Rows[data].Cells[4].Value = saying;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvDisplay.SelectedRows)
            {
                dgvDisplay.Rows.Remove(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvDisplay.Rows.Clear();
        }

        private void dgvDisplay_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form1 F1 = (Form1)Application.OpenForms["Form1"];
            int r = dgvDisplay.CurrentCell.RowIndex;
            F1.lblData.Text = r.ToString();
            F1.txtName.Text = dgvDisplay.Rows[r].Cells[0].Value.ToString();
            string gender = dgvDisplay.Rows[r].Cells[1].Value.ToString();
            if (gender == "Male")
            {
                F1.radMale.Checked = true;
            }
            if (gender == "Female")
            {
                F1.radFemale.Checked = true;
            }
            string hobbies = dgvDisplay.Rows[r].Cells[2].Value.ToString();
            string[] h = hobbies.Split(',');
            foreach (string val in h) {

                if (val == "Basketball")
                {
                    F1.chkBasketball.Checked = true;
                }
                if (val == "Volleyball")
                {
                    F1.chkVolleyball.Checked = true;
                }
                if (val == "Soccer")
                {
                    F1.chkSoccer.Checked = true;
                }
            }
            string favColor = dgvDisplay.Rows[r].Cells[3].Value.ToString();
            if (favColor == "Pink")
            {
                F1.cmbFavoriteColor.SelectedIndex = 0;
            }
            if (favColor == "Blue")
            {
                F1.cmbFavoriteColor.SelectedIndex = 1;
            }
            F1.txtSaying.Text = dgvDisplay.Rows[r].Cells[4].Value.ToString();
            //dgvDisplay.Rows[r].Cells[2].Value.ToString();
            //dgvDisplay.Rows[r].Cells[3].Value.ToString();
            //dgvDisplay.Rows[r].Cells[4].Value.ToString();

            
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            dgvDisplay.ClearSelection();
            foreach(DataGridViewRow r in dgvDisplay.Rows)
            {
                if (r.Cells[0].Value.Equals(txtSearch.Text))
                {
                    r.Selected = true;
                    break;
                }
            }
        }
    }
}
