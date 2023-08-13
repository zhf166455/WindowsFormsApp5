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
    public partial class Form_SumChild : Form
    {
        public Form_SumChild()
        {
            InitializeComponent();
        }

        private void Form_SumChild_Load(object sender, EventArgs e)
        {
            init_grid();
        }
        private void init_grid()
        {
            grid_sum.AutoRedraw = false;
            grid_sum.Rows = 3;
            grid_sum.Range(0, 1, 2, 16).Locked = false;
            grid_sum.Range(0, 1, 2, 16).ClearAll();

            grid_sum.Column(0).Width = 10;
            grid_sum.Column(1).Width = 80;
            grid_sum.Column(2).Width = 80;
            grid_sum.Column(3).Width = 120;
            grid_sum.Column(4).Width = 120;
            grid_sum.Column(5).Width = 120;
            grid_sum.Column(6).Width = 120;
            grid_sum.Column(7).Width = 120;
            grid_sum.Column(8).Width = 220;
            grid_sum.Column(9).Width = 120;
            grid_sum.Column(10).Width = 120;
            grid_sum.Column(11).Width = 220;
            grid_sum.Column(12).Width = 120;
            grid_sum.Column(13).Width = 100;
            grid_sum.Column(14).Width = 100;
            grid_sum.Column(15).Width = 100;
            grid_sum.Column(16).Width = 100;

            grid_sum.Cell(0, 1).Text = "过账";
            grid_sum.Cell(0, 2).Text = "核销";
            grid_sum.Cell(0, 3).Text = "营业部";
            grid_sum.Cell(0, 4).Text = "单据类型";
            grid_sum.Cell(0, 5).Text = "单据编号";
            grid_sum.Cell(0, 6).Text = "单据日期";
            grid_sum.Cell(0, 7).Text = "制单时间";
            grid_sum.Cell(0, 8).Text = "供应商";
            grid_sum.Cell(0, 9).Text = "商品编码";
            grid_sum.Cell(0, 10).Text = "类别";
            grid_sum.Cell(0, 11).Text = "商品名称";
            grid_sum.Cell(0, 12).Text = "别名";
            grid_sum.Cell(0, 13).Text = "颜色";
            grid_sum.Cell(0, 14).Text = "条码";
            grid_sum.Cell(0, 15).Text = "数量";
            grid_sum.Cell(0, 16).Text = "单价";

            grid_sum.Range(0, 1, 2, 16).Locked = true;
            grid_sum.AutoRedraw = true;
            grid_sum.Refresh();
        }
    }
}
