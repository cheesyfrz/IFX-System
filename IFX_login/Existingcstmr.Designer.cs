namespace IFX_login
{
    partial class Existingcstmr
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nxt_btn = new System.Windows.Forms.Button();
            this.bck_btn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_cstmrlist = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bck_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cstmrlist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nxt_btn);
            this.panel1.Controls.Add(this.bck_btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgv_cstmrlist);
            this.panel1.Location = new System.Drawing.Point(51, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 423);
            this.panel1.TabIndex = 0;
            // 
            // nxt_btn
            // 
            this.nxt_btn.Location = new System.Drawing.Point(661, 375);
            this.nxt_btn.Name = "nxt_btn";
            this.nxt_btn.Size = new System.Drawing.Size(117, 38);
            this.nxt_btn.TabIndex = 22;
            this.nxt_btn.Text = "Continue";
            this.nxt_btn.UseVisualStyleBackColor = true;
            this.nxt_btn.Click += new System.EventHandler(this.nxt_btn_Click);
            // 
            // bck_btn
            // 
            this.bck_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bck_btn.Image = global::IFX_login.Properties.Resources.Back_btn;
            this.bck_btn.Location = new System.Drawing.Point(13, 15);
            this.bck_btn.Name = "bck_btn";
            this.bck_btn.Size = new System.Drawing.Size(24, 24);
            this.bck_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bck_btn.TabIndex = 21;
            this.bck_btn.TabStop = false;
            this.bck_btn.Click += new System.EventHandler(this.bck_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Customer List";
            // 
            // dgv_cstmrlist
            // 
            this.dgv_cstmrlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cstmrlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_cstmrlist.BackgroundColor = System.Drawing.Color.White;
            this.dgv_cstmrlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cstmrlist.GridColor = System.Drawing.Color.DarkGray;
            this.dgv_cstmrlist.Location = new System.Drawing.Point(29, 81);
            this.dgv_cstmrlist.Name = "dgv_cstmrlist";
            this.dgv_cstmrlist.Size = new System.Drawing.Size(749, 284);
            this.dgv_cstmrlist.TabIndex = 0;
            this.dgv_cstmrlist.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cstmrlist_CellEnter);
            this.dgv_cstmrlist.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cstmrlist_CellMouseEnter);
            // 
            // Existingcstmr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Existingcstmr";
            this.Size = new System.Drawing.Size(909, 498);
            this.Load += new System.EventHandler(this.Existingcstmr_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bck_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cstmrlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_cstmrlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox bck_btn;
        private System.Windows.Forms.Button nxt_btn;
    }
}
