﻿namespace DC
{
    partial class Addservices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addservices));
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(321, 470);
            button1.Name = "button1";
            button1.Size = new Size(253, 72);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(370, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(337, 33);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(370, 277);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(337, 33);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(370, 351);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(394, 33);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(164, 202);
            label1.Name = "label1";
            label1.Size = new Size(142, 30);
            label1.TabIndex = 4;
            label1.Text = "Service Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(164, 277);
            label2.Name = "label2";
            label2.Size = new Size(132, 30);
            label2.TabIndex = 5;
            label2.Text = "Service Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(164, 354);
            label3.Name = "label3";
            label3.Size = new Size(193, 30);
            label3.TabIndex = 6;
            label3.Text = "Service Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(40, 170, 214);
            label4.Location = new Point(299, 9);
            label4.Name = "label4";
            label4.Size = new Size(348, 82);
            label4.TabIndex = 7;
            label4.Text = "Add Services";
            // 
            // Addservices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 240, 255);
            ClientSize = new Size(980, 765);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Addservices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addservices";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}