﻿namespace IFX_login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_unamelog = new System.Windows.Forms.TextBox();
            this.tb_pwlog = new System.Windows.Forms.TextBox();
            this.admin_btn = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.btn_scanqr = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_pw = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timein_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_unamelog
            // 
            this.tb_unamelog.BackColor = System.Drawing.SystemColors.Control;
            this.tb_unamelog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_unamelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_unamelog.Location = new System.Drawing.Point(331, 177);
            this.tb_unamelog.Name = "tb_unamelog";
            this.tb_unamelog.Size = new System.Drawing.Size(405, 24);
            this.tb_unamelog.TabIndex = 0;
            // 
            // tb_pwlog
            // 
            this.tb_pwlog.BackColor = System.Drawing.SystemColors.Control;
            this.tb_pwlog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pwlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pwlog.Location = new System.Drawing.Point(331, 251);
            this.tb_pwlog.Name = "tb_pwlog";
            this.tb_pwlog.Size = new System.Drawing.Size(405, 24);
            this.tb_pwlog.TabIndex = 1;
            this.tb_pwlog.UseSystemPasswordChar = true;
            // 
            // admin_btn
            // 
            this.admin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.admin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_btn.Location = new System.Drawing.Point(331, 346);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(405, 53);
            this.admin_btn.TabIndex = 2;
            this.admin_btn.Text = "Login";
            this.admin_btn.UseVisualStyleBackColor = false;
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // time
            // 
            this.time.Enabled = true;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // btn_scanqr
            // 
            this.btn_scanqr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_scanqr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_scanqr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_scanqr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scanqr.Location = new System.Drawing.Point(461, 425);
            this.btn_scanqr.Name = "btn_scanqr";
            this.btn_scanqr.Size = new System.Drawing.Size(143, 41);
            this.btn_scanqr.TabIndex = 9;
            this.btn_scanqr.Text = "Scan QR";
            this.btn_scanqr.UseVisualStyleBackColor = false;
            this.btn_scanqr.Click += new System.EventHandler(this.btn_scanqr_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IFX_login.Properties.Resources.coding_login;
            this.pictureBox2.Location = new System.Drawing.Point(-11, -9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1066, 643);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(328, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(328, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Password";
            // 
            // cb_pw
            // 
            this.cb_pw.AutoSize = true;
            this.cb_pw.BackColor = System.Drawing.Color.Black;
            this.cb_pw.ForeColor = System.Drawing.Color.Transparent;
            this.cb_pw.Location = new System.Drawing.Point(333, 304);
            this.cb_pw.Name = "cb_pw";
            this.cb_pw.Size = new System.Drawing.Size(102, 17);
            this.cb_pw.TabIndex = 13;
            this.cb_pw.Text = "Show Password";
            this.cb_pw.UseVisualStyleBackColor = false;
            this.cb_pw.CheckedChanged += new System.EventHandler(this.cb_pw_CheckedChanged_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.timein_btn);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Location = new System.Drawing.Point(350, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 186);
            this.panel1.TabIndex = 15;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_pw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_scanqr);
            this.Controls.Add(this.admin_btn);
            this.Controls.Add(this.tb_pwlog);
            this.Controls.Add(this.tb_unamelog);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IFX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_pwlog;
        private System.Windows.Forms.TextBox tb_unamelog;
        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Button btn_scanqr;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_pw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button timein_btn;
        private System.Windows.Forms.Button login_btn;
    }
}

