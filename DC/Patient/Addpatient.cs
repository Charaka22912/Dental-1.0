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





            // Validate input
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(NIC) || string.IsNullOrEmpty(Medical_History))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Connection 
            string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";

            // SQL query
            string query = "INSERT INTO Patients(Patient_Name,Patient_Address,DOB ,Gender,NIC,ContactNO,Medical_Details) " +
                           "VALUES (@name, @Address,@DOB, @Gender, @NIC, @Contact,@Medical_History)";

            // Create connection 
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@DOB", DOB);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@NIC", NIC);
                command.Parameters.AddWithValue("@Contact", Contact);
                command.Parameters.AddWithValue("@Medical_History", Medical_History);




                try
                {
                    // Open the connection
                    connection.Open();
                    // Execute the SQL command
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

