namespace thuvienonline
{
    partial class ViewStudent
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new thuvienonline.owf.TextBox();
            this.txtAge = new thuvienonline.owf.TextBox();
            this.txtClass = new thuvienonline.owf.TextBox();
            this.txtStudentName = new thuvienonline.owf.TextBox();
            this.uibtnUpdate = new thuvienonline.owf.UIButton();
            this.uibtnDelete = new thuvienonline.owf.UIButton();
            this.txtSearchStudents = new thuvienonline.owf.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 165);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1096, 223);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::thuvienonline.Properties.Resources.ViewStudenFix;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtClass);
            this.panel1.Controls.Add(this.txtStudentName);
            this.panel1.Controls.Add(this.uibtnUpdate);
            this.panel1.Controls.Add(this.uibtnDelete);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtSearchStudents);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 661);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::thuvienonline.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(1110, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 22);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.txtEmail.Location = new System.Drawing.Point(676, 529);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "Enter Email ...";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.Size = new System.Drawing.Size(313, 35);
            this.txtEmail.TabIndex = 11;
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
            this.txtAge.Location = new System.Drawing.Point(266, 529);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge.Multiline = false;
            this.txtAge.Name = "txtAge";
            this.txtAge.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAge.PasswordChar = false;
            this.txtAge.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAge.PlaceholderText = "Enter Age ...";
            this.txtAge.ReadOnly = false;
            this.txtAge.Size = new System.Drawing.Size(313, 35);
            this.txtAge.TabIndex = 10;
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
            this.txtClass.Location = new System.Drawing.Point(676, 439);
            this.txtClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClass.Multiline = false;
            this.txtClass.Name = "txtClass";
            this.txtClass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtClass.PasswordChar = false;
            this.txtClass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtClass.PlaceholderText = "Enter Class ...";
            this.txtClass.ReadOnly = false;
            this.txtClass.Size = new System.Drawing.Size(313, 35);
            this.txtClass.TabIndex = 9;
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
            this.txtStudentName.Location = new System.Drawing.Point(266, 439);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentName.Multiline = false;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStudentName.PasswordChar = false;
            this.txtStudentName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtStudentName.PlaceholderText = "Enter Student Name ...";
            this.txtStudentName.ReadOnly = false;
            this.txtStudentName.Size = new System.Drawing.Size(313, 35);
            this.txtStudentName.TabIndex = 8;
            this.txtStudentName.Texts = "";
            this.txtStudentName.UnderlinedStyle = false;
            // 
            // uibtnUpdate
            // 
            this.uibtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(250)))));
            this.uibtnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(250)))));
            this.uibtnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.uibtnUpdate.BorderRadius = 10;
            this.uibtnUpdate.BorderSize = 0;
            this.uibtnUpdate.FlatAppearance.BorderSize = 0;
            this.uibtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uibtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uibtnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.uibtnUpdate.Location = new System.Drawing.Point(872, 609);
            this.uibtnUpdate.Name = "uibtnUpdate";
            this.uibtnUpdate.Size = new System.Drawing.Size(150, 40);
            this.uibtnUpdate.TabIndex = 7;
            this.uibtnUpdate.Text = "+ Update";
            this.uibtnUpdate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.uibtnUpdate.UseVisualStyleBackColor = false;
            this.uibtnUpdate.Click += new System.EventHandler(this.uibtnUpdate_Click);
            // 
            // uibtnDelete
            // 
            this.uibtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(102)))));
            this.uibtnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(102)))));
            this.uibtnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(102)))));
            this.uibtnDelete.BorderRadius = 10;
            this.uibtnDelete.BorderSize = 0;
            this.uibtnDelete.FlatAppearance.BorderSize = 0;
            this.uibtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uibtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uibtnDelete.ForeColor = System.Drawing.Color.White;
            this.uibtnDelete.Location = new System.Drawing.Point(1042, 609);
            this.uibtnDelete.Name = "uibtnDelete";
            this.uibtnDelete.Size = new System.Drawing.Size(150, 40);
            this.uibtnDelete.TabIndex = 6;
            this.uibtnDelete.Text = "x Delete";
            this.uibtnDelete.TextColor = System.Drawing.Color.White;
            this.uibtnDelete.UseVisualStyleBackColor = false;
            this.uibtnDelete.Click += new System.EventHandler(this.uibtnDelete_Click);
            // 
            // txtSearchStudents
            // 
            this.txtSearchStudents.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchStudents.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.txtSearchStudents.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.txtSearchStudents.BorderRadius = 10;
            this.txtSearchStudents.BorderSize = 2;
            this.txtSearchStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.txtSearchStudents.Location = new System.Drawing.Point(321, 106);
            this.txtSearchStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchStudents.Multiline = false;
            this.txtSearchStudents.Name = "txtSearchStudents";
            this.txtSearchStudents.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearchStudents.PasswordChar = false;
            this.txtSearchStudents.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchStudents.PlaceholderText = "Search Students Name";
            this.txtSearchStudents.ReadOnly = false;
            this.txtSearchStudents.Size = new System.Drawing.Size(855, 32);
            this.txtSearchStudents.TabIndex = 4;
            this.txtSearchStudents.Texts = "";
            this.txtSearchStudents.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(262, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Student Name *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(672, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Class *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(262, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Age *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label4.Location = new System.Drawing.Point(673, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email *";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::thuvienonline.Properties.Resources.Close;
            this.pictureBox2.Location = new System.Drawing.Point(1169, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1239, 661);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewStudent";
            this.Text = "ViewStudent";
            this.Load += new System.EventHandler(this.ViewStudent_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewStudent_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private owf.TextBox txtSearchStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private owf.UIButton uibtnDelete;
        private owf.UIButton uibtnUpdate;
        private owf.TextBox txtStudentName;
        private owf.TextBox txtAge;
        private owf.TextBox txtClass;
        private owf.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}