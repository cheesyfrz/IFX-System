using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace IFX_login
{
    public partial class Profile : UserControl
    {
        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataReader reader;
        OleDbDataAdapter adapter;
        DataTable dt;
        public static Profile inst { get; set; }
        public Profile()
        {
            InitializeComponent();
            GetUsers();
            dataGridView1.Hide();
            inst = this;
        }

        void GetUsers()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb");
            conn.Open();
            string getquery = "SELECT * FROM Admin WHERE ID = ?";
            cmd = new OleDbCommand(getquery, conn);
            cmd.Parameters.AddWithValue("?", logincreds.ID);
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
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb");

            getquery = "SELECT * FROM Loginfo WHERE ID = ?";
            conn.Open();
            cmd = new OleDbCommand(getquery, conn);
            cmd.Parameters.AddWithValue("?", logincreds.ID);
            adapter = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            dataGridView1.Columns.Remove("LogID");

        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (logincreds.UT == "Admin")
            {


                //new customerr
                if (!adminDashB.Instance.PnlContainer.Controls.ContainsKey("ChangePass"))
                {

                    ChangePass changePass = new ChangePass();

                    adminDashB.Instance.PnlContainer.Controls.Remove(this);
                    changePass.Dock = DockStyle.Right;
                    adminDashB.Instance.PnlContainer.Controls.Add(changePass);
                    adminDashB.Instance.PnlContainer.Controls["ChangePass"].BringToFront();



                }

            }

            else if (logincreds.UT == "Teller")
            {
                if (!UserDB.Instance.PnlContainer.Controls.ContainsKey("ChangePass"))
                {

                    ChangePass changePass = new ChangePass();

                    UserDB.Instance.PnlContainer.Controls.Remove(this);
                    changePass.Dock = DockStyle.Right;
                    UserDB.Instance.PnlContainer.Controls.Add(changePass);
                    UserDB.Instance.PnlContainer.Controls["ChangePass"].BringToFront();



                }
            }
        }

        private void Attendancebt_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
        }

        private void Infobt_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
