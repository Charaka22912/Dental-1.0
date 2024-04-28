namespace DC
{
    partial class INVOICE
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
            button1 = new Button();
            labelname = new Label();
            listBox1 = new ListBox();
            button2 = new Button();
            labeldate = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(459, 49);
            button1.Name = "button1";
            button1.Size = new Size(83, 28);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Location = new Point(164, 157);
            labelname.Name = "labelname";
            labelname.Size = new Size(0, 20);
            labelname.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Mr", "Ms" });
            listBox1.Location = new Point(89, 153);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(58, 24);
            listBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(89, 222);
            button2.Name = "button2";
            button2.Size = new Size(150, 80);
            button2.TabIndex = 4;
            button2.Text = "Add Service";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labeldate
            // 
            labeldate.AutoSize = true;
            labeldate.Location = new Point(958, 153);
            labeldate.Name = "labeldate";
            labeldate.Size = new Size(50, 20);
            labeldate.TabIndex = 6;
            labeldate.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(265, 222);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(743, 207);
            dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(958, 518);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // button3
            // 
            button3.Location = new Point(459, 518);
            button3.Name = "button3";
            button3.Size = new Size(199, 33);
            button3.TabIndex = 9;
            button3.Text = "Calculate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(810, 518);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 10;
            label2.Text = "Total";
            // 
            // button4
            // 
            button4.Location = new Point(973, 33);
            button4.Name = "button4";
            button4.Size = new Size(68, 43);
            button4.TabIndex = 11;
            button4.Text = "Print";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // INVOICE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 586);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(labeldate);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(labelname);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "INVOICE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INVOICE";
            Load += INVOICE_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label labelname;
        private ListBox listBox1;
        private Button button2;
        private Label labeldate;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button3;
        private Label label2;
        private Button button4;
    }
}