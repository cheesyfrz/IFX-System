using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FaceRecognition;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;



namespace IFX_login
{
    
    public partial class Form1 : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        Thread th;
        private int loginattempts = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private string connectionstring = @"Provider=Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb";


        
        private void admin_btn_Click(object sender, EventArgs e)
        {
            /* faceRec.Save_IMAGE(tb_unamelog.Text);*/

            string uname = tb_unamelog.Text;
            string pass = tb_pwlog.Text;

            logincreds.uname = uname;
            


            if (string.IsNullOrEmpty(uname) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("No Input");
            }

            else
            {

                using (OleDbConnection conn = new OleDbConnection(connectionstring))
                {
                    try
                    {              
                        conn.Open(); //open ng connection
                        string query = "SELECT UserType, ID, Firstname, Lastname, Email FROM admin WHERE username = @Username AND [Password] = @Password";
                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", uname);
                            cmd.Parameters.AddWithValue("@Password", pass);
                            

                            using(OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                if(reader.Read())
                                {
                                    logincreds.ID = Convert.ToInt32(reader["ID"]);
                                    logincreds.Firstname = reader["Firstname"].ToString();
                                    logincreds.Lastname = reader["Lastname"].ToString();
                                    logincreds.email = reader["Email"].ToString();
                                }
                            }


                            object result = cmd.ExecuteScalar();


                            /* int userID = (int)result;*/

                            if (result != null)
                            {


                                string formattedTimein = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                string insertLogQuery = "INSERT INTO Loginfo (ID, Timein) VALUES (@userId, @timeIn)";
                                OleDbCommand insertCmd = new OleDbCommand(insertLogQuery, conn);
                               insertCmd.Parameters.AddWithValue("@userId", logincreds.ID);
                               insertCmd.Parameters.AddWithValue("@timeIn", formattedTimein);
                               


                                string UT = result.ToString();

                                if (UT == "Admin")
                                {
                                    insertCmd.ExecuteNonQuery();
                                    logincreds.UT = UT;
                                    conn.Close();
                                    th = new Thread(OpenNewForm);
                                    th.SetApartmentState(ApartmentState.STA);
                                    th.Start();


                                    this.Close();
                                }
                                else if (UT == "Teller")
                                {
                                    insertCmd.ExecuteNonQuery();
                                    logincreds.UT = UT;
                                    conn.Close();
                                    th = new Thread(Openuserform);
                                    th.SetApartmentState(ApartmentState.STA);
                                    th.Start();
                                    this.Close();
                                }
                                else if (UT == "Rider")
                                {
                                    bool checkpoint = true;
                                    logincreds.UT = UT;
                                    if (checkpoint == true)
                                    {


                                        string inserttimeoutquery = "SELECT Timein FROM Loginfo WHERE ID = @userId AND Timeout IS NULL";

                                        OleDbCommand checkcmd = new OleDbCommand(inserttimeoutquery, conn);
                                        checkcmd.Parameters.AddWithValue("?", logincreds.ID);
                                        OleDbDataReader reader = checkcmd.ExecuteReader();
                                        if (reader.Read())
                                        {
                                            checkpoint = false;
                                            inserttimeoutquery = "UPDATE Loginfo SET TimeOut = @timeOut WHERE ID = @userId AND Timeout IS NULL";
                                            OleDbCommand timeoutcmd = new OleDbCommand(inserttimeoutquery, conn);
                                            timeoutcmd.Parameters.AddWithValue("@timeout", formattedTimein);
                                            timeoutcmd.Parameters.AddWithValue("@userId", logincreds.ID);
                                            timeoutcmd.ExecuteNonQuery();
                                            MessageBox.Show("Timed out Successfully", "Rider", MessageBoxButtons.OK);

                                        }
                                        else
                                        {
                                            insertCmd.ExecuteNonQuery();
                                            panel1.Show();
                                        }
                                    }
                                }
                            }


                            else
                            {
                                MessageBox.Show("Username or Password does not match");
                            }
                        }
                    }

                    catch (OleDbException ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }

                    finally
                    {
                        conn.Close();
                    }
                
                }
                
            }


           /* conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\\Users\\kenji\\Desktop\\Portfolio\\IFX_Databases\\admin_db.accdb");
            string query = "SELECT COUNT (*) FROM admin WHERE username = @Username AND [Password] = @Password";
            
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", tb_unamelog.Text);
            cmd.Parameters.AddWithValue("@Password", tb_pwlog.Text);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();*/
           
            


           /* if (count > 0)
            {
                 
                if (UT == "Admin")
                {
                    th = new Thread(OpenNewForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    this.Close();
                }

                else if (UT == "User")
                {
                    th = new Thread(Openuserform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    this.Close();
                }
                
            }

            else
            {
                loginattempts++;
                MessageBox.Show("Invalid Username or Password");
                if (loginattempts > 5)
                {
                    MessageBox.Show("Contacting Security...");

                }
            }*/

            
             
           
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            panel1.Hide();



            time.Start();
            /*Date_lbl.Text = DateTime.Now.ToShortDateString();
            Time_lbl.Text = DateTime.Now.ToLongTimeString();*/

        }

       

        private void cb_pw_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_pw.Checked)
            {
                tb_pwlog.UseSystemPasswordChar = false;
            }

            else 
            {
                tb_pwlog.UseSystemPasswordChar = true;
            }
        }

        

        private void OpenNewForm()
        {

            Application.Run(new adminDashB());
        }

        private void Openuserform()
        {
            Application.Run(new UserDB());
        }

        private void Rider()
        {

            Application.Run(new RiderDashB());
        }


        private void time_Tick(object sender, EventArgs e)
        {
           /* Time_lbl.Text = DateTime.Now.ToLongTimeString();*/
            time.Start();
        }

        private void btn_scanqr_Click(object sender, EventArgs e)
        {
            
            th = new Thread(OpenQRform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();

        }

        private void OpenQRform()
        {
            
            Application.Run(new loginqr());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
                
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void cb_pw_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb_pw.Checked)
            {
                tb_pwlog.UseSystemPasswordChar = false;
            }

            else
            {
                tb_pwlog.UseSystemPasswordChar = true;
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            th = new Thread(Rider);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void timein_btn_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
    }

    public static class logincreds
    {
        public static int ID;
        public static string Firstname;
        public static string Lastname;
        public static string UT;
        public static string uname;
        public static string pw;
        public static string email;
        public static string cntctnum;  
    }
}
