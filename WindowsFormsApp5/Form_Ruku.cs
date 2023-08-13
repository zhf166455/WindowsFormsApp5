using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp.Serializers.Json;
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
    public partial class Form_Ruku : Form
    {
        public Form_Ruku()
        {
            InitializeComponent();
        }

        private void Form_Ruku_Load(object sender, EventArgs e)
        {
            uiComboBox1.SelectedIndex=0;
            init_gridruku();
        }
        private void init_gridruku()
        {
            grid_ruku.AutoRedraw = false;
            grid_ruku.Rows = 4;
            grid_ruku.Range(0, 1, 3, 14).Locked = false;
            grid_ruku.Range(0,1,3,14).ClearAll();

            grid_ruku.Column(0).Width = 10;
            grid_ruku.Column(1).Width = 30;
            grid_ruku.Column(2).Width = 30;
            grid_ruku.Column(3).Width = 100;
            grid_ruku.Column(4).Width = 100;
            grid_ruku.Column(5).Width = 140;
            grid_ruku.Column(6).Width = 200;
            grid_ruku.Column(7).Width = 80;
            grid_ruku.Column(8).Width = 80;
            grid_ruku.Column(9).Width = 120;
            grid_ruku.Column(10).Width = 80;
            grid_ruku.Column(11).Width = 80;
            grid_ruku.Column(12).Width = 80;
            grid_ruku.Column(13).Width = 300;
            grid_ruku.Column(14).Width = 200;

            grid_ruku.Range(0, 0, 1, 0).Merge();
            grid_ruku.Range(0, 1, 1, 1).Merge();
            grid_ruku.Range(0, 2, 1, 2).Merge();
            grid_ruku.Range(0, 3, 1, 3).Merge();
            grid_ruku.Range(0, 4, 1, 4).Merge();
            grid_ruku.Range(0, 5, 1, 5).Merge();
            grid_ruku.Range(0, 6, 1, 6).Merge();
            grid_ruku.Range(0, 9, 1, 9).Merge();
            grid_ruku.Range(0, 10, 1, 10).Merge();
            grid_ruku.Range(0, 11, 1, 11).Merge();
            grid_ruku.Range(0, 12, 1, 12).Merge();
            grid_ruku.Range(0, 13, 1, 13).Merge();
            grid_ruku.Range(0, 14, 1, 14).Merge();
            grid_ruku.Range(0, 7, 0, 8).Merge();

            grid_ruku.Cell(0, 1).Text = "过账";
            grid_ruku.Cell(0, 2).Text = "核销";
            grid_ruku.Cell(0, 3).Text = "营业部";
            grid_ruku.Cell(0, 4).Text = "单据日期";
            grid_ruku.Cell(0, 5).Text = "单据编号";
            grid_ruku.Cell(0, 6).Text = "供应商";
            grid_ruku.Cell(0, 7).Text = "数量";
            grid_ruku.Cell(1, 7).Text = "串码类";
            grid_ruku.Cell(1, 8).Text = "普通类";
            grid_ruku.Cell(0, 9).Text = "单据金额";
            grid_ruku.Cell(0, 10).Text = "经办人";
            grid_ruku.Cell(0, 11).Text = "制单人";
            grid_ruku.Cell(0, 12).Text = "过账人";
            grid_ruku.Cell(0, 13).Text = "备注";
            grid_ruku.Cell(0, 14).Text = "采购订单";

            grid_ruku.Column(1).CellType = FlexCell.CellTypeEnum.TextBox;
            grid_ruku.Column(2).CellType = FlexCell.CellTypeEnum.TextBox;
            grid_ruku.Cell(3, 5).Text = "记录数:0";
            grid_ruku.Column(9).Mask = FlexCell.MaskEnum.Numeric;
            grid_ruku.Column(9).DecimalLength = 2;

            grid_ruku.Cell(3, 7).Text = "0";
            grid_ruku.Cell(3, 8).Text = "0";
            grid_ruku.Cell(3, 9).Text = "0";
            grid_ruku.Range(3, 1, 3, 14).Locked = true;
            grid_ruku.AutoRedraw = true;
            grid_ruku.Refresh();
        }

        private void uiButton_update_Click(object sender, EventArgs e)
        {
            string rel=Util.httpget("/stock/v2/get?type=CG", Util.G_token);
            JObject job = (JObject)JsonConvert.DeserializeObject(rel);

            // 访问解析后的JSON数据
            int code = ((int)job["code"]);
            string msg = ((string)job["msg"]);
            if(code == -1)
            {
                MessageBox.Show(msg);
            }
            else
            {
                int n = job["items"].Count();
                if (n>0)
                {
                    grid_ruku.AutoRedraw = false;
                    grid_ruku.Rows = n + 3;
                    grid_ruku.Column(1).CellType = FlexCell.CellTypeEnum.CheckBox;
                    grid_ruku.Column(2).CellType = FlexCell.CellTypeEnum.CheckBox;
                    for (int i = 0; i < n; i++)
                    {
                        string doc_day = (string)(job["items"][i]["doc_day"]);
                        bool po = (bool)(job["items"][i]["po"]);
                        bool vo = (bool)(job["items"][i]["vo"]);
                        string custom_id = (string)(job["items"][i]["custom_id"]);
                        string client = (string)(job["items"][i]["client"]);
                        int s_num = (int)(job["items"][i]["s_num"]);
                        int n_num = (int)(job["items"][i]["n_num"]);
                        double sum = (double)(job["items"][i]["sum"]);
                        string creator = (string)(job["items"][i]["creator"]);
                        string trans = (string)(job["items"][i]["trans"]);
                        string posted = (string)(job["items"][i]["posted"]);
                        string note = (string)(job["items"][i]["note"]);
                        string order_id = (string)(job["items"][i]["order_id"]);

                        grid_ruku.Cell(i + 2, 1).Text = po ? "1" : "0";
                        grid_ruku.Cell(i + 2, 2).Text = vo ? "1" : "0";
                        grid_ruku.Cell(i + 2, 3).Text = Util.G_dname;
                        grid_ruku.Cell(i + 2, 4).Text = doc_day;
                        grid_ruku.Cell(i + 2, 5).Text = custom_id;
                        grid_ruku.Cell(i + 2, 6).Text = client;
                        grid_ruku.Cell(i + 2, 7).Text = s_num.ToString();
                        grid_ruku.Cell(i + 2, 8).Text = n_num.ToString();
                        grid_ruku.Cell(i + 2, 9).Text = sum.ToString();
                        grid_ruku.Cell(i + 2, 11).Text = creator;
                        grid_ruku.Cell(i + 2, 10).Text = trans;
                        grid_ruku.Cell(i + 2, 12).Text = posted;
                        grid_ruku.Cell(i + 2, 13).Text = note;
                        grid_ruku.Cell(i + 2, 14).Text = order_id;
                    }
                    grid_ruku.Cell(n+2,1).CellType = FlexCell.CellTypeEnum.TextBox;
                    grid_ruku.Cell(n+2,2).CellType = FlexCell.CellTypeEnum.TextBox;
                    grid_ruku.Cell(n + 2, 5).Text = "记录数:0";
                    grid_ruku.Cell(n + 2, 7).Text = "0";
                    grid_ruku.Cell(n + 2, 8).Text = "0";
                    grid_ruku.Cell(n + 2, 9).Text = "0";

                    grid_ruku.AutoRedraw = true;
                    grid_ruku.Refresh();

                }
                else
                {
                    init_gridruku();
                }
                
            }
            
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            init_gridruku();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Form_Danju mainForm = new Form_Danju();
            mainForm.ShowDialog();
        }
    }
}
