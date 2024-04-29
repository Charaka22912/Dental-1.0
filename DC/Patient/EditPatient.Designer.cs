namespace DC
{
    partial class EditPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPatient));
            textBox1 = new TextBox();
            textBoxAddress = new TextBox();
            textBoxcontact = new TextBox();
            textBox5 = new TextBox();
            textBoxname = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxNIC = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label9 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(392, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 33);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(392, 260);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(364, 33);
            textBoxAddress.TabIndex = 1;
            // 
            // textBoxcontact
            // 
            textBoxcontact.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxcontact.Location = new Point(392, 515);
            textBoxcontact.Name = "textBoxcontact";
            textBoxcontact.Size = new Size(364, 33);
            textBoxcontact.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(392, 587);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(364, 33);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBoxname
            // 
            textBoxname.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxname.Location = new Point(392, 196);
            textBoxname.Name = "textBoxname";
            textBoxname.Size = new Size(364, 33);
            textBoxname.TabIndex = 7;
            textBoxname.TextChanged += textBox8_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(392, 325);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(430, 678);
            button2.Name = "button2";
            button2.Size = new Size(254, 64);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(793, 121);
            button3.Name = "button3";
            button3.Size = new Size(101, 36);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(223, 126);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 12;
            label1.Text = "Patient ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(223, 201);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 13;
            label2.Text = "Patient Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(223, 268);
            label3.Name = "label3";
            label3.Size = new Size(91, 30);
            label3.TabIndex = 14;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(223, 518);
            label4.Name = "label4";
            label4.Size = new Size(89, 30);
            label4.TabIndex = 15;
            label4.Text = "Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(223, 330);
            label5.Name = "label5";
            label5.Size = new Size(51, 30);
            label5.TabIndex = 16;
            label5.Text = "Dob";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(223, 392);
            label6.Name = "label6";
            label6.Size = new Size(82, 30);
            label6.TabIndex = 17;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(223, 590);
            label7.Name = "label7";
            label7.Size = new Size(156, 30);
            label7.TabIndex = 18;
            label7.Text = "Medical Details";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(223, 447);
            label8.Name = "label8";
            label8.Size = new Size(45, 30);
            label8.TabIndex = 20;
            label8.Text = "NIC";
            // 
            // textBoxNIC
            // 
            textBoxNIC.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNIC.Location = new Point(392, 444);
            textBoxNIC.Name = "textBoxNIC";
            textBoxNIC.Size = new Size(364, 33);
            textBoxNIC.TabIndex = 19;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(400, 390);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 34);
            radioButton1.TabIndex = 21;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(511, 388);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(98, 34);
            radioButton2.TabIndex = 22;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(40, 170, 214);
            label9.Location = new Point(408, 9);
            label9.Name = "label9";
            label9.Size = new Size(309, 82);
            label9.TabIndex = 23;
            label9.Text = "Edit Patient";
            // 
            // EditPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 240, 255);
            ClientSize = new Size(1107, 768);
            Controls.Add(label9);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label8);
            Controls.Add(textBoxNIC);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxname);
            Controls.Add(textBox5);
            Controls.Add(textBoxcontact);
            Controls.Add(textBoxAddress);
            Controls.Add(textBox1);
            Name = "EditPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditPatient";
            Load += EditPatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBoxAddress;
        private TextBox textBoxcontact;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBoxname;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxNIC;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label9;
    }
}