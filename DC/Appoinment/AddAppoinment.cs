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
using DC;

namespace DC
{
    public partial class AddAppoinment : Form
    {
        public AddAppoinment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selectpatient secondForm = new Selectpatient();


            if (secondForm.ShowDialog() == DialogResult.OK)
            {
                textBoxpatient.Text = secondForm.SelectedDetails;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string PatientID = textBoxpatient.Text.Trim();
            DateTime appoinmentday = dateTimePicker1.Value;
            string DentistID = textBoxdentist.Text.Trim();
            string status = listBox1.Text.Trim();

            if (string.IsNullOrEmpty(PatientID))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            APPOINTMENT appointment = new APPOINTMENT();
            appointment.savedata(PatientID, appoinmentday, DentistID, status);
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttondentist_Click(object sender, EventArgs e)
        {
            Selectdentist secondForm = new Selectdentist();


            if (secondForm.ShowDialog() == DialogResult.OK)
            {
                textBoxdentist.Text = secondForm.SelectedDetails;

            }
        }
    }
}
