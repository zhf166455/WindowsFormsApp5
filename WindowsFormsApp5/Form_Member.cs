using FlexCell;
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
    public partial class Form_Member : Form
    {
        public Form_Member()
        {
            InitializeComponent();
        }

        private void Form_Member_Load(object sender, EventArgs e)
        {
            init_grid();
        }

        private void init_grid()
        {
            grid1.Locked = false;
            grid1.AutoRedraw = false;
            grid1.Rows = 3;

            grid1.Column(0).Width = 10;
            grid1.Column(1).Width = 100;
            grid1.Column(2).Width = 100;
            grid1.Column(3).Width = 100;
            grid1.Column(4).Width = 100;

            grid1.Cell(0, 1).Text = "账号";
            grid1.Cell(0, 2).Text = "用户名";
            grid1.Cell(0, 3).Text = "营业部";
            grid1.Cell(0, 4).Text = "备注";

            grid1.Locked = true;
            grid1.AutoRedraw = true;
            grid1.Refresh();
            
        }

    }
}
