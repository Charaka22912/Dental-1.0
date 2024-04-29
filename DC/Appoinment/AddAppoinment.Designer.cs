namespace DC
{
    partial class AddAppoinment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAppoinment));
            textBoxpatient = new TextBox();
            buttonview = new Button();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            textBoxdentist = new TextBox();
            buttondentist = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxpatient
            // 
            textBoxpatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxpatient.Location = new Point(347, 134);
            textBoxpatient.Name = "textBoxpatient";
            textBoxpatient.Size = new Size(268, 34);
            textBoxpatient.TabIndex = 0;
            textBoxpatient.TextChanged += textBox1_TextChanged;
            // 
            // buttonview
            // 
            buttonview.BackgroundImage = (Image)resources.GetObject("buttonview.BackgroundImage");
            buttonview.BackgroundImageLayout = ImageLayout.Stretch;
            buttonview.FlatAppearance.BorderSize = 0;
            buttonview.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonview.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonview.FlatStyle = FlatStyle.Flat;
            buttonview.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonview.Location = new Point(647, 133);
            buttonview.Name = "buttonview";
            buttonview.Size = new Size(119, 37);
            buttonview.TabIndex = 1;
            buttonview.UseVisualStyleBackColor = true;
            buttonview.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(347, 249);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(268, 34);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2024, 4, 21, 0, 0, 0, 0);
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(332, 388);
            button2.Name = "button2";
            button2.Size = new Size(225, 68);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxdentist
            // 
            textBoxdentist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxdentist.Location = new Point(347, 193);
            textBoxdentist.Name = "textBoxdentist";
            textBoxdentist.Size = new Size(268, 34);
            textBoxdentist.TabIndex = 4;
            // 
            // buttondentist
            // 
            buttondentist.BackgroundImage = (Image)resources.GetObject("buttondentist.BackgroundImage");
            buttondentist.BackgroundImageLayout = ImageLayout.Stretch;
            buttondentist.FlatAppearance.BorderSize = 0;
            buttondentist.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttondentist.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttondentist.FlatStyle = FlatStyle.Flat;
            buttondentist.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttondentist.Location = new Point(647, 191);
            buttondentist.Name = "buttondentist";
            buttondentist.Size = new Size(119, 36);
            buttondentist.TabIndex = 5;
            buttondentist.UseVisualStyleBackColor = true;
            buttondentist.Click += buttondentist_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Items.AddRange(new object[] { "Pending", "Confirmed" });
            listBox1.Location = new Point(347, 301);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(178, 32);
            listBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(111, 134);
            label1.Name = "label1";
            label1.Size = new Size(106, 31);
            label1.TabIndex = 7;
            label1.Text = "PatientID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(111, 194);
            label2.Name = "label2";
            label2.Size = new Size(106, 31);
            label2.TabIndex = 8;
            label2.Text = "DentistID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(111, 249);
            label3.Name = "label3";
            label3.Size = new Size(191, 31);
            label3.TabIndex = 9;
            label3.Text = "Appoinment Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(111, 302);
            label4.Name = "label4";
            label4.Size = new Size(209, 31);
            label4.TabIndex = 10;
            label4.Text = "Appoinment Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(40, 170, 214);
            label5.Location = new Point(282, 23);
            label5.Name = "label5";
            label5.Size = new Size(347, 50);
            label5.TabIndex = 11;
            label5.Text = "Add New Appointment";
            // 
            // AddAppoinment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 240, 255);
            ClientSize = new Size(932, 555);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(buttondentist);
            Controls.Add(textBoxdentist);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonview);
            Controls.Add(textBoxpatient);
            MaximizeBox = false;
            Name = "AddAppoinment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAppoinment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxpatient;
        private Button buttonview;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private TextBox textBoxdentist;
        private Button buttondentist;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}