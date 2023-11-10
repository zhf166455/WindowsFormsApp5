using Newtonsoft.Json.Linq;
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

namespace WindowsFormsApp5
{
    public partial class Form_Pro_Class_Min : Form
    {
        private string from_type;
        public Form_Pro_Class_Min(string from_type)
        {
            InitializeComponent();
            this.from_type = from_type;
        }

        private void Form_Pro_Class_Min_Load(object sender, EventArgs e)
        {
            if(from_type =="串码")
            {
                this.Text = "串码商品小类--新增";
            }
            else
            {
                this.Text = "普通商品小类--新增";
            }
            uiTextBox_name.Focus();
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiSymbolButton_ok_Click(object sender, EventArgs e)
        {
            
             string name = uiTextBox_name.Text;
             if (name == "")
                 return;
             string id = uiLabel_cidmax.Text;
             string check = uiCheckBox_check.Checked ? "true" : "false";
             string pram = "?id=" + id + "&name=" + WebUtility.UrlEncode(name) + "&check=" + check;
            string rel = "";
             if (from_type == "串码")
            {
                rel = Util.httpget("/special/addMinClass" + pram, Util.G_token);
            }
             else
            {
                rel = Util.httpget("/normal/addMinClass" + pram, Util.G_token);
            }
              
             MessageBox.Show(rel);
            
        }
    }
}
