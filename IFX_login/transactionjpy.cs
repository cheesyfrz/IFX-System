using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using static IFX_login.Existingcstmr;
using static IFX_login.flagbutton;

namespace IFX_login
{
    public partial class transactionjpy : UserControl
    {
        public static transactionjpy inst {  get; set; }

        



        public transactionjpy()
        {
            InitializeComponent();
            inst = this;
        }

        double convertedAmount;

        string fromcrnt;
        string tocrnt;
        bool currencyswap = false;
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;
        double addamnt;
        double deductamnt;
        double amount;
        bool checkpoint = true;
        double amountt;
        

        newcustomer nwc = new newcustomer();

        private void transactionjpy_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            cstmrid_lbl.Text = "Customer ID: " + cstmrinfo.cstmrid.ToString();
            fname_tb.Text = cstmrinfo.cstmrfname.ToString();
            lname_tb.Text = cstmrinfo.cstmrlname.ToString();
            address_tb.Text = cstmrinfo.cstmraddrs.ToString();
            gender_tb.Text = cstmrinfo.cstmrgndr.ToString();
            ctznship_tb.Text = cstmrinfo.cstmrctznshp.ToString();
            soi_tb.Text = cstmrinfo.cstmrsoi.ToString();
            idtype_tb.Text = cstmrinfo.cstmrtypeofid.ToString();
            idnum_tb.Text = cstmrinfo.cstmridnum.ToString();
            cntctnum_tb.Text = cstmrinfo.contactnum.ToString();
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

        private void cnvrt_btn_Click(object sender, EventArgs e)
        {

            var yn = MessageBox.Show("Are you sure you want to contine?", "Warning", MessageBoxButtons.YesNo);
            if (yn == DialogResult.Yes)
            {


                if (currencyswap == false)
                {
                    fromcrnt = "PHP";
                    tocrnt = "JPY";

                    double amount;
                    if (!double.TryParse(amount_tb.Text, out amount))
                    {
                        MessageBox.Show("Please enter a valid amount ", "Error", MessageBoxButtons.OK);
                        return;
                    }

                    double exchangeRate;
                    try
                    {
                        exchangeRate = GetExchangeRate(fromcrnt, tocrnt);

                    }
                    catch
                    {
                        MessageBox.Show("An error occured while retrieving the exchange rate! ", "Error - API error", MessageBoxButtons.OK);
                        return;
                    }


                    /*convertedAmount += 0.30;
                    convertedAmount += 0.20;*/

                    double markup = exchangeRate * 0.01;
                    double tax = exchangeRate * 0.02;
                    double profit = markup + tax;
                    exchangeRate += profit;

                    double convertedAmount = amount * exchangeRate;
                    double sales = amount * profit;
                    convertedAmount = amount * exchangeRate;
                    toamount_tb.Text = convertedAmount.ToString();
                    string formattedtime = DateTime.Now.ToString("HH:mm:ss");
                    string formatteddate = DateTime.Now.ToString("yyyy-MM-dd");
                    string mnth = DateTime.Now.ToString("MM");
                    string day = DateTime.Now.ToString("dd");
                    switch (mnth)
                    {
                        case "01":
                            mnth = "1";
                            break;
                        case "02":
                            mnth = "2";
                            break;
                        case "03":
                            mnth = "3";
                            break;
                        case "04":
                            mnth = "4";
                            break;
                        case "05":
                            mnth = "5";
                            break;
                        case "06":
                            mnth = "6";
                            break;
                        case "07":
                            mnth = "7";
                            break;
                        case "08":
                            mnth = "8";
                            break;
                        case "09":
                            mnth = "9";
                            break;
                        default:
                            break;
                    }

                    switch (day)
                    {
                        case "01":
                            day = "1";
                            break;
                        case "02":
                            day = "2";
                            break;
                        case "03":
                            day = "3";
                            break;
                        case "04":
                            day = "4";
                            break;
                        case "05":
                            day = "5";
                            break;
                        case "06":
                            day = "6";
                            break;
                        case "07":
                            day = "7";
                            break;
                        case "08":
                            day = "8";
                            break;
                        case "09":
                            day = "9";
                            break;
                        default:
                            break;
                    }
                    amountt = Convert.ToDouble(amount_tb.Text);

                    conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb");
                    conn.Open();
                    string checkquery = "SELECT [Amount] FROM CashInventory WHERE Currency = ?"; //to
                    cmd = new OleDbCommand(checkquery, conn);
                    cmd.Parameters.AddWithValue("?", tocrnt);
                    cmd.ExecuteScalar();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        deductamnt = Convert.ToDouble(reader["Amount"]);
                    }
                    if (deductamnt < convertedAmount)
                    {
                        MessageBox.Show("Not Enough Money", "Warning", MessageBoxButtons.OK);
                        checkpoint = false;
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        string salesquery = "INSERT INTO [transaction] (FromCurrency, ToCurrency, FromPrice, ToPrice, CurrentRate, DT, [Time], CustomerID, Sales, [Month], [Day])  VALUES ( @frmcrncy , @tcrcny , @frmprc , @tprc , @crntrte , @dt, @time, @customerid, @sales,@mnth, @day)";


                        cmd = new OleDbCommand(salesquery, conn);
                        cmd.Parameters.AddWithValue("@frmcrncy", fromcrnt);
                        cmd.Parameters.AddWithValue("@tcrcny", tocrnt);
                        cmd.Parameters.AddWithValue("@frmprc", amount.ToString());
                        cmd.Parameters.AddWithValue("@tprc", convertedAmount.ToString("F0"));
                        cmd.Parameters.AddWithValue("@crntrte", exchangeRate.ToString());
                        cmd.Parameters.AddWithValue("@dt", formatteddate);
                        cmd.Parameters.AddWithValue("@time", formattedtime);
                        cmd.Parameters.AddWithValue("@customerid", cstmrinfo.cstmrid.ToString());
                        cmd.Parameters.AddWithValue("@sales", sales);
                        cmd.Parameters.AddWithValue("@mnth", mnth);
                        cmd.Parameters.AddWithValue("@day", day);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            LCustomerID.Text = cstmrinfo.cstmrid.ToString();
                            LCurrency.Text = fromcrnt + " - " + tocrnt;
                            LName.Text = cstmrinfo.cstmrfname.ToString() + " " + cstmrinfo.cstmrlname.ToString();
                            LRate.Text = exchangeRate.ToString();
                            LAmount.Text = amount_tb.Text.ToString();
                            LCAmount.Text = convertedAmount.ToString();
                            LDateTime.Text = formatteddate.ToString() + " " + formattedtime.ToString();

                            panel1.Show();

                        }

                        catch (OleDbException ex)
                        {
                            MessageBox.Show($"An error occured: {ex.Message}");

                        }

                        finally { conn.Close(); }



                    }
                }


                else
                {
                    fromcrnt = "JPY";
                    tocrnt = "PHP";

                    double amount;
                    if (!double.TryParse(amount_tb.Text, out amount))
                    {
                        MessageBox.Show("Please enter a valid amount ", "Error", MessageBoxButtons.OK);
                        return;
                    }

                    double exchangeRate;
                    try
                    {
                        exchangeRate = GetExchangeRate(fromcrnt, tocrnt);

                    }
                    catch
                    {
                        MessageBox.Show("An error occured while retrieving the exchange rate! ", "Error - API error", MessageBoxButtons.OK);
                        return;
                    }



                    double markup = exchangeRate * 0.01;
                    double tax = exchangeRate * 0.02;
                    double profit = markup + tax;
                    exchangeRate += profit;


                    double sales = amount * profit;
                    convertedAmount = amount * exchangeRate;
                    toamount_tb.Text = convertedAmount.ToString();
                    string formattedtime = DateTime.Now.ToString("HH:mm:ss");
                    string formatteddate = DateTime.Now.ToString("yyyy-MM-dd");
                    string mnth = DateTime.Now.ToString("MM");
                    string day = DateTime.Now.ToString("dd");
                    switch (mnth)
                    {
                        case "01":
                            mnth = "1";
                            break;
                        case "02":
                            mnth = "2";
                            break;
                        case "03":
                            mnth = "3";
                            break;
                        case "04":
                            mnth = "4";
                            break;
                        case "05":
                            mnth = "5";
                            break;
                        case "06":
                            mnth = "6";
                            break;
                        case "07":
                            mnth = "7";
                            break;
                        case "08":
                            mnth = "8";
                            break;
                        case "09":
                            mnth = "9";
                            break;
                        default:
                            break;
                    }

                    switch (day)
                    {
                        case "01":
                            day = "1";
                            break;
                        case "02":
                            day = "2";
                            break;
                        case "03":
                            day = "3";
                            break;
                        case "04":
                            day = "4";
                            break;
                        case "05":
                            day = "5";
                            break;
                        case "06":
                            day = "6";
                            break;
                        case "07":
                            day = "7";
                            break;
                        case "08":
                            day = "8";
                            break;
                        case "09":
                            day = "9";
                            break;
                        default:
                            break;
                    }
                    amountt = Convert.ToDouble(amount_tb.Text);

                    conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb");
                    conn.Open();
                    string checkquery = "SELECT [Amount] FROM CashInventory WHERE Currency = ?"; //to
                    cmd = new OleDbCommand(checkquery, conn);
                    cmd.Parameters.AddWithValue("?", tocrnt);
                    cmd.ExecuteScalar();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        deductamnt = Convert.ToDouble(reader["Amount"]);
                    }
                    if (deductamnt < convertedAmount)
                    {
                        MessageBox.Show("Not Enough Money", "Warning", MessageBoxButtons.OK);
                        checkpoint = false;
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        string salesquery = "INSERT INTO [transaction] (FromCurrency, ToCurrency, FromPrice, ToPrice, CurrentRate, DT, [Time], CustomerID, Sales, [Month], [Day])  VALUES ( @frmcrncy , @tcrcny , @frmprc , @tprc , @crntrte , @dt, @time, @customerid, @sales,@mnth, @day)";


                        cmd = new OleDbCommand(salesquery, conn);
                        cmd.Parameters.AddWithValue("@frmcrncy", fromcrnt);
                        cmd.Parameters.AddWithValue("@tcrcny", tocrnt);
                        cmd.Parameters.AddWithValue("@frmprc", amount.ToString());
                        cmd.Parameters.AddWithValue("@tprc", convertedAmount.ToString("F0"));
                        cmd.Parameters.AddWithValue("@crntrte", exchangeRate.ToString());
                        cmd.Parameters.AddWithValue("@dt", formatteddate);
                        cmd.Parameters.AddWithValue("@time", formattedtime);
                        cmd.Parameters.AddWithValue("@customerid", cstmrinfo.cstmrid.ToString());
                        cmd.Parameters.AddWithValue("@sales", sales);
                        cmd.Parameters.AddWithValue("@mnth", mnth);
                        cmd.Parameters.AddWithValue("@day", day);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            LCustomerID.Text = cstmrinfo.cstmrid.ToString();
                            LCurrency.Text = fromcrnt + " - " + tocrnt;
                            LName.Text = cstmrinfo.cstmrfname.ToString() + " " + cstmrinfo.cstmrlname.ToString();
                            LRate.Text = exchangeRate.ToString();
                            LAmount.Text = amount_tb.Text.ToString();
                            LCAmount.Text = convertedAmount.ToString();
                            LDateTime.Text = formatteddate.ToString() + " " + formattedtime.ToString();

                            panel1.Show();
                        }

                        catch (OleDbException ex)
                        {
                            MessageBox.Show($"An error occured: {ex.Message}");


                        }
                    }

                }
                if (checkpoint == true)
                {
                    conn.Open();            // update cash inventory
                    string getquery = "SELECT [Amount] FROM CashInventory WHERE Currency = ?"; //from
                    cmd = new OleDbCommand(getquery, conn);
                    cmd.Parameters.AddWithValue("?", fromcrnt);
                    cmd.ExecuteScalar();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        addamnt = Convert.ToDouble(reader["Amount"]);
                    }

                    addamnt += amountt;

                    string query = "UPDATE CashInventory SET [Amount] = ? WHERE Currency = ?";
                    cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", addamnt);
                    cmd.Parameters.AddWithValue("?", fromcrnt);
                    cmd.ExecuteNonQuery();
                    getquery = "SELECT [Amount] FROM CashInventory WHERE Currency = ?"; //to
                    cmd = new OleDbCommand(getquery, conn);
                    cmd.Parameters.AddWithValue("?", tocrnt);
                    cmd.ExecuteScalar();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        deductamnt = Convert.ToDouble(reader["Amount"]);
                    }
                    deductamnt -= convertedAmount;
                    query = "UPDATE CashInventory SET [Amount] = ? WHERE Currency = ?";
                    cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", deductamnt);
                    cmd.Parameters.AddWithValue("?", tocrnt);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            else
            {
                return;
            }
            
        }

        private void arrowup_btn_Click(object sender, EventArgs e)
        {
            if (currencyswap == false)
            {

                jpy.Location = new Point(45, 105);
                ph.Location = new Point(45, 319);
                jpy_lbl.Location = new Point(162, 141);
                ph_lbl.Location = new Point(162, 343);
                currencyswap = true;
            }

            else if (currencyswap == true)
            {
                jpy.Location = new Point(45, 319);
                ph.Location = new Point(45, 105);
                jpy_lbl.Location = new Point(162, 343);
                ph_lbl.Location = new Point(162, 141);
                currencyswap = false;
            }
        }

        private void arrowdown_btn_Click(object sender, EventArgs e)
        {
            if (currencyswap == false)
            {

                jpy.Location = new Point(45, 105);
                ph.Location = new Point(45, 319);
                jpy_lbl.Location = new Point(162, 141);
                ph_lbl.Location = new Point(162, 343);
                currencyswap = true;
            }

            else if (currencyswap == true)
            {
                jpy.Location = new Point(45, 319);
                ph.Location = new Point(45, 105);
                jpy_lbl.Location = new Point(162, 343);
                ph_lbl.Location = new Point(162, 141);
                currencyswap = false;
            }
        }

        private void newcstmr_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void oldcstmr_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void bck_btn_Click(object sender, EventArgs e)
        {
            if (logincreds.UT == "Admin")
            {


                //new customerr
                if (!adminDashB.Instance.PnlContainer.Controls.ContainsKey("flagbutton"))
                {

                    flagbutton flgbtn = new flagbutton();

                    adminDashB.Instance.PnlContainer.Controls.Remove(this);
                    flgbtn.Dock = DockStyle.Right;
                    adminDashB.Instance.PnlContainer.Controls.Add(flgbtn);
                    adminDashB.Instance.PnlContainer.Controls["flagbutton"].BringToFront();



                }

            }

            else if (logincreds.UT == "Teller")
            {
                if (!UserDB.Instance.PnlContainer.Controls.ContainsKey("flagbutton"))
                {

                    flagbutton flgbtn = new flagbutton();

                    UserDB.Instance.PnlContainer.Controls.Remove(this);
                    flgbtn.Dock = DockStyle.Right;
                    UserDB.Instance.PnlContainer.Controls.Add(flgbtn);
                    UserDB.Instance.PnlContainer.Controls["flagbutton"].BringToFront();



                }
            }
        }
        private static Bitmap DrawControlToBitmap(Control control)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Rectangle rect = control.RectangleToScreen(control.ClientRectangle);
            graphics.CopyFromScreen(rect.Location, Point.Empty, control.Size);
            return bitmap;
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bitmap = DrawControlToBitmap(panel1);
                bitmap.Save(@"C:\Users\kenji\Desktop\Portfolio\receipt\test.png");

                /*Bitmap bmp = new Bitmap(panel1.Width * 2, panel1.Height * 2);
                panel1.DrawToBitmap(bmp, panel1.Bounds);
                bmp.Save(@"C:\Users\kenji\Desktop\Portfolio\CodeniNaval\test.png");*/
                MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);

                string employeeemail = cstmrinfo.cstmremail;

                string frmemail; //email
                string title = "Receipt";
                string to = employeeemail;
                string fileloc = "C:\\Users\\kenji\\Desktop\\Portfolio\\receipt\\test.png";
                string apppass; //pass

                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress(frmemail);
                    mail.Subject = title;
                    mail.To.Add(to);
                    System.Net.Mail.Attachment attachment;
                    attachment = new System.Net.Mail.Attachment(fileloc);
                    mail.Attachments.Add(attachment);


                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential(frmemail, apppass);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    MessageBox.Show("Message sent successfully", "email sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            amount_tb.Text = "";
            toamount_tb.Text = "";
        }
    }
}
