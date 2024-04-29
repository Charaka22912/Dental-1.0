using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DC
{
    public class REGISTER
    {
        public void registeremployee(string firstName, string lastName, string gender, string addressLine, DateTime dob, string userType, string username, string password)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";
            string query = "INSERT INTO Register(First_Name, Last_Name, Address, Gender, DOB, Usertype, Username, Password) " +
                           "VALUES (@FirstName, @LastName, @Address, @Gender, @DOB, @Usertype, @Username, @Pass_word)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Address", addressLine);
                command.Parameters.AddWithValue("@DOB", dob);
                command.Parameters.AddWithValue("@Usertype", userType);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Pass_word", password);


                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully!");

                        Form1 h1 = new Form1();
                        h1.Show();
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
    }
}
