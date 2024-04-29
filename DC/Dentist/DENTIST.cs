using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DC
{
    public class DENTIST
    {
        public bool saveDentist(string name,string Address,string Contact ,DateTime JD,string special) {
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
            return true;
        }
        public void search(string Dentist_Name ,DataGridView dataGridView1)
        {
            string query = "SELECT * FROM Dentist WHERE Dentist_Name LIKE @Dentist_Name";

            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Dentist_Name", "%" + Dentist_Name + "%");
                connection.Open();
                DataTable dataTable = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
            }
        }

        public void Delete(DataGridViewCellEventArgs e, DataGridView dataGridView1)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (clickedCell != null && clickedCell.Value != null)
                {

                    string DentistID = dataGridView1.Rows[e.RowIndex].Cells["DentistID"].Value.ToString();


                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        string deleteQuery = "DELETE  FROM Dentist WHERE DentistID = @DentistID";
                        using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True"))
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@DentistID", DentistID);


                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();


                            if (rowsAffected > 0)
                            {

                                dataGridView1.Rows.RemoveAt(e.RowIndex);
                                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }







}
