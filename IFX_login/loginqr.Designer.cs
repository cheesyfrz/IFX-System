namespace IFX_login
{
    partial class loginqr
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
            this.btn_manuallog = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Timer(this.components);
            this.tb_details = new System.Windows.Forms.TextBox();
            this.cb_Device = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_scanner = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timein_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_scanner)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_manuallog
            // 
            this.btn_manuallog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_manuallog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_manuallog.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manuallog.Location = new System.Drawing.Point(458, 443);
            this.btn_manuallog.Name = "btn_manuallog";
            this.btn_manuallog.Size = new System.Drawing.Size(133, 42);
            this.btn_manuallog.TabIndex = 18;
            this.btn_manuallog.Text = "Manual Login";
            this.btn_manuallog.UseVisualStyleBackColor = false;
            this.btn_manuallog.Click += new System.EventHandler(this.btn_manuallog_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tb_details
            // 
            this.tb_details.Location = new System.Drawing.Point(1032, 636);
            this.tb_details.Multiline = true;
            this.tb_details.Name = "tb_details";
            this.tb_details.Size = new System.Drawing.Size(10, 10);
            this.tb_details.TabIndex = 4;
            // 
            // cb_Device
            // 
            this.cb_Device.FormattingEnabled = true;
            this.cb_Device.Location = new System.Drawing.Point(358, 170);
            this.cb_Device.Name = "cb_Device";
            this.cb_Device.Size = new System.Drawing.Size(371, 21);
            this.cb_Device.TabIndex = 11;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Black;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(271, 167);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(81, 24);
            this.lbl.TabIndex = 12;
            this.lbl.Text = "Camera:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IFX_login.Properties.Resources.qrlogin_coding;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1048, 658);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pb_scanner
            // 
            this.pb_scanner.Location = new System.Drawing.Point(413, 237);
            this.pb_scanner.Name = "pb_scanner";
            this.pb_scanner.Size = new System.Drawing.Size(226, 133);
            this.pb_scanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_scanner.TabIndex = 13;
            this.pb_scanner.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.timein_btn);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Location = new System.Drawing.Point(339, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 186);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome Rider!";
            // 
            // timein_btn
            // 
            this.timein_btn.Location = new System.Drawing.Point(220, 121);
            this.timein_btn.Name = "timein_btn";
            this.timein_btn.Size = new System.Drawing.Size(75, 23);
            this.timein_btn.TabIndex = 1;
            this.timein_btn.Text = "Time In";
            this.timein_btn.UseVisualStyleBackColor = true;
            this.timein_btn.Click += new System.EventHandler(this.timein_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(66, 121);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // loginqr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_details);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pb_scanner);
            this.Controls.Add(this.cb_Device);
            this.Controls.Add(this.btn_manuallog);
            this.Controls.Add(this.pictureBox1);
            this.Name = "loginqr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginqr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loginqr_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.loginqr_FormClosed);
            this.Load += new System.EventHandler(this.loginqr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_scanner)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_manuallog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pb_scanner;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.TextBox tb_details;
        private System.Windows.Forms.ComboBox cb_Device;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button timein_btn;
        private System.Windows.Forms.Button login_btn;
    }
}