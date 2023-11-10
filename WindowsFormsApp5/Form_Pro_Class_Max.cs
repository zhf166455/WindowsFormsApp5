using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp5
{
    public partial class Form_Pro_Class_Max : Form
    {
        private string from_type;
        public Form_Pro_Class_Max(string from_type)
        {
            InitializeComponent();
            this.from_type = from_type;
        }

        private void Form_Pro_Class_Max_Load(object sender, EventArgs e)
        {
            if(from_type=="串码")
            {
                this.Text = "串码商品大类--新增";
            }
            else
            {
                this.Text = "普通商品大类--新增";
            }
        }

        private void uiSymbolButton_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiSymbolButton_ok_Click(object sender, EventArgs e)
        {
            if(uiTextBox_cid.Text=="" ||  uiTextBox_name.Text=="")
            {
                MessageBox.Show("请输入正确的编号或名称");
                return;
            }
            string cid = uiTextBox_cid.Text;
            string name = WebUtility.UrlEncode(uiTextBox_name.Text);
            string pram;
            string check = uiCheckBox_check.Checked ? "true" : "false";
            pram = "?id="+cid+"&name="+name+"&check="+ check;
            string rel="";
            if (from_type=="串码")
            {
                rel = Util.httpget("/special/addMaxClass"+pram, Util.G_token);
            }
            else
            {
                rel = Util.httpget("/normal/addMaxClass" + pram, Util.G_token);
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
                MessageBox.Show("新建成功");
                this.Close();
            }
        }
    }
}
