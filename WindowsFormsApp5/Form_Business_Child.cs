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
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms.VisualStyles;
using Sunny.UI;

namespace WindowsFormsApp5
{
    public partial class Form_Business_Child : Form
    {
        private string from_type;
        private string pfrom_type;
        private string st;
        private string et;
        public Form_Business_Child(string from_type, string pfrom_type, string st, string et)
        {
            InitializeComponent();
            this.from_type = from_type;
            this.pfrom_type = pfrom_type;
            this.st = st;
            this.et = et;
        }

        private void Form_Business_Child_Load(object sender, EventArgs e)
        {
            init_grid();
            if (from_type == "供应商")
            {
                uiLabel2.Text = "业务详情";
                string pram = "?day_start=" + st + "&day_end=" + et + "&type=CG";
                string rel = Util.httpget("/summary/v2/get_client" + pram, Util.G_token);
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
                        grid1.Locked = false;
                        grid1.AutoRedraw = false;
                        grid1.InsertRow(1, n - 1);

                        for (int i = 0; i < n; i++)
                        {
                            string doc_day = (string)(job["items"][i]["doc_day"]);
                            string clientid = (string)(job["items"][i]["client_id"]);
                            string client = (string)(job["items"][i]["client"]);
                            int snum = (int)(job["items"][i]["special_num"]);
                            int nnum = (int)(job["items"][i]["normal_num"]);
                            float sum = (float)(job["items"][i]["sum"]);

                            grid1.Cell(i + 1, 1).Text = (i + 1).ToString("D5");
                            grid1.Cell(i + 1, 2).Text = client;
                            grid1.Cell(i + 1, 3).Text = doc_day;
                            grid1.Cell(i + 1, 4).Text = (snum + nnum).ToString();
                            grid1.Cell(i + 1, 5).Text = sum.ToString();
                            grid1.Cell(i + 1, 6).Text = sum.ToString();
                            grid1.Cell(i + 1, 7).Text = clientid;
                        }


                        grid1.AutoRedraw = true;
                        grid1.Locked = true;
                        Calculate_grid_l();
                        setbotomrowcolor();
                        grid1.Refresh();
                    }
                }
            }
            else
            {
                uiLabel2.Text = "商品详情";
                string pram = "?day_start=" + st + "&day_end=" + et + "&type=CG";
                string rel = Util.httpget("/summary/v2/get_product" + pram, Util.G_token);
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
                        grid1.Locked = false;
                        grid1.AutoRedraw = false;
                        grid1.InsertRow(1, n - 1);

                        for (int i = 0; i < n; i++)
                        {
                            string proid = (string)(job["items"][i]["custom_id"]);
                            string proclass = (string)(job["items"][i]["class"]);
                            string proname = (string)(job["items"][i]["name"]);
                            string prooname = (string)(job["items"][i]["oname"]);
                            string procolor = (string)(job["items"][i]["color"]);
                            int pronum = (int)(job["items"][i]["num"]);

                            grid1.Cell(i + 1, 1).Text = proclass;
                            grid1.Cell(i + 1, 2).Text = proname;
                            grid1.Cell(i + 1, 3).Text = prooname;
                            grid1.Cell(i + 1, 4).Text = procolor;
                            grid1.Cell(i + 1, 5).Text = pronum.ToString();
                            grid1.Cell(i + 1, 8).Text = proid;
                        }


                        grid1.AutoRedraw = true;
                        grid1.Locked = true;
                        Calculate_grid_l_pro();
                        setbotomrowcolor();
                        grid1.Refresh();
                    }
                }
            }
         }

        private void init_grid_r()
        {
            grid2.Locked = false;
            grid2.AutoRedraw = false;
            grid2.Rows = 3;
            grid2.Range(0,0,2,15).ClearAll();

            grid2.Column(0).Width = 10;
            grid2.Column(1).Width = 40;
            grid2.Column(2).Width = 40;
            grid2.Column(3).Width = 100;
            grid2.Column(4).Width = 100;
            grid2.Column(5).Width = 120;
            grid2.Column(6).Width = 100;
            grid2.Column(7).Width = 60;
            grid2.Column(8).Width = 120;
            grid2.Column(9).Width = 120;
            grid2.Column(10).Width = 100;
            grid2.Column(11).Width = 120;
            grid2.Column(12).Width = 100;
            grid2.Column(13).Width = 100;
            grid2.Column(14).Width = 100;
            grid2.Column(15).Width = 100;

            grid2.Cell(0, 1).Text = "过账";
            grid2.Cell(0, 2).Text = "核销";
            grid2.Cell(0, 3).Text = "营业部";
            grid2.Cell(0, 4).Text = "单据类型";
            grid2.Cell(0, 5).Text = "单据编号";
            grid2.Cell(0, 6).Text = "单据日期";
            grid2.Cell(0, 7).Text = "制单时间";
            grid2.Cell(0, 8).Text = "供应商";
            grid2.Cell(0, 9).Text = "商品编码";
            grid2.Cell(0, 10).Text = "类别";
            grid2.Cell(0, 11).Text = "商品名称";
            grid2.Cell(0, 12).Text = "别名";
            grid2.Cell(0, 13).Text = "颜色";
            grid2.Cell(0, 14).Text = "条码";
            grid2.Cell(0, 15).Text = "数量";

            grid2.Column(1).CellType = FlexCell.CellTypeEnum.TextBox;
            grid2.Column(2).CellType = FlexCell.CellTypeEnum.TextBox;
            grid2.Cell(2, 4).Text = "记录数:0";
            grid2.Cell(2, 15).Text = "0";
            grid2.Range(grid2.Rows - 1, 1, grid2.Rows - 1, grid2.Cols - 1).BackColor = Color.White;

            grid2.Locked = true;
            grid2.AutoRedraw = true;
            grid2.Refresh();
        }

        private void init_grid()
        {
            if (from_type== "供应商")
            {
                grid1.Locked = false;
                grid1.AutoRedraw = false;
                grid1.Rows = 3;
                grid1.Cols = 8;

                grid1.Column(0).Width = 10;
                grid1.Column(1).Width = 80;
                grid1.Column(2).Width = 120;
                grid1.Column(3).Width = 100;
                grid1.Column(4).Width = 100;
                grid1.Column(5).Width = 100;
                grid1.Column(6).Width = 120;
                grid1.Column(7).Width = 0;

                grid1.Cell(0, 1).Text = "编号";
                grid1.Cell(0, 2).Text = "供应商";
                grid1.Cell(0, 3).Text = "日期";
                grid1.Cell(0, 4).Text = "商品数量";
                grid1.Cell(0, 5).Text = "合计金额";
                grid1.Cell(0, 6).Text = "未核销金额";
                grid1.Cell(0, 7).Text = "供应商编号";

                grid1.Column(5).Mask = FlexCell.MaskEnum.Numeric;
                grid1.Column(5).DecimalLength = 2;
                grid1.Column(6).Mask = FlexCell.MaskEnum.Numeric;
                grid1.Column(6).DecimalLength = 2;

                grid1.Locked = true;
                grid1.AutoRedraw = true;
                grid1.Refresh();
            }
            else
            {
                grid1.Locked = false;
                grid1.AutoRedraw = false;
                grid1.Rows = 3;
                grid1.Cols = 9;

                grid1.Column(0).Width = 10;
                grid1.Column(1).Width = 120;
                grid1.Column(2).Width = 120;
                grid1.Column(3).Width = 100;
                grid1.Column(4).Width = 100;
                grid1.Column(5).Width = 100;
                grid1.Column(6).Width = 100;

                grid1.Cell(0, 1).Text = "类别";
                grid1.Cell(0, 2).Text = "商品名称";
                grid1.Cell(0, 3).Text = "别名";
                grid1.Cell(0, 4).Text = "颜色";
                grid1.Cell(0, 5).Text = "商品数量";
                grid1.Cell(0, 6).Text = "均价";
                grid1.Cell(0, 7).Text = "合计金额";
                grid1.Cell(0, 8).Text = "商品编码";

                grid1.Locked = true;
                grid1.AutoRedraw = true;
                grid1.Refresh();
            }

            grid2.Locked= false; 
            grid2.AutoRedraw = false;
            grid2.Rows = 3;

            grid2.Column(0).Width = 10;
            grid2.Column(1).Width = 40;
            grid2.Column(2).Width = 40;
            grid2.Column(3).Width = 100;
            grid2.Column(4).Width = 100;
            grid2.Column(5).Width = 120;
            grid2.Column(6).Width = 100;
            grid2.Column(7).Width = 60;
            grid2.Column(8).Width = 120;
            grid2.Column(9).Width = 120;
            grid2.Column(10).Width = 100;
            grid2.Column(11).Width = 120;
            grid2.Column(12).Width = 100;
            grid2.Column(13).Width = 100;
            grid2.Column(14).Width = 100;
            grid2.Column(15).Width = 100;

            grid2.Cell(0,1).Text= "过账";
            grid2.Cell(0,2).Text= "核销";
            grid2.Cell(0,3).Text= "营业部";
            grid2.Cell(0,4).Text= "单据类型";
            grid2.Cell(0,5).Text= "单据编号";
            grid2.Cell(0,6).Text= "单据日期";
            grid2.Cell(0,7).Text= "制单时间";
            grid2.Cell(0,8).Text= "供应商";
            grid2.Cell(0,9).Text= "商品编码";
            grid2.Cell(0,10).Text= "类别";
            grid2.Cell(0,11).Text="商品名称";
            grid2.Cell(0,12).Text="别名";
            grid2.Cell(0,13).Text="颜色";
            grid2.Cell(0,14).Text="条码";
            grid2.Cell(0,15).Text="数量";

            grid2.Locked = true;
            grid2.AutoRedraw = true;
            grid2.Refresh();
        }

        private void Calculate_grid_l_pro()
        {
            int n = grid1.Rows - 1;
            int sum_n = 0;
            int sum_num = 0;
            float sum_price = 0;
            float sum_sum = 0;

            int ls_zs = 0;
            float ls_xs = 0;
            string tx = "";
            for (int i = 0; i < n; i++)
            {
                tx = grid1.Cell(i + 1, 1).Text;
                if (tx != "")
                {
                    sum_n++;
                    tx = grid1.Cell(i + 1, 5).Text;
                    ls_zs = Convert.ToInt32(tx);
                    sum_num += ls_zs;
                    tx = grid1.Cell(i + 1, 6).Text;
                    if (tx == "")
                        ls_xs = 0;
                    else
                        ls_xs = Convert.ToSingle(tx);
                    sum_price += ls_xs;
                    tx = grid1.Cell(i + 1, 7).Text;
                    if (tx == "")
                        ls_xs = 0;
                    else
                        ls_xs = Convert.ToSingle(tx);
                    sum_sum += ls_xs;
                }

            }

            n = grid1.Rows - 1;
            grid1.Cell(n, 2).Text = "记录数:" + sum_n.ToString();
            grid1.Cell(n, 5).Text = sum_num.ToString();
            grid1.Cell(n, 6).Text = sum_price.ToString();
            grid1.Cell(n, 7).Text = sum_sum.ToString();
        }

        private void Calculate_grid_l()
        {
            int n = grid1.Rows - 1;
            int sum_n = 0;
            int sum_num = 0;
            float sum_price = 0;
            float sum_sum = 0;

            int ls_zs = 0;
            float ls_xs = 0;
            string tx = "";
            for (int i = 0; i < n; i++)
            {
                tx = grid1.Cell(i + 1, 1).Text;
                if (tx != "")
                {
                    sum_n++;
                    tx = grid1.Cell(i + 1, 4).Text;
                    ls_zs = Convert.ToInt32(tx);
                    sum_num += ls_zs;
                    tx = grid1.Cell(i + 1, 5).Text;
                    ls_xs = Convert.ToSingle(tx);
                    sum_price += ls_xs;
                    tx = grid1.Cell(i + 1, 6).Text;
                    if(tx=="")
                        ls_xs = 0;
                    else
                        ls_xs = Convert.ToSingle(tx);
                    sum_sum += ls_xs;
                }

            }

            n = grid1.Rows - 1;
            grid1.Cell(n, 2).Text = "记录数:" + sum_n.ToString();
            grid1.Cell(n, 4).Text = sum_num.ToString();
            grid1.Cell(n, 5).Text = sum_price.ToString();
            grid1.Cell(n, 6).Text = sum_sum.ToString();
        }
        private void setbotomrowcolor()
        {
            grid1.Range(grid1.Rows - 1, 1, grid1.Rows - 1, grid1.Cols - 1).BackColor = Color.White;
        }

        

        private void get_summary_detial_client(string cid,string ctype,string st)
        {
            string pram = "?day_start=" + st + "&day_end=" + st + "&type="+ ctype + "&client="+ cid;
            string rel = Util.httpget("/summary/v2/getdetial_client" + pram, Util.G_token);
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
                init_grid_r();
                int n = job["items"].Count();
                if (n > 0)
                {
                    grid2.Locked = false;
                    grid2.AutoRedraw = false;
                    grid2.InsertRow(1, n - 1);
                    grid2.Column(1).CellType = FlexCell.CellTypeEnum.CheckBox;
                    grid2.Column(2).CellType = FlexCell.CellTypeEnum.CheckBox;

                    for (int i = 0; i < n; i++)
                    {
                        bool po = (bool)(job["items"][i]["po"]);
                        bool vo = (bool)(job["items"][i]["vo"]);
                        string custom_id = (string)(job["items"][i]["custom_id"]);
                        string doc_type= (string)(job["items"][i]["type"]);
                        string doc_day= (string)(job["items"][i]["doc_time"]);
                        string doc_client = (string)(job["items"][i]["client_name"]);
                        string proid = (string)(job["items"][i]["pc_custom_id"]);
                        string prclass = (string)(job["items"][i]["classname"]);
                        string proname = (string)(job["items"][i]["pro_name"]);
                        string prooname = (string)(job["items"][i]["pro_oname"]);
                        string pc_color = (string)(job["items"][i]["pc_color"]);
                        string pc_code = (string)(job["items"][i]["pc_code"]);
                        string pc_num = "999";


                        grid2.Cell(i + 1, 1).Text =po?"true":"false";
                        grid2.Cell(i + 1, 2).Text = vo ? "true" : "false";
                        grid2.Cell(i + 1, 3).Text = Util.G_dname;
                        grid2.Cell(i + 1, 4).Text = doc_type;
                        grid2.Cell(i + 1, 5).Text = custom_id;
                        grid2.Cell(i + 1, 6).Text =Util.getNowDate(doc_day);
                        grid2.Cell(i + 1, 7).Text =Util.getNowTime(doc_day);
                        grid2.Cell(i + 1, 8).Text = doc_client;
                        grid2.Cell(i + 1, 9).Text = proid;
                        grid2.Cell(i + 1, 10).Text = prclass;
                        grid2.Cell(i + 1, 11).Text = proname;
                        grid2.Cell(i + 1, 12).Text = prooname;
                        grid2.Cell(i + 1, 13).Text = pc_color;
                        grid2.Cell(i + 1, 14).Text = pc_code;
                        grid2.Cell(i + 1, 15).Text = pc_num;
                    }


                    grid2.AutoRedraw = true;
                    grid2.Locked = true;
                    grid2.Cell(grid2.Rows-1, 1).CellType = FlexCell.CellTypeEnum.TextBox;
                    grid2.Cell(grid2.Rows - 1, 2).CellType = FlexCell.CellTypeEnum.TextBox;
                    Calculate_grid_r();
                    grid2.Refresh();
                }

            }

        }

        private void get_summary_detial_pro(string cid, string ctype, string st,string et)
        {
            string pram = "?day_start=" + st + "&day_end=" + et + "&type=" + ctype + "&customid=" + cid;
            string rel = Util.httpget("/summary/v2/getdetial_product" + pram, Util.G_token);
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
                init_grid_r();
                int n = job["items"].Count();
                if (n > 0)
                {
                    grid2.Locked = false;
                    grid2.AutoRedraw = false;
                    grid2.InsertRow(1, n - 1);
                    grid2.Column(1).CellType = FlexCell.CellTypeEnum.CheckBox;
                    grid2.Column(2).CellType = FlexCell.CellTypeEnum.CheckBox;

                    for (int i = 0; i < n; i++)
                    {
                        bool po = (bool)(job["items"][i]["po"]);
                        bool vo = (bool)(job["items"][i]["vo"]);
                        string custom_id = (string)(job["items"][i]["custom_id"]);
                        string doc_type = (string)(job["items"][i]["type"]);
                        string doc_day = (string)(job["items"][i]["doc_time"]);
                        string doc_client = (string)(job["items"][i]["client_name"]);
                        string proid = (string)(job["items"][i]["pc_custom_id"]);
                        string prclass = (string)(job["items"][i]["classname"]);
                        string proname = (string)(job["items"][i]["pro_name"]);
                        string prooname = (string)(job["items"][i]["pro_oname"]);
                        string pc_color = (string)(job["items"][i]["pc_color"]);
                        string pc_code = (string)(job["items"][i]["pc_code"]);
                        string pc_num = "999";


                        grid2.Cell(i + 1, 1).Text = po ? "true" : "false";
                        grid2.Cell(i + 1, 2).Text = vo ? "true" : "false";
                        grid2.Cell(i + 1, 3).Text = Util.G_dname;
                        grid2.Cell(i + 1, 4).Text = doc_type;
                        grid2.Cell(i + 1, 5).Text = custom_id;
                        grid2.Cell(i + 1, 6).Text = Util.getNowDate(doc_day);
                        grid2.Cell(i + 1, 7).Text = Util.getNowTime(doc_day);
                        grid2.Cell(i + 1, 8).Text = doc_client;
                        grid2.Cell(i + 1, 9).Text = proid;
                        grid2.Cell(i + 1, 10).Text = prclass;
                        grid2.Cell(i + 1, 11).Text = proname;
                        grid2.Cell(i + 1, 12).Text = prooname;
                        grid2.Cell(i + 1, 13).Text = pc_color;
                        grid2.Cell(i + 1, 14).Text = pc_code;
                        grid2.Cell(i + 1, 15).Text = pc_num;
                    }


                    grid2.AutoRedraw = true;
                    grid2.Locked = true;
                    grid2.Cell(grid2.Rows - 1, 1).CellType = FlexCell.CellTypeEnum.TextBox;
                    grid2.Cell(grid2.Rows - 1, 2).CellType = FlexCell.CellTypeEnum.TextBox;
                    Calculate_grid_r();
                    grid2.Refresh();
                }

            }

        }

        private void Calculate_grid_r()
        {
            
            int n = grid2.Rows - 1;
            int sum_n = 0;
            int sum_num = 0;
            int ls_zs = 0;

            string tx = "";
            for (int i = 0; i < n; i++)
            {
                tx = grid2.Cell(i + 1, 1).Text;
                if (tx != "")
                {
                    sum_n++;
                    tx = grid2.Cell(i + 1, 15).Text;
                    ls_zs = Convert.ToInt32(tx);
                    sum_num += ls_zs;
                }

            }

            n = grid2.Rows - 1;
            grid2.Cell(n, 4).Text = "记录数:" + sum_n.ToString();
            grid2.Cell(n, 15).Text = sum_num.ToString();
            grid2.Range(grid2.Rows - 1, 1, grid2.Rows - 1, grid2.Cols - 1).BackColor = Color.White;
        }

        private void grid1_RowColChange(object Sender, Grid.RowColChangeEventArgs e)
        {
            if (from_type == "供应商")
            {
                Cell ac = grid1.ActiveCell;
                int n = ac.Row;
                string tx = grid1.Cell(n, 2).Text;
                string dtx = grid1.Cell(n, 3).Text;
                string cid = grid1.Cell(n, 7).Text;
                if (tx != "")
                {
                    uiLabel2.Text = "业务详情 日期：" + dtx + " 供应商：" + tx;
                    get_summary_detial_client(cid, "CG", dtx);
                }
                else
                {
                    uiLabel2.Text = "业务详情";
                }

            }
            else
            {
                uiLabel2.Text = " 商品：苹果14 128G 颜色：黑色";

                Cell ac = grid1.ActiveCell;
                int n = ac.Row;
                string tx = grid1.Cell(n, 2).Text;
                string dtx = grid1.Cell(n, 4).Text;
                string cid = grid1.Cell(n, 8).Text;

                if (tx != "")
                {
                    uiLabel2.Text = "商品详情 商品：" + tx + " 颜色：" + dtx;
                    get_summary_detial_pro(cid, "CG",this.st,this.et);
                }
                else
                {
                    uiLabel2.Text = "商品详情";
                }
            }
        }

        private void 导出到excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            Cell ac = grid1.ActiveCell;
            int n = ac.Row;

            if(from_type== "供应商")
            {
                string tx = grid1.Cell(n, 2).Text;
                string dtx = grid1.Cell(n, 3).Text;
                string cid = grid1.Cell(n, 7).Text;

                string sname = "供应商汇总详细" + tx + dtx;

                saveFileDialog1.InitialDirectory = path;
                saveFileDialog1.FileName = sname;
                DialogResult rel = saveFileDialog1.ShowDialog(this);
                if (rel == DialogResult.OK)
                {
                    path = saveFileDialog1.FileName;
                    grid2.ExportToExcel(path, true, false);
                    MessageBox.Show("导出成功");
                }
            }
            else
            {
                string tx = grid1.Cell(n, 8).Text;

                string sname = "商品汇总详细" + tx;

                saveFileDialog1.InitialDirectory = path;
                saveFileDialog1.FileName = sname;
                DialogResult rel = saveFileDialog1.ShowDialog(this);
                if (rel == DialogResult.OK)
                {
                    path = saveFileDialog1.FileName;
                    grid2.ExportToExcel(path, true, false);
                    MessageBox.Show("导出成功");
                }
            }
            
        }

        private void 导出到excelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string ti = Util.getNowDate() + Util.getNowTime();
            ti = ti.Replace("-", "");
            ti = ti.Replace(":", "");
            string sname =from_type=="供应商"?"按供应商汇总":"按商品汇总";
            
            saveFileDialog2.FileName = sname + ti;

            saveFileDialog2.InitialDirectory = path;
            
            DialogResult rel = saveFileDialog2.ShowDialog(this);
            if (rel == DialogResult.OK)
            {
                path = saveFileDialog2.FileName;
                grid1.ExportToExcel(path, true, false);
                MessageBox.Show("导出成功");
            }
        }
    }
}
