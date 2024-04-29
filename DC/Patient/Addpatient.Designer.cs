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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addpatient));
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
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(442, 130);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(359, 33);
            textBoxName.TabIndex = 0;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(442, 204);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(359, 33);
            textBoxAddress.TabIndex = 1;
            // 
            // textBoxNIC
            // 
            textBoxNIC.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNIC.Location = new Point(442, 389);
            textBoxNIC.Name = "textBoxNIC";
            textBoxNIC.Size = new Size(359, 33);
            textBoxNIC.TabIndex = 2;
            // 
            // textBoxContact
            // 
            textBoxContact.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContact.Location = new Point(442, 460);
            textBoxContact.Name = "textBoxContact";
            textBoxContact.Size = new Size(359, 33);
            textBoxContact.TabIndex = 4;
            // 
            // textBoxMedical
            // 
            textBoxMedical.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMedical.Location = new Point(442, 534);
            textBoxMedical.Name = "textBoxMedical";
            textBoxMedical.Size = new Size(359, 33);
            textBoxMedical.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(426, 653);
            button1.Name = "button1";
            button1.Size = new Size(213, 71);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DOBPicker1
            // 
            DOBPicker1.Format = DateTimePickerFormat.Short;
            DOBPicker1.Location = new Point(442, 270);
            DOBPicker1.Name = "DOBPicker1";
            DOBPicker1.Size = new Size(250, 27);
            DOBPicker1.TabIndex = 7;
            DOBPicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Pname
            // 
            Pname.AutoSize = true;
            Pname.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Pname.Location = new Point(264, 130);
            Pname.Name = "Pname";
            Pname.Size = new Size(131, 30);
            Pname.TabIndex = 8;
            Pname.Text = "Patient Name";
            // 
            // PAddress
            // 
            PAddress.AutoSize = true;
            PAddress.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            PAddress.Location = new Point(264, 207);
            PAddress.Name = "PAddress";
            PAddress.Size = new Size(150, 30);
            PAddress.TabIndex = 9;
            PAddress.Text = "Patient Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(264, 389);
            label3.Name = "label3";
            label3.Size = new Size(43, 30);
            label3.TabIndex = 10;
            label3.Text = "NIC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(264, 272);
            label4.Name = "label4";
            label4.Size = new Size(49, 30);
            label4.TabIndex = 11;
            label4.Text = "DOB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(264, 460);
            label5.Name = "label5";
            label5.Size = new Size(111, 30);
            label5.TabIndex = 12;
            label5.Text = "Contact No";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(264, 534);
            label6.Name = "label6";
            label6.Size = new Size(146, 30);
            label6.TabIndex = 13;
            label6.Text = "Medical Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(264, 333);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 14;
            label1.Text = "Gender";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(442, 333);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 30);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(597, 333);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(88, 30);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(40, 170, 214);
            label2.Location = new Point(426, 9);
            label2.Name = "label2";
            label2.Size = new Size(318, 82);
            label2.TabIndex = 17;
            label2.Text = "Add Patient";
            // 
            // Addpatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 240, 255);
            ClientSize = new Size(1161, 805);
            Controls.Add(label2);
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
        private Label label2;
    }
}