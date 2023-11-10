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

namespace WindowsFormsApp5
{
    public partial class Form_client_new : Form
    {
        public Form_client_new()
        {
            InitializeComponent();
        }

        private void Form_client_new_Load(object sender, EventArgs e)
        {
            
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string fz = uiComboBox_fenzu.GetItemText(uiComboBox_fenzu.SelectedItem);
            fz = Util.midstr(ref fz, "(", ")");
            JObject job=new JObject();
            job["classid"]= fz;
            job["state"] = false;
            job["name"] = uiTextBox_name.Text;
            job["call"] = uiTextBox_phone.Text;
            job["addr1"] = uiTextBox_addr1.Text;
            job["addr2"] = uiTextBox_addr2.Text;
            job["addr3"] = uiTextBox_addr3.Text;
            job["addr4"] = uiTextBox_addr4.Text;
            job["oname"] = uiTextBox_oname.Text;
            job["ophone"] = uiTextBox_ophone.Text;
            job["onote"] = uiTextBox_onote.Text;
            job["note"] = uiTextBox_note.Text;
            string body=job.ToString();
            string rel=Util.httppost("/client/add",ref body, Util.G_token);
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
                string clientid = ((string)rjob["id"]);
                uiTextBox_id.Text = clientid;
                uiSymbolButton_save.Enabled = false;
                MessageBox.Show("新增成功");
            }
                

        }
    }
}
