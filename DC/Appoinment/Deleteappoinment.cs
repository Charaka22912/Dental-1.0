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
    public partial class Deleteappoinment : Form
    {
        public Deleteappoinment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selectpatient s3 = new Selectpatient();


            if (s3.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = s3.SelectedDetails;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            APPOINTMENT apPOINTMENT = new APPOINTMENT();
            int rowIndex = 0;
            apPOINTMENT.DeleteAppointment(rowIndex, dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string PatientName = textBox1.Text.Trim();


            string query = "SELECT A.*, P.Patient_Name " +
                           "FROM Appoinments A " +
                           "INNER JOIN Patients P ON A.PatientID = P.PatientID " +
                           "WHERE P.Patient_Name LIKE @PatientName";

            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PatientName", "%" + PatientName + "%");

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
