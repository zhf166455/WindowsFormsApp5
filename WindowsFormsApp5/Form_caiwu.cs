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
    public partial class Form_caiwu : Form
    {
        public Form_caiwu()
        {
            InitializeComponent();
        }

        private void Form_caiwu_Load(object sender, EventArgs e)
        {
            init_grid();
        }
        private void init_grid()
        {
            grid_caiwu.AutoRedraw = false;
            grid_caiwu.Rows = 4;
            grid_caiwu.Range(0, 1, 3, 15).Locked = false;
            grid_caiwu.Range(0, 1, 3, 15).ClearAll();

            grid_caiwu.Column(0).Width = 10;
            grid_caiwu.Column(1).Width = 120;
            grid_caiwu.Column(2).Width = 120;
            grid_caiwu.Column(3).Width = 120;
            grid_caiwu.Column(4).Width = 100;
            grid_caiwu.Column(5).Width = 120;
            grid_caiwu.Column(6).Width = 140;
            grid_caiwu.Column(7).Width = 100;
            grid_caiwu.Column(8).Width = 100;
            grid_caiwu.Column(9).Width = 100;
            grid_caiwu.Column(10).Width = 100;
            grid_caiwu.Column(11).Width = 140;
            grid_caiwu.Column(12).Width = 140;
            grid_caiwu.Column(13).Width = 140;
            grid_caiwu.Column(12).Width = 140;
            grid_caiwu.Column(13).Width = 140;
            grid_caiwu.Column(14).Width = 200;
            grid_caiwu.Column(15).Width = 80;

            grid_caiwu.Range(0, 0, 1, 0).Merge();
            grid_caiwu.Range(0, 1, 1, 1).Merge();
            grid_caiwu.Range(0, 2, 1, 2).Merge();
            grid_caiwu.Range(0, 3, 1, 3).Merge();
            grid_caiwu.Range(0, 4, 1, 4).Merge();
            grid_caiwu.Range(0, 5, 1, 5).Merge();
            grid_caiwu.Range(0, 6, 1, 6).Merge();
            grid_caiwu.Range(0, 7, 0, 10).Merge();
            grid_caiwu.Range(0, 11, 1, 11).Merge();
            grid_caiwu.Range(0, 12, 1, 12).Merge();
            grid_caiwu.Range(0, 13, 1, 13).Merge();
            grid_caiwu.Range(0, 14, 1, 14).Merge();
            grid_caiwu.Range(0, 15, 1, 15).Merge();

            grid_caiwu.Cell(0, 1).Text = "客户类型";
            grid_caiwu.Cell(0, 2).Text = "客户编号";
            grid_caiwu.Cell(0, 3).Text = "客户名称";
            grid_caiwu.Cell(0, 4).Text = "地区";
            grid_caiwu.Cell(0, 5).Text = "客户经理";
            grid_caiwu.Cell(0, 6).Text = "初期余额(元)";
            grid_caiwu.Cell(0, 7).Text = "本期发生额(元)";
            grid_caiwu.Cell(1, 7).Text = "应收金额";
            grid_caiwu.Cell(1, 8).Text = "实收金额";
            grid_caiwu.Cell(1, 9).Text = "应付金额";
            grid_caiwu.Cell(1, 10).Text = "实付金额";
            grid_caiwu.Cell(0, 11).Text = "余额(元)";
            grid_caiwu.Cell(0, 12).Text = "核销差额(元)";
            grid_caiwu.Cell(0, 13).Text = "信用额度(元)";
            grid_caiwu.Cell(0, 14).Text = "最近商务交易日期";
            grid_caiwu.Cell(0, 15).Text = "停用";

            grid_caiwu.Range(0, 1, 2, 15).Locked = true;
            grid_caiwu.AutoRedraw = true;
            grid_caiwu.Refresh();
        }
    }
}
