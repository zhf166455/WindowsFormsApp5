using Microsoft.VisualBasic.Devices;
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
using static System.Windows.Forms.AxHost;

namespace WindowsFormsApp5
{
    public partial class Form_Track : Form
    {
        public Form_Track()
        {
            InitializeComponent();
        }

        private void Form_Track_Load(object sender, EventArgs e)
        {
            init_grid();

        }
        private void init_grid()
        {
            grid1.AutoRedraw = false;
            grid1.Rows = 2;

            grid1.Column(0).Width = 10;
            grid1.Column(1).Width = 120;
            grid1.Column(2).Width = 100;
            grid1.Column(3).Width = 100;
            grid1.Column(4).Width = 180;
            grid1.Column(5).Width = 100;
            grid1.Column(6).Width = 80;
            grid1.Column(7).Width = 200;
            grid1.Column(8).Width = 100;
            grid1.Column(9).Width = 120;

            grid1.Cell(0, 1).Text = "单据编号";
            grid1.Cell(0, 2).Text = "单据类型";
            grid1.Cell(0, 3).Text = "日期";
            grid1.Cell(0, 4).Text = "机型描述";
            grid1.Cell(0, 5).Text = "价格";
            grid1.Cell(0, 6).Text = "过账";
            grid1.Cell(0, 7).Text = "流向";
            grid1.Cell(0, 8).Text = "附加信息";
            grid1.Cell(0, 9).Text = "录入时间";

            grid1.AutoRedraw = true;
            grid1.Refresh();
        }

        private void uiTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                string kwd = uiTextBox_kwd.Text;
                if (kwd != "")
                {
                    string pram = "?keyword=" + kwd;
                    string rel = Util.httpget("/track/get"+pram, Util.G_token);
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
                        
                        int n = job["items"].Count();
                        init_grid();
                        if (n > 0)
                        {
                            grid1.Rows = n + 1;
                            grid1.AutoRedraw = false;
                            for(int i = 0; i < n; i++)
                            {
                                string doc_id = (string)(job["items"][i]["doc_id"]);
                                int doc_type = (int)(job["items"][i]["doc_type"]);
                                string doc_time = (string)(job["items"][i]["doc_time"]);
                                string name = (string)(job["items"][i]["name"]);
                                float price = (float)(job["items"][i]["price"]);
                                string client = (string)(job["items"][i]["client"]);
                                string note = (string)(job["items"][i]["note"]);

                                grid1.Cell(i + 1, 1).Text = doc_id;
                                grid1.Cell(i + 1, 2).Text = "采购入库单";
                                grid1.Cell(i + 1, 3).Text = "2023/07/18";
                                grid1.Cell(i + 1, 4).Text = name; 
                                grid1.Cell(i + 1, 5).Text = price.ToString();
                                grid1.Cell(i + 1, 6).Text = "true";
                                grid1.Cell(i + 1, 7).Text = client;
                                grid1.Cell(i + 1, 8).Text = note;
                                grid1.Cell(i + 1, 9).Text = "13:54";
                            }
                            grid1.AutoRedraw = true;
                            grid1.Refresh();
                        }
                    }
                }
            }
        }

    }
}
