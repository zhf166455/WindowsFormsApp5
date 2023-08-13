using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;
using Nini.Config;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp5
{
    public partial class from_login : Form
    {
        public from_login()
        {
            InitializeComponent();
            
        }

        
        private void from_login_Load(object sender, EventArgs e)
        {
            string currentDirectory = Environment.CurrentDirectory;
            IniConfigSource configSource = new IniConfigSource(currentDirectory + "\\cfg.ini");
            IConfig config = configSource.Configs["base"];
            string user = config.GetString("user");
            string pwd = config.GetString("pwd");
            pwd = Util.DecryptString(pwd);
            string ip = config.GetString("ip");
            if (ip == "")
            {
                MessageBox.Show("配置错误,请联系管理员");
                return;
            }
            Util.SetRootUrl(ip);
            textBox_uid.Text = user;
            textBox_pwd.Text = pwd;
        }

        private void uiButton_login_Click(object sender, EventArgs e)
        {
            uiButton_login.Enabled = false;
            string uid = textBox_uid.Text;
            string pwd = textBox_pwd.Text;
            string encpwd = Util.ComputeMD5Hash(pwd);
            if (uid == "" || pwd == "")
            {
                MessageBox.Show("请输入账号密码");
                return;
            }
            if (checkBox_repwd.Checked)
            {
                string currentDirectory = Environment.CurrentDirectory;
                IniConfigSource configSource = new IniConfigSource(currentDirectory + "\\cfg.ini");
                // 获取或创建相应的配置部分
                IConfig config = configSource.Configs["base"];
                if (config == null)
                {
                    // 如果配置部分不存在，则创建新的配置部分
                    config = configSource.AddConfig("base");
                }

                // 设置配置项的值
                config.Set("user", uid);
                config.Set("pwd", Util.EncryptString(pwd));

                // 保存配置到文件
                configSource.Save();
            }
            string body = "user=" + uid + "&pwd=" + encpwd;
            string rel = Util.httppost(Util.U_LOGIN, ref body);
            uiButton_login.Enabled = true;
            if (rel == "")
            {
                MessageBox.Show("连接服务器失败!");
                return;
            }
            dynamic jsonObj = JsonConvert.DeserializeObject(rel);

            // 访问解析后的JSON数据
            int code = jsonObj.code;
            string msg = jsonObj.msg;


            if (code == -1)
            {
                MessageBox.Show(msg);
                return;
            }
            Util.G_uid = uid;
            Util.G_name = jsonObj.name;
            Util.G_lv = jsonObj.lv;
            Util.G_did = jsonObj.department_id;
            Util.G_ad = jsonObj.ad;
            Util.G_dname = jsonObj.department_name;
            Util.G_token = "uid="+Util.G_uid+";token="+jsonObj.token;

            // 创建主界面实例
            from_main mainForm = new from_main();

            // 隐藏当前登录界面
            this.Hide();

            // 显示主界面
            mainForm.ShowDialog();

            // 关闭主界面后，销毁登录界面
            this.Close();
        }
    }
}
