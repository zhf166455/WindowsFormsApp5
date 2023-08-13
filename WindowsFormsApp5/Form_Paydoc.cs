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
    public partial class Form_Paydoc : Form
    {
        public Form_Paydoc()
        {
            InitializeComponent();
        }

        private void Form_Paydoc_Load(object sender, EventArgs e)
        {
            init_grid();
        }
        private void init_grid()
        {
            grid_paydoc.AutoRedraw = false;
            grid_paydoc.Rows = 3;
            grid_paydoc.Range(0, 1, 2, 12).Locked = false;
            grid_paydoc.Range(0, 1, 2, 12).ClearAll();

            grid_paydoc.Column(0).Width = 10;
            grid_paydoc.Column(1).Width = 80;
            grid_paydoc.Column(2).Width = 80;
            grid_paydoc.Column(3).Width = 120;
            grid_paydoc.Column(4).Width = 150;
            grid_paydoc.Column(5).Width = 150;
            grid_paydoc.Column(6).Width = 140;
            grid_paydoc.Column(7).Width = 200;
            grid_paydoc.Column(8).Width = 150;
            grid_paydoc.Column(9).Width = 150;
            grid_paydoc.Column(10).Width = 120;
            grid_paydoc.Column(11).Width = 120;
            grid_paydoc.Column(12).Width = 120;
            grid_paydoc.Column(13).Width = 220;

            grid_paydoc.Cell(0, 1).Text = "过账";
            grid_paydoc.Cell(0, 2).Text = "核销";
            grid_paydoc.Cell(0, 3).Text = "营业部";
            grid_paydoc.Cell(0, 4).Text = "单据编号";
            grid_paydoc.Cell(0, 5).Text = "单据日期";
            grid_paydoc.Cell(0, 6).Text = "客户";
            grid_paydoc.Cell(0, 7).Text = "付款类型";
            grid_paydoc.Cell(0, 8).Text = "付款方式";
            grid_paydoc.Cell(0, 9).Text = "金额";
            grid_paydoc.Cell(0, 10).Text = "经办人";
            grid_paydoc.Cell(0, 11).Text = "制单人";
            grid_paydoc.Cell(0, 12).Text = "过账人";
            grid_paydoc.Cell(0, 13).Text = "备注";

            grid_paydoc.Range(0, 1, 2, 13).Locked = true;
            grid_paydoc.AutoRedraw = true;
            grid_paydoc.Refresh();
        }
    }
}
