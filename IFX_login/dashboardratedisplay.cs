using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Data.OleDb;
using ZXing;

namespace IFX_login
{
    public partial class dashboardratedisplay : UserControl
    {
        public dashboardratedisplay()
        {
            InitializeComponent();
            dataGridView1.Hide();
            LoadTable2();
            details_panel.Hide();
        }
        OleDbCommand cmd;
        OleDbConnection conn;
        DataTable dt;
        OleDbDataAdapter adapter;
        OleDbDataReader reader;
        double sum;
        private void lbl_usd_Click(object sender, EventArgs e)
        {

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
        void LoadTable2()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb");
            //filter the table to show only today's transaction
            string query = "SELECT TransactionID, FromCurrency, ToCurrency, FromPrice, ToPrice, CurrentRate, DT, Time, CustomerID, Sales FROM [transaction] WHERE DT = @date";
            conn.Open();
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@date", DateTime.Today.ToString("yyyy-MM-dd"));

            adapter = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            transaction_dgv.DataSource = dt;

            //adding today's total sales
            string salesquery = "SELECT Sales FROM [transaction] WHERE DT = @date";
            cmd = new OleDbCommand(salesquery, conn);
            cmd.Parameters.AddWithValue("@date", DateTime.Today.ToString("yyyy-MM-dd"));
            cmd.ExecuteScalar();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                double sales = Convert.ToDouble(reader["Sales"]);
                sum += sales;
            }
            TodaySale.Text = sum.ToString();
            conn.Close();

        }

        void Getrate()
        {
            string PHPtoCurrency = "PHP";
            double rateamount = 1;

            //usd
            string USDfromCurrency = "USD";
            double usexchangerate = GetExchangeRate(USDfromCurrency, PHPtoCurrency);
            double ustotalrate = rateamount * usexchangerate;
            lbl_usd.Text = "USD: " + ustotalrate.ToString() + " PHP";

            //eur
            string EURfromCurrency = "EUR";
            double eurexchangerate = GetExchangeRate(EURfromCurrency, PHPtoCurrency);
            double eurtotalrate = rateamount * eurexchangerate;
            lbl_eur.Text = "EUR: " + eurtotalrate.ToString() + " PHP";

            //gbp
            string GBPfromCurrency = "GBP";
            double gbpexchangerate = GetExchangeRate(GBPfromCurrency, PHPtoCurrency);
            double gbptotalrate = rateamount * gbpexchangerate;
            lbl_gbp.Text = "GBP: " + gbptotalrate.ToString() + " PHP";

            //jpy
            string JPYfromCurrency = "JPY";
            double jpyexchangerate = GetExchangeRate(JPYfromCurrency, PHPtoCurrency);
            double jpytotalrate = rateamount * jpyexchangerate;
            lbl_jpy.Text = "JPY: " + jpytotalrate.ToString() + " PHP";

            //hkd
            string HKDfromCurrency = "HKD";
            double hkdexchangerate = GetExchangeRate(HKDfromCurrency, PHPtoCurrency);
            double hkdtotalrate = rateamount * hkdexchangerate;
            lbl_hkd.Text = "HKD: " + hkdtotalrate.ToString() + " PHP";


            //aud
            string AUDfromCurrency = "AUD";
            double audexchangerate = GetExchangeRate(AUDfromCurrency, PHPtoCurrency);
            double audtotalrate = rateamount * audexchangerate;
            lbl_aud.Text = "AUD: " + audtotalrate.ToString() + " PHP";

            //sgd
            string SGDfromCurrency = "SGD";
            double sgdexchangerate = GetExchangeRate(SGDfromCurrency, PHPtoCurrency);
            double sgdtotalrate = rateamount * sgdexchangerate;
            lbl_sgd.Text = "SGD: " + sgdtotalrate.ToString() + " PHP";

            //cad
            string CADfromCurrency = "CAD";
            double cadexchangerate = GetExchangeRate(CADfromCurrency, PHPtoCurrency);
            double cadtotalrate = rateamount * cadexchangerate;
            lbl_cad.Text = "CAD: " + cadtotalrate.ToString() + " PHP";
        }

        private void dashboardratedisplay_Load(object sender, EventArgs e)
        {

            LoadTable();
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = "SELECT * FROM Buwan";
                cmd.CommandText = query;

                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chart1.Series["Total Sales"].Points.AddXY(reader["Month"].ToString(), reader["MonthlySales"].ToString());
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally { conn.Close(); }

            Getrate();
            
        }

        private double GetExchangeRate(string fromCurrency, string toCurrency)
        {
            string json;

            using (var client = new WebClient())
            {
                json = client.DownloadString($"https://api.exchangerate-api.com/v4/latest/{fromCurrency}");

            }

            var data = JObject.Parse(json);
            var rate = (double)data["rates"][toCurrency];
            return rate;


        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            LoadTable2();
            

            Getrate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void details_bttn_Click_1(object sender, EventArgs e)
        {
            details_panel.Show();
        }

       
        

        private void details_bttn_Click_2(object sender, EventArgs e)
        {
            details_panel.Show();
        }

        private void details_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_bttn_Click_1(object sender, EventArgs e)
        {
            details_panel.Hide();
        }

        private void transaction_dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            LAmount.Text = transaction_dgv.CurrentRow.Cells[3].Value.ToString();
            LCAmount.Text = transaction_dgv.CurrentRow.Cells[4].Value.ToString();
            LRate.Text = transaction_dgv.CurrentRow.Cells[5].Value.ToString();
            LDateTime.Text = transaction_dgv.CurrentRow.Cells[6].Value.ToString() + " " + transaction_dgv.CurrentRow.Cells[7].Value.ToString();
            LCustomerID.Text = transaction_dgv.CurrentRow.Cells[8].Value.ToString();
            LCurrency.Text = transaction_dgv.CurrentRow.Cells[1].Value.ToString() + " - " + transaction_dgv.CurrentRow.Cells[2].Value.ToString();
            LTransactionNo.Text = transaction_dgv.CurrentRow.Cells[0].Value.ToString();
            LSales.Text = transaction_dgv.CurrentRow.Cells[9].Value.ToString();
            conn.Open();
            string getquery = "SELECT * FROM cstmr WHERE CustomerID = ?";
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
        }
    }
}
