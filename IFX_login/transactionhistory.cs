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

namespace IFX_login
{
    public partial class transactionhistory : UserControl
    {
        public static transactionhistory inst {  get; set; }

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        OleDbDataReader reader;
        string buwanletter = "0";
        string buwannum = "0";
        string araw = "0";
        string date;
        bool checkpoint = false;
        bool checkpoint2 = false;
        double sum;
        

        void BilanginSales()
        {

            for (int i = 01; i <= 12; i++)  //calcu monthly sales
            {

                conn.Open();
                string salesquery = "SELECT Sales FROM [transaction] WHERE [Month] = @mnth";
                cmd = new OleDbCommand(salesquery, conn);
                cmd.Parameters.AddWithValue("@mnth", i);
                cmd.ExecuteScalar();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    double sales = Convert.ToDouble(reader["Sales"]);
                    sum += sales;
                }
                string updatequery = "UPDATE Buwan SET MonthlySales = @sales WHERE [ID] = @mnth";
                cmd = new OleDbCommand(updatequery, conn);
                cmd.Parameters.AddWithValue("@sales", sum);
                cmd.Parameters.AddWithValue("@mnth", i);
                cmd.ExecuteNonQuery();
                sum = 0;
                conn.Close();
            }

        }

        void LoadTable()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT [Month],MonthlySales FROM Buwan", conn);
            conn.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        public transactionhistory()
        {
            InitializeComponent();
            LoadTable();
            BilanginSales();
            panel1.Hide();
            BackBttn.Hide();
            inst = this;
        }

        private void transactionhistory_Load(object sender, EventArgs e)
        {
            BilanginSales();
            LoadTable();
        }

        private void LDetails_Click(object sender, EventArgs e)
        {
            BackBttn.Show();
            if (checkpoint2 == true)
            {   //sa panel
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    LAmount.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    LCAmount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    LRate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    LDateTime.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    LCustomerID.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    LCurrency.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " - " + dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    LTransactionNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    LSales.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    conn.Open();
                    string getquery = "SELECT * FROM [cstmr] WHERE CustomerID = ?";
                    cmd = new OleDbCommand(getquery, conn);
                    cmd.Parameters.AddWithValue("?", LCustomerID.Text);
                    cmd.ExecuteScalar();
                    reader = cmd.ExecuteReader();
                    {
                        if (reader.Read())
                        {
                            LName.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                            LAdd.Text = reader["Address"].ToString();
                            LGender.Text = reader["Gender"].ToString();
                            LCitizen.Text = reader["Citizenship"].ToString();
                            LSource.Text = reader["SOI"].ToString();
                            LTypeID.Text = reader["TOI"].ToString();
                            LIDNo.Text = reader["IDnum"].ToString();
                            LNumber.Text = reader["ContactNumber"].ToString();
                            conn.Close();
                        }
                    }
                    panel1.Show();
                }
                else
                {
                    MessageBox.Show("No row is selected.");
                }
            }


            if (buwannum == "0")
            {   //get value pag wala pa value un month
                buwanletter = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                conn.Open();
                string getquery = "SELECT ID FROM Buwan WHERE [Month] = ?";
                cmd = new OleDbCommand(getquery, conn);
                cmd.Parameters.AddWithValue("?", buwanletter);
                cmd.ExecuteScalar();
                reader = cmd.ExecuteReader();
                {
                    if (reader.Read())
                    {
                        buwannum = reader["ID"].ToString();
                        conn.Close();
                    }
                }
                for (int i = 01; i <= 31; i++)  //calcu daily sales
                {

                    conn.Open();
                    string salesquery = "SELECT Sales FROM [transaction] WHERE [Day] = ? AND [Month] = ?";
                    cmd = new OleDbCommand(salesquery, conn);
                    cmd.Parameters.AddWithValue("?", i);
                    cmd.Parameters.AddWithValue("?", buwannum);
                    cmd.ExecuteScalar();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        double sales = Convert.ToDouble(reader["Sales"]);
                        sum += sales;
                    }
                    string updatequery = "UPDATE Araw SET DailySales = @sales WHERE [Day] = @day";
                    cmd = new OleDbCommand(updatequery, conn);
                    cmd.Parameters.AddWithValue("@sales", sum);
                    cmd.Parameters.AddWithValue("@day", i);
                    cmd.ExecuteNonQuery();
                    sum = 0;
                    conn.Close();
                }
            }
            else if (buwannum != "0" && checkpoint2 == false)
            {   //get ng value ng day pag may laman na un sa month 
                if (checkpoint == true)
                {
                    araw = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                }
            }
            if (araw != "0" && checkpoint2 == false)
            {   // dito na pag may value na lahat
                Lday.Text = araw;
                //filter ng table to show specific date 
                
                string query = "SELECT TransactionID, FromCurrency, ToCurrency, FromPrice, ToPrice, CurrentRate, DT, Time, CustomerID, Sales FROM [transaction] WHERE [Month] = ? AND [Day] = ?";
                conn.Open();
                cmd = new OleDbCommand(query, conn);
                
                cmd.Parameters.AddWithValue("?", buwannum);
                cmd.Parameters.AddWithValue("?", araw);

                adapter = new OleDbDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                checkpoint2 = true;
                conn.Close();
            }
            else if (buwannum != "0" && checkpoint2 == false)
            {

                // palit laman ng table
                checkpoint = true;
                adapter = new OleDbDataAdapter("SELECT Day, DailySales FROM Araw", conn);
                conn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                dataGridView1.Columns.Remove("Month");
                dataGridView1.Columns.Remove("MonthlySales");
                Lmonth.Text = buwanletter;
                for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
                {
                    // Skip the new row
                    if (dataGridView1.Rows[i].IsNewRow)
                        continue;

                    bool isEmpty = true;
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        {
                            isEmpty = false;
                            break;
                        }
                    }
                    if (isEmpty)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }

            }
        }

        private void Close_bttn_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            if (Lday.Text != "_____")
            {
                adapter = new OleDbDataAdapter("SELECT Day, DailySales FROM Araw", conn);
                conn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                dataGridView1.Columns.Remove("TransactionID");
                dataGridView1.Columns.Remove("FromCurrency");
                dataGridView1.Columns.Remove("ToCurrency");
                dataGridView1.Columns.Remove("FromPrice");
                dataGridView1.Columns.Remove("ToPrice");
                dataGridView1.Columns.Remove("CurrentRate");
                dataGridView1.Columns.Remove("DT");
                dataGridView1.Columns.Remove("Time");
                dataGridView1.Columns.Remove("CustomerID");
                dataGridView1.Columns.Remove("Sales");
                Lday.Text = "_____";
                for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
                {
                    // Skip the new row
                    if (dataGridView1.Rows[i].IsNewRow)
                        continue;

                    bool isEmpty = true;
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        {
                            isEmpty = false;
                            break;
                        }
                    }
                    if (isEmpty)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
                checkpoint2 = false;
                araw = "0";
            }
            else if (Lday.Text == "_____")
            {
                LoadTable();
                Lmonth.Text = "__________";
                BackBttn.Hide();
                checkpoint = false;
                buwannum = "0";
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            BilanginSales();
            LoadTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
