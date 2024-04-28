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


            string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";


            string query = "INSERT INTO Appoinments(Appoinment_Date,DentistID ,PatientID,Appoinment_Status) " +
                           "VALUES (@Appoinmentdate, @DentistID,@PatientID,@status)";


            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@PatientID", PatientID);
                command.Parameters.AddWithValue("@Appoinmentdate", appoinmentday);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@DentistID", DentistID);

                try
                {

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully!");
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("No rows were affected.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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
