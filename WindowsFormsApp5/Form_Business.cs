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
    public partial class Form_Business : Form
    {
        private string from_type;
        private string st;
        private string et;
        public Form_Business(string from_type,string st,string et)
        {
            InitializeComponent();
            this.from_type = from_type;
            this.st = st;
            this.et = et;
        }

        private void Form_Business_Load(object sender, EventArgs e)
        {
            uiLabel1.Text = uiLabel1.Text + st + "~" + et;
            if (from_type == "采购")
                this.Text = "采购业务汇总";
            else
                this.Text = "销售业务汇总";
            this.Width= Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            TabPage tabPage = uiTabControl1.TabPages[0];
            Form_Business_Child from_cg = new Form_Business_Child("供应商",from_type,st,et);
            from_cg.Name = "form_business_child";
            from_cg.TopLevel= false;
            from_cg.Dock= DockStyle.Fill;
            tabPage.Controls.Add(from_cg);
            from_cg.Show();

            TabPage tabPage2 = uiTabControl1.TabPages[1];
            Form_Business_Child from_xs = new Form_Business_Child("商品", from_type, st, et);
            from_xs.Name = "form_business_child2";
            from_xs.TopLevel = false;
            from_xs.Dock = DockStyle.Fill;
            tabPage2.Controls.Add(from_xs);
            from_xs.Show();
        }

    }
}
