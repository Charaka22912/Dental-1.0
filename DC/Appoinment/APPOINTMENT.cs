using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Identity.Client;
using System.Data;

namespace DC
{
    public class APPOINTMENT
    {
        public void savedata(string PatientID ,DateTime appoinmentday ,string DentistID ,string status )
        {
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
        public void Search(string PatientID, DataGridView dataGridView1)
        {
            string query = "SELECT * FROM Appoinments WHERE PatientID LIKE @PatientID";
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@PatientID", "%" + PatientID + "%");


                connection.Open();
                DataTable dataTable = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                    
                }


                dataGridView1.DataSource = dataTable;

            }
        }
        public bool DeleteAppointment(int rowIndex, DataGridView dataGridView1)
        {
            if (rowIndex >= 0 && dataGridView1.Rows[rowIndex].Cells["AppoinmentID"].Value != null)
            {
                string appointmentID = dataGridView1.Rows[rowIndex].Cells["AppoinmentID"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM Appoinments WHERE AppoinmentID = @AppoinmentID";
                    using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True"))
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AppoinmentID", appointmentID);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            dataGridView1.Rows.RemoveAt(rowIndex);
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            return false;
        }

    }
}
