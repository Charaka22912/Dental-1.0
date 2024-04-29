using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace DC
{
    public partial class Addpatient : Form
    {
        public Addpatient()
        {
            InitializeComponent();
        }

        private void Addpatient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string Address = textBoxAddress.Text.Trim();
            string NIC = textBoxNIC.Text.Trim();
            string Gender = radioButton1.Checked ? "Male" : "Female";
            DateTime DOB = DOBPicker1.Value;
            string Contact = textBoxContact.Text.Trim();
            string Medical_History = textBoxMedical.Text.Trim();





           
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(NIC) || string.IsNullOrEmpty(Medical_History))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

           
           PATIENTS pATIENTS = new PATIENTS();
            pATIENTS.savepatient(name, Address, DOB, Gender, NIC, Contact, Medical_History);
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

