namespace WindowsFormsApp5
{
    partial class Form_Addnr_Dj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTextBox_cid = new Sunny.UI.UITextBox();
            this.uiTextBox_class = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiTextBox_name = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiTextBox_color = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiTextBox_oname = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiTextBox_num = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiTextBox_price = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiTextBox_note = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiLine3 = new Sunny.UI.UILine();
            this.uiSymbolButton_ok = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_exit = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.LineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine1.Location = new System.Drawing.Point(13, 11);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(552, 20);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 0;
            this.uiLine1.Text = "商品资料";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(12, 45);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(72, 26);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "商品编码";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_cid
            // 
            this.uiTextBox_cid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_cid.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_cid.Location = new System.Drawing.Point(98, 43);
            this.uiTextBox_cid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_cid.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_cid.Name = "uiTextBox_cid";
            this.uiTextBox_cid.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_cid.Radius = 0;
            this.uiTextBox_cid.ShowButton = true;
            this.uiTextBox_cid.ShowText = false;
            this.uiTextBox_cid.Size = new System.Drawing.Size(163, 27);
            this.uiTextBox_cid.TabIndex = 2;
            this.uiTextBox_cid.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_cid.Watermark = "";
            this.uiTextBox_cid.ButtonClick += new System.EventHandler(this.uiTextBox_cid_ButtonClick);
            // 
            // uiTextBox_class
            // 
            this.uiTextBox_class.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_class.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_class.Location = new System.Drawing.Point(371, 43);
            this.uiTextBox_class.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_class.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_class.Name = "uiTextBox_class";
            this.uiTextBox_class.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_class.Radius = 0;
            this.uiTextBox_class.ShowText = false;
            this.uiTextBox_class.Size = new System.Drawing.Size(163, 27);
            this.uiTextBox_class.TabIndex = 4;
            this.uiTextBox_class.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_class.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(285, 45);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(72, 26);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "类别";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_name
            // 
            this.uiTextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_name.Location = new System.Drawing.Point(98, 88);
            this.uiTextBox_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_name.Name = "uiTextBox_name";
            this.uiTextBox_name.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_name.Radius = 0;
            this.uiTextBox_name.ShowText = false;
            this.uiTextBox_name.Size = new System.Drawing.Size(436, 27);
            this.uiTextBox_name.TabIndex = 6;
            this.uiTextBox_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_name.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(12, 90);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(72, 26);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "商品名称";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_color
            // 
            this.uiTextBox_color.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_color.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_color.Location = new System.Drawing.Point(98, 133);
            this.uiTextBox_color.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_color.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_color.Name = "uiTextBox_color";
            this.uiTextBox_color.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_color.Radius = 0;
            this.uiTextBox_color.ShowText = false;
            this.uiTextBox_color.Size = new System.Drawing.Size(163, 27);
            this.uiTextBox_color.TabIndex = 8;
            this.uiTextBox_color.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_color.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(12, 135);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(72, 26);
            this.uiLabel4.TabIndex = 7;
            this.uiLabel4.Text = "颜色/规格";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_oname
            // 
            this.uiTextBox_oname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_oname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_oname.Location = new System.Drawing.Point(371, 133);
            this.uiTextBox_oname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_oname.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_oname.Name = "uiTextBox_oname";
            this.uiTextBox_oname.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_oname.Radius = 0;
            this.uiTextBox_oname.ShowText = false;
            this.uiTextBox_oname.Size = new System.Drawing.Size(163, 27);
            this.uiTextBox_oname.TabIndex = 10;
            this.uiTextBox_oname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_oname.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(285, 135);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(72, 26);
            this.uiLabel5.TabIndex = 9;
            this.uiLabel5.Text = "别名";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_num
            // 
            this.uiTextBox_num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_num.FillColor = System.Drawing.Color.Yellow;
            this.uiTextBox_num.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_num.Location = new System.Drawing.Point(98, 215);
            this.uiTextBox_num.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_num.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_num.Name = "uiTextBox_num";
            this.uiTextBox_num.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_num.Radius = 0;
            this.uiTextBox_num.ShowText = false;
            this.uiTextBox_num.Size = new System.Drawing.Size(163, 27);
            this.uiTextBox_num.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox_num.TabIndex = 12;
            this.uiTextBox_num.Text = "0";
            this.uiTextBox_num.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.uiTextBox_num.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.Location = new System.Drawing.Point(12, 217);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(72, 26);
            this.uiLabel6.TabIndex = 11;
            this.uiLabel6.Text = "采购数量";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_price
            // 
            this.uiTextBox_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_price.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_price.Location = new System.Drawing.Point(371, 215);
            this.uiTextBox_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_price.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_price.Name = "uiTextBox_price";
            this.uiTextBox_price.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_price.Radius = 0;
            this.uiTextBox_price.ShowText = false;
            this.uiTextBox_price.Size = new System.Drawing.Size(163, 27);
            this.uiTextBox_price.TabIndex = 14;
            this.uiTextBox_price.Text = "0.00";
            this.uiTextBox_price.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.uiTextBox_price.Watermark = "";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.Location = new System.Drawing.Point(285, 217);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(72, 26);
            this.uiLabel7.TabIndex = 13;
            this.uiLabel7.Text = "单位(元)";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_note
            // 
            this.uiTextBox_note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_note.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_note.Location = new System.Drawing.Point(98, 258);
            this.uiTextBox_note.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_note.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_note.Name = "uiTextBox_note";
            this.uiTextBox_note.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_note.Radius = 0;
            this.uiTextBox_note.ShowText = false;
            this.uiTextBox_note.Size = new System.Drawing.Size(436, 27);
            this.uiTextBox_note.TabIndex = 16;
            this.uiTextBox_note.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_note.Watermark = "";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.Location = new System.Drawing.Point(12, 260);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(72, 26);
            this.uiLabel8.TabIndex = 15;
            this.uiLabel8.Text = "附加信息";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine2
            // 
            this.uiLine2.FillColor = System.Drawing.Color.Transparent;
            this.uiLine2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine2.LineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine2.Location = new System.Drawing.Point(10, 184);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(552, 20);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 17;
            this.uiLine2.Text = "条目资料";
            // 
            // uiLine3
            // 
            this.uiLine3.FillColor = System.Drawing.Color.Transparent;
            this.uiLine3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine3.LineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine3.Location = new System.Drawing.Point(13, 303);
            this.uiLine3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(552, 21);
            this.uiLine3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine3.TabIndex = 18;
            // 
            // uiSymbolButton_ok
            // 
            this.uiSymbolButton_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_ok.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_ok.Location = new System.Drawing.Point(270, 347);
            this.uiSymbolButton_ok.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_ok.Name = "uiSymbolButton_ok";
            this.uiSymbolButton_ok.Size = new System.Drawing.Size(86, 29);
            this.uiSymbolButton_ok.TabIndex = 19;
            this.uiSymbolButton_ok.Text = "确定";
            this.uiSymbolButton_ok.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiSymbolButton_exit
            // 
            this.uiSymbolButton_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_exit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_exit.Location = new System.Drawing.Point(406, 347);
            this.uiSymbolButton_exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_exit.Name = "uiSymbolButton_exit";
            this.uiSymbolButton_exit.Size = new System.Drawing.Size(86, 29);
            this.uiSymbolButton_exit.Symbol = 61453;
            this.uiSymbolButton_exit.TabIndex = 20;
            this.uiSymbolButton_exit.Text = "取消";
            this.uiSymbolButton_exit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_exit.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // Form_Addnr_Dj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 406);
            this.Controls.Add(this.uiSymbolButton_exit);
            this.Controls.Add(this.uiSymbolButton_ok);
            this.Controls.Add(this.uiLine3);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiTextBox_note);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiTextBox_price);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiTextBox_num);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiTextBox_oname);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiTextBox_color);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiTextBox_name);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiTextBox_class);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiTextBox_cid);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLine1);
            this.Name = "Form_Addnr_Dj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Addnr_Dj";
            this.Load += new System.EventHandler(this.Form_Addnr_Dj_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox_cid;
        private Sunny.UI.UITextBox uiTextBox_class;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox uiTextBox_name;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox uiTextBox_color;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox uiTextBox_oname;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox uiTextBox_num;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox uiTextBox_price;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox uiTextBox_note;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine3;
        private Sunny.UI.UISymbolButton uiSymbolButton_ok;
        private Sunny.UI.UISymbolButton uiSymbolButton_exit;
    }
}