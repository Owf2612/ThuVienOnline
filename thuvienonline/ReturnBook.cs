using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace thuvienonline
{
    public partial class ReturnBook : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);

        public ReturnBook()
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

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            txtSearch.Texts = "";

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
        }

        String bName;
        String bDate;
        string bIssueDate;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                bIssueDate = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                bDate = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            uitxtBookName.Texts = bName;
            uitxtReturnDate.Texts = bDate;
            uitxtIssueDate.Texts = bIssueDate;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=Owf\\SQLSERVER2022;Initial Catalog=UniversityDB;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM IssueBook WHERE Name LIKE '%' + @SearchTerm + '%' AND BookReturn_date IS NULL";
            cmd.Parameters.AddWithValue("@SearchTerm", txtSearch.Texts);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid Name or No Book Issue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts == "")
            {
                dataGridView1.DataSource = null;
            }
        }
        private void LoadData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=Owf\\SQLSERVER2022;Initial Catalog=UniversityDB;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM IssueBook WHERE BookReturn_date IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void uibtnReturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=Owf\\SQLSERVER2022;Initial Catalog=UniversityDB;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "UPDATE IssueBook SET BookReturn_date = @ReturnDate WHERE Name = @SearchTerm AND id = @RowId";
            cmd.Parameters.AddWithValue("@ReturnDate", uitxtReturnDate.Texts);
            cmd.Parameters.AddWithValue("@SearchTerm", txtSearch.Texts);
            cmd.Parameters.AddWithValue("@RowId", rowid);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Return Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh the table by calling your data loading method or the method that populates the DataGridView
            LoadData();
        }

        private void ReturnBook_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
