namespace thuvienonline
{
    partial class ReturnBook
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
            this.uibtnReturn = new thuvienonline.owf.UIButton();
            this.uitxtReturnDate = new thuvienonline.owf.TextBox();
            this.uitxtIssueDate = new thuvienonline.owf.TextBox();
            this.uitxtBookName = new thuvienonline.owf.TextBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new thuvienonline.owf.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BackgroundImage = global::thuvienonline.Properties.Resources.ReturnBook;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.uibtnReturn);
            this.panel1.Controls.Add(this.uitxtReturnDate);
            this.panel1.Controls.Add(this.uitxtIssueDate);
            this.panel1.Controls.Add(this.uitxtBookName);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 586);
            this.panel1.TabIndex = 0;
            // 
            // uibtnReturn
            // 
            this.uibtnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(102)))));
            this.uibtnReturn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(102)))));
            this.uibtnReturn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(102)))));
            this.uibtnReturn.BorderRadius = 10;
            this.uibtnReturn.BorderSize = 0;
            this.uibtnReturn.FlatAppearance.BorderSize = 0;
            this.uibtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uibtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.uibtnReturn.ForeColor = System.Drawing.Color.White;
            this.uibtnReturn.Location = new System.Drawing.Point(1047, 519);
            this.uibtnReturn.Name = "uibtnReturn";
            this.uibtnReturn.Size = new System.Drawing.Size(150, 40);
            this.uibtnReturn.TabIndex = 14;
            this.uibtnReturn.Text = "↺ Return";
            this.uibtnReturn.TextColor = System.Drawing.Color.White;
            this.uibtnReturn.UseVisualStyleBackColor = false;
            this.uibtnReturn.Click += new System.EventHandler(this.uibtnReturn_Click);
            // 
            // uitxtReturnDate
            // 
            this.uitxtReturnDate.BackColor = System.Drawing.SystemColors.Window;
            this.uitxtReturnDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.uitxtReturnDate.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.uitxtReturnDate.BorderRadius = 5;
            this.uitxtReturnDate.BorderSize = 2;
            this.uitxtReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uitxtReturnDate.ForeColor = System.Drawing.Color.DimGray;
            this.uitxtReturnDate.Location = new System.Drawing.Point(844, 415);
            this.uitxtReturnDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uitxtReturnDate.Multiline = false;
            this.uitxtReturnDate.Name = "uitxtReturnDate";
            this.uitxtReturnDate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.uitxtReturnDate.PasswordChar = false;
            this.uitxtReturnDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.uitxtReturnDate.PlaceholderText = "Enter Book Return Date ...";
            this.uitxtReturnDate.ReadOnly = false;
            this.uitxtReturnDate.Size = new System.Drawing.Size(313, 35);
            this.uitxtReturnDate.TabIndex = 13;
            this.uitxtReturnDate.Texts = "";
            this.uitxtReturnDate.UnderlinedStyle = false;
            // 
            // uitxtIssueDate
            // 
            this.uitxtIssueDate.BackColor = System.Drawing.SystemColors.Window;
            this.uitxtIssueDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.uitxtIssueDate.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.uitxtIssueDate.BorderRadius = 5;
            this.uitxtIssueDate.BorderSize = 2;
            this.uitxtIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uitxtIssueDate.ForeColor = System.Drawing.Color.DimGray;
            this.uitxtIssueDate.Location = new System.Drawing.Point(468, 415);
            this.uitxtIssueDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uitxtIssueDate.Multiline = false;
            this.uitxtIssueDate.Name = "uitxtIssueDate";
            this.uitxtIssueDate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.uitxtIssueDate.PasswordChar = false;
            this.uitxtIssueDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.uitxtIssueDate.PlaceholderText = "Enter Issue Date ...";
            this.uitxtIssueDate.ReadOnly = false;
            this.uitxtIssueDate.Size = new System.Drawing.Size(313, 35);
            this.uitxtIssueDate.TabIndex = 12;
            this.uitxtIssueDate.Texts = "";
            this.uitxtIssueDate.UnderlinedStyle = false;
            // 
            // uitxtBookName
            // 
            this.uitxtBookName.BackColor = System.Drawing.SystemColors.Window;
            this.uitxtBookName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.uitxtBookName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.uitxtBookName.BorderRadius = 5;
            this.uitxtBookName.BorderSize = 2;
            this.uitxtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uitxtBookName.ForeColor = System.Drawing.Color.DimGray;
            this.uitxtBookName.Location = new System.Drawing.Point(76, 415);
            this.uitxtBookName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uitxtBookName.Multiline = false;
            this.uitxtBookName.Name = "uitxtBookName";
            this.uitxtBookName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.uitxtBookName.PasswordChar = false;
            this.uitxtBookName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.uitxtBookName.PlaceholderText = "Enter Book Name ...";
            this.uitxtBookName.ReadOnly = false;
            this.uitxtBookName.Size = new System.Drawing.Size(313, 35);
            this.uitxtBookName.TabIndex = 11;
            this.uitxtBookName.Texts = "";
            this.uitxtBookName.UnderlinedStyle = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::thuvienonline.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(1111, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 20);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.txtSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.txtSearch.Location = new System.Drawing.Point(236, 111);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Enter Student Name";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.Size = new System.Drawing.Size(940, 32);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 159);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1094, 177);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(72, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Book Name *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(464, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Issue Date *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(840, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Return Date *";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::thuvienonline.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(1173, 66);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 18;
            this.btnClose.TabStop = false;
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseDown);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1239, 586);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReturnBook_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private owf.TextBox txtSearch;
        private System.Windows.Forms.PictureBox btnSearch;
        private owf.TextBox uitxtBookName;
        private owf.UIButton uibtnReturn;
        private owf.TextBox uitxtReturnDate;
        private owf.TextBox uitxtIssueDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnClose;
    }
}