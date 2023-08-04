namespace thuvienonline
{
    partial class Addbooks
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantity = new thuvienonline.owf.TextBox();
            this.txtPrice = new thuvienonline.owf.TextBox();
            this.txtAuthorName = new thuvienonline.owf.TextBox();
            this.txtBookName = new thuvienonline.owf.TextBox();
            this.btnUpdate = new thuvienonline.owf.UIButton();
            this.btnUICancel = new thuvienonline.owf.UIButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::thuvienonline.Properties.Resources.AddBooks;
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtAuthorName);
            this.panel1.Controls.Add(this.txtBookName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnUICancel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 601);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::thuvienonline.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(1009, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(177, 365);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Name *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(581, 365);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Book Author Name *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label6.Location = new System.Drawing.Point(177, 456);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Book Price *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(114)))));
            this.label7.Location = new System.Drawing.Point(581, 456);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Book Quantity *";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.txtQuantity.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.txtQuantity.BorderRadius = 5;
            this.txtQuantity.BorderSize = 2;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.txtQuantity.Location = new System.Drawing.Point(585, 482);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQuantity.PasswordChar = false;
            this.txtQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQuantity.PlaceholderText = "Enter Quantity ...";
            this.txtQuantity.ReadOnly = false;
            this.txtQuantity.Size = new System.Drawing.Size(313, 35);
            this.txtQuantity.TabIndex = 9;
            this.txtQuantity.Texts = "";
            this.txtQuantity.UnderlinedStyle = false;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.txtPrice.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.txtPrice.BorderRadius = 5;
            this.txtPrice.BorderSize = 2;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrice.Location = new System.Drawing.Point(181, 482);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrice.PasswordChar = false;
            this.txtPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.PlaceholderText = "Enter Price ...";
            this.txtPrice.ReadOnly = false;
            this.txtPrice.Size = new System.Drawing.Size(313, 35);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.Texts = "";
            this.txtPrice.UnderlinedStyle = false;
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
            this.txtAuthorName.Location = new System.Drawing.Point(585, 391);
            this.txtAuthorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuthorName.Multiline = false;
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAuthorName.PasswordChar = false;
            this.txtAuthorName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAuthorName.PlaceholderText = "Enter Author Name ...";
            this.txtAuthorName.ReadOnly = false;
            this.txtAuthorName.Size = new System.Drawing.Size(313, 35);
            this.txtAuthorName.TabIndex = 7;
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
            this.txtBookName.Location = new System.Drawing.Point(181, 391);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBookName.Multiline = false;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBookName.PasswordChar = false;
            this.txtBookName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBookName.PlaceholderText = "Enter Book Name ...";
            this.txtBookName.ReadOnly = false;
            this.txtBookName.Size = new System.Drawing.Size(313, 35);
            this.txtBookName.TabIndex = 6;
            this.txtBookName.Texts = "";
            this.txtBookName.UnderlinedStyle = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.White;
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.BorderSize = 2;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.btnUpdate.Location = new System.Drawing.Point(829, 116);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "+ Update";
            this.btnUpdate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUICancel
            // 
            this.btnUICancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(102)))));
            this.btnUICancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(102)))));
            this.btnUICancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(102)))));
            this.btnUICancel.BorderRadius = 10;
            this.btnUICancel.BorderSize = 0;
            this.btnUICancel.FlatAppearance.BorderSize = 0;
            this.btnUICancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUICancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUICancel.ForeColor = System.Drawing.Color.White;
            this.btnUICancel.Location = new System.Drawing.Point(925, 116);
            this.btnUICancel.Name = "btnUICancel";
            this.btnUICancel.Size = new System.Drawing.Size(90, 30);
            this.btnUICancel.TabIndex = 4;
            this.btnUICancel.Text = "x Cancel";
            this.btnUICancel.TextColor = System.Drawing.Color.White;
            this.btnUICancel.UseVisualStyleBackColor = false;
            this.btnUICancel.Click += new System.EventHandler(this.btnUICancel_Click);
            // 
            // Addbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 601);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Addbooks";
            this.Text = "Addbooks";
            this.Load += new System.EventHandler(this.Addbooks_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Addbooks_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private owf.UIButton btnUpdate;
        private owf.UIButton btnUICancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private owf.TextBox txtPrice;
        private owf.TextBox txtBookName;
        private owf.TextBox txtQuantity;
        private owf.TextBox txtAuthorName;
    }
}