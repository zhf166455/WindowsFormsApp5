namespace WindowsFormsApp5
{
    partial class Form_Pro_Class_Max
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
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiTextBox_cid = new Sunny.UI.UITextBox();
            this.uiTextBox_name = new Sunny.UI.UITextBox();
            this.uiCheckBox_check = new Sunny.UI.UICheckBox();
            this.uiSymbolButton_ok = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_exit = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.LineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine1.Location = new System.Drawing.Point(9, 153);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(407, 18);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 0;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(15, 17);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(85, 36);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "大类编号：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.uiLabel2.Location = new System.Drawing.Point(12, 70);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(87, 26);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "大类名称：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.uiLabel3.Location = new System.Drawing.Point(15, 116);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(87, 26);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "串码管理：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_cid
            // 
            this.uiTextBox_cid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_cid.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_cid.Location = new System.Drawing.Point(88, 23);
            this.uiTextBox_cid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_cid.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_cid.Name = "uiTextBox_cid";
            this.uiTextBox_cid.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_cid.Radius = 0;
            this.uiTextBox_cid.ShowText = false;
            this.uiTextBox_cid.Size = new System.Drawing.Size(114, 30);
            this.uiTextBox_cid.TabIndex = 4;
            this.uiTextBox_cid.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_cid.Watermark = "";
            // 
            // uiTextBox_name
            // 
            this.uiTextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_name.Location = new System.Drawing.Point(88, 71);
            this.uiTextBox_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_name.Name = "uiTextBox_name";
            this.uiTextBox_name.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_name.Radius = 0;
            this.uiTextBox_name.ShowText = false;
            this.uiTextBox_name.Size = new System.Drawing.Size(200, 30);
            this.uiTextBox_name.TabIndex = 5;
            this.uiTextBox_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_name.Watermark = "";
            // 
            // uiCheckBox_check
            // 
            this.uiCheckBox_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox_check.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBox_check.Location = new System.Drawing.Point(82, 120);
            this.uiCheckBox_check.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox_check.Name = "uiCheckBox_check";
            this.uiCheckBox_check.Size = new System.Drawing.Size(25, 18);
            this.uiCheckBox_check.TabIndex = 6;
            this.uiCheckBox_check.Text = "uiCheckBox1";
            // 
            // uiSymbolButton_ok
            // 
            this.uiSymbolButton_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_ok.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_ok.Location = new System.Drawing.Point(183, 184);
            this.uiSymbolButton_ok.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_ok.Name = "uiSymbolButton_ok";
            this.uiSymbolButton_ok.Size = new System.Drawing.Size(74, 28);
            this.uiSymbolButton_ok.TabIndex = 7;
            this.uiSymbolButton_ok.Text = "确定";
            this.uiSymbolButton_ok.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_ok.Click += new System.EventHandler(this.uiSymbolButton_ok_Click);
            // 
            // uiSymbolButton_exit
            // 
            this.uiSymbolButton_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_exit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_exit.Location = new System.Drawing.Point(284, 184);
            this.uiSymbolButton_exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_exit.Name = "uiSymbolButton_exit";
            this.uiSymbolButton_exit.Size = new System.Drawing.Size(74, 28);
            this.uiSymbolButton_exit.Symbol = 61453;
            this.uiSymbolButton_exit.TabIndex = 8;
            this.uiSymbolButton_exit.Text = "取消";
            this.uiSymbolButton_exit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_exit.Click += new System.EventHandler(this.uiSymbolButton_exit_Click);
            // 
            // Form_Pro_Class_Max
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 224);
            this.Controls.Add(this.uiSymbolButton_exit);
            this.Controls.Add(this.uiSymbolButton_ok);
            this.Controls.Add(this.uiCheckBox_check);
            this.Controls.Add(this.uiTextBox_name);
            this.Controls.Add(this.uiTextBox_cid);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLine1);
            this.Name = "Form_Pro_Class_Max";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Pro_Class_Max";
            this.Load += new System.EventHandler(this.Form_Pro_Class_Max_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Sunny.UI.UILine uiLine1;
        public Sunny.UI.UILabel uiLabel1;
        public Sunny.UI.UILabel uiLabel2;
        public Sunny.UI.UILabel uiLabel3;
        public Sunny.UI.UITextBox uiTextBox_cid;
        public Sunny.UI.UITextBox uiTextBox_name;
        public Sunny.UI.UICheckBox uiCheckBox_check;
        public Sunny.UI.UISymbolButton uiSymbolButton_ok;
        public Sunny.UI.UISymbolButton uiSymbolButton_exit;
    }
}