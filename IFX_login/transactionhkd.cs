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
using static IFX_login.Existingcstmr;

namespace IFX_login
{
    public partial class transactionhkd : UserControl
    {
        public static transactionhkd inst {  get; set; }

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;
        double addamnt;
        double deductamnt;
        double amountt;
        double newcstmrmoney;
        bool checkpoint = true;

        public transactionhkd()
        {
            InitializeComponent();
            inst = this;
        }

        double convertedAmount;

        string fromcrnt;
        string tocrnt;
        bool currencyswap = false;
        string frm = "HKD";
        string to = "PHP";
        
        newcustomer nwc = new newcustomer();


        private void transactionhkd_Load(object sender, EventArgs e)
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
            var yn = MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo);
            if (yn == DialogResult.Yes)
            {



                if (currencyswap == false)
                {
                    fromcrnt = "PHP";
                    tocrnt = "HKD";

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

                    double usdrate = GetExchangeRate(frm, to);

                    double rate = usdrate;
                    rate = Convert.ToInt32(rate);
                    double markup = rate * 0.01;
                    double tax = rate * 0.02;
                    /*rate -= .5;*/
                    rate += markup;
                    rate += tax;
                    rate = Convert.ToInt32(rate);

                    int cstmrnum = Convert.ToInt32(amount_tb.Text);
                    int cstmrmoney = cstmrnum;
                    double remain = cstmrmoney / rate;
                    remain -= .5;
                    remain = Convert.ToInt32(remain);
                    double newcstmrmoney = remain * rate;
                    /*newcstmrmoney -= .5;*/
                    newcstmrmoney = Convert.ToInt32(newcstmrmoney);
                    double final = newcstmrmoney / rate;
                    double sukli = cstmrmoney - newcstmrmoney;


                    double extramoney = rate - usdrate;
                    double profit = 0;
                    profit = markup + tax;
                    profit += extramoney;
                    profit *= final;
                    convertedAmount = final;
                    double sales = 0;
                    sales += profit;
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
                    amount = Convert.ToInt32(newcstmrmoney);
                    amountt = Convert.ToInt32(newcstmrmoney);

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
                        cmd.Parameters.AddWithValue("@frmprc", newcstmrmoney);
                        cmd.Parameters.AddWithValue("@tprc", final);
                        cmd.Parameters.AddWithValue("@crntrte", rate);
                        cmd.Parameters.AddWithValue("@dt", formatteddate);
                        cmd.Parameters.AddWithValue("@time", formattedtime);
                        cmd.Parameters.AddWithValue("@customerid", cstmrinfo.cstmrid.ToString());
                        cmd.Parameters.AddWithValue("@sales", sales);
                        cmd.Parameters.AddWithValue("@mnth", mnth);
                        cmd.Parameters.AddWithValue("@day", day);



                        toamount_tb.Text = convertedAmount.ToString();

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your change is " + sukli);
                            LCustomerID.Text = cstmrinfo.cstmrid.ToString();
                            LCurrency.Text = fromcrnt + " - " + tocrnt;
                            LName.Text = cstmrinfo.cstmrfname.ToString() + " " + cstmrinfo.cstmrlname.ToString();
                            LRate.Text = rate.ToString();
                            LAmount.Text = amount_tb.Text.ToString();
                            LCAmount.Text = convertedAmount.ToString();
                            LDateTime.Text = formatteddate.ToString() + " " + formattedtime.ToString();
                            Lchange.Text = sukli.ToString();
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
                    fromcrnt = "HKD";
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

                    double rate = exchangeRate;
                    double markup = rate * 0.01;
                    double tax = rate * 0.02;
                    rate -= markup;
                    rate -= tax;
                    rate = Convert.ToInt32(rate);
                    double profit = markup + tax;
                    amountt = Convert.ToDouble(amount_tb.Text);

                    double extramoney = exchangeRate - rate;

                    convertedAmount = amount * rate;
                    double sales = amount * extramoney;

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
                        cmd.Parameters.AddWithValue("@frmprc", amount_tb.Text);
                        cmd.Parameters.AddWithValue("@tprc", convertedAmount.ToString("F0"));
                        cmd.Parameters.AddWithValue("@crntrte", rate);
                        cmd.Parameters.AddWithValue("@dt", formatteddate);
                        cmd.Parameters.AddWithValue("@time", formattedtime);
                        cmd.Parameters.AddWithValue("@customerid", cstmrinfo.cstmrid.ToString());
                        cmd.Parameters.AddWithValue("@sales", sales);
                        cmd.Parameters.AddWithValue("@mnth", mnth);
                        cmd.Parameters.AddWithValue("@day", day);



                        toamount_tb.Text = convertedAmount.ToString();

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            LCustomerID.Text = cstmrinfo.cstmrid.ToString();
                            LCurrency.Text = fromcrnt + " - " + tocrnt;
                            LName.Text = cstmrinfo.cstmrfname.ToString() + " " + cstmrinfo.cstmrlname.ToString();
                            LRate.Text = rate.ToString();
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
            }
            else
            {
                return;
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

        private void arrowup_btn_Click(object sender, EventArgs e)
        {
            if (currencyswap == false)
            {

                hkd.Location = new Point(45, 105);
                ph.Location = new Point(45, 319);
                hkd_lbl.Location = new Point(162, 141);
                ph_lbl.Location = new Point(162, 343);
                currencyswap = true;
            }

            else if (currencyswap == true)
            {
                hkd.Location = new Point(45, 319);
                ph.Location = new Point(45, 105);
                hkd_lbl.Location = new Point(162, 343);
                ph_lbl.Location = new Point(162, 141);
                currencyswap = false;
            }
        }

        private void arrowdown_btn_Click(object sender, EventArgs e)
        {
            if (currencyswap == false)
            {

                hkd.Location = new Point(45, 105);
                ph.Location = new Point(45, 319);
                hkd_lbl.Location = new Point(162, 141);
                ph_lbl.Location = new Point(162, 343);
                currencyswap = true;
            }

            else if (currencyswap == true)
            {
                hkd.Location = new Point(45, 319);
                ph.Location = new Point(45, 105);
                hkd_lbl.Location = new Point(162, 343);
                ph_lbl.Location = new Point(162, 141);
                currencyswap = false;
            }
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
