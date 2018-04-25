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
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://cryws.herokuapp.com/api/accounts/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            string tendangnhap = txtTenTaiKhoan.Text.Trim();
            string pass = txtMatKhau.Text.Trim();
            string cfmpass = txtXacNhanMatKah.Text.Trim();

            if (tendangnhap.Equals(""))
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống", "Chú ý",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pass.Equals(""))
            {
                MessageBox.Show("Mập khẩu không được bỏ trống", "Chú ý",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cfmpass.Equals(""))
            {
                MessageBox.Show("Xác nhận mật khẩu không được bỏ trống", "Chú ý",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!cfmpass.Equals(pass))
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng với mật khẩu ", "Chú ý",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"username\":" + "\"" + tendangnhap + "\"" + "," +
                              "\"password\":" + "\"" + pass + "\"" + "}";


                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();


            }


          

            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                var streamReader = new StreamReader(httpResponse.GetResponseStream());
                var result = streamReader.ReadToEnd();
                var statuses = DynamicJson.Parse(result);
           
                if (statuses.success == true)
                {

                    MessageBox.Show("Đăng ki thành công", "Thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
             
                }
            }
            catch (WebException we)
            {
               int a = int.Parse(((HttpWebResponse)we.Response).StatusCode.ToString());
                if (a == 422)
                {
                    MessageBox.Show("Đăng kí không thành công tài khoản đã tồn tại !", "Chú ý",
          MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}