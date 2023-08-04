namespace thuvienonline
{
    partial class AddStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new thuvienonline.owf.TextBox();
            this.txtAge = new thuvienonline.owf.TextBox();
            this.txtClass = new thuvienonline.owf.TextBox();
            this.txtStudentName = new thuvienonline.owf.TextBox();
            this.uiButton1 = new thuvienonline.owf.UIButton();
            this.UIbtnSave = new thuvienonline.owf.UIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::thuvienonline.Properties.Resources.AddStudents;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtClass);
            this.panel1.Controls.Add(this.txtStudentName);
            this.panel1.Controls.Add(this.uiButton1);
            this.panel1.Controls.Add(this.UIbtnSave);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 576);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label5.Location = new System.Drawing.Point(615, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email *";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label4.Location = new System.Drawing.Point(173, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Age *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(615, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Class *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(173, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student Name *";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(619, 462);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "Enter Email ...";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.Size = new System.Drawing.Size(313, 35);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.Window;
            this.txtAge.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.txtAge.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.txtAge.BorderRadius = 5;
            this.txtAge.BorderSize = 2;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.DimGray;
            this.txtAge.Location = new System.Drawing.Point(177, 462);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge.Multiline = false;
            this.txtAge.Name = "txtAge";
            this.txtAge.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAge.PasswordChar = false;
            this.txtAge.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAge.PlaceholderText = "Enter Age ...";
            this.txtAge.ReadOnly = false;
            this.txtAge.Size = new System.Drawing.Size(313, 35);
            this.txtAge.TabIndex = 8;
            this.txtAge.Texts = "";
            this.txtAge.UnderlinedStyle = false;
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.SystemColors.Window;
            this.txtClass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.txtClass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.txtClass.BorderRadius = 5;
            this.txtClass.BorderSize = 2;
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.ForeColor = System.Drawing.Color.DimGray;
            this.txtClass.Location = new System.Drawing.Point(619, 376);
            this.txtClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClass.Multiline = false;
            this.txtClass.Name = "txtClass";
            this.txtClass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtClass.PasswordChar = false;
            this.txtClass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtClass.PlaceholderText = "Enter Class ...";
            this.txtClass.ReadOnly = false;
            this.txtClass.Size = new System.Drawing.Size(313, 35);
            this.txtClass.TabIndex = 7;
            this.txtClass.Texts = "";
            this.txtClass.UnderlinedStyle = false;
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.SystemColors.Window;
            this.txtStudentName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.txtStudentName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.txtStudentName.BorderRadius = 5;
            this.txtStudentName.BorderSize = 2;
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.ForeColor = System.Drawing.Color.DimGray;
            this.txtStudentName.Location = new System.Drawing.Point(177, 376);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentName.Multiline = false;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStudentName.PasswordChar = false;
            this.txtStudentName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtStudentName.PlaceholderText = "Enter Student Name ...";
            this.txtStudentName.ReadOnly = false;
            this.txtStudentName.Size = new System.Drawing.Size(313, 35);
            this.txtStudentName.TabIndex = 6;
            this.txtStudentName.Texts = "";
            this.txtStudentName.UnderlinedStyle = false;
            // 
            // uiButton1
            // 
            this.uiButton1.BackColor = System.Drawing.Color.White;
            this.uiButton1.BackgroundColor = System.Drawing.Color.White;
            this.uiButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.uiButton1.BorderRadius = 10;
            this.uiButton1.BorderSize = 2;
            this.uiButton1.FlatAppearance.BorderSize = 0;
            this.uiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.uiButton1.Location = new System.Drawing.Point(833, 120);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(90, 30);
            this.uiButton1.TabIndex = 5;
            this.uiButton1.Text = "↺ Refresh";
            this.uiButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.uiButton1.UseVisualStyleBackColor = false;
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // UIbtnSave
            // 
            this.UIbtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(102)))));
            this.UIbtnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(102)))));
            this.UIbtnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(102)))));
            this.UIbtnSave.BorderRadius = 10;
            this.UIbtnSave.BorderSize = 0;
            this.UIbtnSave.FlatAppearance.BorderSize = 0;
            this.UIbtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UIbtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIbtnSave.ForeColor = System.Drawing.Color.White;
            this.UIbtnSave.Location = new System.Drawing.Point(929, 120);
            this.UIbtnSave.Name = "UIbtnSave";
            this.UIbtnSave.Size = new System.Drawing.Size(90, 30);
            this.UIbtnSave.TabIndex = 4;
            this.UIbtnSave.Text = "✓ Save";
            this.UIbtnSave.TextColor = System.Drawing.Color.White;
            this.UIbtnSave.UseVisualStyleBackColor = false;
            this.UIbtnSave.Click += new System.EventHandler(this.UIbtnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::thuvienonline.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(1010, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1082, 576);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddStudent_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private owf.UIButton UIbtnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private owf.UIButton uiButton1;
        private owf.TextBox txtStudentName;
        private owf.TextBox txtEmail;
        private owf.TextBox txtAge;
        private owf.TextBox txtClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}