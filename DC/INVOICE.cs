using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DC
{
    public partial class INVOICE : Form
    {
        private DataTable selectedServicesTable = new DataTable();
        public INVOICE()
        {
            InitializeComponent();
            InitializeDataGridView();

        }
        private void InitializeDataGridView()
        {
            // Define columns for the DataGridView
            selectedServicesTable.Columns.Add("Service Name");
            selectedServicesTable.Columns.Add("Price");

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = selectedServicesTable;
        }

        private void INVOICE_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            labeldate.Text = today.ToShortDateString();
            CalculateTotalSum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selectpatient s2 = new Selectpatient();
            if (s2.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = s2.SelectedDetails;
            }
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
                    labelname.Text = reader["Patient_Name"].ToString();
                }
                else
                {
                    MessageBox.Show("Patient not found.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectservice selectservice = new selectservice();
            if (selectservice.ShowDialog() == DialogResult.OK)
            {
                string ID = selectservice.SelectedDetails.Trim();
                string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";
                string query = "SELECT Servicename, Price FROM Services WHERE ServiceID = @ID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Add selected service details to the DataGridView
                        selectedServicesTable.Rows.Add(reader["Servicename"].ToString(), reader["Price"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("Service not found.");
                    }
                }
            }

        }
        private void CalculateTotalSum()
        {
            decimal totalSum = 0;


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (!row.IsNewRow && row.Visible)
                {

                    if (decimal.TryParse(row.Cells["Price"].Value.ToString(), out decimal price))
                    {

                        totalSum += price;
                    }
                }
            }


            label1.Text = totalSum.ToString("0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculateTotalSum();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
