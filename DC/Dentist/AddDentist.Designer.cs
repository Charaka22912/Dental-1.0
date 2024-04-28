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
            SuspendLayout();
            // 
            // textBoxname
            // 
            textBoxname.Location = new Point(158, 28);
            textBoxname.Name = "textBoxname";
            textBoxname.Size = new Size(338, 27);
            textBoxname.TabIndex = 0;
            // 
            // textBoxaddress
            // 
            textBoxaddress.Location = new Point(158, 61);
            textBoxaddress.Name = "textBoxaddress";
            textBoxaddress.Size = new Size(338, 27);
            textBoxaddress.TabIndex = 1;
            // 
            // textBoxcontact
            // 
            textBoxcontact.Location = new Point(158, 94);
            textBoxcontact.Name = "textBoxcontact";
            textBoxcontact.Size = new Size(338, 27);
            textBoxcontact.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(158, 127);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(185, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "General Dentist", "Orthodontist", "Endodontist", "Prosthodontist", "Oral Pathologist", "Oral Radiologist" });
            listBox1.Location = new Point(158, 160);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(185, 24);
            listBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 35);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 5;
            label1.Text = "Dentist Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 68);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 6;
            label2.Text = "Dentist Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 101);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 7;
            label3.Text = "Contact";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 132);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 8;
            label4.Text = "Joined Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 164);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 9;
            label5.Text = "Specialization";
            // 
            // button1
            // 
            button1.Location = new Point(158, 200);
            button1.Name = "button1";
            button1.Size = new Size(201, 49);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddDentist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 286);
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
    }
}