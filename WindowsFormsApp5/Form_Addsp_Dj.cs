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

namespace WindowsFormsApp5
{
    public partial class Form_Addsp_Dj : Form
    {
        private Form_Danju pfrom;
        public Form_Addsp_Dj(Form_Danju pfrom)
        {
            InitializeComponent();
            this.pfrom = pfrom;
        }

        private void uiTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiTextBox_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                getspinfo();
            }
        }
        private void getspinfo()
        {
            string pram = uiTextBox_code.Text;
            if (!string.IsNullOrEmpty(pram))
            {
                pram = "?code=" + pram;
                string rel = Util.httpget("/track/getProductByCode" + pram, Util.G_token);
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
                    string cid = (string)(job["item"]["custom_id"]);
                    string classname = (string)(job["item"]["classname"]);
                    string color = (string)(job["item"]["color"]);
                    string name = (string)(job["item"]["name"]);

                    uiTextBox_cid.Text = cid;
                    uiTextBox_class.Text = classname;
                    uiTextBox_name.Text = name;
                    uiTextBox_color.Text = color;
                    uiTextBox_imei.Focus();
                }
            }


        }
        private void uiTextBox_imei_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                pfrom.add_grid_new("串码", uiTextBox_cid.Text, uiTextBox_name.Text, uiTextBox_color.Text,uiTextBox_code.Text,uiTextBox_imei.Text,1,1,1,uiTextBox_onote.Text,uiTextBox_class.Text,"");
                this.Close();
            }
        }
        private void Form_Addsp_Dj_Load(object sender, EventArgs e)
        {

        }

        private void uiTextBox_cid_ButtonClick(object sender, EventArgs e)
        {
            Form_Chose_Pro_Dj mainfrom = new Form_Chose_Pro_Dj(this);
            mainfrom.from_type = "串码";
            mainfrom.Text = "选择普通商品";
            mainfrom.ShowDialog();
        }
    }

     
}
