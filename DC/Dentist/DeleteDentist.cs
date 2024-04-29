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

namespace DC.Dentist
{
    public partial class DeleteDentist : Form
    {
        public DeleteDentist()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Dentist_Name = textBox1.Text.Trim();

            DENTIST dENTIST = new DENTIST();
            dENTIST.search(Dentist_Name, dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DENTIST dENTIST = new DENTIST();
            dENTIST.Delete(e, dataGridView1);
        }
    }
}
