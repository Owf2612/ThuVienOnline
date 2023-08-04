using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace thuvienonline
{
    public partial class IssueBook : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);

        public IssueBook()
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

        private void IssueBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=Owf\\SQLSERVER2022;Initial Catalog=UniversityDB;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd = new SqlCommand("select bName from NewBook", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    uitxtBookName.Texts = Sdr.GetString(i);
                }
            }
            Sdr.Close();
            con.Close();
        }

        int count;
        private void uibtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchID.Texts))
            {
                ClearStudentDetails();
                return;
            }

            int studentId;
            if (!int.TryParse(txtSearchID.Texts, out studentId))
            {
                MessageBox.Show("Invalid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearStudentDetails();
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=Owf\\SQLSERVER2022;Initial Catalog=UniversityDB;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM NewStudent WHERE id = @sid", con))
                {
                    cmd.Parameters.AddWithValue("@sid", studentId);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            int bookCount;
                            using (SqlCommand countCmd = new SqlCommand("SELECT COUNT(id) FROM IssueBook WHERE id = @sid AND BookReturn_date IS NULL", con))
                            {
                                countCmd.Parameters.AddWithValue("@sid", studentId);
                                bookCount = Convert.ToInt32(countCmd.ExecuteScalar());
                            }

                            count = bookCount;

                            DataRow studentRow = ds.Tables[0].Rows[0];
                            uitxtName.Texts = studentRow["Name"].ToString();
                            uitxtAge.Texts = studentRow["Age"].ToString();
                            uitxtClass.Texts = studentRow["Class"].ToString();
                            uitxtEmail.Texts = studentRow["Email"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Student ID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearStudentDetails();
                        }
                    }
                }
            }
        }

        private void ClearStudentDetails()
        {
            uitxtName.Texts = "";
            uitxtAge.Texts = "";
            uitxtClass.Texts = "";
            uitxtEmail.Texts = "";
            uitxtBookName.Texts = "";
            uitxtIssueDate.Texts = "";
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uitxtName.Texts))
            {
                MessageBox.Show("Enter Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (count > 1)
            {
                MessageBox.Show("Maximum number of Books has been Issued", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string studentName = uitxtName.Texts;
            Int64 studentAge = Int64.Parse(uitxtAge.Texts);
            string studentClass = uitxtClass.Texts;
            string studentEmail = uitxtEmail.Texts;
            string bookName = uitxtBookName.Texts;
            string bookIssueDate = uitxtIssueDate.Texts;

            string sid = txtSearchID.Texts;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=Owf\\SQLSERVER2022;Initial Catalog=UniversityDB;Integrated Security=True";

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = con;
                con.Open();

                // Check if the book is available and has enough quantity
                cmd.CommandText = "SELECT bQuantity FROM NewBook WHERE bName = @BookNameCheck";
                cmd.Parameters.AddWithValue("@BookNameCheck", bookName);
                int availableQuantity = Convert.ToInt32(cmd.ExecuteScalar());

                if (availableQuantity <= 0)
                {
                    MessageBox.Show("Book not available or not enough quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    return;
                }

                // Update the book quantity
                cmd.CommandText = "UPDATE NewBook SET bQuantity = bQuantity - 1 WHERE bName = @BookNameUpdate";
                cmd.Parameters.AddWithValue("@BookNameUpdate", bookName);
                cmd.ExecuteNonQuery();

                // Insert the book issue record
                cmd.CommandText = "INSERT INTO IssueBook (Name, Age, Class, Email, BookName, BookIssue_date, BookReturn_date) VALUES (@Name, @Age, @Class, @Email, @BookNameInsert, @BookIssue_date, NULL)";
                cmd.Parameters.AddWithValue("@Name", studentName);
                cmd.Parameters.AddWithValue("@Age", studentAge);
                cmd.Parameters.AddWithValue("@Class", studentClass);
                cmd.Parameters.AddWithValue("@Email", studentEmail);
                cmd.Parameters.AddWithValue("@BookNameInsert", bookName);
                cmd.Parameters.AddWithValue("@BookIssue_date", bookIssueDate);
                cmd.ExecuteNonQuery();

                con.Close();
            }

            MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void IssueBook_MouseDown(object sender, MouseEventArgs e)
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
