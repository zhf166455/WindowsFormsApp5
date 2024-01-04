using FlexCell;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form_Addsp : Form
    {
        private string pro_code;
        private string from_type;
        public Form_Addsp(string from_type, string pro_code)
        {
            InitializeComponent();
            this.pro_code = pro_code;
            this.from_type = from_type;
        }

        private void Form_Addsp_Load(object sender, EventArgs e)
        {
            init_grid();
            if (pro_code !="")
            {
                string rel = "";
                string pram = "";
                if (from_type=="串码")
                {
                    this.Text = "串码商品详细--修改";
                    pram = "?id=" + pro_code;
                    rel = Util.httpget("/special/get" + pram, Util.G_token);
                }
                else
                {
                    this.Text = "普通商品详细--修改";
                    pram = "?id=" + pro_code;
                    rel = Util.httpget("/normal/get" + pram, Util.G_token);
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
                    string classname = (string)job["classname"];
                    string class_id = (string)job["class_id"];
                    string custom_id = (string)job["custom_id"];
                    string name = (string)job["name"];
                    string oname = (string)job["oname"];
                    int bit = (int)job["bit"];
                    int mbit = (int)job["mbit"];
                    string org = (string)job["org"];
                    string keyword = (string)job["keyword"];
                    bool check = (bool)job["check"];

                    uiTextBox_bit.Text=bit.ToString();
                    uiTextBox_cid.Text = custom_id;
                    uiTextBox_class.Text = classname;
                    uiTextBox_name.Text = name;
                    uiTextBox_keyword.Text = keyword;
                    uiTextBox_mbit.Text = mbit.ToString();
                    uiTextBox_org.Text = org;
                    uiCheckBox_check.Checked = check;
                    uiTextBox_oname.Text = oname;
                    uiLabel_cid.Text = class_id;

                    int n = job["items"].Count();
                    grid1.Locked = false;
                    grid1.AutoRedraw = false;
                    grid1.InsertRow(1, n - 1);

                    grid1.Column(4).CellType = FlexCell.CellTypeEnum.CheckBox;

                    for (int i = 0; i < n; i++)
                    {
                        string itnid= (string)job["items"][i]["nid"];
                        string itname = (string)job["items"][i]["name"];
                        string itcode = (string)job["items"][i]["code"];
                        bool itstate = (bool)job["items"][i]["state"];
                        string itimg = (string)job["items"][i]["img"];

                        grid1.Cell(i + 1, 1).Text = itnid;
                        grid1.Cell(i + 1, 2).Text = itname;
                        grid1.Cell(i + 1, 3).Text = itcode;
                        grid1.Cell(i + 1, 4).Text = itstate?"true":"false";
                        grid1.Cell(i + 1, 5).Text = itimg;
                    }

                    grid1.Locked = true;
                    grid1.AutoRedraw = true;
                    grid1.Refresh();
                }


            }
        }
        private void init_grid()
        {
            grid1.AutoRedraw = false;
            grid1.Rows = 2;

            grid1.Column(0).Width = 10;
            grid1.Column(1).Width = 60;
            grid1.Column(2).Width = 80;
            grid1.Column(3).Width = 150;
            grid1.Column(4).Width = 60;
            grid1.Column(5).Width = 150;

            grid1.Cell(0, 1).Text = "编号";
            grid1.Cell(0, 2).Text = "颜色";
            grid1.Cell(0, 3).Text = "条码";
            grid1.Cell(0, 4).Text = "停用";
            grid1.Cell(0, 5).Text = "图片文件";

            grid1.AutoRedraw = true;
            grid1.Locked = true;
            grid1.Refresh();
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            Form_Color mainfrom= new Form_Color(this,from_type,"","");
            mainfrom.Text = "商品颜色详细--新增";
            mainfrom.Show();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            JObject job = new JObject();
            JArray jArray = new JArray();
            if(pro_code=="")
                job["custom_id"] = uiLabel_cid.Text;
            else
                job["custom_id"] = pro_code;
            job["name"] = uiTextBox_name.Text;
            job["oname"] = uiTextBox_oname.Text;
            job["bit"] = uiTextBox_bit.Text;
            job["mbit"] = uiTextBox_mbit.Text;
            job["org"] = uiTextBox_org.Text;
            job["check"] = uiCheckBox_check.Checked;
            job["keyword"] = uiTextBox_keyword.Text;
            int n = grid1.Rows-1;
            for (int i = 0;i<n;i++)
            {
                JObject cjob = new JObject();
                cjob["name"] = grid1.Cell(i+1,2).Text;
                cjob["code"] = grid1.Cell(i+1, 3).Text;
                cjob["state"] = grid1.Cell(i+1, 4).Text;
                cjob["img"] =grid1.Cell(i+1, 5).Text;
                cjob["nid"] =grid1.Cell(i+1, 1).Text;
                jArray.Add(cjob);
            }
            job["colors"] = jArray;

            string body = job.ToString();
            string rel = "";

            if(pro_code=="")
            {
                if (from_type == "串码")
                {
                    rel = Util.httppost("/special/add", ref body, Util.G_token);
                }
                else
                {
                    rel = Util.httppost("/normal/add", ref body, Util.G_token);
                }

                JObject rjob = (JObject)JsonConvert.DeserializeObject(rel);

                int code = ((int)rjob["code"]);
                string msg = ((string)rjob["msg"]);

                if (code == -1)
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    string cid = ((string)rjob["custom_id"]);
                    uiTextBox_cid.Text = cid;
                    uiButton_save.Enabled = false;
                    MessageBox.Show("新建成功");
                }
            }
            else
            {
                if (from_type == "串码")
                {
                    rel = Util.httppost("/special/update", ref body, Util.G_token);
                }
                else
                {
                    rel = Util.httppost("/normal/update", ref body, Util.G_token);
                }

                JObject rjob = (JObject)JsonConvert.DeserializeObject(rel);

                int code = ((int)rjob["code"]);
                string msg = ((string)rjob["msg"]);

                if (code == -1)
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    string cid = ((string)rjob["custom_id"]);
                    uiTextBox_cid.Text = cid;
                    uiButton_save.Enabled = false;
                    MessageBox.Show("修改成功");
                }
            }

            
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiButton_color_del_Click(object sender, EventArgs e)
        {
            Cell ac = grid1.ActiveCell;
            int n = ac.Row;
            if(n>0)
            {
                DialogResult asw = MessageBox.Show("确定要删除颜色吗");
                if (asw == DialogResult.OK)
                {
                    //删除颜色
                    grid1.Row(n).Delete();
                }
            }

            
        }


        private void color_update()
        {
            Cell ac = grid1.ActiveCell;
            int n = ac.Row;
            if (n > 0)
            {
                string cname;
                string ccode;
                cname = grid1.Cell(n, 2).Text;
                ccode = grid1.Cell(n, 3).Text;
                Form_Color fc=new Form_Color(this,from_type, cname, ccode);
                fc.Show();

            }
        }

        private void uiButton6_color_update_Click(object sender, EventArgs e)
        {
            color_update();
        }

        private void grid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            color_update();
        }
    }
}
