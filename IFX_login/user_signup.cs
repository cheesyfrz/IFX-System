using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;



namespace IFX_login
{
    public partial class user_signup : UserControl
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;


        public user_signup()
        {
            InitializeComponent();
        }

        private void tbfname_addusr_TextChanged(object sender, EventArgs e)
        {
            
          

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbfname_addusr.Text)||
               string.IsNullOrWhiteSpace(tblname_addusr.Text)||
               string.IsNullOrWhiteSpace(tbMname_addusr.Text)||
               string.IsNullOrWhiteSpace(dtbday_addusr.Text)||
               string.IsNullOrWhiteSpace(tbcntctnum_addusr.Text)||
               string.IsNullOrWhiteSpace(tbuname_addusr.Text)||
               string.IsNullOrWhiteSpace(tbpw_addusr.Text)||
               string.IsNullOrWhiteSpace(tbrpw_addusr.Text)||
               string.IsNullOrWhiteSpace(tbemail_addusr.Text)||
               string.IsNullOrWhiteSpace(tbage_addusr.Text) ||
               string.IsNullOrWhiteSpace(tbadd_addusr.Text)
                )
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if(tbpw_addusr.Text != tbrpw_addusr.Text)
            {
                MessageBox.Show("Password do not match. Please re-enter your password");
                return;
            }
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb");
            string query = "INSERT INTO admin(Firstname,Lastname,Middlename,Address,Age,email,username,[Password],Birthday,UserType, ContactNo) VALUES"
                + "(@fn,@ln,@mn,@ad,@age,@em,@un,@pw,@bd,@ut,@cn)";

            cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("@fn",tbfname_addusr.Text);
            cmd.Parameters.AddWithValue("@ln", tblname_addusr.Text);
            cmd.Parameters.AddWithValue("@mn", tbMname_addusr.Text);
            cmd.Parameters.AddWithValue("@ad", tbadd_addusr.Text);
            cmd.Parameters.AddWithValue("@age", tbage_addusr.Text);
            cmd.Parameters.AddWithValue("@em", tbemail_addusr.Text);
            cmd.Parameters.AddWithValue("@um", tbuname_addusr.Text);
            cmd.Parameters.AddWithValue("@pw", tbpw_addusr.Text);
            cmd.Parameters.AddWithValue("@bd", dtbday_addusr.Value);
            cmd.Parameters.AddWithValue("@ut", tbusrtype_addusr.Text);
            cmd.Parameters.AddWithValue("@cn", tbcntctnum_addusr.Text );
            

            try
            {

                tbuname_addusr.Text = tbuname_addusr.Text + " ";
                tbpw_addusr.Text = tbpw_addusr.Text + " ";
                QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
                var MyData = QG.CreateQrCode(tbuname_addusr.Text + tbpw_addusr.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
                var code = new QRCoder.QRCode(MyData);
                qr_pb.Image = code.GetGraphic(50);
                Bitmap pic = new Bitmap(qr_pb.ClientSize.Width, qr_pb.ClientSize.Height);
                using (Graphics g = Graphics.FromImage(pic))
                {
                    qr_pb.Image.Save(@"C:\Users\kenji\Desktop\Portfolio\qr\Test1.png", System.Drawing.Imaging.ImageFormat.Png);
                }
                string employeeemail = tbemail_addusr.Text;
                string frmemail; //email
                string title = "QR";
                string to = employeeemail;
                string fileloc = "C:\\Users\\kenji\\Desktop\\Portfolio\\qr\\Test1.png";
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

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered Succesfully");
                tbfname_addusr.Text = "";
                tblname_addusr.Text = "";
                tbMname_addusr.Text = "";
                tbadd_addusr.Text = "";
                tbage_addusr.Text = "";
                tbemail_addusr.Text = "";
                tbuname_addusr.Text = "";
                tbpw_addusr.Text = "";
                tbrpw_addusr.Text = "";
                tbcntctnum_addusr.Text = "";
                tbusrtype_addusr.Text = "";
                

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

        private void user_signup_Load(object sender, EventArgs e)
        {
            qr_pb.Hide();
        }
    }
}
