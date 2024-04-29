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
    public partial class Selectpatient : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";

      
        private string selectQuery = "SELECT * FROM Patients";
        public string SelectedDetails { get; private set; }
        public Selectpatient()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            PATIENTS pATIENTS = new PATIENTS();
            pATIENTS.LoadData(dataGridView1, selectQuery);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Selectpatient_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                
                SelectedDetails = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                Close();


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Patient_Name = textBox1.Text.Trim();

            PATIENTS patients = new PATIENTS();
            patients.searchdata(dataGridView1, Patient_Name);
        }
    }
}
