using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFX_login
{
    public partial class EditUser : UserControl
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        OleDbDataReader reader;
        string id;

        void LoadTable()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM admin", conn);
            conn.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            panel2.Hide();
        }

        public EditUser()
        {
            InitializeComponent();
            LoadTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb");
            conn.Open();
            string getquery = "SELECT * FROM admin WHERE ID = ?";
            cmd = new OleDbCommand(getquery, conn);
            cmd.Parameters.AddWithValue("?", id);
            cmd.ExecuteScalar();
            reader = cmd.ExecuteReader();
            {
                if (reader.Read())
                {
                    Enumtb.Text = reader["ID"].ToString();
                    Fnametb.Text = reader["Firstname"].ToString();
                    Lnametb.Text = reader["Lastname"].ToString();
                    Mnametb.Text = reader["Middlename"].ToString();
                    addtb.Text = reader["Address"].ToString();
                    agetb.Text = reader["Age"].ToString();
                    emailtb.Text = reader["email"].ToString();
                    usertb.Text = reader["username"].ToString();
                    passtb.Text = reader["Password"].ToString();
                    bdaytb.Text = reader["Birthday"].ToString();
                    typetb.Text = reader["UserType"].ToString();
                    jobtb.Text = reader["UserType"].ToString();
                    numtb.Text = reader["ContactNo"].ToString();
                    conn.Close();
                }
            }
        }

        private void Editbt_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                panel2.Show();
            }
            else
            {
                MessageBox.Show("No row is selected.");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Infobt_Click(object sender, EventArgs e)
        {

        }

        private void Backbt_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void Savebt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Enumtb.Text) || string.IsNullOrWhiteSpace(Fnametb.Text) ||
                string.IsNullOrWhiteSpace(Lnametb.Text) || string.IsNullOrWhiteSpace(Mnametb.Text) ||
                string.IsNullOrWhiteSpace(addtb.Text) || string.IsNullOrWhiteSpace(agetb.Text) ||
                string.IsNullOrWhiteSpace(emailtb.Text) || string.IsNullOrWhiteSpace(usertb.Text) ||
                string.IsNullOrWhiteSpace(passtb.Text) || string.IsNullOrWhiteSpace(bdaytb.Text) ||
                string.IsNullOrWhiteSpace(typetb.Text) || string.IsNullOrWhiteSpace(jobtb.Text) || string.IsNullOrWhiteSpace(numtb.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb");
            string query = "UPDATE admin SET Firstname = ?, Lastname = ?, Middlename = ?, Address = ?, Age = ?, email = ?, username = ?, Birthday = ?, UserType = ?, ContactNo = ? WHERE ID = ?";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("?", Fnametb.Text);
            cmd.Parameters.AddWithValue("?", Lnametb.Text);
            cmd.Parameters.AddWithValue("?", Mnametb.Text);
            cmd.Parameters.AddWithValue("?", addtb.Text);
            cmd.Parameters.AddWithValue("?", agetb.Text);
            cmd.Parameters.AddWithValue("?", emailtb.Text);
            cmd.Parameters.AddWithValue("?", usertb.Text);
            cmd.Parameters.AddWithValue("?", bdaytb.Text);
            cmd.Parameters.AddWithValue("?", typetb.Text);
            cmd.Parameters.AddWithValue("?", numtb.Text);
            cmd.Parameters.AddWithValue("?", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Updated Successfully");
            conn.Close();
            LoadTable();
            panel2.Hide();
        }

        private void dltbt_Click(object sender, EventArgs e)
        {
            
        }

        private void Deletebt_Click(object sender, EventArgs e)
        {
            var yn = MessageBox.Show("Are you sure you want to DELETE this user?", "Warning", MessageBoxButtons.YesNo);

            if (yn == DialogResult.Yes)
            {
                string query = "DELETE FROM admin WHERE ID = @id";
                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Deleted");
                conn.Close();
                LoadTable();
                panel2.Hide();
            }

            else
            {
                return;
            }
            
        }
    }
}
