namespace Cryws
{
    partial class frmChiTietDongCoin
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.AreaSeriesView areaSeriesView1 = new DevExpress.XtraCharts.AreaSeriesView();
            DevExpress.XtraCharts.AreaSeriesView areaSeriesView2 = new DevExpress.XtraCharts.AreaSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietDongCoin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSymBol = new DevExpress.XtraEditors.LabelControl();
            this.lblNamecoin = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblChange24h = new DevExpress.XtraEditors.LabelControl();
            this.lblPrice = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSubblly = new DevExpress.XtraEditors.LabelControl();
            this.lblVolume24 = new DevExpress.XtraEditors.LabelControl();
            this.lblMarketcap = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.lblBieudo = new DevExpress.XtraEditors.LabelControl();
            this.btnHuyUaThich = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemUaThich = new DevExpress.XtraEditors.SimpleButton();
            this.pBDongcoin = new System.Windows.Forms.PictureBox();
            this.btnTrolai = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDongcoin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblSymBol);
            this.panel1.Controls.Add(this.lblNamecoin);
            this.panel1.Location = new System.Drawing.Point(188, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 60);
            this.panel1.TabIndex = 2;
            // 
            // lblSymBol
            // 
            this.lblSymBol.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymBol.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSymBol.Location = new System.Drawing.Point(14, 28);
            this.lblSymBol.Name = "lblSymBol";
            this.lblSymBol.Size = new System.Drawing.Size(59, 19);
            this.lblSymBol.TabIndex = 1;
            this.lblSymBol.Text = "Symbol";
            // 
            // lblNamecoin
            // 
            this.lblNamecoin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamecoin.Location = new System.Drawing.Point(14, 3);
            this.lblNamecoin.Name = "lblNamecoin";
            this.lblNamecoin.Size = new System.Drawing.Size(47, 19);
            this.lblNamecoin.TabIndex = 0;
            this.lblNamecoin.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblChange24h);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Location = new System.Drawing.Point(431, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 33);
            this.panel2.TabIndex = 3;
            // 
            // lblChange24h
            // 
            this.lblChange24h.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange24h.Location = new System.Drawing.Point(149, 3);
            this.lblChange24h.Name = "lblChange24h";
            this.lblChange24h.Size = new System.Drawing.Size(95, 23);
            this.lblChange24h.TabIndex = 3;
            this.lblChange24h.Text = "Change24";
            // 
            // lblPrice
            // 
            this.lblPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(3, 3);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 23);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelControl3);
            this.panel3.Controls.Add(this.labelControl2);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Location = new System.Drawing.Point(396, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 35);
            this.panel3.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(355, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(151, 18);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Số lượng coin bán ra";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(187, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(126, 18);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Khối lượng (24h)";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(4, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(137, 18);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Vốn hóa thị trường";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblSubblly);
            this.panel4.Controls.Add(this.lblVolume24);
            this.panel4.Controls.Add(this.lblMarketcap);
            this.panel4.Location = new System.Drawing.Point(396, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(513, 35);
            this.panel4.TabIndex = 7;
            // 
            // lblSubblly
            // 
            this.lblSubblly.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubblly.Location = new System.Drawing.Point(355, 9);
            this.lblSubblly.Name = "lblSubblly";
            this.lblSubblly.Size = new System.Drawing.Size(49, 18);
            this.lblSubblly.TabIndex = 6;
            this.lblSubblly.Text = "subbly";
            // 
            // lblVolume24
            // 
            this.lblVolume24.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume24.Location = new System.Drawing.Point(187, 9);
            this.lblVolume24.Name = "lblVolume24";
            this.lblVolume24.Size = new System.Drawing.Size(74, 18);
            this.lblVolume24.TabIndex = 5;
            this.lblVolume24.Text = "volume24";
            // 
            // lblMarketcap
            // 
            this.lblMarketcap.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarketcap.Location = new System.Drawing.Point(4, 9);
            this.lblMarketcap.Name = "lblMarketcap";
            this.lblMarketcap.Size = new System.Drawing.Size(79, 18);
            this.lblMarketcap.TabIndex = 4;
            this.lblMarketcap.Text = "Marketcap";
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "Chameleon";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(27, 273);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteName = "Metro";
            series1.Name = "Price";
            areaSeriesView1.Transparency = ((byte)(0));
            series1.View = areaSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            areaSeriesView2.Transparency = ((byte)(0));
            this.chartControl1.SeriesTemplate.View = areaSeriesView2;
            this.chartControl1.Size = new System.Drawing.Size(1096, 441);
            this.chartControl1.TabIndex = 9;
            // 
            // lblBieudo
            // 
            this.lblBieudo.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBieudo.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblBieudo.Location = new System.Drawing.Point(435, 242);
            this.lblBieudo.Name = "lblBieudo";
            this.lblBieudo.Size = new System.Drawing.Size(155, 25);
            this.lblBieudo.TabIndex = 12;
            this.lblBieudo.Text = "bieudothaydoi ";
            // 
            // btnHuyUaThich
            // 
            this.btnHuyUaThich.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyUaThich.Image")));
            this.btnHuyUaThich.Location = new System.Drawing.Point(923, 102);
            this.btnHuyUaThich.Name = "btnHuyUaThich";
            this.btnHuyUaThich.Size = new System.Drawing.Size(200, 33);
            this.btnHuyUaThich.TabIndex = 11;
            this.btnHuyUaThich.Text = "Hủy ưa thích";
            this.btnHuyUaThich.Click += new System.EventHandler(this.btnHuyUaThich_Click);
            // 
            // btnThemUaThich
            // 
            this.btnThemUaThich.Image = ((System.Drawing.Image)(resources.GetObject("btnThemUaThich.Image")));
            this.btnThemUaThich.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnThemUaThich.Location = new System.Drawing.Point(923, 37);
            this.btnThemUaThich.Name = "btnThemUaThich";
            this.btnThemUaThich.Size = new System.Drawing.Size(200, 39);
            this.btnThemUaThich.TabIndex = 10;
            this.btnThemUaThich.Text = "Thêm vào danh sách ưa thích ";
            this.btnThemUaThich.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pBDongcoin
            // 
            this.pBDongcoin.Location = new System.Drawing.Point(46, 77);
            this.pBDongcoin.Name = "pBDongcoin";
            this.pBDongcoin.Size = new System.Drawing.Size(136, 134);
            this.pBDongcoin.TabIndex = 1;
            this.pBDongcoin.TabStop = false;
            // 
            // btnTrolai
            // 
            this.btnTrolai.Image = ((System.Drawing.Image)(resources.GetObject("btnTrolai.Image")));
            this.btnTrolai.Location = new System.Drawing.Point(46, 12);
            this.btnTrolai.Name = "btnTrolai";
            this.btnTrolai.Size = new System.Drawing.Size(75, 45);
            this.btnTrolai.TabIndex = 0;
            this.btnTrolai.Text = "Thoát";
            this.btnTrolai.Click += new System.EventHandler(this.btnTrolai_Click);
            // 
            // frmChiTietDongCoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 728);
            this.Controls.Add(this.lblBieudo);
            this.Controls.Add(this.btnHuyUaThich);
            this.Controls.Add(this.btnThemUaThich);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBDongcoin);
            this.Controls.Add(this.btnTrolai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChiTietDongCoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChiTietDongCoin";
            this.Load += new System.EventHandler(this.frmChiTietDongCoin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDongcoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTrolai;
        private System.Windows.Forms.PictureBox pBDongcoin;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblSymBol;
        private DevExpress.XtraEditors.LabelControl lblNamecoin;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblChange24h;
        private DevExpress.XtraEditors.LabelControl lblPrice;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl lblSubblly;
        private DevExpress.XtraEditors.LabelControl lblVolume24;
        private DevExpress.XtraEditors.LabelControl lblMarketcap;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuyUaThich;
        private DevExpress.XtraEditors.SimpleButton btnThemUaThich;
        private DevExpress.XtraEditors.LabelControl lblBieudo;
    }
}