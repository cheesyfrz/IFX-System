using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFX_login
{
    public partial class Choosecstmr : UserControl
    {
        
        public static Choosecstmr inst {  get; set; }

        public Choosecstmr()
        {
            InitializeComponent();
            inst = this;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //new customerr
            if (logincreds.UT == "Admin")
            {


                //new customerr
                if (!adminDashB.Instance.PnlContainer.Controls.ContainsKey("newcustomer"))
                {

                    newcustomer ncstmr = new newcustomer();

                    adminDashB.Instance.PnlContainer.Controls.Remove(this);
                    ncstmr.Dock = DockStyle.Right;
                    adminDashB.Instance.PnlContainer.Controls.Add(ncstmr);
                    adminDashB.Instance.PnlContainer.Controls["newcustomer"].BringToFront();



                }

            }

            else if (logincreds.UT == "Teller")
            {
                if (!UserDB.Instance.PnlContainer.Controls.ContainsKey("newcustomer"))
                {

                    newcustomer ncstmr = new newcustomer();

                    UserDB.Instance.PnlContainer.Controls.Remove(this);
                    ncstmr.Dock = DockStyle.Right;
                    UserDB.Instance.PnlContainer.Controls.Add(ncstmr);
                    UserDB.Instance.PnlContainer.Controls["newcustomer"].BringToFront();



                }
            }

        }

        private void exstng_cstmrbtn_Click(object sender, EventArgs e)
        {

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
    }
}
