using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace IFX_login
{
    public partial class loginqr : Form
    {
        Thread th;
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;


        public loginqr()
        {
            InitializeComponent();
        }
        private string connectionstring = @"Provider=Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb";

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        
        
        
        private void Date_lbl_Click(object sender, EventArgs e)
        {
        }

        private void loginqr_Load(object sender, EventArgs e)
        {
            time.Start();
            panel1.Hide();



            /*Date_lbl.Text = DateTime.Now.ToShortDateString();
            Time_lbl.Text = DateTime.Now.ToLongTimeString();*/


            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cb_Device.Items.Add(filterInfo.Name);
            cb_Device.SelectedIndex = 0;


            captureDevice = new VideoCaptureDevice(filterInfoCollection[cb_Device.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer.Start();
            

        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pb_scanner.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        

        private void btn_manuallog_Click(object sender, EventArgs e)
        {
            th = new Thread(OpenManualLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void OpenManualLogin()
        {
            
            Application.Run(new Form1());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb_scanner.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pb_scanner.Image);
                if (result != null)
                {
                    tb_details.Text = result.ToString();
                    string[] words = tb_details.Text.Split();
                    string uname = words[0];
                    string pass = words[1];

                     
                    
                    

                    using (OleDbConnection conn = new OleDbConnection(connectionstring))
                    {
                        try
                        {
                            conn.Open(); //open ng connection
                            string query = "SELECT UserType, ID, Firstname, Lastname FROM admin WHERE username = @Username AND [Password] = @Password";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Username", uname);
                                cmd.Parameters.AddWithValue("@Password", pass);

                                using (OleDbDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        logincreds.ID = Convert.ToInt32(reader["ID"]);
                                        logincreds.Firstname = reader["Firstname"].ToString();
                                        logincreds.Lastname = reader["Lastname"].ToString();
                                    }
                                }


                                object rslt = cmd.ExecuteScalar();


                                /* int userID = (int)result;*/

                                if (rslt != null)
                                {


                                    string formattedTimein = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                    string insertLogQuery = "INSERT INTO Loginfo (ID, Timein) VALUES (@userId, @timeIn)";
                                    OleDbCommand insertCmd = new OleDbCommand(insertLogQuery, conn);
                                    insertCmd.Parameters.AddWithValue("@userId", logincreds.ID);
                                    insertCmd.Parameters.AddWithValue("@timeIn", formattedTimein);
                                    


                                    string UT = rslt.ToString();

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
                                    else if(UT == "Rider")
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
                    timer.Stop();
                }
            }
        }


        private void OpenNewForm()
        {
            
            if (captureDevice.IsRunning == true)
            {

                captureDevice.Stop();
                
            }

            Application.Run(new adminDashB());
        }

        private void Openuserform()
        {
            
            if (captureDevice.IsRunning == true)
            {

                try
                {
                    
                        //FinalFrame.NewFrame -= frameHandler; // click button event is fired,
                      

                        captureDevice.NewFrame -= CaptureDevice_NewFrame; // click button event is fired,
                        
                        
                        captureDevice.SignalToStop();
                        
                    
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.ToString());
                }

            }
            Application.Run(new UserDB());
        }

        private void Rider()
        {
            if (captureDevice.IsRunning == true)
            {

                try
                {

                    //FinalFrame.NewFrame -= frameHandler; // click button event is fired,


                    captureDevice.NewFrame -= CaptureDevice_NewFrame; // click button event is fired,


                    captureDevice.SignalToStop();


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.ToString());
                }

            }
            Application.Run(new RiderDashB());
        }

        private void loginqr_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (captureDevice.IsRunning == true)
            {

                try
                {
                    

                    


                  


                    captureDevice.NewFrame -= CaptureDevice_NewFrame; 


                    captureDevice.SignalToStop();
                    

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.ToString());
                }
            }
        }

        private void loginqr_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if (captureDevice.IsRunning == true)
            {

                try
                {


                    


                    //FinalFrame.NewFrame -= frameHandler; // click button event is fired,


                    captureDevice.NewFrame -= CaptureDevice_NewFrame; // click button event is fired,


                    captureDevice.SignalToStop();
                    

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.ToString());
                }
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
}
