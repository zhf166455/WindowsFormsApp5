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
            Form_SumChild from_cg = new Form_SumChild();
            from_cg.Name = "from_sumchild";
            from_cg.TopLevel = false;
            tabPage.Controls.Add(from_cg);
            from_cg.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
