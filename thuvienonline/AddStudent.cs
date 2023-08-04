using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuvienonline
{
    public partial class AddStudent : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);

        public AddStudent()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            txtStudentName.Texts = "";
            txtClass.Texts = "";
            txtAge.Texts = "";
            txtEmail.Texts = "";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UIbtnSave_Click(object sender, EventArgs e)
        {
            String Name = txtStudentName.Texts;
            String Class = txtClass.Texts;
            Int64 Age = Int64.Parse(txtAge.Texts);
            String Email = txtEmail.Texts;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=Owf\\SQLSERVER2022;Initial Catalog=UniversityDB;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into NewStudent (name,class,age,email) values ('" + Name + "','" + Class + "','" + Age + "','" + Email + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data saved!", "SuccessFUll", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
