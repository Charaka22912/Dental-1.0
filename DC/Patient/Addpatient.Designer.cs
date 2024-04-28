namespace DC
{
    partial class Addpatient
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
            textBoxName = new TextBox();
            textBoxAddress = new TextBox();
            textBoxNIC = new TextBox();
            textBoxContact = new TextBox();
            textBoxMedical = new TextBox();
            button1 = new Button();
            DOBPicker1 = new DateTimePicker();
            Pname = new Label();
            PAddress = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(417, 209);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(359, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(417, 283);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(359, 27);
            textBoxAddress.TabIndex = 1;
            // 
            // textBoxNIC
            // 
            textBoxNIC.Location = new Point(417, 468);
            textBoxNIC.Name = "textBoxNIC";
            textBoxNIC.Size = new Size(359, 27);
            textBoxNIC.TabIndex = 2;
            // 
            // textBoxContact
            // 
            textBoxContact.Location = new Point(417, 539);
            textBoxContact.Name = "textBoxContact";
            textBoxContact.Size = new Size(359, 27);
            textBoxContact.TabIndex = 4;
            // 
            // textBoxMedical
            // 
            textBoxMedical.Location = new Point(417, 635);
            textBoxMedical.Name = "textBoxMedical";
            textBoxMedical.Size = new Size(359, 27);
            textBoxMedical.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(771, 728);
            button1.Name = "button1";
            button1.Size = new Size(213, 55);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DOBPicker1
            // 
            DOBPicker1.Format = DateTimePickerFormat.Short;
            DOBPicker1.Location = new Point(417, 349);
            DOBPicker1.Name = "DOBPicker1";
            DOBPicker1.Size = new Size(250, 27);
            DOBPicker1.TabIndex = 7;
            DOBPicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Pname
            // 
            Pname.AutoSize = true;
            Pname.Location = new Point(269, 209);
            Pname.Name = "Pname";
            Pname.Size = new Size(98, 20);
            Pname.TabIndex = 8;
            Pname.Text = "Patient Name";
            // 
            // PAddress
            // 
            PAddress.AutoSize = true;
            PAddress.Location = new Point(269, 286);
            PAddress.Name = "PAddress";
            PAddress.Size = new Size(111, 20);
            PAddress.TabIndex = 9;
            PAddress.Text = "Patient Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 475);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 10;
            label3.Text = "NIC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 354);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 11;
            label4.Text = "DOB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 546);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 12;
            label5.Text = "Contact No";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 642);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 13;
            label6.Text = "Medical Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 414);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 14;
            label1.Text = "Gender";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(417, 412);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(572, 412);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Addpatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 805);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PAddress);
            Controls.Add(Pname);
            Controls.Add(DOBPicker1);
            Controls.Add(button1);
            Controls.Add(textBoxMedical);
            Controls.Add(textBoxContact);
            Controls.Add(textBoxNIC);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxName);
            Name = "Addpatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addpatient";
            Load += Addpatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxAddress;
        private TextBox textBoxNIC;
        private TextBox textBoxContact;
        private TextBox textBoxMedical;
        private Button button1;
        private DateTimePicker DOBPicker1;
        private Label Pname;
        private Label PAddress;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}