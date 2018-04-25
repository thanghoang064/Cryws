using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
using System.IO;
using Codeplex.Data;

namespace Cryws
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            lblUser.Text = Program.taikhoan;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {

            string matkhaucu = txtMatkhaucu.Text;
            string matkhaumoi = txtMatKhauMoi.Text;
            string xnmatkhau = txtXacNhanMatKhau.Text;
            if(matkhaucu.Equals(""))
            {
                MessageBox.Show("Mật khẩu cũ không được bỏ trống", "Chú ý",
      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (matkhaumoi.Equals(""))
            {
                MessageBox.Show("Mật khẩu mới không được bỏ trống", "Chú ý",
      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (xnmatkhau.Equals(""))
            {
                MessageBox.Show("xác nhận mật khẩu không được bỏ trống", "Chú ý",
      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!matkhaucu.Equals(Program.matkhau))
            {
                MessageBox.Show("Mật khẩu cũ sai", "Chú ý",
      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!matkhaumoi.Equals(xnmatkhau))
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng mật khẩu mới sai", "Chú ý",
      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var webRequest = System.Net.WebRequest.Create("https://cryws.herokuapp.com/api/accounts/password/"+matkhaumoi+"");
                if (webRequest != null)
                {
                    webRequest.Method = "PUT";
                    webRequest.ContentType = "application/json";
                    webRequest.Headers.Add("Authorization", Program.token);

                    using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                        {
                            var jsonResponse = sr.ReadToEnd();


                            var statuses = DynamicJson.Parse(jsonResponse);
                        }
                    }
                }
            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo",
       MessageBoxButtons.OK, MessageBoxIcon.Information);
       Program.matkhau = matkhaumoi;
            this.Dispose();
            
          


        }
    }
}