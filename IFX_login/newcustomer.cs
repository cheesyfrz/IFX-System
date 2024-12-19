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
    public partial class newcustomer : UserControl
    {
        public static newcustomer inst {  get; set; }




        public newcustomer()
        {
            InitializeComponent();
            inst = this;
        }

        OleDbConnection conn;
        OleDbCommand cmd;

        private void newcustomer_Load(object sender, EventArgs e)
        {

        }

        

        private void continue_btn_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(fname_tb.Text) ||
                string.IsNullOrEmpty(lname_tb.Text) ||
                string.IsNullOrEmpty(address_tb.Text) ||
                string.IsNullOrEmpty(gender_cb.Text) ||
                string.IsNullOrEmpty(ctznship_tb.Text) ||
                string.IsNullOrEmpty(soi_tb.Text) ||
                string.IsNullOrEmpty(idtype_cb.Text) ||
                string.IsNullOrEmpty(idnum_tb.Text) ||
                    string.IsNullOrEmpty(cntctnum_tb.Text)||
                    string.IsNullOrEmpty(email_tb.Text)
                    )
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else
            { 
                conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb");
                string query = "INSERT INTO cstmr(FirstName, LastName, Address, Gender, Citizenship, SOI, TOI, IDnum, ContactNumber, Email) VALUES"
                +"(@fname, @lname, @add, @gndr, @ctznshp, @soi, @toi, @idnum, @cnum, @email)";

                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@fname", fname_tb.Text);
                cmd.Parameters.AddWithValue("@lname", lname_tb.Text);
                cmd.Parameters.AddWithValue("@add", address_tb.Text);
                cmd.Parameters.AddWithValue("@gndr", gender_cb.Text);
                cmd.Parameters.AddWithValue("@ctzshp", ctznship_tb.Text);
                cmd.Parameters.AddWithValue("@soi", soi_tb.Text);
                cmd.Parameters.AddWithValue("@toi", idtype_cb.Text);
                cmd.Parameters.AddWithValue("@idnum", idnum_tb.Text);
                cmd.Parameters.AddWithValue("@cnum", cntctnum_tb.Text);
                cmd.Parameters.AddWithValue("@email", email_tb.Text);

                var yn = MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo);

                if (yn == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                    finally { conn.Close(); }


                    if (logincreds.UT == "Admin")
                    {


                        //new customerr
                        if (!adminDashB.Instance.PnlContainer.Controls.ContainsKey("Existingcstmr"))
                        {

                            Existingcstmr existingcstmr = new Existingcstmr();

                            adminDashB.Instance.PnlContainer.Controls.Remove(this);
                            existingcstmr.Dock = DockStyle.Right;
                            adminDashB.Instance.PnlContainer.Controls.Add(existingcstmr);
                            adminDashB.Instance.PnlContainer.Controls["Existingcstmr"].BringToFront();



                        }

                    }

                    else if (logincreds.UT == "Teller")
                    {
                        if (!UserDB.Instance.PnlContainer.Controls.ContainsKey("Existingcstmr"))
                        {

                            Existingcstmr existingcstmr = new Existingcstmr();

                            UserDB.Instance.PnlContainer.Controls.Remove(this);
                            existingcstmr.Dock = DockStyle.Right;
                            UserDB.Instance.PnlContainer.Controls.Add(existingcstmr);
                            UserDB.Instance.PnlContainer.Controls["Existingcstmr"].BringToFront();



                        }
                    }



                }
                else
                {
                    return;
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            if (logincreds.UT == "Admin")
            {


                //new customerr
                if (!adminDashB.Instance.PnlContainer.Controls.ContainsKey("Choosecstmr"))
                {

                    Choosecstmr choosecstmr = new Choosecstmr();

                    adminDashB.Instance.PnlContainer.Controls.Remove(this);
                    choosecstmr.Dock = DockStyle.Right;
                    adminDashB.Instance.PnlContainer.Controls.Add(choosecstmr);
                    adminDashB.Instance.PnlContainer.Controls["Choosecstmr"].BringToFront();



                }

            }

            else if (logincreds.UT == "Teller")
            {
                if (!UserDB.Instance.PnlContainer.Controls.ContainsKey("Choosecstmr"))
                {

                    Choosecstmr choosecstmr = new Choosecstmr();

                    UserDB.Instance.PnlContainer.Controls.Remove(this);
                    choosecstmr.Dock = DockStyle.Right;
                    UserDB.Instance.PnlContainer.Controls.Add(choosecstmr);
                    UserDB.Instance.PnlContainer.Controls["Choosecstmr"].BringToFront();



                }
            }

        }
    }
}
