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
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(281, 242);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(364, 27);
            textBoxAddress.TabIndex = 1;
            // 
            // textBoxcontact
            // 
            textBoxcontact.Location = new Point(281, 492);
            textBoxcontact.Name = "textBoxcontact";
            textBoxcontact.Size = new Size(364, 27);
            textBoxcontact.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(281, 563);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(364, 27);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBoxname
            // 
            textBoxname.Location = new Point(281, 175);
            textBoxname.Name = "textBoxname";
            textBoxname.Size = new Size(364, 27);
            textBoxname.TabIndex = 7;
            textBoxname.TextChanged += textBox8_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(281, 302);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button2
            // 
            button2.Location = new Point(664, 661);
            button2.Name = "button2";
            button2.Size = new Size(306, 47);
            button2.TabIndex = 10;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(699, 76);
            button3.Name = "button3";
            button3.Size = new Size(95, 27);
            button3.TabIndex = 11;
            button3.Text = "View all";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 76);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 12;
            label1.Text = "Patient ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 178);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 13;
            label2.Text = "Patient Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 245);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 14;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 495);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 15;
            label4.Text = "Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 307);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 16;
            label5.Text = "Dob";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(131, 369);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 17;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(131, 566);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 18;
            label7.Text = "Medical Details";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(131, 424);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 20;
            label8.Text = "NIC";
            // 
            // textBoxNIC
            // 
            textBoxNIC.Location = new Point(281, 421);
            textBoxNIC.Name = "textBoxNIC";
            textBoxNIC.Size = new Size(364, 27);
            textBoxNIC.TabIndex = 19;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(289, 367);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 21;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(400, 365);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 22;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // EditPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 768);
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
    }
}