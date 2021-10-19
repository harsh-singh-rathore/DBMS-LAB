using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registeration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string rd = "";
            string vacc = "";
            if (male.Checked == false && female.Checked == false)
            {
                rd = "Please Select a Gender";
            }
            if (male.Checked==true){
                rd = "MALE";
            }
            if (female.Checked == true)
            {
                rd = "FEMALE";
            }
            if (dose1.Checked == false && dose2.Checked == false)
            {
                vacc = "Unvaccinated";
            }
            if (dose1.Checked == true && dose2.Checked == false)
            {
                vacc = "Single Dose Vaccinated";
            }
            if (dose1.Checked == true && dose2.Checked == true)
            {
                vacc = "Completely Vaccinated";
            }
            if (dose1.Checked == false && dose2.Checked == true)
            {
                vacc = "Please Select Appropriately";
            }
            MessageBox.Show("Name: "+this.textBox1.Text+"\nRegisteration No.: "+this.textBox2.Text+"\nPhone No.: "+this.textBox3.Text+"\nGender: "+rd+"\nDepartment: "+dept.SelectedItem+"\nVaccination: "+vacc);
        }
    }
}
