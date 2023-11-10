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
using Sunny.UI.Win32;

namespace WindowsFormsApp5
{
    public partial class Form_Client : Form
    {
        public Form_Client()
        {
            InitializeComponent();
        }

        private void Form_Client_Load(object sender, EventArgs e)
        {
            init_grid();
            TreeNode root = uiTreeView1.Nodes[0];
            root.ExpandAll();
            getallclient();
        }
        private void init_grid()
        {
            grid_client.AutoRedraw = false;
            grid_client.Rows = 3;
            grid_client.Range(0, 1, 2, 9).Locked = false;
            grid_client.Range(0, 1, 2, 9).ClearAll();

            grid_client.Column(0).Width = 10;
            grid_client.Column(1).Width = 30;
            grid_client.Column(2).Width = 100;
            grid_client.Column(3).Width = 100;
            grid_client.Column(4).Width = 100;
            grid_client.Column(5).Width = 250;
            grid_client.Column(6).Width = 100;
            grid_client.Column(7).Width = 100;
            grid_client.Column(8).Width = 100;
            grid_client.Column(9).Width = 120;

            grid_client.Range(0, 0, 1, 0).Merge();
            grid_client.Range(0, 1, 1, 1).Merge();
            grid_client.Range(0, 2, 1, 2).Merge();
            grid_client.Range(0, 3, 1, 3).Merge();
            grid_client.Range(0, 4, 1, 4).Merge();
            grid_client.Range(0, 5, 1, 5).Merge();
            grid_client.Range(0, 6, 0, 8).Merge();
            grid_client.Range(0, 9, 1, 9).Merge();

            grid_client.Cell(0, 1).Text = "停用";
            grid_client.Cell(0, 2).Text = "分组";
            grid_client.Cell(0, 3).Text = "编号";
            grid_client.Cell(0, 4).Text = "名称";
            grid_client.Cell(0, 5).Text = "地区";
            grid_client.Cell(0, 6).Text = "公司负责人";
            grid_client.Cell(1, 6).Text = "姓名";
            grid_client.Cell(1, 7).Text = "手机";
            grid_client.Cell(1, 8).Text = "附加信息";
            grid_client.Cell(0, 9).Text = "备注";

            grid_client.AutoRedraw = true;
            grid_client.Refresh();
        }

        private void getallclient()
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
                    grid_client.AutoRedraw = false;
                    grid_client.Rows = n + 2;
                    grid_client.Column(1).CellType = FlexCell.CellTypeEnum.CheckBox;
                    for (int i = 0; i < n; i++)
                    {
                        string classname = (string)(job["items"][i]["classname"]);
                        bool state = (bool)(job["items"][i]["state"]);
                        string customid = (string)(job["items"][i]["customid"]);
                        string name = (string)(job["items"][i]["name"]);
                        string call = (string)(job["items"][i]["call"]);
                        string addr1 = (string)(job["items"][i]["addr1"]);
                        string addr2 = (string)(job["items"][i]["addr2"]);
                        string addr3 = (string)(job["items"][i]["addr3"]);
                        string addr4 = (string)(job["items"][i]["addr4"]);
                        string oname = (string)(job["items"][i]["oname"]);
                        string ophone = (string)(job["items"][i]["ophone"]);
                        string onote = (string)(job["items"][i]["onote"]);
                        string note = (string)(job["items"][i]["note"]);

                        grid_client.Cell(i + 2, 1).Text = state ? "1" : "0";
                        grid_client.Cell(i + 2, 2).Text = classname;
                        grid_client.Cell(i + 2, 3).Text = customid;
                        grid_client.Cell(i + 2, 4).Text = name;
                        grid_client.Cell(i + 2, 5).Text = addr1 + addr2 + addr3 + addr4;
                        grid_client.Cell(i + 2, 6).Text = oname;
                        grid_client.Cell(i + 2, 7).Text = ophone;
                        grid_client.Cell(i + 2, 8).Text = onote;
                        grid_client.Cell(i + 2, 9).Text = note;
                    }

                    grid_client.AutoRedraw = true;
                    grid_client.Refresh();
                    grid_client.Locked = true;
                }
                else
                {
                    init_grid();
                }

            }
        }
        private void uiButton2_Click(object sender, EventArgs e)
        {
            getclientbyclass();
        }

        private void uiButton_add_Click(object sender, EventArgs e)
        {
            Form_client_new mainForm = new Form_client_new();
            TreeNode tn= uiTreeView1.SelectedNode;
            int n=0;
            if (tn!=null)
            {
                n= tn.Index;
            }
            mainForm.uiComboBox_fenzu.SelectedIndex= n;
            mainForm.Text= "客户详细资料--新建";
            mainForm.ShowDialog();
        }

        private void uiButton_update_Click(object sender, EventArgs e)
        {
            client_update();
        }

        private void grid_client_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            client_update();
        }
        private void client_update()
        {
            Cell ac = grid_client.ActiveCell;
            int n = ac.Row;
            if (n >= 2)
            {
                ac= grid_client.Cell(n, 3);
                string cid = ac.Text;
                Form_client_new mainForm = new Form_client_new();
                mainForm.Text = "客户详细资料--修改";
                mainForm.uiTextBox_id.Text= cid;
                string pram = "?clientid=" + cid;
                string rel = Util.httpget("/client/getById"+pram, Util.G_token);
                JObject job = (JObject)JsonConvert.DeserializeObject(rel);
                int code = ((int)job["code"]);
                string msg = ((string)job["msg"]);
                if (code == -1)
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    string classname = (string)(job["item"]["classname"]);
                    bool state = (bool)(job["item"]["state"]);
                    string custom_id = (string)(job["item"]["custom_id"]);
                    string name = (string)(job["item"]["name"]);
                    string call = (string)(job["item"]["call"]);
                    string addr1 = (string)(job["item"]["addr1"]);
                    string addr2 = (string)(job["item"]["addr2"]);
                    string addr3 = (string)(job["item"]["addr3"]);
                    string addr4 = (string)(job["item"]["addr4"]);
                    string oname = (string)(job["item"]["oname"]);
                    string ophone = (string)(job["item"]["ophone"]);
                    string onote = (string)(job["item"]["onote"]);
                    string note = (string)(job["item"]["note"]);

                    switch(classname)
                    {
                        case "本公司":
                           mainForm.uiComboBox_fenzu.SelectedIndex = 0;
                           break;
                        case "供应商":
                            mainForm.uiComboBox_fenzu.SelectedIndex = 1;
                            break;
                        case "内部分销":
                            mainForm.uiComboBox_fenzu.SelectedIndex = 2;
                            break;
                        case "零售对应客户":
                            mainForm.uiComboBox_fenzu.SelectedIndex = 3;
                            break;
                    }
                    mainForm.uiTextBox_id.Text = custom_id;
                    mainForm.uiTextBox_name.Text = name;
                    mainForm.uiTextBox_phone.Text = call;
                    mainForm.uiTextBox_addr1.Text = addr1;
                    mainForm.uiTextBox_addr2.Text = addr2;
                    mainForm.uiTextBox_addr3.Text = addr3;
                    mainForm.uiTextBox_addr4.Text = addr4;
                    mainForm.uiTextBox_oname.Text = oname;
                    mainForm.uiTextBox_ophone.Text = ophone;
                    mainForm.uiTextBox_onote.Text = onote;
                    mainForm.uiTextBox_note.Text= note;

                    mainForm.ShowDialog();
                }
                
            }
        }

        private void uiTreeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            getclientbyclass();
        }

        private void getclientbyclass()
        {
            TreeNode sn = uiTreeView1.SelectedNode;
            string cid = "";
            if (sn != null)
            {
                int n = sn.Index;
                switch (n)
                {
                    case 0:
                        cid = "000";
                        break;
                    case 1:
                        cid = "001";
                        break;
                    case 2:
                        cid = "998";
                        break;
                    case 3:
                        cid = "999";
                        break;
                }
                if (sn.Text == "全部客户")
                {
                    getallclient();
                    return;
                }
                string pram = "?class=" + cid;
                string rel = Util.httpget("/client/getByClass" + pram, Util.G_token);
                JObject job = (JObject)JsonConvert.DeserializeObject(rel);
                int code = ((int)job["code"]);
                string msg = ((string)job["msg"]);
                if (code == -1)
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    int nn = job["items"].Count();
                    if (nn > 0)
                    {
                        grid_client.AutoRedraw = false;
                        grid_client.Rows = nn + 2;
                        grid_client.Column(1).CellType = FlexCell.CellTypeEnum.CheckBox;
                        for (int i = 0; i < nn; i++)
                        {
                            string classname = (string)(job["items"][i]["classname"]);
                            bool state = (bool)(job["items"][i]["state"]);
                            string customid = (string)(job["items"][i]["custom_id"]);
                            string name = (string)(job["items"][i]["name"]);
                            string call = (string)(job["items"][i]["call"]);
                            string addr1 = (string)(job["items"][i]["addr1"]);
                            string addr2 = (string)(job["items"][i]["addr2"]);
                            string addr3 = (string)(job["items"][i]["addr3"]);
                            string addr4 = (string)(job["items"][i]["addr4"]);
                            string oname = (string)(job["items"][i]["oname"]);
                            string ophone = (string)(job["items"][i]["ophone"]);
                            string onote = (string)(job["items"][i]["onote"]);
                            string note = (string)(job["items"][i]["note"]);

                            grid_client.Cell(i + 2, 1).Text = state ? "1" : "0";
                            grid_client.Cell(i + 2, 2).Text = classname;
                            grid_client.Cell(i + 2, 3).Text = customid;
                            grid_client.Cell(i + 2, 4).Text = name;
                            grid_client.Cell(i + 2, 5).Text = addr1 + addr2 + addr3 + addr4;
                            grid_client.Cell(i + 2, 6).Text = oname;
                            grid_client.Cell(i + 2, 7).Text = ophone;
                            grid_client.Cell(i + 2, 8).Text = onote;
                            grid_client.Cell(i + 2, 9).Text = note;
                        }

                        grid_client.AutoRedraw = true;
                        grid_client.Refresh();
                        grid_client.Locked = true;
                    }
                }
            }
            else
            {
                getallclient();
            }
        }

        private void uiButton_del_Click(object sender, EventArgs e)
        {
            Cell ac = grid_client.ActiveCell;
            int n = ac.Row;
            string tx = grid_client.Cell(n, 3).Text;
            if(tx!="")
            {
                DialogResult aws=MessageBox.Show("确定要删除"+tx+"吗", "确认操作", MessageBoxButtons.YesNo);
                if(aws==DialogResult.Yes)
                {
                    string rel = Util.httpget("/client/del?id=" + tx, Util.G_token);
                    JObject job = (JObject)JsonConvert.DeserializeObject(rel);

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
