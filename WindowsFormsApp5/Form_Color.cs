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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Security.Cryptography;
using FlexCell;

namespace WindowsFormsApp5
{
    public partial class Form_Color : Form
    {
        private Form_Addsp pfrom;
        private string from_type;
        private string ccname;
        private string ccode;
        public Form_Color(Form_Addsp pfrom, string from_type,string cname,string ccode)
        {
            InitializeComponent();
            this.pfrom = pfrom;
            this.from_type = from_type;
            this.ccname = cname;
            this.ccode = ccode;
        }

        private void Form_Color_Load(object sender, EventArgs e)
        {
            if(ccname!="" && ccode!="")
            {
                Text = "商品颜色详情--修改";
                uiTextBox_color.Text = ccname;
                uiTextBox_code.Text = ccode;
            }
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if(uiTextBox_color.Text=="" || uiTextBox_code.Text=="")
            {
                MessageBox.Show("不接受空数据");
                return;
            }

            //检测该条码是否可用
            string parm ="?barcode="+ uiTextBox_code.Text;
            if (from_type=="串码")
            {
                string curr_code=uiTextBox_code.Text;
                if(curr_code!=ccode)
                {
                    string rel = Util.httpget("/special/checkcode" + parm, Util.G_token);

                    JObject job = (JObject)JsonConvert.DeserializeObject(rel);

                    // 访问解析后的JSON数据
                    int code = ((int)job["code"]);
                    string msg = ((string)job["msg"]);

                    if (code == -1)
                    {
                        MessageBox.Show(msg);
                        return;
                    }
                    else
                    {
                        if (msg == "err")
                        {
                            MessageBox.Show("条码已被其他商品占用");
                            return;
                        }
                    }
                }
                
            }
            else
            {
                
            }
            if(ccode=="")
            {
                int n = pfrom.grid1.Rows;
                string tx = pfrom.grid1.Cell(n - 1, 1).Text;
                if (tx == "")
                {
                    n--;
                }
                else
                {
                    pfrom.grid1.Rows = n + 1;
                }
                pfrom.grid1.Column(4).CellType = FlexCell.CellTypeEnum.CheckBox;
                pfrom.grid1.Cell(n, 1).Text = n < 9 ? "0" + n.ToString() : n.ToString();
                pfrom.grid1.Cell(n, 2).Text = uiTextBox_color.Text;
                pfrom.grid1.Cell(n, 3).Text = uiTextBox_code.Text;
                pfrom.grid1.Cell(n, 4).Text = "false";
                pfrom.grid1.Cell(n, 5).Text = "无";
            }
            else
            {
                Cell ac = pfrom.grid1.ActiveCell;
                int n = ac.Row;
                if(n > 0)
                {
                    pfrom.grid1.Cell(n, 2).Text = uiTextBox_color.Text;
                    pfrom.grid1.Cell(n, 3).Text = uiTextBox_code.Text;
                }
            }
            this.Close();
        }
    }
}
