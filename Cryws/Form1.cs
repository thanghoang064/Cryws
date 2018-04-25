using Codeplex.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace Cryws
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {

            InitializeComponent();
        }
        public class Dangnhap
        {
            public String sucess { get; set; }
            public String token { get; set; }

        }
        public frmDangKy frmdk;
        public string get_web_content(string url)
        {
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
            request.Method = WebRequestMethods.Http.Get;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string output = reader.ReadToEnd();
            response.Close();

            return output;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://cryws.herokuapp.com/api/accounts/login");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                string tendangnhap = txtTenDN.Text.Trim();
                string pass = txtMatKhau.Text.Trim();
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
                    Program.token = statuses.token;
                    Program.taikhoan = txtTenDN.Text;
                    Program.matkhau = txtMatKhau.Text;
                    if (statuses.success == true)
                    {

                        MessageBox.Show("Đăng nhập thành công", "Thông báo",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.SetVisibleCore(false);

                        frmMain frm = new frmMain();
                        frm.Show();

                    }
                } catch (WebException)
                {
                    MessageBox.Show("Sai tên  tài khoản hoặc mật khẩu vui lòng kiểm tra lại !", "Chú ý",
          MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (WebException)
            {
                MessageBox.Show("Không có kết nối tới server vui lòng kiểm tra lại kết nối internet !", "Chú ý",
         MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void SaveData()
        {
            for (int i = 0; i <= 500; i++)
                Thread.Sleep(10);
        }
        public static DateTime UnixTimestampToDateTime(double unixTime)
        {
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            long unixTimeStampInTicks = (long)(unixTime * TimeSpan.TicksPerSecond);
            return new DateTime(unixStart.Ticks + unixTimeStampInTicks, System.DateTimeKind.Utc);
        }
        private void btnDangKi_Click(object sender, EventArgs e)
        {

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://x2bdev.com/api/article");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                /* string json = "{\"username\":" + "\"" + tendangnhap + "\"" + "," +
                               "\"password\":" + "\"" + pass + "\"" + "}";*/
                string nana = "{\"name\":\"NANA\"," +
                                             "\"type\": \"Hành Động, Phiêu Lưu\"," +
                                             "\"running_time\":\"111 \"," +
                                             "\"release_date\": \"2018-03-23 00:00:00\"," +
                                             "\"image\": \"https://i.imgur.com/2E63FPF.jpg\"," +
                                             "\"youtube\":\"8BAhwgjMvnM\"," +
                                             "\"director\": \"Steven S. DeKnight\"," +
                                             "\"cast\": \"John Boyega, Scott Eastwood, Jing Tian, Cailee Spaeny, Rinko Kikuchi, Burn Gorman, Adria Arjona, Charlie Day\"," +
                                             "\"content\": \"Lấy bối cảnh 10 năm sau những sự kiện đã diễn ra ở phần 1, Jake Pentecost – truyền nhân duy nhất của huyền thoại Stacker Pentecost đã thực hiện lời hứa với cha mình, gia nhập nhóm người điều khiển Jaeger gồm có Lambert (Scott Eastwood) và Amara chỉ mới 15 tuổi (Cailee Spaeny), cùng nhau xây dựng nên một chiến tuyến chống lại Kaiju. Cuộc xung đột toàn cầu kéo dài giữa những quái vật âm mưu phá hủy thế giới và những robot khổng lồ do con người chế tạo ra nhằm đánh bại lũ quái vật hứa hẹn sẽ là một cuộc chiến cam go và kịch tính khi lũ quái vật giờ đây đã tiến hóa vượt bậc cả về thể lực và trí lực.\"}";

              //  MessageBox.Show(nana);
               
                streamWriter.Write(nana);
                streamWriter.Flush();
                streamWriter.Close();


            }
            try
            {
                
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    var streamReader = new StreamReader(httpResponse.GetResponseStream());
                    var result = streamReader.ReadToEnd();
                    MessageBox.Show(result + "");
                
            }
            catch (WebException)
            {
                MessageBox.Show("Sai tên  tài khoản hoặc mật khẩu vui lòng kiểm tra lại !", "Chú ý",
      MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        /*if (frmdk == null || frmdk.IsDisposed)
        {
            frmdk = new frmDangKy();
            //int dong = tblDatHang.CurrentRow.Index;
            frmdk.Show();
        }
        else
        {
            return;
        }


        /*   MessageBox.Show("Some text", "Some title",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
     */
        /*   using (StreamWriter writetext = new StreamWriter("write.txt"))
           {
               writetext.WriteLine("5");
           }*/




        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tggs_Toggled(object sender, EventArgs e)
        {
          
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
