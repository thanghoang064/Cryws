namespace Cryws
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTrangThonTinCoin = new DevExpress.XtraBars.BarButtonItem();
            this.bhiTrangThai = new DevExpress.XtraBars.BarHeaderItem();
            this.btnDanhMucUuThich = new DevExpress.XtraBars.BarButtonItem();
            this.btnUuThich = new DevExpress.XtraBars.BarButtonItem();
            this.btnThayDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ribbon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ribbon.BackgroundImage")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnTrangThonTinCoin,
            this.bhiTrangThai,
            this.btnDanhMucUuThich,
            this.btnUuThich,
            this.btnThayDoiMatKhau,
            this.btnDangXuat});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(974, 147);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnTrangThonTinCoin
            // 
            this.btnTrangThonTinCoin.Caption = "Thông tin \r\ncoin";
            this.btnTrangThonTinCoin.Id = 1;
            this.btnTrangThonTinCoin.ImageUri.Uri = "Currency";
            this.btnTrangThonTinCoin.Name = "btnTrangThonTinCoin";
            this.btnTrangThonTinCoin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrangThonTinCoin_ItemClick);
            // 
            // bhiTrangThai
            // 
            this.bhiTrangThai.Id = 2;
            this.bhiTrangThai.Name = "bhiTrangThai";
            // 
            // btnDanhMucUuThich
            // 
            this.btnDanhMucUuThich.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnDanhMucUuThich.Caption = "Danh mục ưu thích";
            this.btnDanhMucUuThich.Id = 3;
            this.btnDanhMucUuThich.ImageUri.Uri = "Close";
            this.btnDanhMucUuThich.Name = "btnDanhMucUuThich";
            // 
            // btnUuThich
            // 
            this.btnUuThich.Caption = "Danh mục ưu thích";
            this.btnUuThich.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUuThich.Glyph")));
            this.btnUuThich.Id = 4;
            this.btnUuThich.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnUuThich.LargeGlyph")));
            this.btnUuThich.Name = "btnUuThich";
            this.btnUuThich.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUuThich_ItemClick);
            // 
            // btnThayDoiMatKhau
            // 
            this.btnThayDoiMatKhau.Caption = "Thay đổi mật khẩu";
            this.btnThayDoiMatKhau.Id = 8;
            this.btnThayDoiMatKhau.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThayDoiMatKhau.LargeGlyph")));
            this.btnThayDoiMatKhau.Name = "btnThayDoiMatKhau";
            this.btnThayDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThayDoiMatKhau_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 10;
            this.btnDangXuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.LargeGlyph")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTrangThonTinCoin);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUuThich);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThayDoiMatKhau);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bhiTrangThai);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 426);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(974, 23);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnTrangThonTinCoin;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarHeaderItem bhiTrangThai;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btnDanhMucUuThich;
        private DevExpress.XtraBars.BarButtonItem btnUuThich;
        private DevExpress.XtraBars.BarButtonItem btnThayDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}