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
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.AxHost;
using System.Reflection.Emit;
using System.Xml.Linq;
using FlexCell;

namespace WindowsFormsApp5
{
    public partial class Form_product : Form
    {
        private string from_type;
        public Form_product(string from_type)
        {
            InitializeComponent();
            this.from_type = from_type;
        }

        private void Form_product_Load(object sender, EventArgs e)
        {
            init_grid();
            init_tree();
            getprobycla();
        }
        public void init_grid()
        {
            grid_pro.AutoRedraw = false;
            grid_pro.Rows = 2;
            grid_pro.Locked = false;
            grid_pro.Range(0,0,1,8).ClearAll();

            grid_pro.Column(0).Width = 10;
            grid_pro.Column(1).Width = 120;
            grid_pro.Column(2).Width = 120;
            grid_pro.Column(3).Width = 250;
            grid_pro.Column(4).Width = 120;
            grid_pro.Column(5).Width = 100;
            grid_pro.Column(6).Width = 100;
            grid_pro.Column(7).Width = 200;
            grid_pro.Column(8).Width = 80;

            grid_pro.Cell(0, 1).Text = "商品编码";
            grid_pro.Cell(0, 2).Text = "商品分类";
            grid_pro.Cell(0, 3).Text = "机型名称";
            grid_pro.Cell(0, 4).Text = "别名";
            grid_pro.Cell(0, 5).Text = "厂家分类";
            grid_pro.Cell(0, 6).Text = "查询关键字";
            grid_pro.Cell(0, 7).Text = "可选颜色";
            grid_pro.Cell(0, 8).Text = "串码位数";



            grid_pro.Locked = true;
            grid_pro.AutoRedraw = true;
            grid_pro.Refresh();
        }
        private void init_tree() 
        {
            string rel;
            if (from_type == "串码")
            {
                 rel= Util.httpget("/sepcial/getAllClass", Util.G_token);
            }
            else
            {
                rel = Util.httpget("/normal/getAllClass", Util.G_token);
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
                TreeNode root = uiTreeView1.Nodes[0];
                if(from_type=="串码")
                {
                    root.Text = "全部串码商品";
                }
                else
                {
                    root.Text = "全部普通商品";
                }
                root.Tag = 0;
                root.Nodes.Clear();
                int n=job["items"].Count();
                string te_k,te_v,te_t;
                for(int i=0;i<n;i++)
                {
                    te_k = (string)job["items"][i]["key"];
                    te_v= (string)job["items"][i]["value"];
                    te_t = "(" + te_k + ")" + te_v;
                    TreeNode c1 = root.Nodes.Add(te_t);
                    c1.Tag = 1;
                    int b= job["items"][i]["items"].Count();
                    for (int j = 0; j < b; j++)
                    {
                        te_k = (string)job["items"][i]["items"][j]["key"];
                        te_v = (string)job["items"][i]["items"][j]["value"];
                        te_t = "(" + te_k + ")" + te_v;
                        TreeNode c2 = c1.Nodes.Add(te_t);
                        c2.Tag = 2;
                    }
                }
                
                root.Expand();
            }
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            TreeNode tn = uiTreeView1.SelectedNode;
            if (tn == null) return;
            if ((int)tn.Tag == 2)
            {
                TreeNode pn = tn.Parent;
                string pt = pn.Text+"#";
                pt = Util.midstr(ref pt, ")", "#");
                string ct = tn.Text + "#";
                ct = Util.midstr(ref ct, ")", "#");
                Form_Addsp mainForm = new Form_Addsp(from_type,"");
                mainForm.uiTextBox_cid.Text = "<系统生成>";
                mainForm.uiTextBox_class.Text = pt + "/" + ct;
                ct= tn.Text;
                ct = Util.midstr(ref ct, "(", ")");
                mainForm.uiLabel_cid.Text = ct;
                if (from_type == "串码")
                {
                    mainForm.Text = "串码商品详细--新建";
                }
                else
                {
                    mainForm.Text = "普通商品详细--新建";
                }
                mainForm.ShowDialog();
            }
            
        }

        private void getprobycla()
        {
            TreeNode node = uiTreeView1.SelectedNode;
            string pram = "";
            if (node == null)
            {
                pram = "?max=all&min=all";
            }
            else
            {
                int ntag = (int)node.Tag;
                if (ntag == 0)
                {
                    pram = "?max=all&min=all";
                }
                else
                {
                    if (ntag == 1)
                    {
                        string tx = node.Text;
                        tx = Util.midstr(ref tx, "(", ")");
                        pram = "?max=" + tx + "&min=all";
                    }
                    else
                    {
                        string tx = node.Text;
                        tx = Util.midstr(ref tx, "(", ")");
                        string max = Util.leftstr(ref tx, 1);
                        string min = Util.rightstr(ref tx, 3);
                        pram = "?max=" + max + "&min=" + min;
                    }
                }
                
            }
            string rel;
            if (from_type == "串码")
            {
                rel = Util.httpget("/special/getByClass" + pram, Util.G_token);
            }
            else
            {
                rel = Util.httpget("/normal/getByClass" + pram, Util.G_token);
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
                    grid_pro.Locked = false;
                    grid_pro.AutoRedraw = false;
                    grid_pro.Rows = n + 1;

                    for (int i = 0; i < job["items"].Count(); i++)
                    {
                        string cid = (string)(job["items"][i]["custom_id"]);
                        string classname = (string)(job["items"][i]["classname"]);
                        string name = (string)(job["items"][i]["name"]);
                        string oname = (string)(job["items"][i]["oname"]);
                        int bit = (int)(job["items"][i]["bit"]);
                        int mbit = (int)(job["items"][i]["mbit"]);
                        string org = (string)(job["items"][i]["org"]);
                        string keyword = (string)(job["items"][i]["keyword"]);
                        bool check = (bool)(job["items"][i]["check"]);
                        string color = (string)(job["items"][i]["color"]);

                        Debug.WriteLine(cid);

                        grid_pro.Cell(i + 1, 1).Text = cid;
                        grid_pro.Cell(i + 1, 2).Text = classname;
                        grid_pro.Cell(i + 1, 3).Text = name;
                        grid_pro.Cell(i + 1, 4).Text = oname;
                        grid_pro.Cell(i + 1, 5).Text = org;
                        grid_pro.Cell(i + 1, 6).Text = keyword;
                        grid_pro.Cell(i + 1, 7).Text = color;
                        grid_pro.Cell(i + 1, 8).Text = bit.ToString();

                    }
                    grid_pro.Locked = true;
                    grid_pro.AutoRedraw = true;
                    grid_pro.Refresh();

                }
                else
                {
                    init_grid();
                }
            }
        }

        private void uiTreeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            getprobycla();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            TreeNode sn= uiTreeView1.SelectedNode;
            if (uiNavMenu1.Visible == false)
            {
                uiNavMenu1.SelectedNode = null;
                uiNavMenu1.Visible = true;
            }
            else
            {
                uiNavMenu1.Visible = false;
            }
        }


        private void uiNavMenu1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            uiNavMenu1.SelectedNode= e.Node;
            int an = e.Node.Index;
            uiNavMenu1.Visible = false;
            if (an == 0)
            {
                //刷新
                init_tree();
            }
            if (an == 1)
            {
                //新建
                TreeNode tn = uiTreeView1.SelectedNode;
                if (tn == null) return;
                if ((int)tn.Tag == 1)
                {
                    Form_Pro_Class_Min mainfrom = new Form_Pro_Class_Min(from_type);
                    string maxtx = tn.Text+"#!#";
                    string ltx = Util.midstr(ref maxtx, "(", ")");
                    string rtx = Util.midstr(ref maxtx, ")", "#!#");
                    mainfrom.uiTextBox_classname.Text = rtx;
                    mainfrom.uiTextBox_cidmin.Text = "<系统生成>";
                    mainfrom.uiLabel_cidmax.Text = ltx;
                    mainfrom.uiTextBox_name.Focus();
                    mainfrom.ShowDialog();
                }
                if ((int)tn.Tag == 0)
                {
                    Form_Pro_Class_Max mainfrom = new Form_Pro_Class_Max(from_type);
                    mainfrom.ShowDialog();
                }
            }
            if (an == 1)
            {
                //删除

            }
            if (an == 1)
            {
                //修改
            }
            
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            getprobycla();
        }
        private void getprodeial()
        {
            Cell ac = grid_pro.ActiveCell;
            int an = ac.Row;
            string tx = grid_pro.Cell(an, 1).Text;
            if(tx!="")
            {
                Form_Addsp form_Addsp = new Form_Addsp(from_type,tx);
                form_Addsp.ShowDialog();
            }

        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            getprodeial();
        }

        private void grid_pro_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            getprodeial();
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            Cell ac = grid_pro.ActiveCell;
            int n= ac.Row;
            string tx= grid_pro.Cell(n, 1).Text;
            if (tx!="")
            {
                DialogResult aws = MessageBox.Show("确定要删除商品" + tx + "吗", "确认操作", MessageBoxButtons.OKCancel);
                if (aws == DialogResult.OK)
                {
                    string rel = "";
                    if (from_type == "串码")
                    {
                        rel = Util.httpget("/special/del?id=" + tx, Util.G_token);
                    }
                    else
                    {
                        rel = Util.httpget("/normal/del?id=" + tx, Util.G_token);
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
                        MessageBox.Show("删除成功");
                    }
                }
            }
        }
    }
     
}
