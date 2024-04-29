using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.Data;
using System.Windows.Forms;

namespace DC
{
    public class PATIENTS
    {
        string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";
        public void savepatient(string name,string Address,DateTime DOB,string Gender,string NIC ,string Contact,string Medical_History)
        {
            
            string query = "INSERT INTO Patients(Patient_Name,Patient_Address,DOB ,Gender,NIC,ContactNO,Medical_Details) " +
                           "VALUES (@name, @Address,@DOB, @Gender, @NIC, @Contact,@Medical_History)";

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
                 
                    connection.Open();
                   
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully!");
                       

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
        public void LoadData(DataGridView dataGridView1 , string selectQuery)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {

                        connection.Open();
                        DataTable dataTable = new DataTable();


                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }


                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        public void searchdata(DataGridView dataGridView1, string Patient_Name)
        {
            string query = "SELECT * FROM Patients WHERE Patient_Name LIKE @Patient_Name";

            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Patient_Name", "%" + Patient_Name + "%");
                connection.Open();
                DataTable dataTable = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
            }
        }


    }
}
