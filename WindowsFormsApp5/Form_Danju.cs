using FlexCell;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp5
{
    public partial class Form_Danju : Form
    {
        private Form_Ruku pfrom;
        private string from_type;
        private string from_type_title;
        private string from_type_shot;
        private string doc_id;
        private int doc_spc_num;
        private int doc_nor_num;
        private float doc_all_sum;

        public Form_Danju(Form_Ruku pfrom,string from_type,string doc_id)
        {
            InitializeComponent();
            this.pfrom = pfrom;
            this.from_type = from_type;
            this.doc_id = doc_id;
            from_type_title=Util.getTypeTitle(from_type);
            from_type_shot=Util.getTypeShot(from_type);
            this.Text = from_type;
            this.uiLabel_djtype.Text = from_type_title;
        }

        private void Form_Danju_Load(object sender, EventArgs e)
        {
            init_grid();
            if (doc_id!="")
            {
                uiPanel_djid.Text = doc_id;
                uiButton_bc.Enabled = false;
                string pram = "?id=" + doc_id;
                string rel = Util.httpget("/stock/v2/getinfo"+pram, Util.G_token);
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
                    string doc_day = (string)(job["doc_day"]);
                    string custom_id = (string)(job["custom_id"]);
                    string order_id = (string)(job["order_id"]);
                    string doc_time = (string)(job["doc_time"]);
                    string trans = (string)(job["trans"]);
                    string creator = (string)(job["creator"]);
                    string creator_time = (string)(job["creator_time"]);
                    string posted = (string)(job["posted"]);
                    string posted_time = (string)(job["posted_time"]);
                    string note = (string)(job["note"]);
                    bool po = (bool)(job["po"]);
                    bool vo = (bool)(job["vo"]);
                    string client = (string)(job["client"]);

                    uiPanel_djday.Text = doc_day;
                    uiPanel_der.Text = Util.G_dname;
                    uiPanel_order.Text = order_id;
                    uiPanel_trans.Text = trans;
                    uiPanel_djid.Text = custom_id;
                    uiPanel_client.Text = client;
                    uiTextBox_note.Text = note;
                    uiLabel_bzdr.Text = creator;
                    uiLabel_bgzr.Text = posted;
                    uiLabel_bzdt.Text = creator_time;
                    uiLabel_gzt.Text = posted_time;
                    //string cid = (string)(job["items"][i]["custom_id"]);
                    int n = job["item"].Count();
                    init_grid();
                    grid_danju.Locked = false;
                    grid_danju.AutoRedraw = false;
                    grid_danju.InsertRow(1, n - 1);

                    for (int i = 0; i < n; i++)
                    {
                        string imei= (string)(job["item"][i]["imei"]);
                        int num = (int)(job["item"][i]["num"]);
                        float price = (float)(job["item"][i]["price"]);
                        float sum = (float)(job["item"][i]["sum"]);
                        string pro_color = (string)(job["item"][i]["pro_color"]);
                        string pro_code = (string)(job["item"][i]["pro_code"]);
                        string pro_name = (string)(job["item"][i]["pro_name"]);
                        string pro_class = (string)(job["item"][i]["pro_class"]);
                        string cid = (string)(job["item"][i]["custom_id"]);
                        string pro_oname = (string)(job["item"][i]["pro_oname"]);
                        int pro_type = (int)(job["item"][i]["product_type"]);

                        grid_danju.Cell(i + 1, 1).Text = pro_type == 0 ? "串码" : "普通";
                        grid_danju.Cell(i + 1, 2).Text = cid;
                        grid_danju.Cell(i + 1, 3).Text = pro_type == 0 ? "串码" : "普通"; 
                        grid_danju.Cell(i + 1, 4).Text = pro_name;
                        grid_danju.Cell(i + 1, 5).Text = pro_color;
                        grid_danju.Cell(i + 1, 6).Text = pro_code;
                        grid_danju.Cell(i + 1, 7).Text = imei;
                        grid_danju.Cell(i + 1, 8).Text = num.ToString();
                        grid_danju.Cell(i + 1, 9).Text = price.ToString();
                        grid_danju.Cell(i + 1, 10).Text = sum.ToString();
                        grid_danju.Cell(i + 1, 11).Text = "";
                        grid_danju.Cell(i + 1, 12).Text = pro_oname;
                    }

                    grid_danju.Locked = true;
                    grid_danju.AutoRedraw = true;
                    grid_danju.Refresh();

                    CalculateSummary_grid();
                }
            }
            else
            {
                uiPanel_der.Text = Util.G_dname;
                uiLabel_bzdr.Text = Util.G_name;
                uiLabel_bzdt.Text = Util.getNowDate();
            }
        }
        private void init_grid()
        {
            grid_danju.AutoRedraw = false;
            grid_danju.Locked = false;
            grid_danju.Rows = 3;
            grid_danju.Range(0, 1, 2, 12).ClearAll();

            grid_danju.Column(0).Width = 10;
            grid_danju.Column(1).Width = 40;
            grid_danju.Column(2).Width = 120;
            grid_danju.Column(3).Width = 60;
            grid_danju.Column(4).Width = 120;
            grid_danju.Column(5).Width = 60;
            grid_danju.Column(6).Width = 120;
            grid_danju.Column(7).Width = 120;
            grid_danju.Column(8).Width = 80;
            grid_danju.Column(9).Width = 80;
            grid_danju.Column(10).Width = 80;
            grid_danju.Column(11).Width = 100;
            grid_danju.Column(12).Width = 100;

            grid_danju.Cell(0, 1).Text = "类型";
            grid_danju.Cell(0, 2).Text = "商品编码";
            grid_danju.Cell(0, 3).Text = "附加标识";
            grid_danju.Cell(0, 4).Text = "商品名称";
            grid_danju.Cell(0, 5).Text = "颜色";
            grid_danju.Cell(0, 6).Text = "条码";
            grid_danju.Cell(0, 7).Text = "IMEI";
            grid_danju.Cell(0, 8).Text = "数量";
            grid_danju.Cell(0, 9).Text = "单价";
            grid_danju.Cell(0, 10).Text = "金额";
            grid_danju.Cell(0, 11).Text = "附加信息";
            grid_danju.Cell(0, 12).Text = "别名";
            
            grid_danju.Cell(2, 5).Text = "记录数:0";
            grid_danju.Column(9).Mask = FlexCell.MaskEnum.Numeric;
            grid_danju.Column(9).DecimalLength = 2;
            grid_danju.Column(10).Mask = FlexCell.MaskEnum.Numeric;
            grid_danju.Column(10).DecimalLength = 2;

            grid_danju.Cell(2, 8).Text = "0";
            grid_danju.Cell(2, 9).Text = "0";
            grid_danju.Cell(2, 10).Text = "0";
            grid_danju.Locked = true;
            grid_danju.AutoRedraw = true;
            grid_danju.Refresh();
        }

        private void uiButton11_Click(object sender, EventArgs e)
        {
            Form_Addsp_Dj formspdj = new Form_Addsp_Dj(this);
            formspdj.Text = "串码商品--新增";
            formspdj.ShowDialog();
        }
        public void add_grid_new(string pro_type,string pro_id,string name,string color,string code,string imei,int num,float price,float sum,string note,string cname,string oname)
        {
            grid_danju.Locked = false;
            int n = grid_danju.Rows;
            string te = grid_danju.Cell(n - 2, 1).Text;
            if(te!="")
            {
                grid_danju.InsertRow(n - 1, 1);
                n = n - 1;
            }
            else
            {
                n=n-2;
            }
            
            grid_danju.Cell(n,1).Text = pro_type;
            grid_danju.Cell(n,2).Text = pro_id;
            grid_danju.Cell(n, 3).Text = pro_type;
            grid_danju.Cell(n, 4).Text = name;
            grid_danju.Cell(n, 5).Text = color;
            grid_danju.Cell(n, 6).Text = code;
            grid_danju.Cell(n, 7).Text = imei;
            grid_danju.Cell(n, 8).Text = num.ToString();
            grid_danju.Cell(n, 9).Text = price.ToString();
            grid_danju.Cell(n, 10).Text = (num * price).ToString();
            grid_danju.Cell(n, 11).Text = note;
            grid_danju.Cell(n, 12).Text = oname;
            CalculateSummary_grid();
            grid_danju.Locked = true;
        }
        public void CalculateSummary_grid()
        {
            string line_type = "";
            int n = grid_danju.Rows - 2;
            int sum_n = 0;
            int sum_num = 0;
            float sum_price = 0;
            float sum_sum = 0;
            doc_all_sum = 0;
            doc_spc_num = 0;
            doc_nor_num = 0;

            int ls_zs = 0;
            float ls_xs = 0;
            string tx = "";
            for (int i = 0; i < n; i++)
            {
                line_type = grid_danju.Cell(i+1 , 1).Text;
                if (line_type != "")
                {
                    sum_n++;
                    tx = grid_danju.Cell(i + 1, 8).Text;
                    ls_zs = Convert.ToInt32(tx);
                    if(line_type=="串码")
                    {
                        doc_spc_num += ls_zs;
                    }
                    else
                    {
                        doc_nor_num+= ls_zs;
                    }
                    sum_num += ls_zs;
                    tx = grid_danju.Cell(i + 1, 9).Text;
                    ls_xs = Convert.ToSingle(tx);
                    sum_price += ls_xs;
                    tx = grid_danju.Cell(i + 1, 10).Text;
                    ls_xs = Convert.ToSingle(tx);
                    sum_sum += ls_xs;
                }

            }

            doc_all_sum = sum_sum;
            n = grid_danju.Rows - 1;
            grid_danju.Cell(n, 5).Text ="记录数:"+ sum_n.ToString();
            grid_danju.Cell(n, 8).Text = sum_num.ToString();
            grid_danju.Cell(n, 9).Text = sum_price.ToString();
            grid_danju.Cell(n, 10).Text = sum_sum.ToString();
        }
        private void Form_Danju_Shown(object sender, EventArgs e)
        {
            if (uiPanel_client.Text == null)
            {
                FormChoseClient formChoseClient = new FormChoseClient(this);
                formChoseClient.Text = "选择供应商";
                formChoseClient.ShowDialog();
            }
        }

        private void uiLabel7_Click(object sender, EventArgs e)
        {
            FormChoseClient formChoseClient = new FormChoseClient(this);
            formChoseClient.Text = "选择供应商";
            formChoseClient.ShowDialog();
        }

        private void uiButton_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }

        private void grid_danju_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cell ac = grid_danju.ActiveCell;
            string at=grid_danju.Cell(ac.Row,1).Text;
            if(at !="")
            {
                Form_Inputprice infrom = new Form_Inputprice(this);
                infrom.ShowDialog();
            }
        }

        private void uiButton_bc_Click(object sender, EventArgs e)
        {
            JObject job = new JObject();
            JArray jArray = new JArray();
            job["type"] = from_type_shot;
            string cliid = uiPanel_client.Text;
            job["client_id"] =Util.midstr(ref cliid ,"(",")");
            job["custom_id"] = "";
            job["note"] = uiTextBox_note.Text;
            job["creator"] = uiLabel_bzdr.Text;
            job["unorder"] = uiPanel_order.Text;
            job["trans"] = uiPanel_trans.Text;
            job["special_num"] = doc_spc_num;
            job["normal_num"] = doc_nor_num;
            job["doc_sum"] = doc_all_sum;
            int n = grid_danju.Rows - 2;
            for (int i = 0; i < n; i++)
            {
                JObject cjob = new JObject();
                cjob["customid"] = grid_danju.Cell(i + 1, 2).Text;
                cjob["type"] = grid_danju.Cell(i + 1, 1).Text=="串码"?0:1;
                cjob["imei"] = grid_danju.Cell(i + 1, 7).Text;
                cjob["num"] = grid_danju.Cell(i + 1, 8).Text;
                cjob["price"] = grid_danju.Cell(i + 1, 9).Text;
                cjob["sum"] = grid_danju.Cell(i + 1, 10).Text;
                jArray.Add(cjob);
            }
            job["items"] = jArray;

            string body = job.ToString();
            string rel = Util.httppost("/stock/v2/add", ref body, Util.G_token);
            JObject rjob = (JObject)JsonConvert.DeserializeObject(rel);

            // 访问解析后的JSON数据
            int code = ((int)rjob["code"]);
            string msg = ((string)rjob["msg"]);
            if (code == -1)
            {
                MessageBox.Show(msg);
            }
            else
            {
                string doc_id= ((string)rjob["doc_id"]);
                string doc_time = ((string)rjob["doc_time"]);
                doc_time = Util.getNowDate(doc_time);
                uiPanel_djid.Text = doc_id;
                uiPanel_djday.Text= doc_time;
                uiButton_bc.Enabled = false;
            }
               
        }

        private void uiButton_bnr_add_Click(object sender, EventArgs e)
        {
            Form_Addnr_Dj formspdj = new Form_Addnr_Dj(this);
            formspdj.Text = "普通商品--新增";
            formspdj.ShowDialog();
        }

        private void uiTextBox_note_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar=='\r')
            {
                uiButton_bsp_add.Focus();
            }
        }

        private void uiButton_xd_Click(object sender, EventArgs e)
        {
            pfrom.ordnewfrom();
            this.Close();
        }

        private void uiButton_gz_Click(object sender, EventArgs e)
        {
            string tx = uiPanel_djid.Text;
            if(tx!="")
            {
                string pram = "?id="+tx+"&posed=" + WebUtility.UrlEncode(Util.G_name);
                string rel = Util.httpget("/stock/v2/pos" + pram, Util.G_token);
                MessageBox.Show(rel);
            }
            
        }
    }
}
