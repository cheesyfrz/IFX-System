﻿namespace IFX_login
{
    partial class ChangePass
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Canceltb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Retypetb = new System.Windows.Forms.TextBox();
            this.Newtb = new System.Windows.Forms.TextBox();
            this.Oldtb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.qr_pb = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qr_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(82, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "New Password:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Canceltb);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Retypetb);
            this.panel1.Controls.Add(this.Newtb);
            this.panel1.Controls.Add(this.Oldtb);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(240, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 427);
            this.panel1.TabIndex = 3;
            // 
            // Canceltb
            // 
            this.Canceltb.Location = new System.Drawing.Point(86, 308);
            this.Canceltb.Name = "Canceltb";
            this.Canceltb.Size = new System.Drawing.Size(75, 23);
            this.Canceltb.TabIndex = 44;
            this.Canceltb.Text = "Cancel";
            this.Canceltb.UseVisualStyleBackColor = true;
            this.Canceltb.Click += new System.EventHandler(this.Canceltb_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Retype New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(89, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Old Password:";
            // 
            // Retypetb
            // 
            this.Retypetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Retypetb.Location = new System.Drawing.Point(208, 221);
            this.Retypetb.Name = "Retypetb";
            this.Retypetb.Size = new System.Drawing.Size(120, 26);
            this.Retypetb.TabIndex = 41;
            // 
            // Newtb
            // 
            this.Newtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Newtb.Location = new System.Drawing.Point(208, 189);
            this.Newtb.Name = "Newtb";
            this.Newtb.Size = new System.Drawing.Size(120, 26);
            this.Newtb.TabIndex = 41;
            // 
            // Oldtb
            // 
            this.Oldtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Oldtb.Location = new System.Drawing.Point(208, 157);
            this.Oldtb.Name = "Oldtb";
            this.Oldtb.Size = new System.Drawing.Size(120, 26);
            this.Oldtb.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(132, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 28);
            this.label11.TabIndex = 40;
            this.label11.Text = "Change Password";
            // 
            // qr_pb
            // 
            this.qr_pb.Location = new System.Drawing.Point(780, 51);
            this.qr_pb.Name = "qr_pb";
            this.qr_pb.Size = new System.Drawing.Size(53, 44);
            this.qr_pb.TabIndex = 4;
            this.qr_pb.TabStop = false;
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.qr_pb);
            this.Controls.Add(this.panel1);
            this.Name = "ChangePass";
            this.Size = new System.Drawing.Size(909, 498);
            this.Load += new System.EventHandler(this.ChangePass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qr_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Canceltb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Retypetb;
        private System.Windows.Forms.TextBox Newtb;
        private System.Windows.Forms.TextBox Oldtb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox qr_pb;
    }
}
