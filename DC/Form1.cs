using System.Data.SqlClient;
namespace DC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            loginControl loginForm = new loginControl();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {

                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Login failed. Please try again.");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetConnection();
        }

    }
}