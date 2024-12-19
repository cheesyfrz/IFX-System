using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFX_login
{
    public partial class ChangePass : UserControl
    {
        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataReader reader;
        string pass;

        public static ChangePass inst { get; set; }
        public ChangePass()
        {
            InitializeComponent();
            inst = this;
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=admin_db.accdb");

            if (string.IsNullOrEmpty(Oldtb.Text) || string.IsNullOrEmpty(Newtb.Text) || string.IsNullOrEmpty(Retypetb.Text))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Newtb.Text != Retypetb.Text)
            {
                MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Open();
            string query = "SELECT [Password] FROM admin WHERE ID = ?";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("?", logincreds.ID);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                pass = reader["Password"].ToString();
            }

            if (pass != Oldtb.Text)
            {
                MessageBox.Show("Old password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pass == Oldtb.Text)
            {
                string updatequery = "UPDATE admin SET [Password] = ? WHERE [ID] = ?";
                cmd = new OleDbCommand(updatequery, conn);
                cmd.Parameters.AddWithValue("?", Newtb.Text);
                cmd.Parameters.AddWithValue("?", logincreds.ID.ToString());
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Password changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //generate ga uli man qrcode
                    logincreds.uname = logincreds.uname.ToString() + " ";
                    Newtb.Text = Newtb.Text + " ";
                    QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
                    var MyData = QG.CreateQrCode(logincreds.uname + Newtb.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
                    var code = new QRCoder.QRCode(MyData);
                    qr_pb.Image = code.GetGraphic(50);
                    Bitmap pic = new Bitmap(qr_pb.ClientSize.Width, qr_pb.ClientSize.Height);
                    using (Graphics g = Graphics.FromImage(pic))
                    {
                        qr_pb.Image.Save(@"C:\Users\kenji\Desktop\Portfolio\qr\Test1.png", System.Drawing.Imaging.ImageFormat.Png);
                    }
                    string employeeemail = logincreds.email;
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

                    if (logincreds.UT == "Admin")
                    {


                        //new customerr
                        if (!adminDashB.Instance.PnlContainer.Controls.ContainsKey("Profile"))
                        {

                            Profile profile = new Profile();

                            adminDashB.Instance.PnlContainer.Controls.Remove(this);
                            profile.Dock = DockStyle.Right;
                            adminDashB.Instance.PnlContainer.Controls.Add(profile);
                            adminDashB.Instance.PnlContainer.Controls["Profile"].BringToFront();



                        }

                    }

                    else if (logincreds.UT == "Teller")
                    {
                        if (!UserDB.Instance.PnlContainer.Controls.ContainsKey("Profile"))
                        {

                            Profile profile = new Profile();

                            UserDB.Instance.PnlContainer.Controls.Remove(this);
                            profile.Dock = DockStyle.Right;
                            UserDB.Instance.PnlContainer.Controls.Add(profile);
                            UserDB.Instance.PnlContainer.Controls["Profile"].BringToFront();



                        }
                    }


                }
            }
        }

        private void Canceltb_Click(object sender, EventArgs e)
        {
            if (logincreds.UT == "Admin")
            {


                //new customerr
                if (!adminDashB.Instance.PnlContainer.Controls.ContainsKey("Profile"))
                {

                    Profile profile = new Profile();

                    adminDashB.Instance.PnlContainer.Controls.Remove(this);
                    profile.Dock = DockStyle.Right;
                    adminDashB.Instance.PnlContainer.Controls.Add(profile);
                    adminDashB.Instance.PnlContainer.Controls["Profile"].BringToFront();



                }

            }

            else if (logincreds.UT == "Teller")
            {
                if (!UserDB.Instance.PnlContainer.Controls.ContainsKey("Profile"))
                {

                    Profile profile = new Profile();

                    UserDB.Instance.PnlContainer.Controls.Remove(this);
                    profile.Dock = DockStyle.Right;
                    UserDB.Instance.PnlContainer.Controls.Add(profile);
                    UserDB.Instance.PnlContainer.Controls["Profile"].BringToFront();



                }
            }
        }
    }
}
