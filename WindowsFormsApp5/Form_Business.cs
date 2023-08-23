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
        public Form_Business()
        {
            InitializeComponent();
        }

        private void Form_Business_Load(object sender, EventArgs e)
        {
            this.Width= Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            TabPage tabPage = uiTabControl1.TabPages[0];
            Form_Business_Child from_cg = new Form_Business_Child(true);
            from_cg.Name = "form_business_child";
            from_cg.TopLevel= false;
            tabPage.Controls.Add(from_cg);
            from_cg.Show();

            TabPage tabPage2 = uiTabControl1.TabPages[1];
            Form_Business_Child from_xs = new Form_Business_Child(false);
            from_xs.Name = "form_business_child2";
            from_xs.TopLevel = false;
            tabPage2.Controls.Add(from_xs);
            from_xs.Show();
        }

    }
}
