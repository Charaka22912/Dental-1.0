namespace DC
{
    partial class Editappoinment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editappoinment));
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            listBox1 = new ListBox();
            textBoxID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(215, 450);
            button1.Name = "button1";
            button1.Size = new Size(210, 65);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(294, 243);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 27);
            textBox2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(294, 305);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(251, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Pending", "Confirmed" });
            listBox1.Location = new Point(294, 364);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(182, 24);
            listBox1.TabIndex = 4;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(294, 125);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(306, 27);
            textBoxID.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(40, 170, 214);
            label1.Location = new Point(117, 9);
            label1.Name = "label1";
            label1.Size = new Size(459, 82);
            label1.TabIndex = 6;
            label1.Text = "Edit Appointment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(93, 125);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 7;
            label2.Text = "AppointmentID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(93, 183);
            label3.Name = "label3";
            label3.Size = new Size(88, 30);
            label3.TabIndex = 8;
            label3.Text = "PatientID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(93, 243);
            label4.Name = "label4";
            label4.Size = new Size(102, 30);
            label4.TabIndex = 9;
            label4.Text = "Dentists ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(93, 307);
            label5.Name = "label5";
            label5.Size = new Size(169, 30);
            label5.TabIndex = 10;
            label5.Text = "Appointment Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(93, 364);
            label6.Name = "label6";
            label6.Size = new Size(66, 30);
            label6.TabIndex = 11;
            label6.Text = "Status";
            // 
            // Editappoinment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 240, 255);
            ClientSize = new Size(715, 571);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxID);
            Controls.Add(listBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Editappoinment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editappoinment";
            Load += Editappoinment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox1;
        private TextBox textBoxID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}