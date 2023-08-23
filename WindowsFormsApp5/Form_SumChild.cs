using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
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
    public partial class Form_SumChild : Form
    {
        public Form_SumChild()
        {
            InitializeComponent();
        }

        private void Form_SumChild_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            uiDatePicker_s.Value = now;
            uiDatePicker_e.Value = now;
            init_grid();
        }
        private void init_grid()
        {
            grid_sum.AutoRedraw = false;
            grid_sum.Locked = false;
            grid_sum.Rows = 3;
            grid_sum.Range(0, 1, 2, 16).ClearAll();

            grid_sum.Column(0).Width = 10;
            grid_sum.Column(1).Width = 80;
            grid_sum.Column(2).Width = 80;
            grid_sum.Column(3).Width = 120;
            grid_sum.Column(4).Width = 120;
            grid_sum.Column(5).Width = 120;
            grid_sum.Column(6).Width = 120;
            grid_sum.Column(7).Width = 120;
            grid_sum.Column(8).Width = 220;
            grid_sum.Column(9).Width = 120;
            grid_sum.Column(10).Width = 120;
            grid_sum.Column(11).Width = 220;
            grid_sum.Column(12).Width = 120;
            grid_sum.Column(13).Width = 100;
            grid_sum.Column(14).Width = 100;
            grid_sum.Column(15).Width = 100;
            grid_sum.Column(16).Width = 100;

            grid_sum.Cell(0, 1).Text = "过账";
            grid_sum.Cell(0, 2).Text = "核销";
            grid_sum.Cell(0, 3).Text = "营业部";
            grid_sum.Cell(0, 4).Text = "单据类型";
            grid_sum.Cell(0, 5).Text = "单据编号";
            grid_sum.Cell(0, 6).Text = "单据日期";
            grid_sum.Cell(0, 7).Text = "制单时间";
            grid_sum.Cell(0, 8).Text = "供应商";
            grid_sum.Cell(0, 9).Text = "商品编码";
            grid_sum.Cell(0, 10).Text = "类别";
            grid_sum.Cell(0, 11).Text = "商品名称";
            grid_sum.Cell(0, 12).Text = "别名";
            grid_sum.Cell(0, 13).Text = "颜色";
            grid_sum.Cell(0, 14).Text = "条码";
            grid_sum.Cell(0, 15).Text = "数量";
            grid_sum.Cell(0, 16).Text = "单价";

            grid_sum.Locked = true;
            grid_sum.AutoRedraw = true;
            grid_sum.Refresh();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string st=uiDatePicker_s.Value.Date.ToString("yyyy-MM-dd");
            string et = uiDatePicker_e.Value.Date.ToString("yyyy-MM-dd");

            //TODO
            string pram = "?day_start=" + st + "&day_end=" + et + "&type=" + "CG";
            string rel = Util.httpget("/summary/v2/get"+ pram, Util.G_token);
            JObject job = (JObject)JsonConvert.DeserializeObject(rel);

            // 访问解析后的JSON数据
            int code = ((int)job["code"]);
            string msg = ((string)job["msg"]);
            if (code == -1)
            {
                MessageBox.Show(msg);
            }
            else
            {
                string cid = "";
                string type = "";
                string order_id = "";
                string doc_time = "";
                string trans = "";
                string creator = "";
                string creator_time = "";
                string posted = "";
                string posted_time = "";
                string note = "";
                string client_custom_id = "";
                string client_name = "";
                string client_classname = "";
                string pc_custom_id = "";
                string pc_color = "";
                string pc_code = "";
                string pro_name = "";
                string pro_oname = "";
                string po = "";
                string vo = "";
                string classname = "";
                DateTime ls_date;

                init_grid();

                int n= job["items"].Count();
                if(n>0)
                {
                    grid_sum.AutoRedraw = false;
                    grid_sum.Locked= false;
                    grid_sum.InsertRow(1, n - 1);
                    for (int i = 0; i < n; i++)
                    {
                        cid= ((string)job["items"][i]["custom_id"]);
                        type= ((string)job["items"][i]["type"]);
                        doc_time = ((string)job["items"][i]["doc_time"]);
                        ls_date=DateTime.Parse(doc_time);
                        order_id = ((string)job["items"][i]["order_id"]);
                        trans = ((string)job["items"][i]["trans"]);
                        creator = ((string)job["items"][i]["creator"]);
                        creator_time = ((string)job["items"][i]["creator_time"]);
                        posted = ((string)job["items"][i]["posted"]);
                        posted_time = ((string)job["items"][i]["posted_time"]);
                        note = ((string)job["items"][i]["note"]);
                        client_custom_id = ((string)job["items"][i]["client_custom_id"]);
                        client_name = ((string)job["items"][i]["client_name"]);
                        client_classname = ((string)job["items"][i]["client_classname"]);
                        pc_custom_id = ((string)job["items"][i]["pc_custom_id"]);
                        pc_color = ((string)job["items"][i]["pc_color"]);
                        pro_name = ((string)job["items"][i]["pro_name"]);
                        pro_oname = ((string)job["items"][i]["pro_oname"]);
                        pc_code = ((string)job["items"][i]["pc_code"]);
                        po = ((string)job["items"][i]["po"]);
                        vo = ((string)job["items"][i]["vo"]);
                        classname = ((string)job["items"][i]["classname"]);

                        grid_sum.Cell(i + 1, 1).Text = po;
                        grid_sum.Cell(i + 1, 2).Text = vo;
                        grid_sum.Cell(i + 1, 3).Text = Util.G_dname;
                        grid_sum.Cell(i + 1, 4).Text = type;
                        grid_sum.Cell(i + 1, 5).Text = cid;
                        grid_sum.Cell(i + 1, 6).Text = ls_date.ToString("yyyy-MM-dd");
                        grid_sum.Cell(i + 1, 7).Text = ls_date.ToString("HH:mm");
                        grid_sum.Cell(i + 1, 8).Text = "("+client_custom_id+")"+ client_name;
                        grid_sum.Cell(i + 1, 9).Text = pc_custom_id;
                        grid_sum.Cell(i + 1, 10).Text = classname;
                        grid_sum.Cell(i + 1, 11).Text = pro_name;
                        grid_sum.Cell(i + 1, 12).Text = pro_oname;
                        grid_sum.Cell(i + 1, 13).Text = pc_color;
                        grid_sum.Cell(i + 1, 14).Text = pc_code;
                        grid_sum.Cell(i + 1, 15).Text = "1";
                        grid_sum.Cell(i + 1, 16).Text = "1";


                    }
                    grid_sum.AutoRedraw = true;
                    grid_sum.Locked=true;
                    grid_sum.Refresh();
                }
            }
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            Form_Business mainfrom=new Form_Business();
            mainfrom.Text = "采购业务汇总";
            mainfrom.ShowDialog();
        }
    }
}
