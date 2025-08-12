using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentRecordSystem
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=HPLAPTOP\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Students (Name, Age, Course, EnrollmentDate) VALUES (@name, @age, @course, @date)", con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@age", numericAge.Value);
            cmd.Parameters.AddWithValue("@course", comboCourse.Text);
            cmd.Parameters.AddWithValue("@date", datePicker.Value);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
            MessageBox.Show("Student Added Successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "UPDATE Students SET Name=@name, Age=@age, Course=@course, EnrollmentDate=@date WHERE StudentID=@id", con);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@age", numericAge.Value);
            cmd.Parameters.AddWithValue("@course", comboCourse.Text);
            cmd.Parameters.AddWithValue("@date", datePicker.Value);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
            MessageBox.Show("Student Updated Successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Students WHERE StudentID=@id", con);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
            MessageBox.Show("Student Deleted Successfully!");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                numericAge.Value = Convert.ToDecimal(row.Cells[2].Value);
                comboCourse.Text = row.Cells[3].Value.ToString();
                datePicker.Value = Convert.ToDateTime(row.Cells[4].Value);
            }
        }
    }
}
