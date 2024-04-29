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
            label3.Parent = pictureBox2;
            label3.BackColor = Color.White;

            label2.Parent = pictureBox2;
            label2.BackColor = Color.White;

            label4.Parent = pictureBox2;
            label4.BackColor = Color.White;
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
            button6 = new Button();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(312, 473);
            button1.Name = "button1";
            button1.Size = new Size(398, 153);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(740, 473);
            button2.Name = "button2";
            button2.Size = new Size(398, 153);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(1175, 473);
            button3.Name = "button3";
            button3.Size = new Size(398, 153);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(312, 665);
            button4.Name = "button4";
            button4.Size = new Size(398, 153);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(740, 665);
            button5.Name = "button5";
            button5.Size = new Size(398, 153);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top;
            button6.BackColor = Color.Transparent;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(1175, 665);
            button6.Name = "button6";
            button6.Size = new Size(398, 153);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = false;
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
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(1808, 12);
            button7.Name = "button7";
            button7.Size = new Size(82, 73);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Poppins", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(40, 170, 214);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(669, 182);
            label3.Name = "label3";
            label3.Size = new Size(232, 141);
            label3.TabIndex = 10;
            label3.Text = "?";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(692, 321);
            label2.Name = "label2";
            label2.Size = new Size(180, 40);
            label2.TabIndex = 11;
            label2.Text = "Total Patients";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Poppins", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(40, 170, 214);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(1020, 182);
            label4.Name = "label4";
            label4.Size = new Size(170, 141);
            label4.TabIndex = 12;
            label4.Text = "?";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(958, 321);
            label5.Name = "label5";
            label5.Size = new Size(259, 40);
            label5.TabIndex = 13;
            label5.Text = "Today Appoinments";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(614, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(646, 214);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(690, 45);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(500, 68);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // Dashboard
            // 
            BackColor = Color.FromArgb(194, 240, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load_1;
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
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
