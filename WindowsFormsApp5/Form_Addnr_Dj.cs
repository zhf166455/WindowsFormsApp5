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
    public partial class Form_Addnr_Dj : Form
    {
        private Form_Danju pfrom;
        public Form_Addnr_Dj(Form_Danju pfrom)
        {
            this.pfrom= pfrom;
            InitializeComponent();
        }

        private void Form_Addnr_Dj_Load(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiTextBox_cid_ButtonClick(object sender, EventArgs e)
        {
            Form_Chose_Pro_Dj mainfrom = new Form_Chose_Pro_Dj(this);
            mainfrom.from_type = "普通";
            mainfrom.Text = "选择普通商品";
            mainfrom.ShowDialog();
        }

        private void uiSymbolButton_ok_Click(object sender, EventArgs e)
        {
            pfrom.add_grid_new("普通", uiTextBox_cid.Text, uiTextBox_name.Text, uiTextBox_color.Text, "", "",uiTextBox_num.Text.ToInt(), uiTextBox_price.Text.ToFloat(), uiTextBox_price.Text.ToFloat(), "", uiTextBox_class.Text, "");
        }
    }
}
