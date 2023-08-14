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
    public partial class Form_Track : Form
    {
        public Form_Track()
        {
            InitializeComponent();
        }

        private void Form_Track_Load(object sender, EventArgs e)
        {
            init_grid();

        }
        private void init_grid()
        {
            grid1.AutoRedraw = false;
            grid1.Rows = 2;

            grid1.Column(0).Width = 10;
            grid1.Column(1).Width = 120;
            grid1.Column(2).Width = 100;
            grid1.Column(3).Width = 100;
            grid1.Column(4).Width = 180;
            grid1.Column(5).Width = 100;
            grid1.Column(6).Width = 80;
            grid1.Column(7).Width = 200;
            grid1.Column(8).Width = 100;
            grid1.Column(9).Width = 120;

            grid1.Cell(0, 1).Text = "单据编号";
            grid1.Cell(0, 2).Text = "单据类型";
            grid1.Cell(0, 3).Text = "日期";
            grid1.Cell(0, 4).Text = "机型描述";
            grid1.Cell(0, 5).Text = "价格";
            grid1.Cell(0, 6).Text = "过账";
            grid1.Cell(0, 7).Text = "流向";
            grid1.Cell(0, 8).Text = "附加信息";
            grid1.Cell(0, 9).Text = "录入时间";

            grid1.AutoRedraw = true;
            grid1.Refresh();
        }
    }
}
