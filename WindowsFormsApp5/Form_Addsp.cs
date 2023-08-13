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
    public partial class Form_Addsp : Form
    {
        public Form_Addsp()
        {
            InitializeComponent();
        }

        private void Form_Addsp_Load(object sender, EventArgs e)
        {
            init_grid();
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
            Form_Color mainfrom= new Form_Color(this);
            mainfrom.Text = "商品颜色详细--新增";
            mainfrom.Show();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            JObject job = new JObject();
            JArray jArray = new JArray();
            job["custom_id"] = uiLabel_cid.Text;
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
            string rel = Util.httppost("/special/add", ref body, Util.G_token);
            MessageBox.Show(rel);
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
