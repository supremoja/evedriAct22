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
    public partial class Form1 : Form
    {
        Form2 F2 = new Form2();
        
        public Form1()
        {
            InitializeComponent();
        }
        string[] Student = new string[5];
        //int x = 0;
        int i = 0;



        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            string name = "";
            string gender = "";
            string hobbies = "";
            string favColor = "";
            string saying = "";



            name += txtName.Text ;
            
            if (radMale.Checked)
            {
                gender += radMale.Text;
            }
            else
            {
                gender += radFemale.Text;
            }
            if (chkBasketball.Checked)
            {
                hobbies = chkBasketball.Text + ",";
            }
            if (chkVolleyball.Checked)
            {
                hobbies += chkVolleyball.Text + ",";
            }
            if (chkSoccer.Checked)
            {
                hobbies += chkSoccer.Text;
            }
            favColor += cmbFavoriteColor.Text;
            saying += txtSaying.Text;


            Student[i] = name;
            i++;

            F2.insert(txtName.Text, gender, hobbies, favColor, saying);
            txtName.Clear();
            radFemale.Checked = false;
            radMale.Checked = false;
            chkBasketball.Checked = false;
            chkVolleyball.Checked = false;
            chkSoccer.Checked = false;
            cmbFavoriteColor.SelectedIndex = -1;
            txtSaying.Clear();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //string val = "";
            //int x = 0;
            //foreach(string s in Student)
            //{
            //    val += "[" + x + "]=" + s + "\n";
            //    x++;
            //}
            //MessageBox.Show(val);

            string display = "";
            
            for (int x = 0; x < Student.Length; x++)
            {
                display += "[" + x + "]" + Student[x] + "\n";
            }

            F2.Show();
            
            txtName.Clear();
            radFemale.Checked = false;
            radMale.Checked = false;
            chkBasketball.Checked = false;
            chkVolleyball.Checked = false;
            chkSoccer.Checked = false;
            cmbFavoriteColor.SelectedIndex = -1;
            txtSaying.Clear();

        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Form2 F2 = (Form2)Application.OpenForms["Form2"];

            string name= "";
            string gender = "";
            string hobbies = "";
            string favColor = "";
            string saying = "";



            name += txtName.Text;


            if (radMale.Checked)
            {
                gender += radMale.Text;
            }
            else
            {
                gender += radFemale.Text;
            }
            if (chkBasketball.Checked)
            {
                hobbies = chkBasketball.Text + ",";
            }
            if (chkVolleyball.Checked)
            {
                hobbies += chkVolleyball.Text + ",";
            }
            if (chkSoccer.Checked)
            {
                hobbies += chkSoccer.Text;
            }
            favColor += cmbFavoriteColor.Text;
            saying += txtSaying.Text;


            Student[i] = name;
            i++;
            F2.update(Convert.ToInt32(lblData.Text), txtName.Text, gender, hobbies, favColor, saying);
            txtName.Clear();
            radFemale.Checked = false;
            radMale.Checked = false;
            chkBasketball.Checked = false;
            chkVolleyball.Checked = false;
            chkSoccer.Checked = false;
            cmbFavoriteColor.SelectedIndex = -1;
            txtSaying.Clear();

        }
    }
}
