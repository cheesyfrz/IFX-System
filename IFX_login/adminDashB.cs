using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Data.OleDb;

namespace IFX_login
{
    public partial class adminDashB : Form
    {
        public static adminDashB Instance { get; set; }
            
       /* public static adminDashB Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new adminDashB();
                }
                return obj;
            }
        }*/

        

        public Panel PnlContainer
        {
            get { return mainpanel; }
            set { mainpanel = value; }

        }

        


        System.Timers.Timer timr;
        int hr, min, sec;
        private string connectionstring = @"Provider=Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb";
        int salary;
        int totalsalary = 0;
        Thread th;
        OleDbConnection conn;
        public adminDashB()
        {
            InitializeComponent();
            conn = new OleDbConnection(connectionstring);
            Instance = this;
        }

        flagbutton flgbtn = new flagbutton();
        user_signup usrsgnup = new user_signup();
        dashboardratedisplay dbrate = new dashboardratedisplay();
        Choosecstmr ncstmr = new Choosecstmr();
        transactionhistory transactionhistory = new transactionhistory();
        Profile profile = new Profile();
        Inventory CashInventory = new Inventory();
        EditUser EditUser = new EditUser();
        

        private void adminDashB_Load(object sender, EventArgs e)
        {
            
            dbrate.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(dbrate);
            acctname_lbl.Text = logincreds.Firstname.ToString() + " " + logincreds.Lastname.ToString();
            /*dashboardratedisplay1.Show();
            dashboardratedisplay1.BringToFront();
            flagbutton1.Hide();
            user_signup1.Hide();*/

            timr = new System.Timers.Timer();   
            timr.Interval = 1000;
            timr.Elapsed += OntimeEvent;
            timr.Start();
        }

        private void OntimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                sec += 1;
                if(sec == 60)
                {
                    sec = 0;
                    min += 1;
                    if(min == 30)
                    {
                        salary = 41;
                        totalsalary = totalsalary + salary;
                        salary=0;

                    }
                    

                }
                if(min == 60)
                {
                    salary = 41;
                    totalsalary += salary;
                    salary = 0;
                    min = 0;
                    hr += 1;

                }
                time_lbl.Text = String.Format("{0}:{1}:{2}", hr.ToString().PadLeft(2,'0'), min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0'));  
            }
            ));
        }

        bool homeExpand = false;
        bool hamExpand = true;
        bool settExpand = false;

        private void hometrans_Tick(object sender, EventArgs e)
        {
            if(homeExpand == false)
            {
                homeContainer.Height += 10;
                if(homeContainer.Height >= 154)
                {
                    hometrans.Stop();
                    homeExpand = true;
                }
            }

            else
            {
                homeContainer.Height -= 10;
                if (homeContainer.Height <= 43)
                {
                    hometrans.Stop();
                    homeExpand = false;
                }
            }
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            hometrans.Start();
            if(sidebar.Width<= 47)
            {
                ham_trans.Start();
                sidebar.Width += 10;
                if (sidebar.Width >= 150)
                {
                    hamExpand = true;
                    ham_trans.Stop();
                }
            }
        }
        
        private void ham_trans_Tick(object sender, EventArgs e)
        {
            if (hamExpand)
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 150)
                {
                    hamExpand = false;
                    ham_trans.Stop();
                }

            }

            else
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 45)
                {
                    hamExpand = true;
                    ham_trans.Stop();
                }

               
            }
        }

        private void ham_btn_Click(object sender, EventArgs e)
        {
            ham_trans.Start();
            if (homeContainer.Height >= 111)
            {
                hometrans.Start();

                homeContainer.Height -= 10;
                if (homeContainer.Height <= 43)
                {
                    hometrans.Stop();
                    homeExpand = false;
                }
            }

            if(sttngscontainer.Height >= 150)
            {
                sttngs_trans.Start();
                sttngscontainer.Height -= 10;
                if(sttngscontainer.Height <= 37)
                {
                    sttngs_trans.Stop();
                    settExpand = false;
                }
            }
        }

        private void sttngs_trans_Tick(object sender, EventArgs e)
        {
            if(settExpand == false)
            {
                sttngscontainer.Height += 10;
                if(sttngscontainer.Height >= 150)
                {
                    settExpand = true;
                    sttngs_trans.Stop();
                    
                }
               
            }

            else
            {
                sttngscontainer.Height -= 10;
                if (sttngscontainer.Height <= 37)
                {
                    settExpand = false;
                    sttngs_trans.Stop();

                }
            }

        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            sttngs_trans.Start();
            if (sidebar.Width <= 45)
            {
                ham_trans.Start();
                sidebar.Width += 10;
                if (sidebar.Width >= 150)
                {
                    hamExpand = true;
                    ham_trans.Stop();
                }
            }
        }

        private void adminDashB_FormClosing(object sender, FormClosingEventArgs e)
        {

            string mnhrquery = "UPDATE Loginfo SET Manhour = @mh WHERE ID = @id AND Manhour IS NULL";
            OleDbCommand cmdmhr = new OleDbCommand(mnhrquery, conn);
            cmdmhr.Parameters.AddWithValue("@mh", time_lbl.Text);
            cmdmhr.Parameters.AddWithValue("@id", logincreds.ID);
            conn.Open();
            cmdmhr.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            string formattedtimeout = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string updateLogQuery = "UPDATE Loginfo SET TimeOut = @timeOut WHERE ID = @userId AND Timeout IS NULL";
            OleDbCommand cmd = new OleDbCommand(updateLogQuery, conn);
            cmd.Parameters.AddWithValue("@timeout", formattedtimeout);
            cmd.Parameters.AddWithValue("@userId", logincreds.ID);
            cmd.ExecuteNonQuery();

            conn.Close();

            timr.Stop();
            Application.DoEvents();
        }

        private void addusr_btn_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            usrsgnup.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(usrsgnup);

            

            

            if(sttngscontainer.Height >= 150)
            {
                sttngs_trans.Start();

                sttngscontainer.Height -= 10;
                if(sttngscontainer.Height <= 37)
                {
                    
                    sttngs_trans.Stop();
                    settExpand = false;
                }
            }

            if (homeContainer.Height >= 154)
            {
                hometrans.Start();

                homeContainer.Height -= 10;
                if (homeContainer.Height <= 43)
                {
                    hometrans.Stop();
                    homeExpand = false;
                }
            }

            if (sidebar.Width >= 150)
            {
                ham_trans.Start();
                sidebar.Width -= 10;
                if(sidebar.Width <= 45)
                {
                    hamExpand = false;
                    ham_trans.Stop();
                }
            }
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            profile.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(profile);

            if (sttngscontainer.Height >= 150)
            {
                sttngs_trans.Start();

                sttngscontainer.Height -= 10;
                if (sttngscontainer.Height <= 37)
                {

                    sttngs_trans.Stop();
                    settExpand = false;
                }
            }

            if (homeContainer.Height >= 154)
            {
                hometrans.Start();

                homeContainer.Height -= 10;
                if (homeContainer.Height <= 43)
                {
                    hometrans.Stop();
                    homeExpand = false;
                }
            }

            if (sidebar.Width >= 150)
            {
                ham_trans.Start();
                sidebar.Width -= 10;
                if (sidebar.Width <= 45)
                {
                    hamExpand = false;
                    ham_trans.Stop();
                }
            }
        }

        private void edituser_btn_Click(object sender, EventArgs e)
        {

            mainpanel.Controls.Clear();
            EditUser.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(EditUser);

            if (sttngscontainer.Height >= 150)
            {
                sttngs_trans.Start();

                sttngscontainer.Height -= 10;
                if (sttngscontainer.Height <= 37)
                {

                    sttngs_trans.Stop();
                    settExpand = false;
                }
            }

            if (homeContainer.Height >= 154)
            {
                hometrans.Start();

                homeContainer.Height -= 10;
                if (homeContainer.Height <= 43)
                {
                    hometrans.Stop();
                    homeExpand = false;
                }
            }

            if (sidebar.Width >= 150)
            {
                ham_trans.Start();
                sidebar.Width -= 10;
                if (sidebar.Width <= 45)
                {
                    hamExpand = false;
                    ham_trans.Stop();
                }
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            dbrate.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(dbrate);
            /*flagbutton1.Hide();
            user_signup1.Hide();
            dashboardratedisplay1.Show();
            dashboardratedisplay1.BringToFront();*/

            if (sttngscontainer.Height >= 150)
            {
                sttngs_trans.Start();

                sttngscontainer.Height -= 10;
                if (sttngscontainer.Height <= 37)
                {

                    sttngs_trans.Stop();
                    settExpand = false;
                }
            }

            if (homeContainer.Height >= 154)
            {
                hometrans.Start();

                homeContainer.Height -= 10;
                if (homeContainer.Height <= 43)
                {
                    hometrans.Stop();
                    homeExpand = false;
                }
            }

            if (sidebar.Width >= 150)
            {
                ham_trans.Start();
                sidebar.Width -= 10;
                if (sidebar.Width <= 45)
                {
                    hamExpand = false;
                    ham_trans.Stop();
                }
            }
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chnge_btn_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            ncstmr.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(ncstmr);
            

            if (sttngscontainer.Height >= 150)
            {
                sttngs_trans.Start();

                sttngscontainer.Height -= 10;
                if (sttngscontainer.Height <= 37)
                {

                    sttngs_trans.Stop();
                    settExpand = false;
                }
            }

            if (homeContainer.Height >= 154)
            {
                hometrans.Start();

                homeContainer.Height -= 10;
                if (homeContainer.Height <= 43)
                {
                    hometrans.Stop();
                    homeExpand = false;
                }
            }

            if (sidebar.Width >= 150)
            {
                ham_trans.Start();
                sidebar.Width -= 10;
                if (sidebar.Width <= 45)
                {
                    hamExpand = false;
                    ham_trans.Stop();
                }
            }

        }

        private void trnsct_btn_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            transactionhistory.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(transactionhistory);

            if (sttngscontainer.Height >= 150)
            {
                sttngs_trans.Start();

                sttngscontainer.Height -= 10;
                if (sttngscontainer.Height <= 37)
                {

                    sttngs_trans.Stop();
                    settExpand = false;
                }
            }

            if (homeContainer.Height >= 154)
            {
                hometrans.Start();

                homeContainer.Height -= 10;
                if (homeContainer.Height <= 43)
                {
                    hometrans.Stop();
                    homeExpand = false;
                }
            }

            if (sidebar.Width >= 150)
            {
                ham_trans.Start();
                sidebar.Width -= 10;
                if (sidebar.Width <= 45)
                {
                    hamExpand = false;
                    ham_trans.Stop();
                }
            }
        }

        private void acctname_lbl_Click(object sender, EventArgs e)
        {

        }

        private void inventory_btn_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            CashInventory.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(CashInventory);

            if (sttngscontainer.Height >= 150)
            {
                sttngs_trans.Start();

                sttngscontainer.Height -= 10;
                if (sttngscontainer.Height <= 37)
                {

                    sttngs_trans.Stop();
                    settExpand = false;
                }
            }

            if (homeContainer.Height >= 154)
            {
                hometrans.Start();

                homeContainer.Height -= 10;
                if (homeContainer.Height <= 43)
                {
                    hometrans.Stop();
                    homeExpand = false;
                }
            }

            if (sidebar.Width >= 150)
            {
                ham_trans.Start();
                sidebar.Width -= 10;
                if (sidebar.Width <= 45)
                {
                    hamExpand = false;
                    ham_trans.Stop();
                }
            }
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        /*private void home_btn_MouseHover(object sender, EventArgs e)
        {
            sidebar.Width = 150;
            

        }

        private void sidebar_MouseLeave(object sender, EventArgs e)
        {
            sidebar.Width = 45;
        }*/

        private void logout_btn_Click(object sender, EventArgs e)
        {
            var yn = MessageBox.Show("Are you sure you want to Logout?", "Warning", MessageBoxButtons.YesNo);

            if (yn == DialogResult.Yes)
            {



                string mnhrquery = "UPDATE Loginfo SET Manhour = @mh WHERE ID = @id AND Manhour IS NULL";
                OleDbCommand cmdmhr = new OleDbCommand(mnhrquery, conn);
                cmdmhr.Parameters.AddWithValue("@mh", time_lbl.Text);
                cmdmhr.Parameters.AddWithValue("@id", logincreds.ID);
                conn.Open();
                cmdmhr.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                string formattedtimeout = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string updateLogQuery = "UPDATE Loginfo SET TimeOut = @timeOut WHERE ID = @userId AND Timeout IS NULL";
                OleDbCommand cmd = new OleDbCommand(updateLogQuery, conn);
                cmd.Parameters.AddWithValue("@timeout", formattedtimeout);
                cmd.Parameters.AddWithValue("@userId", logincreds.ID);
                cmd.ExecuteNonQuery();

                conn.Close();
                timr.Stop();
                th = new Thread(OpenNewForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }

            else
            {
                return;
            }
            
        }

        private void OpenNewForm()
        {
            Application.Run(new Form1());
        }
    }
}
