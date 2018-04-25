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
using Codeplex.Data;
using PagedList;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace Cryws
{
    public partial class frmThongTinCoin : DevExpress.XtraEditors.XtraForm
    {
        int pageNumBer = 0;
        int pageEnd = 10;
        int count = 0;
        int limit = 20;
        int record = 0;
      public frmChiTietDongCoin frmct;
        //    float a = (count / 10);
        public frmThongTinCoin()
        {
            InitializeComponent();
        }
        public  DataTable Taianhlen(int batdau,int ketthuc)
        {
            DataTable t = new DataTable();
            t.Columns.Add(new DataColumn("#", typeof(int)));
            t.Columns.Add(new DataColumn("KH", typeof(Bitmap)));
            t.Columns.Add(new DataColumn("NAME", typeof(string)));
            t.Columns.Add(new DataColumn("SYMBOL", typeof(string)));
            t.Columns.Add(new DataColumn("GIATRIVONHOA", typeof(string)));
              t.Columns.Add(new DataColumn("GIA", typeof(string)));
              t.Columns.Add(new DataColumn("CHANGE1h", typeof(string)));
           t.Columns.Add(new DataColumn("CHANGE24h", typeof(string)));

            var publicTL = new WebClient().DownloadString(@"https://cryws.herokuapp.com/api/coins/tiny");
            var statuses = DynamicJson.Parse(publicTL);
            string chuoilink = "";
         count = batdau;
            foreach (var status in statuses)
            {
               
                chuoilink = "https://cryws.herokuapp.com/res/coins/"+ statuses[count].sb + ".png";
                WebRequest request = WebRequest.Create(chuoilink);
                using (var response = request.GetResponse()) //Tries to access the object
                {
                    using (var str = response.GetResponseStream()) //Returns the metadata of the image
                    {
                        var image = Bitmap.FromStream(str);
                     
                        t.Rows.Add(new object[] {count+1, image,statuses[count].nm, statuses[count].mc,statuses[count].pr, statuses[count].c01, statuses[count].c24 });
                        
                    }
                }
              
                count++;
                
            if (count == ketthuc) break;
            }
            //         MessageBox.Show(count + "");
          
            return t;
        }
     
        public int soPhanTuCoin()
        {
            int dem = 0;
            var publicTL = new WebClient().DownloadString(@"https://cryws.herokuapp.com/api/coins/tiny");
            var statuses = DynamicJson.Parse(publicTL);
            foreach (var status in statuses)
            {
                dem++;
            }
                return dem;
        }
        public int lamtroncount(int count)
        {
            int a=0;
            if (count % limit == 0)
            {
               a = count/limit;
            }
            else
            {
                a = (count/limit) + 1;
            }

            return a;

        }

       
        public void HienThi()
        {
                int a = (record / limit) * limit;
             int b = (record / limit + 1) * limit;

                Loadducointrongkhoang(a,b);
            Setnut(record);
         
          lblPagelist.Text = string.Format("Page {0}/{1}", record+1, lamtroncount(soPhanTuCoin()));
        

        }
        public void TenBang()
        {
            gvThongTinCoin.Columns[0].HeaderText = "#";
            gvThongTinCoin.Columns[1].HeaderText = "";
            gvThongTinCoin.Columns[2].HeaderText = "Tên đồng tiền";
            gvThongTinCoin.Columns[3].HeaderText = "Kí hiệu";
            gvThongTinCoin.Columns[4].HeaderText = "Vốn hóa thị trường($)";
            gvThongTinCoin.Columns[5].HeaderText = "Giá trị($)";
            gvThongTinCoin.Columns[6].HeaderText = "Thay đổi sau 1h(%)";
            gvThongTinCoin.Columns[7].HeaderText = "Thay đổi sau 24h(%)";
            gvThongTinCoin.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 14, FontStyle.Bold);
            gvThongTinCoin.Columns[2].HeaderCell.Style.Font = new Font("Tahoma",14, FontStyle.Bold);
            gvThongTinCoin.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 14, FontStyle.Bold);
            gvThongTinCoin.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 14, FontStyle.Bold);
            gvThongTinCoin.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 14, FontStyle.Bold);
            gvThongTinCoin.Columns[6].HeaderCell.Style.Font = new Font("Tahoma", 14, FontStyle.Bold);
            gvThongTinCoin.Columns[7].HeaderCell.Style.Font = new Font("Tahoma", 14, FontStyle.Bold);
            this.gvThongTinCoin.DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gvThongTinCoin.Columns["#"].Width = 45;
            gvThongTinCoin.Columns["KH"].Width = 20;
            gvThongTinCoin.Columns["NAME"].Width = 175;
            gvThongTinCoin.Columns["GIATRIVONHOA"].Width = 200;
            gvThongTinCoin.Columns["GIA"].Width = 175;
            gvThongTinCoin.Columns["CHANGE1h"].Width = 200;
            gvThongTinCoin.Columns["CHANGE24h"].Width = 200;
            gvThongTinCoin.Columns[3].DefaultCellStyle.ForeColor = Color.SkyBlue;
            gvThongTinCoin.Columns[4].DefaultCellStyle.ForeColor = Color.SkyBlue;
            //gvThongTinCoin.= Color.LightSkyBlue;
            gvThongTinCoin.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            gvThongTinCoin.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gvThongTinCoin.EnableHeadersVisualStyles = false;

        }
        public void Rowcounts()
        {
            
            for(int i = 0;i<(gvThongTinCoin.Rows.Count-1);i++)
            {
                float kt = float.Parse(gvThongTinCoin.Rows[i].Cells[6].Value.ToString());

                MessageBox.Show(kt + "");
               
            }
        }
        private void frmThongTinCoin_Load(object sender, EventArgs e)
        {
               HienThi();

           
        }
        public void Annut(int a,int b)
        {
            if(a==b)
            {
                btnNext.Enabled = false;
                
            }
           
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            record++;
            Setnut(record);
            int dem1 = (record * limit);
            Loadducointrongkhoang(dem1, limit);
            lblPagelist.Text = string.Format("Page {0}/{1}", record + 1, lamtroncount(soPhanTuCoin()));
        }
            public void Loadducointrongkhoang(int batdau,int ketthuc)
            {
               
            DataTable t = new DataTable();
                t.Columns.Add(new DataColumn("#", typeof(int)));
                t.Columns.Add(new DataColumn("KH", typeof(Bitmap)));
                t.Columns.Add(new DataColumn("NAME", typeof(string)));
            t.Columns.Add(new DataColumn("SYMBOL", typeof(string)));
            t.Columns.Add(new DataColumn("GIATRIVONHOA", typeof(string)));
                t.Columns.Add(new DataColumn("GIA", typeof(string)));
                t.Columns.Add(new DataColumn("CHANGE1h", typeof(string)));
                t.Columns.Add(new DataColumn("CHANGE24h", typeof(string)));
                t.Columns.Add("uri");
                Bitmap b = new Bitmap(50, 15);
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.DrawString("Loading...", this.Font, new SolidBrush(Color.Black), 0f, 0f);
                }
                string url = "https://cryws.herokuapp.com/api/coins/tiny/offset/"+batdau+"/"+ketthuc+"";
       
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Method = WebRequestMethods.Http.Get;
                httpWebRequest.Accept = "text/json";

                HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
                var streamReader = new StreamReader(response.GetResponseStream());
                var result = streamReader.ReadToEnd();
                var statuses = DynamicJson.Parse(result);
               
            foreach (var status in statuses)
                {
               
                t.Rows.Add(new object[] { batdau + 1, b, status.nm, status.sb, status.mc, status.pr, status.c01, status.c24 , "https://cryws.herokuapp.com/res/coins_high/16/color/" + status.sb + ".png" });
                batdau++;
                }
                gvThongTinCoin.DataSource = t;
        
                ThreadPool.QueueUserWorkItem(delegate
                {
                    foreach (DataRow row in t.Rows)
                    {
                        HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(row["uri"].ToString());
                        myRequest.Method = "GET";
                        HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                        System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(myResponse.GetResponseStream());
                        myResponse.Close();

                        row["KH"] = bmp;
                    }
                });
          
            gvThongTinCoin.Columns["uri"].Visible = false;
                 TenBang();
           
        }
        public void TimkiemCoin(string name)
        {
            //  
            DataTable t = new DataTable();
            t.Columns.Add(new DataColumn("#", typeof(int)));
            t.Columns.Add(new DataColumn("KH", typeof(Bitmap)));
            t.Columns.Add(new DataColumn("NAME", typeof(string)));
            t.Columns.Add(new DataColumn("SYMBOL", typeof(string)));
            t.Columns.Add(new DataColumn("GIATRIVONHOA", typeof(string)));
            t.Columns.Add(new DataColumn("GIA", typeof(string)));
            t.Columns.Add(new DataColumn("CHANGE1h", typeof(string)));
            t.Columns.Add(new DataColumn("CHANGE24h", typeof(string)));
            t.Columns.Add("uri");
            Bitmap b = new Bitmap(50, 15);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.DrawString("Loading...", this.Font, new SolidBrush(Color.Black), 0f, 0f);
            }
            string url = "https://cryws.herokuapp.com/api/coins/tiny/fbyname|" + name + "";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = WebRequestMethods.Http.Get;
            httpWebRequest.Accept = "text/json";

            HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
            var streamReader = new StreamReader(response.GetResponseStream());
            var result = streamReader.ReadToEnd();
            var statuses = DynamicJson.Parse(result);
            int count1 = 0;
            foreach (var status in statuses)
            {

                t.Rows.Add(new object[] { count1 + 1, b, status.nm,status.sb, status.mc, status.pr, status.c01, status.c24, "https://cryws.herokuapp.com/res/coins_high/16/color/" + status.sb + ".png" });
                count1++;
            }
            gvThongTinCoin.DataSource = t;
            ThreadPool.QueueUserWorkItem(delegate
            {
                foreach (DataRow row in t.Rows)
                {
                    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(row["uri"].ToString());
                    myRequest.Method = "GET";
                    HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                    System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(myResponse.GetResponseStream());
                    myResponse.Close();
                    row["KH"] = bmp;
                }
            });
            gvThongTinCoin.Columns["uri"].Visible = false;
            TenBang();
        }
        public void Setnut(int page)
        {
            if(page==0)
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
            }
           else if(page == (lamtroncount(soPhanTuCoin())-1))
            {
                btnPrev.Enabled = true;
                btnNext.Enabled = false;
            }
            else
            {
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }
        }
            private void btnPrev_Click(object sender, EventArgs e)
            { 
            record--;
            Setnut(record);
            int dem1 = (record * limit);
            Loadducointrongkhoang(dem1, limit);
            lblPagelist.Text = string.Format("Page {0}/{1}", record + 1, lamtroncount(soPhanTuCoin()));
             }

            private void gvThongTinCoin_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            {/*
            
                if (gvThongTinCoin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && !string.IsNullOrWhiteSpace(gvThongTinCoin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                {
                    gvThongTinCoin.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = new DataGridViewCellStyle { ForeColor = Color.White, BackColor = Color.Black };

                }
                else
                {
                    gvThongTinCoin.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = gvThongTinCoin.DefaultCellStyle;
                }
              */
           
               
          
            for (int i = 0; i < (gvThongTinCoin.RowCount-1); i++)
                     {
                         float kt = float.Parse(gvThongTinCoin.Rows[i].Cells[7].Value.ToString());
                         float kt1 = float.Parse(gvThongTinCoin.Rows[i].Cells[6].Value.ToString());
                         if (kt < 0)
                         {
                             gvThongTinCoin.Rows[i].Cells[7].Style = new DataGridViewCellStyle { ForeColor = Color.Red };

                         }
                         else
                         {
                             gvThongTinCoin.Rows[i].Cells[7].Style = new DataGridViewCellStyle { ForeColor = Color.Green };
                         }
                         if (kt1 < 0)
                         {
                             gvThongTinCoin.Rows[i].Cells[6].Style = new DataGridViewCellStyle { ForeColor = Color.Red };

                         }
                         else
                         {
                             gvThongTinCoin.Rows[i].Cells[6].Style = new DataGridViewCellStyle { ForeColor = Color.Green};
                         }

                     }
                     //gvThongTinCoin.Rows[5].Cells[6].Style = new DataGridViewCellStyle { ForeColor = Color.Orange, BackColor = Color.Blue };
                    
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tencoin = txtTimKiem.Text;
            TimkiemCoin(tencoin);
            if(tencoin.Equals(""))
            {
                record = 0;
                int a = (record / limit) * limit;
                int b = (record / limit + 1) * limit;
                Loadducointrongkhoang(a, b);
                lblPagelist.Text = string.Format("Page {0}/{1}", record + 1, lamtroncount(soPhanTuCoin()));
            }
        }
    
        private void btnSeach_Click(object sender, EventArgs e)
        {
  
        }

        private void gvThongTinCoin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void gvThongTinCoin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        if (frmct == null || frmct.IsDisposed)
            {
                 frmct = new frmChiTietDongCoin();
                //int dong = tblDatHang.CurrentRow.Index;
                frmct.GetDataGridView = gvThongTinCoin;
                frmct.Show();
            }
            else
            {
                return;
            }
         
        }

        private void swichNightMode_Toggled(object sender, EventArgs e)
        {

        }
    }
}