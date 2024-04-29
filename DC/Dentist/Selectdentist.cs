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
    public partial class Selectdentist : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";
        private string selectQuery = "SELECT * FROM Dentist";
        public string SelectedDetails { get; private set; }
        public Selectdentist()
        {
            InitializeComponent();
        }
        private void LoadData()
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Dentist_Name = textBox1.Text.Trim();
            DENTIST dENTIST = new DENTIST();
            dENTIST.search(Dentist_Name, dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                SelectedDetails = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                Close();


            }
        }

        private void Selectdentist_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
