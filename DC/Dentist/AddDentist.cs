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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DC
{
    public partial class AddDentist : Form
    {
        public AddDentist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxname.Text.Trim();
            string Address = textBoxaddress.Text.Trim();
            DateTime JD = dateTimePicker1.Value;
            string Contact = textBoxcontact.Text.Trim();
            string special = listBox1.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(special))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";

            string query = "INSERT INTO Dentist(Dentist_Name,Dentist_Address,ContactNO,JoindDate,Specialization) " +
                           "VALUES (@name, @Address,@Contact,@JD,@special)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Contact", Contact);
                command.Parameters.AddWithValue("@JD", JD);
                command.Parameters.AddWithValue("@special", special);
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
        Dentist d1 = new Dentist();
    }
}
