namespace IFX_login
{
    partial class dashboardratedisplay
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_usd = new System.Windows.Forms.Label();
            this.lbl_eur = new System.Windows.Forms.Label();
            this.lbl_gbp = new System.Windows.Forms.Label();
            this.lbl_aud = new System.Windows.Forms.Label();
            this.lbl_hkd = new System.Windows.Forms.Label();
            this.lbl_jpy = new System.Windows.Forms.Label();
            this.lbl_cad = new System.Windows.Forms.Label();
            this.lbl_sgd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.details_bttn = new System.Windows.Forms.Button();
            this.transaction_dgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TodaySale = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.details_panel = new System.Windows.Forms.Panel();
            this.LNumber = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LSales = new System.Windows.Forms.Label();
            this.LTransactionNo = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LDateTime = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LCurrency = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LIDNo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LCAmount = new System.Windows.Forms.Label();
            this.LCitizen = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LTypeID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LRate = new System.Windows.Forms.Label();
            this.LAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LGender = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LSource = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LAdd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LCustomerID = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Close_bttn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.details_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_usd
            // 
            this.lbl_usd.AutoSize = true;
            this.lbl_usd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usd.Location = new System.Drawing.Point(13, 2);
            this.lbl_usd.Name = "lbl_usd";
            this.lbl_usd.Size = new System.Drawing.Size(59, 25);
            this.lbl_usd.TabIndex = 0;
            this.lbl_usd.Text = "USD: ";
            this.lbl_usd.Click += new System.EventHandler(this.lbl_usd_Click);
            // 
            // lbl_eur
            // 
            this.lbl_eur.AutoSize = true;
            this.lbl_eur.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eur.Location = new System.Drawing.Point(13, 41);
            this.lbl_eur.Name = "lbl_eur";
            this.lbl_eur.Size = new System.Drawing.Size(57, 25);
            this.lbl_eur.TabIndex = 1;
            this.lbl_eur.Text = "EUR: ";
            // 
            // lbl_gbp
            // 
            this.lbl_gbp.AutoSize = true;
            this.lbl_gbp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gbp.Location = new System.Drawing.Point(13, 83);
            this.lbl_gbp.Name = "lbl_gbp";
            this.lbl_gbp.Size = new System.Drawing.Size(52, 25);
            this.lbl_gbp.TabIndex = 2;
            this.lbl_gbp.Text = "GBP:";
            // 
            // lbl_aud
            // 
            this.lbl_aud.AutoSize = true;
            this.lbl_aud.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aud.Location = new System.Drawing.Point(13, 201);
            this.lbl_aud.Name = "lbl_aud";
            this.lbl_aud.Size = new System.Drawing.Size(57, 25);
            this.lbl_aud.TabIndex = 5;
            this.lbl_aud.Text = "AUD:";
            // 
            // lbl_hkd
            // 
            this.lbl_hkd.AutoSize = true;
            this.lbl_hkd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hkd.Location = new System.Drawing.Point(13, 159);
            this.lbl_hkd.Name = "lbl_hkd";
            this.lbl_hkd.Size = new System.Drawing.Size(57, 25);
            this.lbl_hkd.TabIndex = 4;
            this.lbl_hkd.Text = "HKD:";
            // 
            // lbl_jpy
            // 
            this.lbl_jpy.AutoSize = true;
            this.lbl_jpy.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jpy.Location = new System.Drawing.Point(13, 120);
            this.lbl_jpy.Name = "lbl_jpy";
            this.lbl_jpy.Size = new System.Drawing.Size(47, 25);
            this.lbl_jpy.TabIndex = 3;
            this.lbl_jpy.Text = "JPY:";
            // 
            // lbl_cad
            // 
            this.lbl_cad.AutoSize = true;
            this.lbl_cad.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cad.Location = new System.Drawing.Point(13, 278);
            this.lbl_cad.Name = "lbl_cad";
            this.lbl_cad.Size = new System.Drawing.Size(56, 25);
            this.lbl_cad.TabIndex = 7;
            this.lbl_cad.Text = "CAD:";
            // 
            // lbl_sgd
            // 
            this.lbl_sgd.AutoSize = true;
            this.lbl_sgd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sgd.Location = new System.Drawing.Point(13, 239);
            this.lbl_sgd.Name = "lbl_sgd";
            this.lbl_sgd.Size = new System.Drawing.Size(54, 25);
            this.lbl_sgd.TabIndex = 6;
            this.lbl_sgd.Text = "SGD:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_cad);
            this.panel1.Controls.Add(this.lbl_eur);
            this.panel1.Controls.Add(this.lbl_sgd);
            this.panel1.Controls.Add(this.lbl_usd);
            this.panel1.Controls.Add(this.lbl_aud);
            this.panel1.Controls.Add(this.lbl_gbp);
            this.panel1.Controls.Add(this.lbl_hkd);
            this.panel1.Controls.Add(this.lbl_jpy);
            this.panel1.Location = new System.Drawing.Point(706, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 322);
            this.panel1.TabIndex = 8;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(12, 277);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Yellow};
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Total Sales";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(506, 212);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 175);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(822, 466);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.refreshbtn.TabIndex = 11;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // details_bttn
            // 
            this.details_bttn.Location = new System.Drawing.Point(576, 227);
            this.details_bttn.Name = "details_bttn";
            this.details_bttn.Size = new System.Drawing.Size(75, 23);
            this.details_bttn.TabIndex = 10;
            this.details_bttn.Text = "Details";
            this.details_bttn.UseVisualStyleBackColor = true;
            this.details_bttn.Click += new System.EventHandler(this.details_bttn_Click_2);
            // 
            // transaction_dgv
            // 
            this.transaction_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transaction_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.transaction_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transaction_dgv.Location = new System.Drawing.Point(40, 31);
            this.transaction_dgv.Name = "transaction_dgv";
            this.transaction_dgv.Size = new System.Drawing.Size(623, 192);
            this.transaction_dgv.TabIndex = 15;
            this.transaction_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transaction_dgv_CellContentClick_1);
            this.transaction_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transaction_dgv_CellContentClick_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.details_bttn);
            this.panel2.Location = new System.Drawing.Point(12, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 262);
            this.panel2.TabIndex = 16;
            // 
            // TodaySale
            // 
            this.TodaySale.AutoSize = true;
            this.TodaySale.Location = new System.Drawing.Point(20, 61);
            this.TodaySale.Name = "TodaySale";
            this.TodaySale.Size = new System.Drawing.Size(13, 13);
            this.TodaySale.TabIndex = 1;
            this.TodaySale.Text = "--";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Today\'s Sales";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.TodaySale);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Location = new System.Drawing.Point(535, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 96);
            this.panel3.TabIndex = 17;
            // 
            // details_panel
            // 
            this.details_panel.BackColor = System.Drawing.Color.White;
            this.details_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.details_panel.Controls.Add(this.LNumber);
            this.details_panel.Controls.Add(this.label14);
            this.details_panel.Controls.Add(this.LSales);
            this.details_panel.Controls.Add(this.LTransactionNo);
            this.details_panel.Controls.Add(this.label19);
            this.details_panel.Controls.Add(this.label13);
            this.details_panel.Controls.Add(this.LDateTime);
            this.details_panel.Controls.Add(this.label12);
            this.details_panel.Controls.Add(this.LCurrency);
            this.details_panel.Controls.Add(this.label9);
            this.details_panel.Controls.Add(this.LIDNo);
            this.details_panel.Controls.Add(this.label8);
            this.details_panel.Controls.Add(this.LCAmount);
            this.details_panel.Controls.Add(this.LCitizen);
            this.details_panel.Controls.Add(this.label11);
            this.details_panel.Controls.Add(this.LTypeID);
            this.details_panel.Controls.Add(this.label5);
            this.details_panel.Controls.Add(this.LRate);
            this.details_panel.Controls.Add(this.LAmount);
            this.details_panel.Controls.Add(this.label7);
            this.details_panel.Controls.Add(this.LGender);
            this.details_panel.Controls.Add(this.label17);
            this.details_panel.Controls.Add(this.label10);
            this.details_panel.Controls.Add(this.LSource);
            this.details_panel.Controls.Add(this.label4);
            this.details_panel.Controls.Add(this.LAdd);
            this.details_panel.Controls.Add(this.label6);
            this.details_panel.Controls.Add(this.LCustomerID);
            this.details_panel.Controls.Add(this.LName);
            this.details_panel.Controls.Add(this.label16);
            this.details_panel.Controls.Add(this.label3);
            this.details_panel.Controls.Add(this.label2);
            this.details_panel.Controls.Add(this.label1);
            this.details_panel.Controls.Add(this.label15);
            this.details_panel.Controls.Add(this.Close_bttn);
            this.details_panel.Location = new System.Drawing.Point(308, 25);
            this.details_panel.Name = "details_panel";
            this.details_panel.Size = new System.Drawing.Size(292, 449);
            this.details_panel.TabIndex = 18;
            this.details_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.details_panel_Paint);
            // 
            // LNumber
            // 
            this.LNumber.AutoSize = true;
            this.LNumber.Location = new System.Drawing.Point(155, 138);
            this.LNumber.Name = "LNumber";
            this.LNumber.Size = new System.Drawing.Size(13, 13);
            this.LNumber.TabIndex = 2;
            this.LNumber.Text = "--";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Contact Number:";
            // 
            // LSales
            // 
            this.LSales.AutoSize = true;
            this.LSales.Location = new System.Drawing.Point(155, 374);
            this.LSales.Name = "LSales";
            this.LSales.Size = new System.Drawing.Size(13, 13);
            this.LSales.TabIndex = 1;
            this.LSales.Text = "--";
            // 
            // LTransactionNo
            // 
            this.LTransactionNo.AutoSize = true;
            this.LTransactionNo.Location = new System.Drawing.Point(155, 352);
            this.LTransactionNo.Name = "LTransactionNo";
            this.LTransactionNo.Size = new System.Drawing.Size(13, 13);
            this.LTransactionNo.TabIndex = 1;
            this.LTransactionNo.Text = "--";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(42, 374);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Sales:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Transaction Number:";
            // 
            // LDateTime
            // 
            this.LDateTime.AutoSize = true;
            this.LDateTime.Location = new System.Drawing.Point(155, 330);
            this.LDateTime.Name = "LDateTime";
            this.LDateTime.Size = new System.Drawing.Size(13, 13);
            this.LDateTime.TabIndex = 1;
            this.LDateTime.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Date and Time:";
            // 
            // LCurrency
            // 
            this.LCurrency.AutoSize = true;
            this.LCurrency.Location = new System.Drawing.Point(155, 248);
            this.LCurrency.Name = "LCurrency";
            this.LCurrency.Size = new System.Drawing.Size(13, 13);
            this.LCurrency.TabIndex = 1;
            this.LCurrency.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Currency:";
            // 
            // LIDNo
            // 
            this.LIDNo.AutoSize = true;
            this.LIDNo.Location = new System.Drawing.Point(155, 226);
            this.LIDNo.Name = "LIDNo";
            this.LIDNo.Size = new System.Drawing.Size(13, 13);
            this.LIDNo.TabIndex = 1;
            this.LIDNo.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID Number:";
            // 
            // LCAmount
            // 
            this.LCAmount.AutoSize = true;
            this.LCAmount.Location = new System.Drawing.Point(155, 307);
            this.LCAmount.Name = "LCAmount";
            this.LCAmount.Size = new System.Drawing.Size(13, 13);
            this.LCAmount.TabIndex = 1;
            this.LCAmount.Text = "--";
            // 
            // LCitizen
            // 
            this.LCitizen.AutoSize = true;
            this.LCitizen.Location = new System.Drawing.Point(155, 159);
            this.LCitizen.Name = "LCitizen";
            this.LCitizen.Size = new System.Drawing.Size(13, 13);
            this.LCitizen.TabIndex = 1;
            this.LCitizen.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Converted Amount:";
            // 
            // LTypeID
            // 
            this.LTypeID.AutoSize = true;
            this.LTypeID.Location = new System.Drawing.Point(155, 203);
            this.LTypeID.Name = "LTypeID";
            this.LTypeID.Size = new System.Drawing.Size(13, 13);
            this.LTypeID.TabIndex = 1;
            this.LTypeID.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Citizenship:";
            // 
            // LRate
            // 
            this.LRate.AutoSize = true;
            this.LRate.Location = new System.Drawing.Point(155, 267);
            this.LRate.Name = "LRate";
            this.LRate.Size = new System.Drawing.Size(13, 13);
            this.LRate.TabIndex = 1;
            this.LRate.Text = "--";
            // 
            // LAmount
            // 
            this.LAmount.AutoSize = true;
            this.LAmount.Location = new System.Drawing.Point(155, 285);
            this.LAmount.Name = "LAmount";
            this.LAmount.Size = new System.Drawing.Size(13, 13);
            this.LAmount.TabIndex = 1;
            this.LAmount.Text = "--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Type Of ID:";
            // 
            // LGender
            // 
            this.LGender.AutoSize = true;
            this.LGender.Location = new System.Drawing.Point(155, 115);
            this.LGender.Name = "LGender";
            this.LGender.Size = new System.Drawing.Size(13, 13);
            this.LGender.TabIndex = 1;
            this.LGender.Text = "--";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(42, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Rate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Amount:";
            // 
            // LSource
            // 
            this.LSource.AutoSize = true;
            this.LSource.Location = new System.Drawing.Point(155, 181);
            this.LSource.Name = "LSource";
            this.LSource.Size = new System.Drawing.Size(13, 13);
            this.LSource.TabIndex = 1;
            this.LSource.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gender:";
            // 
            // LAdd
            // 
            this.LAdd.AutoSize = true;
            this.LAdd.Location = new System.Drawing.Point(155, 92);
            this.LAdd.Name = "LAdd";
            this.LAdd.Size = new System.Drawing.Size(13, 13);
            this.LAdd.TabIndex = 1;
            this.LAdd.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Source Of Income:";
            // 
            // LCustomerID
            // 
            this.LCustomerID.AutoSize = true;
            this.LCustomerID.Location = new System.Drawing.Point(155, 50);
            this.LCustomerID.Name = "LCustomerID";
            this.LCustomerID.Size = new System.Drawing.Size(13, 13);
            this.LCustomerID.TabIndex = 1;
            this.LCustomerID.Text = "--";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(155, 70);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(13, 13);
            this.LName.TabIndex = 1;
            this.LName.Text = "--";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Customer ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction Details";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(235, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "______________________________________";
            // 
            // Close_bttn
            // 
            this.Close_bttn.Location = new System.Drawing.Point(102, 404);
            this.Close_bttn.Name = "Close_bttn";
            this.Close_bttn.Size = new System.Drawing.Size(75, 23);
            this.Close_bttn.TabIndex = 0;
            this.Close_bttn.Text = "Close";
            this.Close_bttn.UseVisualStyleBackColor = true;
            this.Close_bttn.Click += new System.EventHandler(this.Close_bttn_Click_1);
            // 
            // dashboardratedisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.details_panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.transaction_dgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "dashboardratedisplay";
            this.Size = new System.Drawing.Size(909, 498);
            this.Load += new System.EventHandler(this.dashboardratedisplay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.details_panel.ResumeLayout(false);
            this.details_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_usd;
        private System.Windows.Forms.Label lbl_eur;
        private System.Windows.Forms.Label lbl_gbp;
        private System.Windows.Forms.Label lbl_aud;
        private System.Windows.Forms.Label lbl_hkd;
        private System.Windows.Forms.Label lbl_jpy;
        private System.Windows.Forms.Label lbl_cad;
        private System.Windows.Forms.Label lbl_sgd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button details_bttn;
        private System.Windows.Forms.DataGridView transaction_dgv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TodaySale;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel details_panel;
        private System.Windows.Forms.Label LNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LSales;
        private System.Windows.Forms.Label LTransactionNo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LDateTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LCurrency;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LIDNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LCAmount;
        private System.Windows.Forms.Label LCitizen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LTypeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LRate;
        private System.Windows.Forms.Label LAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LGender;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LCustomerID;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Close_bttn;
    }
}
