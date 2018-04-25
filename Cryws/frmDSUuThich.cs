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
using Codeplex.Data;
using System.Net;
using System.IO;
using System.Threading;

namespace Cryws
{
    public partial class frmDSUuThich : DevExpress.XtraEditors.XtraForm
    {
        public frmDSUuThich()
        {
            InitializeComponent();
        }
        List<string> list;
        public frmChiTietDongCoin frmct;
        public void LoadducoinThemTen()
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
            string url = "https://cryws.herokuapp.com/api/coins/tiny";

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


                //  MessageBox.Show(status1 + ""+ status.sb);
                foreach (string prime in list)
                {
                    if (prime.Equals(status.sb.ToString()))
                    {
                        t.Rows.Add(new object[] { count1, b, status.nm, status.sb, status.mc, status.pr, status.c01, status.c24, "https://cryws.herokuapp.com/res/coins_high/16/color/" + status.sb + ".png" });
                        break;
                    }

                }
                count1++;

              
                                   
                        
                

               
            }
         gvDSUuThich.DataSource = t;

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
           gvDSUuThich.Columns["uri"].Visible = false;
          
        }
        public void Laydanhsachuathich()
        {
            ThreadPool.QueueUserWorkItem(delegate
            {
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


                            var statuses1 = DynamicJson.Parse(jsonResponse);
                            int index = 0;
                            foreach (var status1 in statuses1.favorites)
                            {
                                list.Add(status1);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            });
            //   gvDSUuThich.DataSource = t;
        }
            public void TenBang()
        {
            gvDSUuThich.Columns[0].HeaderText = "#";
            gvDSUuThich.Columns[1].HeaderText = "";
            gvDSUuThich.Columns[2].HeaderText = "Tên đồng tiền";
            gvDSUuThich.Columns[3].HeaderText = "Kí hiệu";
            gvDSUuThich.Columns[4].HeaderText = "Vốn hóa thị trường($)";
            gvDSUuThich.Columns[5].HeaderText = "Giá trị($)";
            gvDSUuThich.Columns[6].HeaderText = "Thay đổi sau 1h(%)";
            gvDSUuThich.Columns[7].HeaderText = "Thay đổi sau 24h(%)";
            gvDSUuThich.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 14, FontStyle.Bold);
            gvDSUuThich.Columns[2].HeaderCell.Style.Font = new Font("Tahoma",14, FontStyle.Bold);
            gvDSUuThich.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 14, FontStyle.Bold);
            gvDSUuThich.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 14, FontStyle.Bold);
            gvDSUuThich.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 14, FontStyle.Bold);
            gvDSUuThich.Columns[6].HeaderCell.Style.Font = new Font("Tahoma", 14, FontStyle.Bold);
            gvDSUuThich.Columns[7].HeaderCell.Style.Font = new Font("Tahoma", 14, FontStyle.Bold);
            this.gvDSUuThich.DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gvDSUuThich.Columns["#"].Width = 45;
            gvDSUuThich.Columns["KH"].Width = 20;
            gvDSUuThich.Columns["NAME"].Width = 175;
            gvDSUuThich.Columns["GIATRIVONHOA"].Width = 200;
            gvDSUuThich.Columns["GIA"].Width = 175;
            gvDSUuThich.Columns["CHANGE1h"].Width = 200;
            gvDSUuThich.Columns["CHANGE24h"].Width = 200;
            gvDSUuThich.Columns[3].DefaultCellStyle.ForeColor = Color.SkyBlue;
            gvDSUuThich.Columns[4].DefaultCellStyle.ForeColor = Color.SkyBlue;
            //gvDSUuThich.= Color.LightSkyBlue;
            gvDSUuThich.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            gvDSUuThich.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gvDSUuThich.EnableHeadersVisualStyles = false;

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
        private void frmDSUuThich_Load(object sender, EventArgs e)
        {
            if(Demds()==0)
            {
                MessageBox.Show("Chưa có coin ưa thích", "Chú ý",
       MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvDSUuThich.DataSource = null;
                return;
            }
            
            list = new List<string>();
            Laydanhsachuathich();
            LoadducoinThemTen();
            TenBang();
       
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            frmDSUuThich_Load(sender, e);
        }

        private void gvDSUuThich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (frmct == null || frmct.IsDisposed)
            {
                frmct = new frmChiTietDongCoin();
                //int dong = tblDatHang.CurrentRow.Index;
                frmct.GetDataGridView = gvDSUuThich;
                frmct.Show();
            }
            else
            {
                return;
            }
        }

        private void gvDSUuThich_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < (gvDSUuThich.RowCount - 1); i++)
            {
                float kt = float.Parse(gvDSUuThich.Rows[i].Cells[7].Value.ToString());
                float kt1 = float.Parse(gvDSUuThich.Rows[i].Cells[6].Value.ToString());
                if (kt < 0)
                {
                    gvDSUuThich.Rows[i].Cells[7].Style = new DataGridViewCellStyle { ForeColor = Color.Red };

                }
                else
                {
                    gvDSUuThich.Rows[i].Cells[7].Style = new DataGridViewCellStyle { ForeColor = Color.Green };
                }
                if (kt1 < 0)
                {
                    gvDSUuThich.Rows[i].Cells[6].Style = new DataGridViewCellStyle { ForeColor = Color.Red };

                }
                else
                {
                    gvDSUuThich.Rows[i].Cells[6].Style = new DataGridViewCellStyle { ForeColor = Color.Green };
                }

            }
        }
    }
}