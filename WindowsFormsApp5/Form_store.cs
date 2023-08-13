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
    public partial class Form_store : Form
    {
        public Form_store()
        {
            InitializeComponent();
        }

        private void Form_store_Load(object sender, EventArgs e)
        {
            init_grid();
        }
        private void init_grid()
        {
            grid_store.AutoRedraw = false;
            grid_store.Rows = 3;
            grid_store.Range(0, 1, 2, 8).Locked = false;
            grid_store.Range(0, 1, 2, 8).ClearAll();

            grid_store.Column(0).Width = 10;
            grid_store.Column(1).Width = 220;
            grid_store.Column(2).Width = 150;
            grid_store.Column(3).Width = 200;
            grid_store.Column(4).Width = 200;
            grid_store.Column(5).Width = 140;
            grid_store.Column(6).Width = 200;
            grid_store.Column(7).Width = 80;
            grid_store.Column(8).Width = 80;

            grid_store.Cell(0, 1).Text = "商品编码";
            grid_store.Cell(0, 2).Text = "类别";
            grid_store.Cell(0, 3).Text = "商品名称";
            grid_store.Cell(0, 4).Text = "别名";
            grid_store.Cell(0, 5).Text = "颜色";
            grid_store.Cell(0, 6).Text = "条码";
            grid_store.Cell(0, 7).Text = "库存";
            grid_store.Cell(0, 8).Text = "销量";

            grid_store.Range(0, 1, 2, 8).Locked = true;
            grid_store.AutoRedraw = true;
            grid_store.Refresh();
        }
    }
}
