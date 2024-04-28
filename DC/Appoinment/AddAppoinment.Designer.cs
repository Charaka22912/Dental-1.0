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
            SuspendLayout();
            // 
            // textBoxpatient
            // 
            textBoxpatient.Location = new Point(306, 259);
            textBoxpatient.Name = "textBoxpatient";
            textBoxpatient.Size = new Size(268, 27);
            textBoxpatient.TabIndex = 0;
            textBoxpatient.TextChanged += textBox1_TextChanged;
            // 
            // buttonview
            // 
            buttonview.Location = new Point(644, 259);
            buttonview.Name = "buttonview";
            buttonview.Size = new Size(147, 27);
            buttonview.TabIndex = 1;
            buttonview.Text = "View All";
            buttonview.UseVisualStyleBackColor = true;
            buttonview.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(306, 410);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(322, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2024, 4, 21, 0, 0, 0, 0);
            // 
            // button2
            // 
            button2.Location = new Point(644, 657);
            button2.Name = "button2";
            button2.Size = new Size(236, 53);
            button2.TabIndex = 3;
            button2.Text = "Add Appoinment";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxdentist
            // 
            textBoxdentist.Location = new Point(306, 329);
            textBoxdentist.Name = "textBoxdentist";
            textBoxdentist.Size = new Size(268, 27);
            textBoxdentist.TabIndex = 4;
            // 
            // buttondentist
            // 
            buttondentist.Location = new Point(644, 329);
            buttondentist.Name = "buttondentist";
            buttondentist.Size = new Size(147, 27);
            buttondentist.TabIndex = 5;
            buttondentist.Text = "View All";
            buttondentist.UseVisualStyleBackColor = true;
            buttondentist.Click += buttondentist_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Pending", "Confirmed" });
            listBox1.Location = new Point(306, 484);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(178, 24);
            listBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 262);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 7;
            label1.Text = "PatientID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 332);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 8;
            label2.Text = "DentistID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 415);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 9;
            label3.Text = "Appoinment Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 484);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 10;
            label4.Text = "Appoinment Status";
            // 
            // AddAppoinment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 740);
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
    }
}