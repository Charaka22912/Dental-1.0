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

            selectedServicesTable.Columns.Add("Service Name");
            selectedServicesTable.Columns.Add("Price");
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
                try
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
                catch (Exception ex)
                {
                    // Handle the exception appropriately, such as displaying an error message or logging the exception
                    MessageBox.Show("An error occurred: " + ex.Message);
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
            string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";
            string insertQuery = "INSERT INTO Invoice(InvoiceDate,PatientID,Total)" +
                                  " VALUES (@Invoice_Date,@PatientID,@Total)";

            string sal = listBox1.Text.Trim();
            string name = labelname.Text.Trim();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {

                try
                {
                    connection.Open();
                    DataTable dataGridViewData = new DataTable();
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        dataGridViewData.Columns.Add(column.HeaderText);
                    }
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            dataGridViewData.Rows.Add();
                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                dataGridViewData.Rows[dataGridViewData.Rows.Count - 1][i] = row.Cells[i].Value;
                            }
                        }
                    }

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string invoiceDate = labeldate.Text;
                            string patientID = textBox1.Text;


                            {
                                decimal total = decimal.Parse(label1.Text);
                                command.Parameters.AddWithValue("@Invoice_Date", invoiceDate);
                                command.Parameters.AddWithValue("@PatientID", patientID);
                                command.Parameters.AddWithValue("@Total", total);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    PrintInvoice printInvoice = new PrintInvoice(invoiceDate, total, sal, name, dataGridViewData);
                                    printInvoice.Show();
                                }
                                else
                                {
                                    MessageBox.Show("No rows were affected.");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
