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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Dashboard));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.FlatAppearance.MouseDownBackColor = Color.Cyan;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(340, 393);
            button1.Name = "button1";
            button1.Size = new Size(310, 143);
            button1.TabIndex = 0;
            button1.Text = "Appoinment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(705, 393);
            button2.Name = "button2";
            button2.Size = new Size(310, 143);
            button2.TabIndex = 1;
            button2.Text = "Dentist";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(1074, 393);
            button3.Name = "button3";
            button3.Size = new Size(310, 143);
            button3.TabIndex = 2;
            button3.Text = "Patient";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(340, 586);
            button4.Name = "button4";
            button4.Size = new Size(310, 143);
            button4.TabIndex = 3;
            button4.Text = "Services";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(705, 586);
            button5.Name = "button5";
            button5.Size = new Size(310, 143);
            button5.TabIndex = 4;
            button5.Text = "Invoices";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Yu Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(622, 9);
            label1.Name = "label1";
            label1.Size = new Size(507, 103);
            label1.TabIndex = 5;
            label1.Text = "Dental Care";
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top;
            button6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(1074, 586);
            button6.Name = "button6";
            button6.Size = new Size(310, 143);
            button6.TabIndex = 6;
            button6.Text = "Monthly Report";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 169);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.Location = new Point(1659, 20);
            button7.Name = "button7";
            button7.Size = new Size(97, 44);
            button7.TabIndex = 8;
            button7.Text = "Log out";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(436, 152);
            label3.Name = "label3";
            label3.Size = new Size(426, 138);
            label3.TabIndex = 10;
            label3.Text = "Total";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(570, 290);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 11;
            label2.Text = "Total Patients";
            // 
            // label4
            // 
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(946, 152);
            label4.Name = "label4";
            label4.Size = new Size(406, 138);
            label4.TabIndex = 12;
            label4.Text = "Appoinm";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(1033, 290);
            label5.Name = "label5";
            label5.Size = new Size(187, 28);
            label5.TabIndex = 13;
            label5.Text = "Today Appoinments";
            // 
            // Dashboard
            // 
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1784, 841);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load_1;
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private string connectionString = "Data Source=localhost;Initial Catalog=DentalCare;Integrated Security=True";
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Patients p1 = new Patients();
            p1.Show();
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Button button6;
        private Button button7;
        private PictureBox pictureBox1;

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 h2 = new Form1();
            h2.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Appoinment appoinment = new Appoinment();
            appoinment.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Services services = new Services();
            services.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadPatientCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Patients";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        connection.Open();
                        int patientCount = (int)command.ExecuteScalar();
                        label3.Text = "" + patientCount.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {
            LoadPatientCount();
            LoadappoinmentCount();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            INVOICE invoice = new INVOICE();
            invoice.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Report report = new Report();
            report.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoadappoinmentCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Appoinments WHERE CONVERT(DATE, Appoinment_Date) = CONVERT(DATE, GETDATE())";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        connection.Open();
                        int appoinmentCount = (int)command.ExecuteScalar();
                        label4.Text = "" + appoinmentCount.ToString();
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
            this.Close();
            Dentists dentists = new Dentists();
            dentists.Show();
        }
    }
}
