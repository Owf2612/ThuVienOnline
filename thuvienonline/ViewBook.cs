using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace thuvienonline
{
    public partial class ViewBook : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);

        public ViewBook()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            SearchBooks(null);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=Owf\\SQLSERVER2022;Initial Catalog=UniversityDB;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from NewBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            // Apply DataGridView styling
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Automatically adjust column widths to fit the content and control width
            dataGridView1.BorderStyle = BorderStyle.FixedSingle; // Set the border style to FixedSingle or Fixed3D if you want a 3D effect
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single; // Choose the cell border style you prefer
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(67, 190, 105);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //optional
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Refernce Sans Serif", 12);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 227, 241);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(48, 57, 114);

            // Load data from SQL Server database
            SearchBooks(null);
        }

        int bid;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=Owf\\SQLSERVER2022;Initial Catalog=UniversityDB;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from NewBook where bid= " + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtBookName.Texts = ds.Tables[0].Rows[0][1].ToString();
            txtAuthorName.Texts = ds.Tables[0].Rows[0][2].ToString();
            UItxtPrice.Texts = ds.Tables[0].Rows[0][3].ToString();
            UItxtQuantity.Texts = ds.Tables[0].Rows[0][4].ToString();
        }

        // Create a method to perform book search
        private void SearchBooks(string searchTerm)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=Owf\\SQLSERVER2022;Initial Catalog=UniversityDB;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                cmd.CommandText = "Select * from NewBook where bName LIKE @SearchTerm";
                cmd.Parameters.AddWithValue("@SearchTerm", searchTerm + "%");
            }
            else
            {
                cmd.CommandText = "Select * from NewBook";
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SearchBooks(txtSearchBooks.Texts);
        }

        private void UIbtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Delete. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=Owf\\SQLSERVER2022;Initial Catalog=UniversityDB;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from NewBook where bid =" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                // Refresh the data after deletion
                SearchBooks(txtSearchBooks.Texts);

                // Automatically adjust column widths to fit the content and control width
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void UIbtnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Update. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=Owf\\SQLSERVER2022;Initial Catalog=UniversityDB;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update NewBook set bName = '" + txtBookName.Texts + "', bAuthor = '" + txtAuthorName.Texts + "',bPrice = '" + UItxtPrice.Texts + "',bQuantity = '" + UItxtQuantity.Texts + "' where bid = " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                // Refresh the data after deletion
                SearchBooks(txtSearchBooks.Text);

                // Automatically adjust column widths to fit the content and control width
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            }
        }

        private void ViewBook_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
