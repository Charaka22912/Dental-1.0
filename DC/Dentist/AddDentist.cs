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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DC
{
    public partial class AddDentist : Form
    {
        public AddDentist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxname.Text.Trim();
            string Address = textBoxaddress.Text.Trim();
            DateTime JD = dateTimePicker1.Value;
            string Contact = textBoxcontact.Text.Trim();
            string special = listBox1.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(special))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }


            DENTIST dENTIST = new DENTIST();
            dENTIST.saveDentist(name, Address, Contact, JD, special);
            this.Close();
        }

    }
}
