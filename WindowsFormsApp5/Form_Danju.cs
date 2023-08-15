using FlexCell;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class Form_Danju : Form
    {
        public Form_Danju()
        {
            InitializeComponent();
        }

        private void Form_Danju_Load(object sender, EventArgs e)
        {
            uiPanel_der.Text = Util.G_dname;
            uiLabel_bzdr.Text = Util.G_name;
            uiLabel_bzdt.Text = "2023/08/14";
            init_grid();
            
        }
        private void init_grid()
        {
            grid_danju.AutoRedraw = false;
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
            

            grid_danju.Column(1).CellType = FlexCell.CellTypeEnum.TextBox;
            grid_danju.Column(2).CellType = FlexCell.CellTypeEnum.TextBox;
            grid_danju.Cell(2, 5).Text = "记录数:0";
            grid_danju.Column(9).Mask = FlexCell.MaskEnum.Numeric;
            grid_danju.Column(9).DecimalLength = 2;

            grid_danju.Cell(2, 8).Text = "0";
            grid_danju.Cell(2, 9).Text = "0";
            grid_danju.Cell(2, 10).Text = "0";
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
            grid_danju.Cell(n, 10).Text = sum.ToString();
            grid_danju.Cell(n, 11).Text = note;
            grid_danju.Cell(n, 12).Text = oname;
            CalculateSummary_grid();
        }
        private void CalculateSummary_grid()
        {
            int n = grid_danju.Rows - 2;
            int sum_n = 0;
            int sum_num = 0;
            float sum_price = 0;
            float sum_sum = 0;

            int ls_zs = 0;
            float ls_xs = 0;
            string tx = "";
            for (int i = 0; i < n; i++)
            {
                tx = grid_danju.Cell(n + 1, 2).Text;
                if (tx != "")
                {
                    sum_n++;
                    tx = grid_danju.Cell(n + 1, 8).Text;
                    ls_zs = Convert.ToInt32(tx);
                    sum_num += ls_zs;
                    tx = grid_danju.Cell(n + 1, 9).Text;
                    ls_xs = Convert.ToSingle(tx);
                    sum_price += ls_xs;
                    tx = grid_danju.Cell(n + 1, 10).Text;
                    ls_xs = Convert.ToSingle(tx);
                    sum_sum += ls_xs;
                }

            }

            MessageBox.Show(sum_n.ToString());
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
            MessageBox.Show(ac.Row.ToString());
        }

        private void uiButton_bc_Click(object sender, EventArgs e)
        {
            JObject job = new JObject();
            JArray jArray = new JArray();
            job["type"] = Util.getshortcode();
            string cliid = uiPanel_client.Text;
            job["client_id"] =Util.midstr(ref cliid ,"(",")");
            job["custom_id"] = "";
            job["note"] = uiTextBox_note.Text;
            job["create"] = uiLabel_bzdr.Text;
            job["unorder"] = uiPanel_order.Text;
            job["trans"] = uiPanel_trans.Text;
            job["special_num"] = 1;
            job["normal_num"] = 1;
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
                string doc_time = "2023-08-14";
                uiPanel_djid.Text = doc_id;
                uiPanel_djday.Text= doc_time;
            }
               
        }

        private void uiButton_bnr_add_Click(object sender, EventArgs e)
        {
            Form_Addnr_Dj formspdj = new Form_Addnr_Dj(this);
            formspdj.Text = "普通商品--新增";
            formspdj.ShowDialog();
        }
    }
}
