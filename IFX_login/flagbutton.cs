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

namespace IFX_login
{
    public partial class flagbutton : UserControl
    {
        public static flagbutton inst { get; set; }

        public static class rates
        {
            public static string usd;
            public static string aud;
            public static string cad;
            public static string eur;
            public static string gbp;
            public static string hkd;
            public static string sgd;
            public static string jpy;
        }

        public flagbutton()
        {
            InitializeComponent();
            inst = this;
        }

        private void flagbutton_Load(object sender, EventArgs e)
        {
            string PHPtoCurrency = "PHP";
            double rateamount = 1;
            /*double tax = 0;
            double cmpny = 0;*/
            double additional = 0;

            //usd
            string USDfromCurrency = "USD";
            double usexchangerate = GetExchangeRate(USDfromCurrency, PHPtoCurrency);
            double ustotalrate = rateamount * usexchangerate;
            ustotalrate += additional;
            usd_lbl.Text = "USD: " + ustotalrate.ToString() + " PHP";

            //eur
            string EURfromCurrency = "EUR";
            double eurexchangerate = GetExchangeRate(EURfromCurrency, PHPtoCurrency);
            double eurtotalrate = rateamount * eurexchangerate;
            eurtotalrate += additional;
            eur_lbl.Text = "EUR: " + eurtotalrate.ToString() + " PHP";

            //gbp
            string GBPfromCurrency = "GBP";
            double gbpexchangerate = GetExchangeRate(GBPfromCurrency, PHPtoCurrency);
            double gbptotalrate = rateamount * gbpexchangerate;
            gbptotalrate += additional;
            gbp_lbl.Text = "GBP: " + gbptotalrate.ToString() + " PHP";

            //jpy
            string JPYfromCurrency = "JPY";
            double jpyexchangerate = GetExchangeRate(JPYfromCurrency, PHPtoCurrency);
            double jpytotalrate = rateamount * jpyexchangerate;
            /*jpytotalrate += additional;*/
            jpy_lbl.Text = "JPY: " + jpytotalrate.ToString() + " PHP";

            //hkd
            string HKDfromCurrency = "HKD";
            double hkdexchangerate = GetExchangeRate(HKDfromCurrency, PHPtoCurrency);
            double hkdtotalrate = rateamount * hkdexchangerate;
            hkdtotalrate += additional; 
            hkd_lbl.Text = "HKD: " + hkdtotalrate.ToString() + " PHP";


            //aud
            string AUDfromCurrency = "AUD";
            double audexchangerate = GetExchangeRate(AUDfromCurrency, PHPtoCurrency);
            double audtotalrate = rateamount * audexchangerate;
            audtotalrate += additional;
            aud_lbl.Text = "AUD: " + audtotalrate.ToString() + " PHP";

            //sgd
            string SGDfromCurrency = "SGD";
            double sgdexchangerate = GetExchangeRate(SGDfromCurrency, PHPtoCurrency);
            double sgdtotalrate = rateamount * sgdexchangerate;
            sgdtotalrate += additional;
            sgd_lbl.Text = "SGD: " + sgdtotalrate.ToString() + " PHP";

            //cad
            string CADfromCurrency = "CAD";
            double cadexchangerate = GetExchangeRate(CADfromCurrency, PHPtoCurrency);
            double cadtotalrate = rateamount * cadexchangerate;
            cadtotalrate += additional;
            cad_lbl.Text = "CAD: " + cadtotalrate.ToString() + " PHP";
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

        private void flagbutton_Load_1(object sender, EventArgs e)
        {
            string PHPtoCurrency = "PHP";
            double rateamount = 1;
            /*double tax = 0.20;
            double cmpny = 0.30;*/
            double additional = 0;

            //usd
            string USDfromCurrency = "USD";
            double usexchangerate = GetExchangeRate(USDfromCurrency, PHPtoCurrency);
            double ustotalrate = rateamount * usexchangerate;
            ustotalrate += additional;
            usd_lbl.Text = "USD: " + ustotalrate.ToString() + " PHP";

            //eur
            string EURfromCurrency = "EUR";
            double eurexchangerate = GetExchangeRate(EURfromCurrency, PHPtoCurrency);
            double eurtotalrate = rateamount * eurexchangerate;
            eurtotalrate += additional;
            eur_lbl.Text = "EUR: " + eurtotalrate.ToString() + " PHP";

            //gbp
            string GBPfromCurrency = "GBP";
            double gbpexchangerate = GetExchangeRate(GBPfromCurrency, PHPtoCurrency);
            double gbptotalrate = rateamount * gbpexchangerate;
            gbptotalrate += additional;
            gbp_lbl.Text = "GBP: " + gbptotalrate.ToString() + " PHP";

            //jpy
            string JPYfromCurrency = "JPY";
            double jpyexchangerate = GetExchangeRate(JPYfromCurrency, PHPtoCurrency);
            double jpytotalrate = rateamount * jpyexchangerate;
            jpytotalrate += additional;
            jpy_lbl.Text = "JPY: " + jpytotalrate.ToString() + " PHP";

            //hkd
            string HKDfromCurrency = "HKD";
            double hkdexchangerate = GetExchangeRate(HKDfromCurrency, PHPtoCurrency);
            double hkdtotalrate = rateamount * hkdexchangerate;
            hkdtotalrate += additional;
            hkd_lbl.Text = "HKD: " + hkdtotalrate.ToString() + " PHP";


            //aud
            string AUDfromCurrency = "AUD";
            double audexchangerate = GetExchangeRate(AUDfromCurrency, PHPtoCurrency);
            double audtotalrate = rateamount * audexchangerate;
            audtotalrate += additional;
            aud_lbl.Text = "AUD: " + audtotalrate.ToString() + " PHP";

            //sgd
            string SGDfromCurrency = "SGD";
            double sgdexchangerate = GetExchangeRate(SGDfromCurrency, PHPtoCurrency);
            double sgdtotalrate = rateamount * sgdexchangerate;
            sgdtotalrate += additional;
            sgd_lbl.Text = "SGD: " + sgdtotalrate.ToString() + " PHP";

            //cad
            string CADfromCurrency = "CAD";
            double cadexchangerate = GetExchangeRate(CADfromCurrency, PHPtoCurrency);
            double cadtotalrate = rateamount * cadexchangerate;
            cadtotalrate += additional;
            cad_lbl.Text = "CAD: " + cadtotalrate.ToString() + " PHP";
        }

        

        private void usd_btn_Click(object sender, EventArgs e)
        {
            /*adminDashB.Instance.PnlContainer.Controls.Clear();
            tusd.Dock = DockStyle.Fill;
            tusd.BringToFront();
            adminDashB.Instance.PnlContainer.Controls.Add(tusd);*/
            rates.usd = usd_lbl.Text;
            //transactionusd

            if (logincreds.UT == "Admin")
            {


                //new customerr
                if (!adminDashB.Instance.PnlContainer.Controls.ContainsKey("transactionusd"))
                {

                    transactionusd transactionusd = new transactionusd();

                    adminDashB.Instance.PnlContainer.Controls.Remove(this);
                    transactionusd.Dock = DockStyle.Right;
                    adminDashB.Instance.PnlContainer.Controls.Add(transactionusd);
                    adminDashB.Instance.PnlContainer.Controls["transactionusd"].BringToFront();



                }

            }

            else if (logincreds.UT == "Teller")
            {
                if (!UserDB.Instance.PnlContainer.Controls.ContainsKey("transactionusd"))
                {

                    transactionusd transactionusd = new transactionusd();

                    UserDB.Instance.PnlContainer.Controls.Remove(this);
                    transactionusd.Dock = DockStyle.Right;
                    UserDB.Instance.PnlContainer.Controls.Add(transactionusd);
                    UserDB.Instance.PnlContainer.Controls["transactionusd"].BringToFront();



                }
            }



        }

        private void cad_btn_Click(object sender, EventArgs e)
        {
            rates.cad = cad_lbl.Text;
            if (logincreds.UT == "Admin")
            {


                //new customerr
                if (!adminDashB.Instance.PnlContainer.Controls.ContainsKey("transactioncad"))
                {

                    transactioncad transactioncad = new transactioncad();

                    adminDashB.Instance.PnlContainer.Controls.Remove(this);
                    transactioncad.Dock = DockStyle.Right;
                    adminDashB.Instance.PnlContainer.Controls.Add(transactioncad);
                    adminDashB.Instance.PnlContainer.Controls["transactionusd"].BringToFront();



                }

            }

            else if (logincreds.UT == "Teller")
            {
                if (!UserDB.Instance.PnlContainer.Controls.ContainsKey("transactioncad"))
                {

                    transactioncad transactioncad = new transactioncad();

                    UserDB.Instance.PnlContainer.Controls.Remove(this);
                    transactioncad.Dock = DockStyle.Right;
                    UserDB.Instance.PnlContainer.Controls.Add(transactioncad);
                    UserDB.Instance.PnlContainer.Controls["transactionusd"].BringToFront();



                }
            }
        }

        private void aud_btn_Click(object sender, EventArgs e)
        {
            rates.aud = aud_lbl.Text;
            if (logincreds.UT == "Admin")
            {


                //new customerr
                if (!adminDashB.Instance.PnlContainer.Controls.ContainsKey("transactionaud"))
                {

                    transactionaud transactionaud = new transactionaud();

                    adminDashB.Instance.PnlContainer.Controls.Remove(this);
                    transactionaud.Dock = DockStyle.Right;
                    adminDashB.Instance.PnlContainer.Controls.Add(transactionaud);
                    adminDashB.Instance.PnlContainer.Controls["transactionusd"].BringToFront();



                }

            }

            else if (logincreds.UT == "Teller")
            {
                if (!UserDB.Instance.PnlContainer.Controls.ContainsKey("transactionaud"))
                {

                    transactionaud transactionaud = new transactionaud();

                    UserDB.Instance.PnlContainer.Controls.Remove(this);
                    transactionaud.Dock = DockStyle.Right;
                    UserDB.Instance.PnlContainer.Controls.Add(transactionaud);
                    UserDB.Instance.PnlContainer.Controls["transactionaud"].BringToFront();



                }
            }
        }

        private void jpy_btn_Click(object sender, EventArgs e)
        {
            rates.jpy = jpy_lbl.Text;
            if (logincreds.UT == "Admin")
            {


                //new customerr
                if (!adminDashB.Instance.PnlContainer.Controls.ContainsKey("transactionjpy"))
                {

                    transactionjpy transactionjpy = new transactionjpy();

                    adminDashB.Instance.PnlContainer.Controls.Remove(this);
                    transactionjpy.Dock = DockStyle.Right;
                    adminDashB.Instance.PnlContainer.Controls.Add(transactionjpy);
                    adminDashB.Instance.PnlContainer.Controls["transactionjpy"].BringToFront();



                }

            }

            else if (logincreds.UT == "Teller")
            {
                if (!UserDB.Instance.PnlContainer.Controls.ContainsKey("transactionjpy"))
                {

                    transactionjpy transactionjpy = new transactionjpy();

                    UserDB.Instance.PnlContainer.Controls.Remove(this);
                    transactionjpy.Dock = DockStyle.Right;
                    UserDB.Instance.PnlContainer.Controls.Add(transactionjpy);
                    UserDB.Instance.PnlContainer.Controls["transactionjpy"].BringToFront();



                }
            }
        }

        private void hkd_btn_Click(object sender, EventArgs e)
        {
            rates.hkd = hkd_lbl.Text;
            if (logincreds.UT == "Admin")
            {


                //new customerr
                if (!adminDashB.Instance.PnlContainer.Controls.ContainsKey("transactionhkd"))
                {

                    transactionhkd transactionhkd = new transactionhkd();

                    adminDashB.Instance.PnlContainer.Controls.Remove(this);
                    transactionhkd.Dock = DockStyle.Right;
                    adminDashB.Instance.PnlContainer.Controls.Add(transactionhkd);
                    adminDashB.Instance.PnlContainer.Controls["transactionhkd"].BringToFront();



                }

            }

            else if (logincreds.UT == "Teller")
            {
                if (!UserDB.Instance.PnlContainer.Controls.ContainsKey("transactionhkd"))
                {

                    transactionhkd transactionhkd = new transactionhkd();

                    UserDB.Instance.PnlContainer.Controls.Remove(this);
                    transactionhkd.Dock = DockStyle.Right;
                    UserDB.Instance.PnlContainer.Controls.Add(transactionhkd);
                    UserDB.Instance.PnlContainer.Controls["transactionhkd"].BringToFront();



                }
            }
        }

        private void sgd_btn_Click(object sender, EventArgs e)
        {
            rates.sgd = sgd_lbl.Text;
            if (logincreds.UT == "Admin")
            {


                //new customerr
                if (!adminDashB.Instance.PnlContainer.Controls.ContainsKey("transactionsgd"))
                {

                    transactionsgd transactionsgd = new transactionsgd();

                    adminDashB.Instance.PnlContainer.Controls.Remove(this);
                    transactionsgd.Dock = DockStyle.Right;
                    adminDashB.Instance.PnlContainer.Controls.Add(transactionsgd);
                    adminDashB.Instance.PnlContainer.Controls["transactionsgd"].BringToFront();



                }

            }

            else if (logincreds.UT == "Teller")
            {
                if (!UserDB.Instance.PnlContainer.Controls.ContainsKey("transactionsgd"))
                {

                    transactionsgd transactionsgd = new transactionsgd();

                    UserDB.Instance.PnlContainer.Controls.Remove(this);
                    transactionsgd.Dock = DockStyle.Right;
                    UserDB.Instance.PnlContainer.Controls.Add(transactionsgd);
                    UserDB.Instance.PnlContainer.Controls["transactionsgd"].BringToFront();



                }
            }
        }

        private void eur_btn_Click(object sender, EventArgs e)
        {
            rates.eur = eur_lbl.Text;
            if (logincreds.UT == "Admin")
            {


                //new customerr
                if (!adminDashB.Instance.PnlContainer.Controls.ContainsKey("transactioneur"))
                {

                    transactioneur transactioneur = new transactioneur();

                    adminDashB.Instance.PnlContainer.Controls.Remove(this);
                    transactioneur.Dock = DockStyle.Right;
                    adminDashB.Instance.PnlContainer.Controls.Add(transactioneur);
                    adminDashB.Instance.PnlContainer.Controls["transactioneur"].BringToFront();



                }

            }

            else if (logincreds.UT == "Teller")
            {
                if (!UserDB.Instance.PnlContainer.Controls.ContainsKey("transactioneur"))
                {

                    transactioneur transactioneur = new transactioneur();

                    UserDB.Instance.PnlContainer.Controls.Remove(this);
                    transactioneur.Dock = DockStyle.Right;
                    UserDB.Instance.PnlContainer.Controls.Add(transactioneur);
                    UserDB.Instance.PnlContainer.Controls["transactioneur"].BringToFront();



                }
            }
        }

        private void gbp_btn_Click(object sender, EventArgs e)
        {
            rates.gbp = gbp_lbl.Text;
            if (logincreds.UT == "Admin")
            {


                //new customerr
                if (!adminDashB.Instance.PnlContainer.Controls.ContainsKey("transactiongbp"))
                {

                    transactiongbp transactiongbp = new transactiongbp();

                    adminDashB.Instance.PnlContainer.Controls.Remove(this);
                    transactiongbp.Dock = DockStyle.Right;
                    adminDashB.Instance.PnlContainer.Controls.Add(transactiongbp);
                    adminDashB.Instance.PnlContainer.Controls["transactiongbp"].BringToFront();



                }

            }

            else if (logincreds.UT == "Teller")
            {
                if (!UserDB.Instance.PnlContainer.Controls.ContainsKey("transactiongbp"))
                {

                    transactiongbp transactiongbp = new transactiongbp();

                    UserDB.Instance.PnlContainer.Controls.Remove(this);
                    transactiongbp.Dock = DockStyle.Right;
                    UserDB.Instance.PnlContainer.Controls.Add(transactiongbp);
                    UserDB.Instance.PnlContainer.Controls["transactiongbp"].BringToFront();



                }
            }
        }
    }
}
