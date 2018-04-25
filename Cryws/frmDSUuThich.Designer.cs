namespace Cryws
{
    partial class frmDSUuThich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSUuThich));
            this.gvDSUuThich = new System.Windows.Forms.DataGridView();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnReLoad = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSUuThich)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDSUuThich
            // 
            this.gvDSUuThich.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvDSUuThich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDSUuThich.Location = new System.Drawing.Point(129, 113);
            this.gvDSUuThich.Name = "gvDSUuThich";
            this.gvDSUuThich.Size = new System.Drawing.Size(1157, 235);
            this.gvDSUuThich.TabIndex = 0;
            this.gvDSUuThich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDSUuThich_CellClick);
            this.gvDSUuThich.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvDSUuThich_CellFormatting);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // btnReLoad
            // 
            this.btnReLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.Appearance.Options.UseFont = true;
            this.btnReLoad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnReLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnReLoad.Image")));
            this.btnReLoad.Location = new System.Drawing.Point(129, 71);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(90, 36);
            this.btnReLoad.TabIndex = 1;
            this.btnReLoad.Text = "Reload";
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Location = new System.Drawing.Point(445, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(454, 29);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "DANH SÁCH COIN ƯU THÍCH CỦA TÔI";
            // 
            // frmDSUuThich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1298, 457);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.gvDSUuThich);
            this.Name = "frmDSUuThich";
            this.Text = "Danh Sách Ưu Thích";
            this.Load += new System.EventHandler(this.frmDSUuThich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDSUuThich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDSUuThich;
        private DevExpress.XtraEditors.SimpleButton btnReLoad;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}