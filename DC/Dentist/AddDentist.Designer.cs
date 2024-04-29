namespace DC
{
    partial class AddDentist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDentist));
            textBoxname = new TextBox();
            textBoxaddress = new TextBox();
            textBoxcontact = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBoxname
            // 
            textBoxname.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxname.Location = new Point(269, 110);
            textBoxname.Name = "textBoxname";
            textBoxname.Size = new Size(338, 37);
            textBoxname.TabIndex = 0;
            // 
            // textBoxaddress
            // 
            textBoxaddress.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxaddress.Location = new Point(269, 171);
            textBoxaddress.Name = "textBoxaddress";
            textBoxaddress.Size = new Size(338, 37);
            textBoxaddress.TabIndex = 1;
            // 
            // textBoxcontact
            // 
            textBoxcontact.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxcontact.Location = new Point(269, 227);
            textBoxcontact.Name = "textBoxcontact";
            textBoxcontact.Size = new Size(338, 37);
            textBoxcontact.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(269, 297);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(185, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 36;
            listBox1.Items.AddRange(new object[] { "General Dentist", "Orthodontist", "Endodontist", "Prosthodontist", "Oral Pathologist", "Oral Radiologist" });
            listBox1.Location = new Point(261, 349);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(172, 40);
            listBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 113);
            label1.Name = "label1";
            label1.Size = new Size(154, 36);
            label1.TabIndex = 5;
            label1.Text = "Dentist Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(70, 174);
            label2.Name = "label2";
            label2.Size = new Size(176, 36);
            label2.TabIndex = 6;
            label2.Text = "Dentist Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(70, 230);
            label3.Name = "label3";
            label3.Size = new Size(98, 36);
            label3.TabIndex = 7;
            label3.Text = "Contact";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(70, 288);
            label4.Name = "label4";
            label4.Size = new Size(137, 36);
            label4.TabIndex = 8;
            label4.Text = "Joined Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(70, 353);
            label5.Name = "label5";
            label5.Size = new Size(161, 36);
            label5.TabIndex = 9;
            label5.Text = "Specialization";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(269, 439);
            button1.Name = "button1";
            button1.Size = new Size(164, 49);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(40, 170, 214);
            label6.Location = new Point(159, 9);
            label6.Name = "label6";
            label6.Size = new Size(343, 82);
            label6.TabIndex = 11;
            label6.Text = "Add Dentists";
            // 
            // AddDentist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 240, 255);
            ClientSize = new Size(705, 529);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxcontact);
            Controls.Add(textBoxaddress);
            Controls.Add(textBoxname);
            Name = "AddDentist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddDentist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxname;
        private TextBox textBoxaddress;
        private TextBox textBoxcontact;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
    }
}