using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class from_main : Form
    {
        public from_main()
        {
            InitializeComponent();
        }

        private void from_main_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " " + Util.G_ver;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            toolStripStatusLabel_ad.Text = Util.G_ad;
            toolStripStatusLabel_der.Text = Util.G_dname;
            toolStripStatusLabel_uid.Text = Util.G_uid;
            toolStripStatusLabel_name.Text = Util.G_name;
            toolStripStatusLabel_lv.Text = Util.G_lv == 7 ? "超级管理员" : "普通用户";
            toolStripStatusLabel_ver.Text = Util.G_ver;
            timer1.Start();
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;
            toolStripStatusLabel_time1.Text = t.ToString("yyyy年MM月dd日 HH时mm分ss秒");
            DayOfWeek dayOfWeek = t.DayOfWeek;
            string dayOfWeekString = "";
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dayOfWeekString = "星期日";
                    break;
                case DayOfWeek.Monday:
                    dayOfWeekString = "星期一";
                    break;
                case DayOfWeek.Tuesday:
                    dayOfWeekString = "星期二";
                    break;
                case DayOfWeek.Wednesday:
                    dayOfWeekString = "星期三";
                    break;
                case DayOfWeek.Thursday:
                    dayOfWeekString = "星期四";
                    break;
                case DayOfWeek.Friday:
                    dayOfWeekString = "星期五";
                    break;
                case DayOfWeek.Saturday:
                    dayOfWeekString = "星期六";
                    break;
            };
            toolStripStatusLabel_time2.Text = dayOfWeekString;
        }

        private void 采购入库单ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            
        }

      

        private bool uiTabControl1_BeforeRemoveTabPage(object sender, int index)
        {
            
            Control tc= uiTabControl1.GetControl(index);
            
            if (tc.Text == "导航")
            {
                MessageBox.Show("无法关闭的页面");
                return false;
            }
            return true;
        }

        private int getpageidx(string title)
        {
            int n= uiTabControl1.TabPages.Count;
            int rel=0;
            for(int i = 0; i < n; i++)
            {
                if (uiTabControl1.TabPages[i].Text == title)
                    rel = i;
                
            }
            return rel;
            
        }
        

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            int idx = getpageidx("采购入库单");
            if (idx==0)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "采购入库单";
                tabPage.Name = "page_cg";
                Form_Ruku from_cg = new Form_Ruku("采购入库单");
                from_cg.Name = "from_cg";
                from_cg.TopLevel = false;
                from_cg.Dock = DockStyle.Fill;
                tabPage.Controls.Add(from_cg);
                from_cg.Show();
                uiTabControl1.TabPages.Add(tabPage);
                uiTabControl1.SelectedTab = tabPage;
            }
            else
            {
                uiTabControl1.SelectedIndex = idx;
            }
        }

        private void uiImageButton2_Click(object sender, EventArgs e)
        {
            int idx = getpageidx("串码商品管理");
            if (idx == 0)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "串码商品管理";
                tabPage.Name = "page_spro";
                Form_product from_cg = new Form_product("串码");
                from_cg.Name = "from_spro";
                from_cg.TopLevel = false;
                from_cg.Dock = DockStyle.Fill;
                tabPage.Controls.Add(from_cg);
                from_cg.Show();
                uiTabControl1.TabPages.Add(tabPage);
                uiTabControl1.SelectedTab = tabPage;
            }
            else
            {
                uiTabControl1.SelectedIndex = idx;
            }
        }


        private void uiImageButton4_Click(object sender, EventArgs e)
        {
            int idx = getpageidx("串码追踪");
            if (idx == 0)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "串码追踪";
                tabPage.Name = "page_track";
                Form_Track from_cg = new Form_Track();
                from_cg.Name = "from_track";
                from_cg.TopLevel = false;
                from_cg.Dock = DockStyle.Fill;
                tabPage.Controls.Add(from_cg);
                from_cg.Show();
                uiTabControl1.TabPages.Add(tabPage);
                uiTabControl1.SelectedTab = tabPage;
            }
            else
            {
                uiTabControl1.SelectedIndex = idx;
            }
        }

        private void uiImageButton5_Click(object sender, EventArgs e)
        {
            int idx = getpageidx("库存管理");
            if (idx == 0)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "库存管理";
                tabPage.Name = "page_stock";
                Form_store from_cg = new Form_store();
                from_cg.Name = "from_stock";
                from_cg.TopLevel = false;
                from_cg.Dock = DockStyle.Fill;
                tabPage.Controls.Add(from_cg);
                from_cg.Show();
                uiTabControl1.TabPages.Add(tabPage);
                uiTabControl1.SelectedTab = tabPage;
            }
            else
            {
                uiTabControl1.SelectedIndex = idx;
            }
        }

        private void uiImageButton6_Click(object sender, EventArgs e)
        {
            int idx = getpageidx("业务汇总");
            if (idx == 0)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "业务汇总";
                tabPage.Name = "page_summary";
                Form_Summary from_cg = new Form_Summary();
                from_cg.Name = "from_summary";
                from_cg.TopLevel = false;
                from_cg.Dock = DockStyle.Fill;
                tabPage.Controls.Add(from_cg);
                from_cg.Show();
                uiTabControl1.TabPages.Add(tabPage);
                uiTabControl1.SelectedTab = tabPage;
            }
            else
            {
                uiTabControl1.SelectedIndex = idx;
            }
        }


        private void uiImageButton12_Click(object sender, EventArgs e)
        {
            int idx = getpageidx("采购退库单");
            if (idx == 0)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "采购退库单";
                tabPage.Name = "page_ct";
                Form_Ruku from_cg = new Form_Ruku("采购退库单");
                from_cg.Name = "from_ct";
                from_cg.TopLevel = false;
                from_cg.Dock = DockStyle.Fill;
                tabPage.Controls.Add(from_cg);
                from_cg.Show();
                uiTabControl1.TabPages.Add(tabPage);
                uiTabControl1.SelectedTab = tabPage;
              }
            else
            {
                uiTabControl1.SelectedIndex = idx;
            }
        }

        private void uiImageButton13_Click(object sender, EventArgs e)
        {
            int idx = getpageidx("零售出库单");
            if (idx == 0)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "零售出库单";
                tabPage.Name = "page_ls";
                Form_Ruku from_cg = new Form_Ruku("零售出库单");
                from_cg.Name = "from_ls";
                from_cg.TopLevel = false;
                from_cg.Dock = DockStyle.Fill;
                tabPage.Controls.Add(from_cg);
                from_cg.Show();
                uiTabControl1.TabPages.Add(tabPage);
                uiTabControl1.SelectedTab = tabPage;
            }
            else
            {
                uiTabControl1.SelectedIndex = idx;
            }
        }

        private void uiImageButton14_Click(object sender, EventArgs e)
        {
            int idx = getpageidx("零售退库单");
            if (idx == 0)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "零售退库单";
                tabPage.Name = "page_lt";
                Form_Ruku from_cg = new Form_Ruku("零售退库单");
                from_cg.Name = "from_lt";
                from_cg.TopLevel = false;
                from_cg.Dock = DockStyle.Fill;
                tabPage.Controls.Add(from_cg);
                from_cg.Show();
                uiTabControl1.TabPages.Add(tabPage);
                uiTabControl1.SelectedTab = tabPage;
            }
            else
            {
                uiTabControl1.SelectedIndex = idx;
            }
        }

        private void uiImageButton16_Click(object sender, EventArgs e)
        {
            int idx = getpageidx("内部分销单");
            if (idx == 0)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "内部分销单";
                tabPage.Name = "page_fx";
                Form_Ruku from_cg = new Form_Ruku("内部分销单");
                from_cg.Name = "from_fx";
                from_cg.TopLevel = false;
                from_cg.Dock = DockStyle.Fill;
                tabPage.Controls.Add(from_cg);
                from_cg.Show();
                uiTabControl1.TabPages.Add(tabPage);
                uiTabControl1.SelectedTab = tabPage;
             }
             else
             {
                 uiTabControl1.SelectedIndex = idx;
             }
        }

        private void uiImageButton15_Click(object sender, EventArgs e)
        {
            int idx = getpageidx("内部退销单");
            if (idx == 0)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "内部退销单";
                tabPage.Name = "page_tx";
                Form_Ruku from_cg = new Form_Ruku("内部退销单");
                from_cg.Name = "from_tx";
                from_cg.TopLevel = false;
                from_cg.Dock = DockStyle.Fill;
                tabPage.Controls.Add(from_cg);
                from_cg.Show();
                uiTabControl1.TabPages.Add(tabPage);
                uiTabControl1.SelectedTab = tabPage;
            }
            else
            {
                uiTabControl1.SelectedIndex = idx;
            }
        }

        private void uiImageButton11_Click(object sender, EventArgs e)
        {
            int idx = getpageidx("普通商品管理");
            if (idx == 0)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "普通商品管理";
                tabPage.Name = "page_npro";
                Form_product from_cg = new Form_product("普通");
                from_cg.Name = "from_npro";
                from_cg.TopLevel = false;
                from_cg.Dock = DockStyle.Fill;
                tabPage.Controls.Add(from_cg);
                from_cg.Show();
                uiTabControl1.TabPages.Add(tabPage);
                uiTabControl1.SelectedTab = tabPage;
            }
            else
            {
                uiTabControl1.SelectedIndex = idx;
            }
        }

        private void uiImageButton10_Click(object sender, EventArgs e)
        {
            int idx = getpageidx("成员管理");
            if (idx == 0)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "成员管理";
                tabPage.Name = "page_member";
                Form_Member from_cg = new Form_Member();
                from_cg.Name = "from_member";
                from_cg.TopLevel = false;
                from_cg.Dock = DockStyle.Fill;
                tabPage.Controls.Add(from_cg);
                from_cg.Show();
                uiTabControl1.TabPages.Add(tabPage);
                uiTabControl1.SelectedTab = tabPage;
            }
            else
            {
                uiTabControl1.SelectedIndex = idx;
            }
        }


        private void uiImageButton7_Click_1(object sender, EventArgs e)
        {
            int idx = getpageidx("客户往来账务");
            if (idx == 0)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "客户往来账务";
                tabPage.Name = "page_caiwu";
                Form_caiwu from_cg = new Form_caiwu();
                from_cg.Name = "from_caiwu";
                from_cg.TopLevel = false;
                tabPage.Controls.Add(from_cg);
                from_cg.Show();
                uiTabControl1.TabPages.Add(tabPage);
                uiTabControl1.SelectedTab = tabPage;
            }
            else
            {
                uiTabControl1.SelectedIndex = idx;
            }
        }

        private void uiImageButton8_Click_1(object sender, EventArgs e)
        {
            int idx = getpageidx("往来户收款单");
            if (idx == 0)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "往来户收款单";
                tabPage.Name = "page_recdoc";
                Form_Paydoc from_cg = new Form_Paydoc();
                from_cg.Name = "from_recdoc";
                from_cg.TopLevel = false;
                tabPage.Controls.Add(from_cg);
                from_cg.Show();
                uiTabControl1.TabPages.Add(tabPage);
                uiTabControl1.SelectedTab = tabPage;
            }
            else
            {
                uiTabControl1.SelectedIndex = idx;
            }
        }

        private void uiImageButton9_Click_1(object sender, EventArgs e)
        {
            int idx = getpageidx("往来户付款单");
            if (idx == 0)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "往来户付款单";
                tabPage.Name = "page_paydoc";
                Form_Paydoc from_cg = new Form_Paydoc();
                from_cg.Name = "from_paydoc";
                from_cg.TopLevel = false;
                tabPage.Controls.Add(from_cg);
                from_cg.Show();
                uiTabControl1.TabPages.Add(tabPage);
                uiTabControl1.SelectedTab = tabPage;
            }
            else
            {
                uiTabControl1.SelectedIndex = idx;
            }
        }

        private void uiImageButton3_Click_1(object sender, EventArgs e)
        {
            int idx = getpageidx("客户资料");
            if (idx == 0)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "客户资料";
                tabPage.Name = "page_client";
                Form_Client from_cg = new Form_Client();
                from_cg.Name = "from_client";
                from_cg.TopLevel = false;
                from_cg.Dock = DockStyle.Fill;
                tabPage.Controls.Add(from_cg);
                from_cg.Show();
                uiTabControl1.TabPages.Add(tabPage);
                uiTabControl1.SelectedTab = tabPage;
            }
            else
            {
                uiTabControl1.SelectedIndex = idx;
            }
        }

        private void uiImageButton17_Click(object sender, EventArgs e)
        {
            Form_PayType mainfrom= new Form_PayType();
            mainfrom.Text = "收款方式资料";
            mainfrom.ShowDialog();
        }

        private void uiImageButton18_Click(object sender, EventArgs e)
        {
            Form_PayType mainfrom = new Form_PayType();
            mainfrom.Text = "付款方式资料";
            mainfrom.ShowDialog();
        }

        private void from_main_Resize(object sender, EventArgs e)
        {
            
            //int aw= this.Width - 25;
            ////uiTabControl1.Height=(int)(this.Height*0.8);
            //uiTabControlMenu1.Width = aw;
            //uiPanel1.Left = (aw - 200)/2- uiPanel1.Width/2;
        }

        private void uiTabControl1_Resize(object sender, EventArgs e)
        {
            
        }

        private void 串码商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
