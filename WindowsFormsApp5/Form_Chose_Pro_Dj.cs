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
using Sunny.UI;
using System.Diagnostics;
using FlexCell;

namespace WindowsFormsApp5
{
    public partial class Form_Chose_Pro_Dj : Form
    {
        public string from_type;
        public Form_Chose_Pro_Dj()
        {
            InitializeComponent();
        }

        private void Form_Chose_Pro_Dj_Load(object sender, EventArgs e)
        {
            init_grid();
            init_tree();
        }

        private void init_grid()
        {
            grid1.AutoRedraw = false;
            grid1.Rows = 2;

            grid1.Column(0).Width = 10;
            grid1.Column(1).Width = 120;
            grid1.Column(2).Width = 100;
            grid1.Column(3).Width = 200;
            grid1.Column(4).Width = 80;
            grid1.Column(5).Width = 80;
            grid1.Column(6).Width = 150;
            grid1.Column(7).Width = 150;

            grid1.Cell(0, 1).Text = "商品编码";
            grid1.Cell(0, 2).Text = "类别";
            grid1.Cell(0, 3).Text = "商品名称";
            grid1.Cell(0, 4).Text = "颜色";
            grid1.Cell(0, 5).Text = "别名";
            grid1.Cell(0, 6).Text = "条码";
            grid1.Cell(0, 7).Text = "说明";

            grid1.AutoRedraw=true;
            grid1.Refresh();
        }

        private void uiSymbolButton_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void init_tree()
        {
            string rel="";
            if(from_type=="普通")
            {
                rel = Util.httpget("/normal/getAllClass", Util.G_token);
            }
            else
            {
                rel = Util.httpget("/sepcial/getAllClass", Util.G_token);
            }
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
                uiTreeView1.Nodes.Clear();
                TreeNode root=new TreeNode();
                root.Text = "全部普通商品";
                uiTreeView1.Nodes.Add(root);

                int n = job["items"].Count();
                string te_k, te_v, te_t;
                for (int i = 0; i < n; i++)
                {
                    te_k = (string)job["items"][i]["key"];
                    te_v = (string)job["items"][i]["value"];
                    te_t = "(" + te_k + ")" + te_v;
                    TreeNode c1 = root.Nodes.Add(te_t);
                    c1.Tag = 1;
                    int b = job["items"][i]["items"].Count();
                    for (int j = 0; j < b; j++)
                    {
                        te_k = (string)job["items"][i]["items"][j]["key"];
                        te_v = (string)job["items"][i]["items"][j]["value"];
                        te_t = "(" + te_k + ")" + te_v;
                        TreeNode c2 = c1.Nodes.Add(te_t);
                        c2.Tag = 2;
                    }
                }
                root.ExpandAll();

            }
        }

        private void uiTreeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode node = uiTreeView1.SelectedNode;
            string tx = node.Text;
            tx = Util.midstr(ref tx, "(", ")");
            string pram = "?class=" + tx ;
            string rel;
            if (Util.G_page == "串码商品管理")
            {
                rel = Util.httpget("/special/getByClass/detail" + pram, Util.G_token);
            }
            else
            {
                rel = Util.httpget("/normal/getByClass/detail" + pram, Util.G_token);
            }

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

                    for (int i = 0; i < job["items"].Count(); i++)
                    {
                        string cid = (string)(job["items"][i]["custom_id"]);
                        string classname = (string)(job["items"][i]["classname"]);
                        string name = (string)(job["items"][i]["name"]);
                        string oname = (string)(job["items"][i]["oname"]);
                        string color = (string)(job["items"][i]["color"]);
                        string rcode = (string)(job["items"][i]["rcode"]);

                        Debug.WriteLine(cid);

                        grid1.Cell(i + 1, 1).Text = cid;
                        grid1.Cell(i + 1, 2).Text = classname;
                        grid1.Cell(i + 1, 3).Text = name;
                        grid1.Cell(i + 1, 4).Text = color;
                        grid1.Cell(i + 1, 5).Text = oname;
                        grid1.Cell(i + 1, 6).Text = rcode;
                        grid1.Cell(i + 1, 7).Text = "";

                    }
                    grid1.AutoRedraw = true;
                    grid1.Refresh();

                }
                else
                {
                    init_grid();
                }
            }
        }

        private void grid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cell ac = grid1.ActiveCell;
            int n = ac.Row;
            if(n>1)
            {
                string tx = grid1.Cell(n, 1).Text;
                MessageBox.Show(tx);
            }
        }
    }
}
