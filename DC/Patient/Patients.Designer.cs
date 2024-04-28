namespace DC
{
    partial class Patients
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            patientsBindingSource = new BindingSource(components);
            button1 = new Button();
            Addnew = new Button();
            Edit = new Button();
            Refresh = new Button();
            SearchButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 162);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.GridColor = SystemColors.HighlightText;
            dataGridView1.Location = new Point(88, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowTemplate.DividerHeight = 2;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(1350, 677);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // patientsBindingSource
            // 
            patientsBindingSource.DataSource = typeof(Patients);
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(58, 59);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Addnew
            // 
            Addnew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Addnew.BackColor = Color.Transparent;
            Addnew.BackgroundImage = (Image)resources.GetObject("Addnew.BackgroundImage");
            Addnew.BackgroundImageLayout = ImageLayout.Stretch;
            Addnew.FlatAppearance.BorderSize = 0;
            Addnew.FlatStyle = FlatStyle.Flat;
            Addnew.Location = new Point(1307, 167);
            Addnew.Name = "Addnew";
            Addnew.Size = new Size(58, 58);
            Addnew.TabIndex = 2;
            Addnew.UseVisualStyleBackColor = false;
            Addnew.Click += button2_Click;
            // 
            // Edit
            // 
            Edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Edit.Location = new Point(1380, 170);
            Edit.Name = "Edit";
            Edit.Size = new Size(58, 55);
            Edit.TabIndex = 4;
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += button4_Click;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(88, 170);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(54, 46);
            Refresh.TabIndex = 5;
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += button5_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(508, 99);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(109, 26);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 102);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 8;
            label1.Text = "Patient Name";
            // 
            // Patients
            // 
            ClientSize = new Size(1576, 947);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(SearchButton);
            Controls.Add(Refresh);
            Controls.Add(Edit);
            Controls.Add(Addnew);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Patients";
            Text = "Patients";
            WindowState = FormWindowState.Maximized;
            Load += Patients_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private BindingSource patientsBindingSource;
        protected DataGridView dataGridView1;
        private Button button1;
        private Button Addnew;
        private Button Edit;
        private Button Refresh;
        private Button SearchButton;
        private TextBox textBox1;
        private Label label1;
    }
}