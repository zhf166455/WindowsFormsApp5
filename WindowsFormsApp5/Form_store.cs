using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form_store : Form
    {
        public Form_store()
        {
            InitializeComponent();
        }

        private void Form_store_Load(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;
            uiDatePicker_s.Value = now;
            uiDatePicker_e.Value = now;
            init_grid();
        }
        private void init_grid()
        {
            grid_store.AutoRedraw = false;
            grid_store.Rows = 3;
            grid_store.Range(0, 1, 2, 8).Locked = false;
            grid_store.Range(0, 1, 2, 8).ClearAll();

            grid_store.Column(0).Width = 10;
            grid_store.Column(1).Width = 220;
            grid_store.Column(2).Width = 150;
            grid_store.Column(3).Width = 200;
            grid_store.Column(4).Width = 200;
            grid_store.Column(5).Width = 140;
            grid_store.Column(6).Width = 200;
            grid_store.Column(7).Width = 80;
            grid_store.Column(8).Width = 80;

            grid_store.Cell(0, 1).Text = "商品编码";
            grid_store.Cell(0, 2).Text = "类别";
            grid_store.Cell(0, 3).Text = "商品名称";
            grid_store.Cell(0, 4).Text = "别名";
            grid_store.Cell(0, 5).Text = "颜色";
            grid_store.Cell(0, 6).Text = "条码";
            grid_store.Cell(0, 7).Text = "库存";
            grid_store.Cell(0, 8).Text = "销量";

            grid_store.Range(0, 1, 2, 8).Locked = true;
            grid_store.AutoRedraw = true;
            grid_store.Refresh();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string rel;
            if(uiRadioButton_spc.Checked)
            {
                rel = Util.httpget("/special/num", Util.G_token);
            }
            else
            {
                rel = Util.httpget("/normal/num", Util.G_token);
            }

            JObject job = (JObject)JsonConvert.DeserializeObject(rel);

            int code = ((int)job["code"]);
            string msg = ((string)job["msg"]);
            if (code == -1)
            {
                MessageBox.Show(msg);
            }
            else
            {
                int n = job["items"].Count();
                init_grid();
                if (n > 0)
                {
                    grid_store.Locked = false;
                    grid_store.AutoRedraw = false;

                    grid_store.InsertRow(1, n - 1);
                    grid_store.AutoRedraw = false;
                    for (int i = 0;i<n;i++)
                    {
                        string cid = job["items"][i]["custom_id"].ToString();
                        string cla = job["items"][i]["class"].ToString();
                        string color = job["items"][i]["color"].ToString();
                        string pro_code = job["items"][i]["pro_code"].ToString();
                        int snum = (int)job["items"][i]["num"];
                        string pro_name = job["items"][i]["pro_name"].ToString();
                        string pro_oname = (string)job["items"][i]["pro_oname"];
                        int num = 999;

                        grid_store.Cell(i + 1, 1).Text = cid;
                        grid_store.Cell(i + 1, 2).Text = cla;
                        grid_store.Cell(i + 1, 3).Text = pro_name;
                        grid_store.Cell(i + 1, 4).Text = pro_oname;
                        grid_store.Cell(i + 1, 5).Text = color;
                        grid_store.Cell(i + 1, 6).Text = pro_code;
                        grid_store.Cell(i + 1, 7).Text = snum.ToString();
                        grid_store.Cell(i + 1, 8).Text = num.ToString();

                    }

                    grid_store.Locked = true;
                    grid_store.AutoRedraw = true;
                    grid_store.Refresh ();
                }
            }
        }
    }
}
