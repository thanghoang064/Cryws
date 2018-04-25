using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Threading;

namespace Cryws
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        void SaveData()
        {
            for (int i = 0; i <= 1000; i++)
                Thread.Sleep(50);
        }
        private void btnTrangThonTinCoin_ItemClick(object sender, ItemClickEventArgs e)
        {
            
         
            Form frm = this.CheckExists(typeof(frmThongTinCoin));           
            if (frm != null) frm.Activate();
            else
            {
               
                frmThongTinCoin f = new frmThongTinCoin();
                    f.MdiParent = this;
                    f.Show();               
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void btnUuThich_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDSUuThich));
            if (frm != null) frm.Activate();
            else
            {

                frmDSUuThich f = new frmDSUuThich();
                f.MdiParent = this;
                f.Show();




            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn đăng xuất không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Program.token = "";
                Program.taikhoan = "";
                Program.matkhau = "";
                Form1 frm = new Form1();
                frm.Show();
                
            }
            else
            {
                //xử lí khác
            }
            
        }

        private void btnThayDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDoiMatKhau));
            if (frm != null) frm.Activate();
            else
            {

                frmDoiMatKhau f = new frmDoiMatKhau();
                f.MdiParent = this;
                f.Show();




            }
        }
    }
}