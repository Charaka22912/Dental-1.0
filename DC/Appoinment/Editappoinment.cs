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
    public partial class Editappoinment : Form
    {

        public Editappoinment(string patientID)
        {
            InitializeComponent();
            textBox1.Text = patientID;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Editappoinment_Load(object sender, EventArgs e)
        {
            string PatientID = textBox1.Text.Trim();
            string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";
            string query = "SELECT *FROM Appoinments WHERE PatientID = @PatientID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PatientID", PatientID);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    textBoxID.Text =reader["AppoinmentID"].ToString();
                    textBox2.Text = reader["DentistID"].ToString();
                    listBox1.Text = reader["Appoinment_Status"].ToString();

                }
                else
                {
                    MessageBox.Show("Appointment not found.");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";
            string query = "UPDATE Appoinments SET DentistID = @DentistID, Appoinment_Status = @AppoinmentStatus WHERE AppoinmentID = @AppoinmentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@DentistID", textBox2.Text);
                command.Parameters.AddWithValue("@AppoinmentStatus", listBox1.Text);
                command.Parameters.AddWithValue("@PatientID", textBox1.Text);
                command.Parameters.AddWithValue("@AppoinmentID",textBoxID.Text);



                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Appointment details updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update Appointment details.");
                }
            }

        }

    }
}
