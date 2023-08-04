namespace thuvienonline
{
    partial class ViewBook
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.UIbtnDelete = new thuvienonline.owf.UIButton();
            this.UIbtnUpdate = new thuvienonline.owf.UIButton();
            this.UItxtQuantity = new thuvienonline.owf.TextBox();
            this.UItxtPrice = new thuvienonline.owf.TextBox();
            this.txtAuthorName = new thuvienonline.owf.TextBox();
            this.txtBookName = new thuvienonline.owf.TextBox();
            this.txtSearchBooks = new thuvienonline.owf.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 160);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 222);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::thuvienonline.Properties.Resources.Search;
            this.pictureBox2.Location = new System.Drawing.Point(1081, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 22);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::thuvienonline.Properties.Resources.ViewBook;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1239, 661);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(259, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Book Name *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(677, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Author Name *";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label9.Location = new System.Drawing.Point(259, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Price *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label10.Location = new System.Drawing.Point(677, 478);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "Quantity *";
            // 
            // UIbtnDelete
            // 
            this.UIbtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(102)))));
            this.UIbtnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(102)))));
            this.UIbtnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(102)))));
            this.UIbtnDelete.BorderRadius = 10;
            this.UIbtnDelete.BorderSize = 2;
            this.UIbtnDelete.FlatAppearance.BorderSize = 0;
            this.UIbtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UIbtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIbtnDelete.ForeColor = System.Drawing.Color.White;
            this.UIbtnDelete.Location = new System.Drawing.Point(1042, 579);
            this.UIbtnDelete.Name = "UIbtnDelete";
            this.UIbtnDelete.Size = new System.Drawing.Size(150, 40);
            this.UIbtnDelete.TabIndex = 14;
            this.UIbtnDelete.Text = "x Delete";
            this.UIbtnDelete.TextColor = System.Drawing.Color.White;
            this.UIbtnDelete.UseVisualStyleBackColor = false;
            this.UIbtnDelete.Click += new System.EventHandler(this.UIbtnDelete_Click);
            // 
            // UIbtnUpdate
            // 
            this.UIbtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(250)))));
            this.UIbtnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(250)))));
            this.UIbtnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.UIbtnUpdate.BorderRadius = 10;
            this.UIbtnUpdate.BorderSize = 2;
            this.UIbtnUpdate.FlatAppearance.BorderSize = 0;
            this.UIbtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UIbtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIbtnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.UIbtnUpdate.Location = new System.Drawing.Point(876, 579);
            this.UIbtnUpdate.Name = "UIbtnUpdate";
            this.UIbtnUpdate.Size = new System.Drawing.Size(150, 40);
            this.UIbtnUpdate.TabIndex = 13;
            this.UIbtnUpdate.Text = "+ Update";
            this.UIbtnUpdate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.UIbtnUpdate.UseVisualStyleBackColor = false;
            this.UIbtnUpdate.Click += new System.EventHandler(this.UIbtnUpdate_Click);
            // 
            // UItxtQuantity
            // 
            this.UItxtQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.UItxtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.UItxtQuantity.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.UItxtQuantity.BorderRadius = 5;
            this.UItxtQuantity.BorderSize = 2;
            this.UItxtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UItxtQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.UItxtQuantity.Location = new System.Drawing.Point(681, 504);
            this.UItxtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UItxtQuantity.Multiline = false;
            this.UItxtQuantity.Name = "UItxtQuantity";
            this.UItxtQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.UItxtQuantity.PasswordChar = false;
            this.UItxtQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.UItxtQuantity.PlaceholderText = "Enter Quantity ...";
            this.UItxtQuantity.ReadOnly = false;
            this.UItxtQuantity.Size = new System.Drawing.Size(313, 35);
            this.UItxtQuantity.TabIndex = 12;
            this.UItxtQuantity.Texts = "";
            this.UItxtQuantity.UnderlinedStyle = false;
            // 
            // UItxtPrice
            // 
            this.UItxtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.UItxtPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.UItxtPrice.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.UItxtPrice.BorderRadius = 5;
            this.UItxtPrice.BorderSize = 2;
            this.UItxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UItxtPrice.ForeColor = System.Drawing.Color.DimGray;
            this.UItxtPrice.Location = new System.Drawing.Point(263, 504);
            this.UItxtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UItxtPrice.Multiline = false;
            this.UItxtPrice.Name = "UItxtPrice";
            this.UItxtPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.UItxtPrice.PasswordChar = false;
            this.UItxtPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.UItxtPrice.PlaceholderText = "Enter Price ...";
            this.UItxtPrice.ReadOnly = false;
            this.UItxtPrice.Size = new System.Drawing.Size(313, 35);
            this.UItxtPrice.TabIndex = 11;
            this.UItxtPrice.Texts = "";
            this.UItxtPrice.UnderlinedStyle = false;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.BackColor = System.Drawing.SystemColors.Window;
            this.txtAuthorName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.txtAuthorName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.txtAuthorName.BorderRadius = 5;
            this.txtAuthorName.BorderSize = 2;
            this.txtAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.ForeColor = System.Drawing.Color.DimGray;
            this.txtAuthorName.Location = new System.Drawing.Point(681, 428);
            this.txtAuthorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuthorName.Multiline = false;
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAuthorName.PasswordChar = false;
            this.txtAuthorName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAuthorName.PlaceholderText = "Enter Author Name ...";
            this.txtAuthorName.ReadOnly = false;
            this.txtAuthorName.Size = new System.Drawing.Size(313, 35);
            this.txtAuthorName.TabIndex = 10;
            this.txtAuthorName.Texts = "";
            this.txtAuthorName.UnderlinedStyle = false;
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBookName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.txtBookName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.txtBookName.BorderRadius = 5;
            this.txtBookName.BorderSize = 2;
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.ForeColor = System.Drawing.Color.DimGray;
            this.txtBookName.Location = new System.Drawing.Point(263, 428);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBookName.Multiline = false;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBookName.PasswordChar = false;
            this.txtBookName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBookName.PlaceholderText = "Enter Book Name ...";
            this.txtBookName.ReadOnly = false;
            this.txtBookName.Size = new System.Drawing.Size(313, 35);
            this.txtBookName.TabIndex = 9;
            this.txtBookName.Texts = "";
            this.txtBookName.UnderlinedStyle = false;
            // 
            // txtSearchBooks
            // 
            this.txtSearchBooks.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchBooks.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.txtSearchBooks.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.txtSearchBooks.BorderRadius = 10;
            this.txtSearchBooks.BorderSize = 2;
            this.txtSearchBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.txtSearchBooks.Location = new System.Drawing.Point(294, 101);
            this.txtSearchBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchBooks.Multiline = false;
            this.txtSearchBooks.Name = "txtSearchBooks";
            this.txtSearchBooks.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearchBooks.PasswordChar = false;
            this.txtSearchBooks.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchBooks.PlaceholderText = "";
            this.txtSearchBooks.ReadOnly = false;
            this.txtSearchBooks.Size = new System.Drawing.Size(855, 32);
            this.txtSearchBooks.TabIndex = 7;
            this.txtSearchBooks.Texts = "";
            this.txtSearchBooks.UnderlinedStyle = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::thuvienonline.Properties.Resources.Close;
            this.pictureBox3.Location = new System.Drawing.Point(1159, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1239, 661);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UIbtnDelete);
            this.Controls.Add(this.UIbtnUpdate);
            this.Controls.Add(this.UItxtQuantity);
            this.Controls.Add(this.UItxtPrice);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtSearchBooks);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewBook";
            this.Text = "ViewBook";
            this.Load += new System.EventHandler(this.ViewBook_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewBook_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private owf.TextBox txtSearchBooks;
        private System.Windows.Forms.PictureBox pictureBox2;
        private owf.TextBox txtBookName;
        private owf.TextBox txtAuthorName;
        private owf.TextBox UItxtPrice;
        private owf.TextBox UItxtQuantity;
        private owf.UIButton UIbtnUpdate;
        private owf.UIButton UIbtnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}