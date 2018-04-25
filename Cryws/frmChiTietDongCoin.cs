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
using System.Windows.Forms.DataVisualization.Charting;
using DevExpress.XtraCharts;
using System.Collections;

namespace Cryws
{
    public partial class frmChiTietDongCoin : DevExpress.XtraEditors.XtraForm
    {
        public DataGridView GetDataGridView { get; set; }
        public int count=0;
        public int flag = 0;
        public frmChiTietDongCoin()
        {
            InitializeComponent();
        }
       
        private void frmChiTietDongCoin_Load(object sender, EventArgs e)
        {
          
            LoadChiTietCoin();
         

        }
        public static DateTime UnixTimestampToDateTime(double unixTime)
        {
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            long unixTimeStampInTicks = (long)(unixTime * TimeSpan.TicksPerSecond);
            return new DateTime(unixStart.Ticks + unixTimeStampInTicks, System.DateTimeKind.Utc);
        }
     
        public void vebieudoPrice(string sym)
        {          
            var publicTL = new WebClient().DownloadString(@"https://cryws.herokuapp.com/api/coins/chart7days/"+sym+"");
         //   string concac = "";
            int index = 0;
            int i = 0;
            ArrayList listDataSource = new ArrayList();
            var statuses = DynamicJson.Parse(publicTL);
            foreach (var status in statuses)
            {

                foreach (var n in status.max7days_values)
                {
                    dynamic nValues = n.GetType().GetProperty("Value").GetValue(n, null);
                    chartControl1.Series["Price"].Points.Add(new SeriesPoint(UnixTimestampToDateTime(nValues.timeStamp), nValues.price.ToString()));   
                    index++;
                }


            }
      
        }
      
        public void LoadHinhAnhCoin(string tenDongCoin)
        {
           
            var request = WebRequest.Create("https://cryws.herokuapp.com/res/coins_high/128/icon/"+tenDongCoin+".png");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pBDongcoin.Image = Bitmap.FromStream(stream);
            }
        }
        public void LoadTenCoinvaKiTu(string name,string kitu,float price,float change24h)
        {
            lblNamecoin.Text = name;
            lblSymBol.Text = "(" + kitu + ")";
            lblPrice.Text = price+" USD";
            lblChange24h.Text = "(" + change24h + "%)";
            lblBieudo.Text = "Biểu đồ thay đổi trị giá " + name + " trong 7 ngày"; 
            if(change24h>=0)
            {
                lblChange24h.ForeColor = Color.Green;
            }
            else
            {
                lblChange24h.ForeColor = Color.Red;
            }
        }
        public void LoadChitietThongTin(string sym)
        {
            string url = "https://cryws.herokuapp.com/api/coins/nonchart/"+sym+"";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = WebRequestMethods.Http.Get;
            httpWebRequest.Accept = "text/json";

            HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
            var streamReader = new StreamReader(response.GetResponseStream());
            var result = streamReader.ReadToEnd();
            var statuses = DynamicJson.Parse(result);
            foreach(var status in statuses)
            {
                lblMarketcap.Text = status.last_values.marketcap+" USD";
                lblVolume24.Text = status.last_values.volume24 + " USD";
                lblSubblly.Text = status.available_supply;
            }
        }
        public void LoadChiTietCoin()
        {
            
    
            int dong = GetDataGridView.CurrentRow.Index;
            string tenDongCoin = GetDataGridView.Rows[dong].Cells[3].Value.ToString();
            string Kihieu = GetDataGridView.Rows[dong].Cells[2].Value.ToString();
            float gia = float.Parse(GetDataGridView.Rows[dong].Cells[5].Value.ToString());
            float thaydoi24h = float.Parse(GetDataGridView.Rows[dong].Cells[7].Value.ToString());
            LoadHinhAnhCoin(tenDongCoin);
           LoadTenCoinvaKiTu(Kihieu, tenDongCoin,gia,thaydoi24h);
            LoadChitietThongTin(tenDongCoin);
            vebieudoPrice(tenDongCoin);
            Laydanhsachuathich(tenDongCoin);
            //KiemTradsuuthich();
        }

        private void btnTrolai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Laydanhsachuathich(string sym)
        {
            this.ShowInTaskbar = false;
            try
            {
                var webRequest = System.Net.WebRequest.Create("https://cryws.herokuapp.com/api/accounts/favorites");
                if (webRequest != null)
                {
                    webRequest.Method = "GET";
                    webRequest.ContentType = "application/json";
                    webRequest.Headers.Add("Authorization", Program.token);

                    using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                        {
                            var jsonResponse = sr.ReadToEnd();

                           
                            var statuses = DynamicJson.Parse(jsonResponse);
                            int index = 0;
             
                            if (Demds() == 0)
                            {
                                if (flag == 0)
                                {
                                    btnThemUaThich.Enabled = true;
                                    btnHuyUaThich.Enabled = false;
                                    return;
                                }
                                if (flag == 1)
                                {
                                    btnThemUaThich.Enabled = false;
                                    btnHuyUaThich.Enabled = true;
                                    return;
                                }
                                if (flag == 2)
                                {
                                    btnThemUaThich.Enabled = true;
                                    btnHuyUaThich.Enabled = false;
                                    return;
                                }

                            }
                        
                       

                            foreach (var status in statuses.favorites)
                            {
                              

                                if (sym.Equals(status))
                                {
                                   
                                    btnThemUaThich.Enabled = false;
                                    btnHuyUaThich.Enabled = true;
                                    break;
                                }
                              else 
                                {
                                    btnThemUaThich.Enabled = true;
                                    btnHuyUaThich.Enabled = false;
                                }
                                index++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public int Demds()
        {
            int a = 0;
            var webRequest = System.Net.WebRequest.Create("https://cryws.herokuapp.com/api/accounts/favorites");
                if (webRequest != null)
                {
                    webRequest.Method = "GET";
                    webRequest.ContentType = "application/json";
                    webRequest.Headers.Add("Authorization", Program.token);

                    using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                        {
                            var jsonResponse = sr.ReadToEnd();


                            var statuses = DynamicJson.Parse(jsonResponse);
                               

                            foreach (var status in statuses.favorites)
                            {
                               
                            
                                a++;
                          
                            }
                            
                        }
                    }
                }
            return a;

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm đồng coin này vào danh sách ưu thích không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                   flag = 1;
            int dong = GetDataGridView.CurrentRow.Index;
            string kihieu = GetDataGridView.Rows[dong].Cells[3].Value.ToString();
        
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://cryws.herokuapp.com/api/accounts/favorites");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Authorization", Program.token);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"favorites\":["+"\""+kihieu+"\"]}";
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();


            }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                var streamReader = new StreamReader(httpResponse.GetResponseStream());
                var result = streamReader.ReadToEnd();
                var statuses = DynamicJson.Parse(result);
                MessageBox.Show("Thêm vào danh sách ưu thích thành công");
                frmChiTietDongCoin_Load(sender, e);

            }
            else
            {
                //xử lí khác
            }
        



      


        }

        private void btnHuyUaThich_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có bỏ đồng này khỏi danh sách ưu thích  không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                flag = 2;
                int dong = GetDataGridView.CurrentRow.Index;
                string kihieu = GetDataGridView.Rows[dong].Cells[3].Value.ToString();

                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://cryws.herokuapp.com/api/accounts/favorites/" + kihieu + "");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "DELETE";
                httpWebRequest.Headers.Add("Authorization", Program.token);

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                var streamReader = new StreamReader(httpResponse.GetResponseStream());
                var result = streamReader.ReadToEnd();
                var statuses = DynamicJson.Parse(result);

                MessageBox.Show("Đã hủy trong danh sách ưu thích");

                frmChiTietDongCoin_Load(sender, e);
            }
            else
            {

            }

        }

        private void cmbChonGiaTri_SelectedIndexChanged(object sender, EventArgs e)
        {
        

        }
    }
}