namespace DC
{
    partial class PrintInvoice
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            lableTotal = new Label();
            dataGridView1 = new DataGridView();
            labledate = new Label();
            labelname = new Label();
            labelMrms = new Label();
            label1 = new Label();
            button1 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lableTotal);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(labledate);
            panel1.Controls.Add(labelname);
            panel1.Controls.Add(labelMrms);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(49, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 581);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(442, 480);
            label2.Name = "label2";
            label2.Size = new Size(70, 36);
            label2.TabIndex = 6;
            label2.Text = "Total";
            // 
            // lableTotal
            // 
            lableTotal.AutoSize = true;
            lableTotal.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lableTotal.Location = new Point(535, 480);
            lableTotal.Name = "lableTotal";
            lableTotal.Size = new Size(27, 36);
            lableTotal.TabIndex = 5;
            lableTotal.Text = "?";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(95, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(500, 199);
            dataGridView1.TabIndex = 4;
            // 
            // labledate
            // 
            labledate.AutoSize = true;
            labledate.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labledate.Location = new Point(504, 119);
            labledate.Name = "labledate";
            labledate.Size = new Size(25, 31);
            labledate.TabIndex = 3;
            labledate.Text = "?";
            labledate.Click += labledate_Click;
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelname.Location = new Point(126, 119);
            labelname.Name = "labelname";
            labelname.Size = new Size(25, 31);
            labelname.TabIndex = 2;
            labelname.Text = "?";
            // 
            // labelMrms
            // 
            labelMrms.AutoSize = true;
            labelMrms.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelMrms.Location = new Point(95, 119);
            labelMrms.Name = "labelMrms";
            labelMrms.Size = new Size(25, 31);
            labelMrms.TabIndex = 1;
            labelMrms.Text = "?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(228, 6);
            label1.Name = "label1";
            label1.Size = new Size(153, 60);
            label1.TabIndex = 0;
            label1.Text = "Invoice";
            // 
            // button1
            // 
            button1.Location = new Point(636, 14);
            button1.Name = "button1";
            button1.Size = new Size(64, 38);
            button1.TabIndex = 1;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // PrintInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 651);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "PrintInvoice";
            Text = "PrintInvoice";
            Load += PrintInvoice_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label lableTotal;
        private DataGridView dataGridView1;
        private Label labledate;
        private Label labelname;
        private Label labelMrms;
        private Label label1;
        private Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
    }
}