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
    public partial class Services : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";

        private string selectQuery = "SELECT * FROM Services";
        public Services()
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Services_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void LoginUserControl_LoginSuccess(object sender, EventArgs e)
        {
            Addservices newservice = new Addservices();
            newservice.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            loginControl loginForm = new loginControl();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Login successful....");

                Addservices newservice = new Addservices();
                newservice.Show();
            }
            else
            {
                MessageBox.Show("Login failed. Please try again.");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginControl loginForm = new loginControl();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Login successful....");

                Editservices newservice = new Editservices();
                newservice.Show();
            }
            else
            {

                MessageBox.Show("Login failed. Please try again.");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
