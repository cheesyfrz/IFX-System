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
using static IFX_login.newcustomer;

namespace IFX_login
{
    public partial class Existingcstmr : UserControl
    {
        public static Existingcstmr inst { get; set; }

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;

        public static class cstmrinfo
        {
            public static string cstmrid;
            public static string cstmrfname;
            public static string cstmrlname;
            public static string cstmraddrs;
            public static string cstmrgndr;
            public static string cstmrctznshp;
            public static string cstmrsoi;
            public static string cstmrtypeofid;
            public static string cstmridnum;
            public static string contactnum;
            public static string cstmremail;
        }

        public Existingcstmr()
        {
            InitializeComponent();
            inst = this;
        }

        void GetUsers()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM cstmr", conn);
            conn.Open();
            adapter.Fill(dt);
            dgv_cstmrlist.DataSource = dt;
            conn.Close();
        }

        private void Existingcstmr_Load(object sender, EventArgs e)
        {
            GetUsers();
        }

        private void dgv_cstmrlist_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_cstmrlist_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bck_btn_Click(object sender, EventArgs e)
        {
            if (logincreds.UT == "Admin")
            {


                //new customerr
                if (!adminDashB.Instance.PnlContainer.Controls.ContainsKey("Choosecstmr"))
                {

                    Choosecstmr chos = new Choosecstmr();

                    adminDashB.Instance.PnlContainer.Controls.Remove(this);
                    chos.Dock = DockStyle.Right;
                    adminDashB.Instance.PnlContainer.Controls.Add(chos);
                    adminDashB.Instance.PnlContainer.Controls["Choosecstmr"].BringToFront();



                }

            }

            else if (logincreds.UT == "Teller")
            {
                if (!UserDB.Instance.PnlContainer.Controls.ContainsKey("Choosecstmr"))
                {

                    Choosecstmr chos = new Choosecstmr();

                    UserDB.Instance.PnlContainer.Controls.Remove(this);
                    chos.Dock = DockStyle.Right;
                    UserDB.Instance.PnlContainer.Controls.Add(chos);
                    UserDB.Instance.PnlContainer.Controls["Choosecstmr"].BringToFront();



                }
            }
        }

        private void nxt_btn_Click(object sender, EventArgs e)
        {
            var yn = MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo);

            if (yn == DialogResult.Yes)
            {
                
                    cstmrinfo.cstmrid = dgv_cstmrlist.CurrentRow.Cells[0].Value.ToString();
                    cstmrinfo.cstmrfname = dgv_cstmrlist.CurrentRow.Cells[1].Value.ToString();
                    cstmrinfo.cstmrlname = dgv_cstmrlist.CurrentRow.Cells[2].Value.ToString();
                    cstmrinfo.cstmraddrs = dgv_cstmrlist.CurrentRow.Cells[3].Value.ToString();
                    cstmrinfo.cstmrgndr = dgv_cstmrlist.CurrentRow.Cells[4].Value.ToString();
                    cstmrinfo.cstmrctznshp = dgv_cstmrlist.CurrentRow.Cells[5].Value.ToString();
                    cstmrinfo.cstmrsoi = dgv_cstmrlist.CurrentRow.Cells[6].Value.ToString();
                    cstmrinfo.cstmrtypeofid = dgv_cstmrlist.CurrentRow.Cells[7].Value.ToString();
                    cstmrinfo.cstmridnum = dgv_cstmrlist.CurrentRow.Cells[8].Value.ToString();
                    cstmrinfo.contactnum = dgv_cstmrlist.CurrentRow.Cells[9].Value.ToString();
                    cstmrinfo.cstmremail = dgv_cstmrlist.CurrentRow.Cells[10].Value.ToString();





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
            else
            {
                return;
            }

        }
    }
}
