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
    public partial class Form_Summary : Form
    {
        public Form_Summary()
        {
            InitializeComponent();
        }

        private void Form_Summary_Load(object sender, EventArgs e)
        {
            TabPage tabPage = uiTabControl1.TabPages[0];
            Form_SumChild from_cg = new Form_SumChild("采购");
            from_cg.Name = "from_sumchild";
            from_cg.TopLevel = false;
            from_cg.Dock = DockStyle.Fill;
            tabPage.Controls.Add(from_cg);
            from_cg.Show();

            TabPage tabPage1 = uiTabControl1.TabPages[1];
            Form_SumChild from_xs = new Form_SumChild("销售");
            from_xs.Name = "from_sumchild1";
            from_xs.TopLevel = false;
            from_xs.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(from_xs);
            from_xs.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
