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
    public partial class Inventory : UserControl
    {
        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataReader reader;
        OleDbDataAdapter adapter;
        DataTable dt;
        double amnt;
        string message;
        void GetUsers()
        {

            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb");

            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT Currency, [Amount] FROM CashInventory", conn);
            conn.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }
        public Inventory()
        {
            InitializeComponent();
            GetUsers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deductbt_Click(object sender, EventArgs e)
        {
            button1.Text = "Deduct";
            Amounttb.Clear();
            
        }

        private void Addbt_Click(object sender, EventArgs e)
        {
            button1.Text = "Add";
            Amounttb.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(Amounttb.Text, out int number);
            conn.Open();
            string getquery = "SELECT [Amount] FROM CashInventory WHERE Currency = ?";
            cmd = new OleDbCommand(getquery, conn);
            cmd.Parameters.AddWithValue("?", Currencytb.Text);
            cmd.ExecuteScalar();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                amnt = Convert.ToDouble(reader["Amount"]);
            }
            if (button1.Text == "Add")
            {
                message = "Added";
                amnt += number;
            }
            else if (button1.Text == "Deduct")
            {
                message = "Deducted";
                amnt -= number;
            }
            string query = "UPDATE CashInventory SET [Amount] = ? WHERE Currency = ?";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("?", amnt);
            cmd.Parameters.AddWithValue("?", Currencytb.Text);
            cmd.ExecuteNonQuery();
            Amounttb.Clear();
            
            MessageBox.Show(message+" successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetUsers();
        }

        private void refreshbt_Click(object sender, EventArgs e)
        {
            GetUsers();
        }
    }
}
