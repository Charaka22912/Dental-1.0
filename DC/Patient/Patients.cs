﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace DC
{
    public partial class Patients : Form
    {

        private string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";
        private string selectQuery = "SELECT * FROM Patients";
        public Patients()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Patients_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Create a connection 
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create a SqlCommand 
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {

                        connection.Open();
                        DataTable dataTable = new DataTable();


                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addpatient a1 = new Addpatient();
            a1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard d1 = new Dashboard();
            d1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditPatient e1 = new EditPatient();
            e1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Patient_Name = textBox1.Text.Trim();

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


        private void button6_Click(object sender, EventArgs e)
        {
            string Patient_Name = textBox1.Text.Trim();

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
