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
            label2 = new Label();
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
            dataGridView1.BackgroundColor = Color.FromArgb(194, 240, 255);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            dataGridView1.Location = new Point(301, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowTemplate.DividerHeight = 2;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(1463, 763);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // patientsBindingSource
            // 
            patientsBindingSource.DataSource = typeof(Patients);
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(85, 59);
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
            Addnew.Location = new Point(36, 231);
            Addnew.Name = "Addnew";
            Addnew.Size = new Size(235, 81);
            Addnew.TabIndex = 2;
            Addnew.UseVisualStyleBackColor = false;
            Addnew.Click += button2_Click;
            // 
            // Edit
            // 
            Edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Edit.BackgroundImage = (Image)resources.GetObject("Edit.BackgroundImage");
            Edit.BackgroundImageLayout = ImageLayout.Stretch;
            Edit.FlatAppearance.BorderSize = 0;
            Edit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Edit.FlatStyle = FlatStyle.Flat;
            Edit.Location = new Point(36, 344);
            Edit.Name = "Edit";
            Edit.Size = new Size(235, 81);
            Edit.TabIndex = 4;
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += button4_Click;
            // 
            // Refresh
            // 
            Refresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Refresh.BackgroundImage = (Image)resources.GetObject("Refresh.BackgroundImage");
            Refresh.BackgroundImageLayout = ImageLayout.Stretch;
            Refresh.FlatAppearance.BorderSize = 0;
            Refresh.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Refresh.FlatStyle = FlatStyle.Flat;
            Refresh.Location = new Point(1606, 173);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(158, 52);
            Refresh.TabIndex = 5;
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += button5_Click;
            // 
            // SearchButton
            // 
            SearchButton.BackgroundImage = (Image)resources.GetObject("SearchButton.BackgroundImage");
            SearchButton.BackgroundImageLayout = ImageLayout.Stretch;
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Location = new Point(774, 144);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(97, 36);
            SearchButton.TabIndex = 6;
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(470, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 34);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(301, 144);
            label1.Name = "label1";
            label1.Size = new Size(163, 36);
            label1.TabIndex = 8;
            label1.Text = "Patient Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(40, 170, 214);
            label2.Location = new Point(960, 9);
            label2.Name = "label2";
            label2.Size = new Size(245, 82);
            label2.TabIndex = 9;
            label2.Text = "Patients ";
            // 
            // Patients
            // 
            BackColor = Color.FromArgb(194, 240, 255);
            ClientSize = new Size(1902, 1033);
            Controls.Add(label2);
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
        private Label label2;
    }
}