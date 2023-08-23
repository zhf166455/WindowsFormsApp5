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
    public partial class Form_Business_Child : Form
    {
        private bool _iscg;
        public Form_Business_Child(bool iscg)
        {
            InitializeComponent();
            _iscg = iscg;
        }

        private void Form_Business_Child_Load(object sender, EventArgs e)
        {
            init_grid();
        }
        private void init_grid()
        {
            if (_iscg)
            {
                grid1.Locked = false;
                grid1.AutoRedraw = false;
                grid1.Rows = 3;
                grid1.Cols = 7;

                grid1.Column(0).Width = 10;
                grid1.Column(1).Width = 120;
                grid1.Column(2).Width = 120;
                grid1.Column(3).Width = 100;
                grid1.Column(4).Width = 100;
                grid1.Column(5).Width = 100;
                grid1.Column(6).Width = 100;

                grid1.Cell(0, 1).Text = "编号";
                grid1.Cell(0, 2).Text = "供应商";
                grid1.Cell(0, 3).Text = "日期";
                grid1.Cell(0, 4).Text = "商品数量";
                grid1.Cell(0, 5).Text = "合计金额";
                grid1.Cell(0, 6).Text = "未核销金额";

                grid1.Locked = true;
                grid1.AutoRedraw = true;
                grid1.Refresh();
            }
            else
            {
                grid1.Locked = false;
                grid1.AutoRedraw = false;
                grid1.Rows = 3;
                grid1.Cols = 9;

                grid1.Column(0).Width = 10;
                grid1.Column(1).Width = 120;
                grid1.Column(2).Width = 120;
                grid1.Column(3).Width = 100;
                grid1.Column(4).Width = 100;
                grid1.Column(5).Width = 100;
                grid1.Column(6).Width = 100;

                grid1.Cell(0, 1).Text = "类别";
                grid1.Cell(0, 2).Text = "商品名称";
                grid1.Cell(0, 3).Text = "别名";
                grid1.Cell(0, 4).Text = "颜色";
                grid1.Cell(0, 5).Text = "商品数量";
                grid1.Cell(0, 6).Text = "均价";
                grid1.Cell(0, 7).Text = "合计金额";
                grid1.Cell(0, 8).Text = "商品编码";

                grid1.Locked = true;
                grid1.AutoRedraw = true;
                grid1.Refresh();
            }

            grid2.Locked= false; 
            grid2.AutoRedraw = false;
            grid1.Rows = 3;

            grid2.Column(0).Width = 10;
            grid2.Column(1).Width = 60;
            grid2.Column(2).Width = 60;
            grid2.Column(3).Width = 100;
            grid2.Column(4).Width = 100;
            grid2.Column(5).Width = 100;
            grid2.Column(6).Width = 100;
            grid2.Column(7).Width = 100;
            grid2.Column(8).Width = 120;
            grid2.Column(9).Width = 120;
            grid2.Column(10).Width = 100;
            grid2.Column(11).Width = 100;
            grid2.Column(12).Width = 100;
            grid2.Column(13).Width = 100;
            grid2.Column(14).Width = 100;
            grid2.Column(15).Width = 100;

            grid2.Cell(0,1).Text= "过账";
            grid2.Cell(0,2).Text= "核销";
            grid2.Cell(0,3).Text= "营业部";
            grid2.Cell(0,4).Text= "单据类型";
            grid2.Cell(0,5).Text= "单据编号";
            grid2.Cell(0,6).Text= "单据日期";
            grid2.Cell(0,7).Text= "制单时间";
            grid2.Cell(0,8).Text= "供应商";
            grid2.Cell(0,9).Text= "商品编码";
            grid2.Cell(0,10).Text= "类别";
            grid2.Cell(0,11).Text="商品名称";
            grid2.Cell(0,12).Text="别名";
            grid2.Cell(0,13).Text="颜色";
            grid2.Cell(0,14).Text="条码";
            grid2.Cell(0,15).Text="数量";

            grid2.Locked = true;
            grid2.AutoRedraw = true;
            grid2.Refresh();
        }

    }
}
