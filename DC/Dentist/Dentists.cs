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
using DC.Dentist;

namespace DC
{
    public partial class Dentists : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";
        private string selectQuery = "SELECT * FROM Dentist";
        public Dentists()
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

        private void Dentists_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string Dentist_Name = textBox1.Text.Trim();

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

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            string Dentist_Name = textBox1.Text.Trim();

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

        private void button1_Click(object sender, EventArgs e)
        {
            AddDentist addDentist = new AddDentist();
            addDentist.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteDentist deleteDentist = new DeleteDentist();
            deleteDentist.Show();
        }
    }
}
