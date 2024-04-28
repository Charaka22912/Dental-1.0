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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            listBox1 = new ListBox();
            textBoxID = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(562, 598);
            button1.Name = "button1";
            button1.Size = new Size(210, 62);
            button1.TabIndex = 0;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(239, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 27);
            textBox2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(239, 382);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(251, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Pending", "Confirmed" });
            listBox1.Location = new Point(239, 461);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(182, 24);
            listBox1.TabIndex = 4;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(239, 110);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(306, 27);
            textBoxID.TabIndex = 5;
            // 
            // Editappoinment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 759);
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
    }
}