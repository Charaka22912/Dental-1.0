using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DC
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxfname.Name = "Firstname";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LastName.Name = "Lastname";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBoxaddress.Name = "Addressline1";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Name = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Name = "female";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBoxusername.Name = "Username";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBoxpswrd.Name = "password";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string firstName = textBoxfname.Text.Trim();
            string lastName = LastName.Text.Trim();
            string addressLine = textBoxaddress.Text.Trim();
            string gender = radioButton1.Checked ? "Male" : "Female";
            DateTime dob = dateTimePicker1.Value;
            string userType = radioButton3.Checked ? "Receptionlist" : "Dentist";
            string username = textBoxusername.Text.Trim();
            string password = textBoxpswrd.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(userType) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            REGISTER rEGISTER = new REGISTER();
            rEGISTER.registeremployee(firstName, lastName, gender, addressLine, dob, userType, username, password);
            this.Close();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 h1 = new Form1();
            h1.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
