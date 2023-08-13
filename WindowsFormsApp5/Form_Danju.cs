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
    public partial class Form_Danju : Form
    {
        public Form_Danju()
        {
            InitializeComponent();
        }

        private void Form_Danju_Load(object sender, EventArgs e)
        {
            init_grid();
            
        }
        private void init_grid()
        {
            grid_danju.AutoRedraw = false;
            grid_danju.Rows = 3;
            grid_danju.Range(0, 1, 2, 12).Locked = false;
            grid_danju.Range(0, 1, 2, 12).ClearAll();

            grid_danju.Column(0).Width = 10;
            grid_danju.Column(1).Width = 30;
            grid_danju.Column(2).Width = 30;
            grid_danju.Column(3).Width = 100;
            grid_danju.Column(4).Width = 100;
            grid_danju.Column(5).Width = 140;
            grid_danju.Column(6).Width = 200;
            grid_danju.Column(7).Width = 80;
            grid_danju.Column(8).Width = 80;
            grid_danju.Column(9).Width = 120;
            grid_danju.Column(10).Width = 80;
            grid_danju.Column(11).Width = 80;
            grid_danju.Column(12).Width = 80;

            grid_danju.Cell(0, 1).Text = "类型";
            grid_danju.Cell(0, 2).Text = "商品编码";
            grid_danju.Cell(0, 3).Text = "附加标识";
            grid_danju.Cell(0, 4).Text = "商品名称";
            grid_danju.Cell(0, 5).Text = "颜色";
            grid_danju.Cell(0, 6).Text = "条码";
            grid_danju.Cell(0, 7).Text = "IMEI";
            grid_danju.Cell(0, 8).Text = "数量";
            grid_danju.Cell(0, 9).Text = "单价";
            grid_danju.Cell(0, 10).Text = "金额";
            grid_danju.Cell(0, 11).Text = "附加信息";
            grid_danju.Cell(0, 12).Text = "别名";
            

            grid_danju.Column(1).CellType = FlexCell.CellTypeEnum.TextBox;
            grid_danju.Column(2).CellType = FlexCell.CellTypeEnum.TextBox;
            grid_danju.Cell(2, 5).Text = "记录数:0";
            grid_danju.Column(9).Mask = FlexCell.MaskEnum.Numeric;
            grid_danju.Column(9).DecimalLength = 2;

            grid_danju.Cell(2, 7).Text = "0";
            grid_danju.Cell(2, 8).Text = "0";
            grid_danju.Cell(2, 9).Text = "0";
            grid_danju.Range(2, 1, 2, 12).Locked = true;
            grid_danju.AutoRedraw = true;
            grid_danju.Refresh();
        }

        private void uiButton11_Click(object sender, EventArgs e)
        {
            Form_Addsp_Dj formspdj = new Form_Addsp_Dj(this);
            formspdj.Text = "增加串码商品--新增";
            formspdj.ShowDialog();
        }
        public void add_grid_new(string pro_type,string pro_id,string name,string color,string code,string imei,int num,float price,float sum,string note,string cname,string oname)
        {
            int n = grid_danju.Rows;
            string te = grid_danju.Cell(n - 2, 1).Text;
            if(te!="")
            {
                grid_danju.InsertRow(n - 1, 1);
                n = n - 1;
            }
            else
            {
                n=n-2;
            }
            
            grid_danju.Cell(n,1).Text = pro_type;
            grid_danju.Cell(n,2).Text = pro_id;
            grid_danju.Cell(n, 3).Text = pro_type;
            grid_danju.Cell(n, 4).Text = name;
            grid_danju.Cell(n, 5).Text = color;
            grid_danju.Cell(n, 6).Text = code;
            grid_danju.Cell(n, 7).Text = imei;
            grid_danju.Cell(n, 8).Text = num.ToString();
            grid_danju.Cell(n, 9).Text = price.ToString();
            grid_danju.Cell(n, 10).Text = sum.ToString();
            grid_danju.Cell(n, 11).Text = note;
            grid_danju.Cell(n, 12).Text = oname;
        }
        private void Form_Danju_Shown(object sender, EventArgs e)
        {
            if (uiPanel_client.Text == null)
            {
                FormChoseClient formChoseClient = new FormChoseClient(this);
                formChoseClient.ShowDialog();
            }
        }

        private void uiLabel7_Click(object sender, EventArgs e)
        {
            FormChoseClient formChoseClient = new FormChoseClient(this);
            formChoseClient.ShowDialog();
        }

        private void uiButton_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }

        private void grid_danju_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cell ac = grid_danju.ActiveCell;
            MessageBox.Show(ac.Row.ToString());
        }
    }
}
