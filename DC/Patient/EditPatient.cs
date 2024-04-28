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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DC
{
    public partial class EditPatient : Form
    {
        public EditPatient()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string PatientID = textBox1.Text.Trim();
            string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";
            string query = "SELECT *FROM Patients WHERE PatientID = @PatientID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PatientID", PatientID);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    textBoxname.Text = reader["Patient_Name"].ToString();
                    textBoxAddress.Text = reader["Patient_Address"].ToString();
                    textBoxcontact.Text = reader["ContactNO"].ToString();
                    if (reader["DOB"] != DBNull.Value)
                    {

                        DateTime DOB = Convert.ToDateTime(reader["DOB"]);

                        dateTimePicker1.Value = DOB;
                    }
                    else
                    {

                        dateTimePicker1.Value = DateTime.Today;
                    }
                    string gender = reader["Gender"].ToString();
                    if (gender == "Male")
                    {
                        radioButton1.Checked = true;
                    }
                    else if (gender == "Female")
                    {
                        radioButton2.Checked = true;
                    }
                    textBoxNIC.Text = reader["NIC"].ToString();
                    textBox5.Text = reader["Medical_Details"].ToString();


                }
                else
                {
                    MessageBox.Show("Patient not found.");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";
            string query = "UPDATE Patients SET Patient_Name = @Name, Patient_Address = @Address,DOB =@DOB,Gender =@Gender ,NIC =@NIC ,ContactNO = @Contact,Medical_Details=@Medical WHERE PatientID = @PatientID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", textBoxname.Text);
                command.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                command.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@Gender", radioButton1.Checked ? "Male" : "Female");
                command.Parameters.AddWithValue("@NIC", textBoxNIC.Text);
                command.Parameters.AddWithValue("@Contact", textBoxcontact.Text);
                command.Parameters.AddWithValue("@Medical", textBox5.Text);


                command.Parameters.AddWithValue("@PatientID", textBox1.Text);


                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Patient details updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update patient details.");
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            Selectpatient s2 = new Selectpatient();


            if (s2.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = s2.SelectedDetails;
            }
        }

        private void EditPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
