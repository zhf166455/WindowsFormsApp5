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
using FlexCell;

namespace WindowsFormsApp5
{
    public partial class FormChoseClient : Form
    {
        private Form_Danju pfrom;
        public FormChoseClient(Form_Danju pfrom)
        {
            InitializeComponent();
            this.pfrom = pfrom;
        }

        private void FormChoseClient_Load(object sender, EventArgs e)
        {
            init_grid();
        }
        private void init_grid()
        {
            grid1.AutoRedraw = false;
            grid1.Rows = 2;

            grid1.Column(0).Width = 10;
            grid1.Column(1).Width = 100;
            grid1.Column(2).Width = 120;
            grid1.Column(3).Width = 180;
            grid1.Column(4).Width = 180;
            grid1.Column(5).Width = 140;
            grid1.Column(6).Width = 200;

            grid1.Cell(0, 1).Text = "分组";
            grid1.Cell(0, 2).Text = "编号";
            grid1.Cell(0, 3).Text = "供应商名称";
            grid1.Cell(0, 4).Text = "地区";
            grid1.Cell(0, 5).Text = "联系人";
            grid1.Cell(0, 6).Text = "手机号码";

            grid1.Locked = true;
            grid1.AutoRedraw = true;
            grid1.Refresh();
        }

        private void FormChoseClient_Shown(object sender, EventArgs e)
        {
            string rel = Util.httpget("/client/getAll", Util.G_token);
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
                if (n > 0)
                {
                    grid1.AutoRedraw = false;
                    grid1.Rows = n + 1;
                    for (int i = 0; i < n; i++)
                    {
                        string classname = (string)(job["items"][i]["classname"]);
                        string customid = (string)(job["items"][i]["customid"]);
                        string name = (string)(job["items"][i]["name"]);
                        string addr1 = (string)(job["items"][i]["addr1"]);
                        string oname = (string)(job["items"][i]["oname"]);
                        string ophone = (string)(job["items"][i]["ophone"]);

                        grid1.Cell(i + 1, 1).Text = classname;
                        grid1.Cell(i + 1, 2).Text = customid;
                        grid1.Cell(i + 1, 3).Text = name;
                        grid1.Cell(i + 1, 4).Text = addr1;
                        grid1.Cell(i + 1, 5).Text = oname;
                        grid1.Cell(i + 1, 6).Text = ophone;
                    }

                    grid1.AutoRedraw = true;
                    grid1.Refresh();
                    grid1.Locked = true;
                }
                else
                {
                    init_grid();
                }
            }
        }

        private void clientischose()
        {
            Cell ac= grid1.ActiveCell;
            if (ac != null )
            {
                int n=ac.Row;
                string cid = grid1.Cell(n, 2).Text;
                string cname= grid1.Cell(n, 3).Text;
                if (n > 0 && cid != "" && cname != "")
                {
                    cname = "(" + cid + ")" + cname;
                    pfrom.uiPanel_client.Text=cname;
                    this.Close();
                }
            }
        }

        private void uiSymbolButton_save_Click(object sender, EventArgs e)
        {
            clientischose();
        }

        private void uiSymbolButton_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clientischose();
        }
    }   
}
