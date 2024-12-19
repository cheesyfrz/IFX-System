namespace IFX_login
{
    partial class UserDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sttngs_trans = new System.Windows.Forms.Timer(this.components);
            this.profile_btn = new System.Windows.Forms.Button();
            this.homeContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chnge_btn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.trnsct_btn = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.inventory_btn = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.sttngscontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settings_btn = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.hometrans = new System.Windows.Forms.Timer(this.components);
            this.ham_trans = new System.Windows.Forms.Timer(this.components);
            this.time_lbl = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.acctname_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ham_btn = new System.Windows.Forms.PictureBox();
            this.homeContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel5.SuspendLayout();
            this.sttngscontainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ham_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // sttngs_trans
            // 
            this.sttngs_trans.Interval = 10;
            this.sttngs_trans.Tick += new System.EventHandler(this.sttngs_trans_Tick);
            // 
            // profile_btn
            // 
            this.profile_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.profile_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profile_btn.Image = global::IFX_login.Properties.Resources.administrator_icon;
            this.profile_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile_btn.Location = new System.Drawing.Point(-4, -10);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Padding = new System.Windows.Forms.Padding(28, 1, 14, 1);
            this.profile_btn.Size = new System.Drawing.Size(169, 47);
            this.profile_btn.TabIndex = 4;
            this.profile_btn.Text = "       Profile";
            this.profile_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile_btn.UseVisualStyleBackColor = false;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // homeContainer
            // 
            this.homeContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.homeContainer.Controls.Add(this.panel3);
            this.homeContainer.Controls.Add(this.panel4);
            this.homeContainer.Controls.Add(this.panel6);
            this.homeContainer.Controls.Add(this.panel9);
            this.homeContainer.Location = new System.Drawing.Point(3, 40);
            this.homeContainer.Name = "homeContainer";
            this.homeContainer.Size = new System.Drawing.Size(157, 43);
            this.homeContainer.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.home_btn);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 31);
            this.panel3.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button5);
            this.panel8.Location = new System.Drawing.Point(0, 26);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(138, 31);
            this.panel8.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = global::IFX_login.Properties.Resources.dashboard_white;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-4, -9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 47);
            this.button5.TabIndex = 4;
            this.button5.Text = "      Home";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.home_btn.Image = global::IFX_login.Properties.Resources.home_button_white_icon3;
            this.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.Location = new System.Drawing.Point(-4, -6);
            this.home_btn.Name = "home_btn";
            this.home_btn.Padding = new System.Windows.Forms.Padding(10, 1, 11, 1);
            this.home_btn.Size = new System.Drawing.Size(174, 43);
            this.home_btn.TabIndex = 4;
            this.home_btn.Text = "       Home";
            this.home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chnge_btn);
            this.panel4.Location = new System.Drawing.Point(3, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 31);
            this.panel4.TabIndex = 6;
            // 
            // chnge_btn
            // 
            this.chnge_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chnge_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chnge_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chnge_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chnge_btn.Image = global::IFX_login.Properties.Resources.dollar_white;
            this.chnge_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chnge_btn.Location = new System.Drawing.Point(-4, -9);
            this.chnge_btn.Name = "chnge_btn";
            this.chnge_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chnge_btn.Size = new System.Drawing.Size(169, 47);
            this.chnge_btn.TabIndex = 4;
            this.chnge_btn.Text = "      Change Money";
            this.chnge_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chnge_btn.UseVisualStyleBackColor = false;
            this.chnge_btn.Click += new System.EventHandler(this.chnge_btn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.trnsct_btn);
            this.panel6.Location = new System.Drawing.Point(3, 77);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(138, 31);
            this.panel6.TabIndex = 6;
            // 
            // trnsct_btn
            // 
            this.trnsct_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trnsct_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trnsct_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trnsct_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trnsct_btn.Image = global::IFX_login.Properties.Resources.database_white;
            this.trnsct_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trnsct_btn.Location = new System.Drawing.Point(-4, -9);
            this.trnsct_btn.Name = "trnsct_btn";
            this.trnsct_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.trnsct_btn.Size = new System.Drawing.Size(169, 47);
            this.trnsct_btn.TabIndex = 4;
            this.trnsct_btn.Text = "      Transactions";
            this.trnsct_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trnsct_btn.UseVisualStyleBackColor = false;
            this.trnsct_btn.Click += new System.EventHandler(this.trnsct_btn_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.inventory_btn);
            this.panel9.Location = new System.Drawing.Point(3, 114);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(138, 31);
            this.panel9.TabIndex = 7;
            // 
            // inventory_btn
            // 
            this.inventory_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inventory_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventory_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventory_btn.Image = global::IFX_login.Properties.Resources.inventory;
            this.inventory_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventory_btn.Location = new System.Drawing.Point(-4, -7);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.inventory_btn.Size = new System.Drawing.Size(169, 47);
            this.inventory_btn.TabIndex = 5;
            this.inventory_btn.Text = "     Inventory";
            this.inventory_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventory_btn.UseVisualStyleBackColor = false;
            this.inventory_btn.Click += new System.EventHandler(this.inventory_btn_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.homeContainer);
            this.sidebar.Controls.Add(this.sttngscontainer);
            this.sidebar.Controls.Add(this.panel12);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 61);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(45, 498);
            this.sidebar.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_dashboard);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(138, 31);
            this.panel5.TabIndex = 5;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dashboard.Image = global::IFX_login.Properties.Resources.dashboard_white;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(-4, -9);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(13, 10, 14, 1);
            this.btn_dashboard.Size = new System.Drawing.Size(169, 47);
            this.btn_dashboard.TabIndex = 4;
            this.btn_dashboard.Text = "       Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // sttngscontainer
            // 
            this.sttngscontainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sttngscontainer.Controls.Add(this.panel2);
            this.sttngscontainer.Controls.Add(this.panel11);
            this.sttngscontainer.Location = new System.Drawing.Point(3, 89);
            this.sttngscontainer.Name = "sttngscontainer";
            this.sttngscontainer.Size = new System.Drawing.Size(158, 37);
            this.sttngscontainer.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.settings_btn);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 31);
            this.panel2.TabIndex = 8;
            // 
            // settings_btn
            // 
            this.settings_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.settings_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settings_btn.Image = global::IFX_login.Properties.Resources.settings_white;
            this.settings_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings_btn.Location = new System.Drawing.Point(-4, -10);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Padding = new System.Windows.Forms.Padding(11, 1, 14, 0);
            this.settings_btn.Size = new System.Drawing.Size(169, 47);
            this.settings_btn.TabIndex = 4;
            this.settings_btn.Text = "       Settings";
            this.settings_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings_btn.UseVisualStyleBackColor = false;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.profile_btn);
            this.panel11.Location = new System.Drawing.Point(3, 40);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(138, 31);
            this.panel11.TabIndex = 7;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.logout_btn);
            this.panel12.Location = new System.Drawing.Point(3, 132);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(139, 24);
            this.panel12.TabIndex = 7;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout_btn.Image = global::IFX_login.Properties.Resources.logout_white1;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(-4, -7);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Padding = new System.Windows.Forms.Padding(13, 0, 14, 0);
            this.logout_btn.Size = new System.Drawing.Size(172, 35);
            this.logout_btn.TabIndex = 4;
            this.logout_btn.Text = "       Logout";
            this.logout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // hometrans
            // 
            this.hometrans.Interval = 10;
            this.hometrans.Tick += new System.EventHandler(this.hometrans_Tick);
            // 
            // ham_trans
            // 
            this.ham_trans.Interval = 10;
            this.ham_trans.Tick += new System.EventHandler(this.ham_trans_Tick);
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lbl.Location = new System.Drawing.Point(856, 524);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(88, 25);
            this.time_lbl.TabIndex = 12;
            this.time_lbl.Text = "00:00:00";
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.Transparent;
            this.mainpanel.Location = new System.Drawing.Point(47, 62);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(909, 498);
            this.mainpanel.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.acctname_lbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ham_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 61);
            this.panel1.TabIndex = 11;
            // 
            // acctname_lbl
            // 
            this.acctname_lbl.AutoSize = true;
            this.acctname_lbl.BackColor = System.Drawing.Color.Yellow;
            this.acctname_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctname_lbl.Location = new System.Drawing.Point(745, 20);
            this.acctname_lbl.Name = "acctname_lbl";
            this.acctname_lbl.Size = new System.Drawing.Size(53, 21);
            this.acctname_lbl.TabIndex = 4;
            this.acctname_lbl.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IFX_login.Properties.Resources.user_black_png;
            this.pictureBox1.Location = new System.Drawing.Point(911, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IFX_login.Properties.Resources.Screenshot_2024_10_01_221202;
            this.pictureBox2.Location = new System.Drawing.Point(42, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // ham_btn
            // 
            this.ham_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ham_btn.Image = global::IFX_login.Properties.Resources.hambutton;
            this.ham_btn.Location = new System.Drawing.Point(9, 20);
            this.ham_btn.Name = "ham_btn";
            this.ham_btn.Size = new System.Drawing.Size(30, 25);
            this.ham_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ham_btn.TabIndex = 1;
            this.ham_btn.TabStop = false;
            this.ham_btn.Click += new System.EventHandler(this.ham_btn_Click);
            // 
            // UserDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 559);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.time_lbl);
            this.Name = "UserDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserDB_FormClosing);
            this.Load += new System.EventHandler(this.UserDB_Load);
            this.homeContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.sttngscontainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ham_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer sttngs_trans;
        private System.Windows.Forms.Button profile_btn;
        private System.Windows.Forms.FlowLayoutPanel homeContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button chnge_btn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button trnsct_btn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button inventory_btn;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.FlowLayoutPanel sttngscontainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Timer hometrans;
        private System.Windows.Forms.Timer ham_trans;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label acctname_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ham_btn;
    }
}