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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INVOICE));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            textBox1 = new TextBox();
            button1 = new Button();
            labelname = new Label();
            listBox1 = new ListBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            button4 = new Button();
            labeldate = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(89, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 34);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(448, 112);
            button1.Name = "button1";
            button1.Size = new Size(104, 34);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelname.Location = new Point(329, 197);
            labelname.Name = "labelname";
            labelname.Size = new Size(25, 31);
            labelname.TabIndex = 2;
            labelname.Text = "?";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Items.AddRange(new object[] { "Mr", "Ms" });
            listBox1.Location = new Point(265, 198);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(58, 30);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(89, 281);
            button2.Name = "button2";
            button2.Size = new Size(141, 49);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(194, 240, 255);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(265, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.Size = new Size(743, 207);
            dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(941, 515);
            label1.Name = "label1";
            label1.Size = new Size(67, 30);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(459, 490);
            button3.Name = "button3";
            button3.Size = new Size(195, 61);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(805, 503);
            label2.Name = "label2";
            label2.Size = new Size(94, 50);
            label2.TabIndex = 10;
            label2.Text = "Total";
            label2.Click += label2_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(861, 100);
            button4.Name = "button4";
            button4.Size = new Size(147, 46);
            button4.TabIndex = 11;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // labeldate
            // 
            labeldate.AutoSize = true;
            labeldate.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labeldate.Location = new Point(952, 194);
            labeldate.Name = "labeldate";
            labeldate.Size = new Size(71, 36);
            labeldate.TabIndex = 6;
            labeldate.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(40, 170, 214);
            label3.Location = new Point(372, 9);
            label3.Name = "label3";
            label3.Size = new Size(397, 82);
            label3.TabIndex = 12;
            label3.Text = "Select Services";
            // 
            // INVOICE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 240, 255);
            ClientSize = new Size(1181, 586);
            Controls.Add(label3);
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
            MaximizeBox = false;
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
        private DataGridView dataGridView1;
        private Label label1;
        private Button button3;
        private Label label2;
        private Button button4;
        private Label labeldate;
        private Label label3;
    }
}