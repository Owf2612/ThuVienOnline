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
    public partial class BooksDetail : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);

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

        public BooksDetail()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
        }

        private void BooksDetail_Load(object sender, EventArgs e)
        {
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

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Automatically adjust column widths to fit the content and control width
            dataGridView2.BorderStyle = BorderStyle.FixedSingle; // Set the border style to FixedSingle or Fixed3D if you want a 3D effect
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.Single; // Choose the cell border style you prefer
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(67, 190, 105);
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //optional
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("MS Refernce Sans Serif", 12);
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 227, 241);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(48, 57, 114);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=Owf\\SQLSERVER2022;Initial Catalog=UniversityDB;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT id, Name, Age, Class, BookName, BookIssue_date FROM IssueBook WHERE BookReturn_date IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            cmd.CommandText = "SELECT id, Name, Age, Class, BookName, BookIssue_date, BookReturn_date FROM IssueBook WHERE BookReturn_date IS NOT NULL";
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);

            dataGridView2.DataSource = ds2.Tables[0];
        }

        private void BooksDetail_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
