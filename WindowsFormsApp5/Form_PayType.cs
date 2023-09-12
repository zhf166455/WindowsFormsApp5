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
    public partial class Form_PayType : Form
    {
        public Form_PayType()
        {
            InitializeComponent();
        }

        private void Form_PayType_Load(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Form_PayType_Child mainfrom =new Form_PayType_Child();
            mainfrom.Text = "收款方式--新建";
            mainfrom.ShowDialog();
        }
    }
}
