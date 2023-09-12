using FlexCell;
using Sunny.UI;
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
    public partial class Form_Inputprice : Form
    {
        private Form_Danju pfrom;
        public Form_Inputprice(Form_Danju pfrom)
        {
            InitializeComponent();
            this.pfrom = pfrom;
        }

        private void uiSymbolButton_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiSymbolButton_ok_Click(object sender, EventArgs e)
        {
            Cell ac = pfrom.grid_danju.ActiveCell;
            float pri = uiTextBox_price.Text.ToFloat();
            int n= pfrom.grid_danju.Cell(ac.Row,8).Text.ToInt();
            float sum = pri * n;
            pfrom.grid_danju.Cell(ac.Row, 9).Text= pri.ToString();
            pfrom.grid_danju.Cell(ac.Row, 10).Text = sum.ToString();
            pfrom.CalculateSummary_grid();
            this.Close();

        }
    }
}
