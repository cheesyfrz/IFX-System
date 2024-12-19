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

namespace IFX_login
{
    public partial class RiderDashB : Form
    {
        public RiderDashB()
        {
            InitializeComponent();
        }
        Thread th;
        Profile profile = new Profile();
        private void logout_btn_Click(object sender, EventArgs e)
        {
            th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void OpenNewForm()
        {
            Application.Run(new Form1());
        }

        private void RiderDashB_Load(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            profile.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(profile);
            acctname_lbl.Text = logincreds.Firstname.ToString() + " " + logincreds.Lastname.ToString();
        }
    }
}
