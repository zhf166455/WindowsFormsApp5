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
    public partial class Form_Color : Form
    {
        private Form_Addsp pfrom;
        public Form_Color(Form_Addsp pfrom)
        {
            InitializeComponent();
            this.pfrom = pfrom;
        }

        private void Form_Color_Load(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if(uiTextBox_color.Text=="" || uiTextBox_code.Text=="")
            {
                MessageBox.Show("不接受空数据");
                return;
            }
            int n = pfrom.grid1.Rows;
            string tx = pfrom.grid1.Cell(n-1,1).Text;
            if(tx =="")
            {
                n--;
            }
            else
            {
                pfrom.grid1.Rows = n + 1;
            }
            pfrom.grid1.Cell(n, 1).Text = n<9?"0"+n.ToString():n.ToString();
            pfrom.grid1.Cell(n, 2).Text = uiTextBox_color.Text;
            pfrom.grid1.Cell(n, 3).Text = uiTextBox_code.Text;
            pfrom.grid1.Cell(n, 4).Text = "假";
            pfrom.grid1.Cell(n, 5).Text = "无";
            this.Close();
        }
    }
}
