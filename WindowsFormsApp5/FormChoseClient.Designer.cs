namespace WindowsFormsApp5
{
    partial class FormChoseClient
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTextBox_keyword = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.grid1 = new FlexCell.Grid();
            this.uiSymbolButton_save = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_exit = new Sunny.UI.UISymbolButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(7, 6);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(89, 33);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "模糊查询";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_keyword
            // 
            this.uiTextBox_keyword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_keyword.FillColor = System.Drawing.Color.Yellow;
            this.uiTextBox_keyword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_keyword.Location = new System.Drawing.Point(89, 10);
            this.uiTextBox_keyword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_keyword.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_keyword.Name = "uiTextBox_keyword";
            this.uiTextBox_keyword.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_keyword.Radius = 0;
            this.uiTextBox_keyword.ShowText = false;
            this.uiTextBox_keyword.Size = new System.Drawing.Size(196, 28);
            this.uiTextBox_keyword.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox_keyword.TabIndex = 1;
            this.uiTextBox_keyword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_keyword.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(293, 6);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(154, 33);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "(支持拼音首字母)";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grid1
            // 
            this.grid1.AllowUserSort = true;
            this.grid1.BackColorActiveCellSel = System.Drawing.SystemColors.ActiveCaption;
            this.grid1.BackColorBkg = System.Drawing.Color.White;
            this.grid1.BackColorSel = System.Drawing.SystemColors.ActiveCaption;
            this.grid1.Cols = 7;
            this.grid1.DefaultFont = new System.Drawing.Font("宋体", 9F);
            this.grid1.DisplayFocusRect = false;
            this.grid1.DisplayRowArrow = true;
            this.grid1.EnterKeyMoveTo = FlexCell.MoveToEnum.NextRow;
            this.grid1.Location = new System.Drawing.Point(3, 46);
            this.grid1.MultiSelect = false;
            this.grid1.Name = "grid1";
            this.grid1.Rows = 2;
            this.grid1.SelectionBorderColor = System.Drawing.Color.Transparent;
            this.grid1.SelectionMode = FlexCell.SelectionModeEnum.ByRow;
            this.grid1.Size = new System.Drawing.Size(1011, 524);
            this.grid1.TabIndex = 3;
            this.grid1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grid1_MouseDoubleClick);
            // 
            // uiSymbolButton_save
            // 
            this.uiSymbolButton_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_save.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_save.LightStyle = true;
            this.uiSymbolButton_save.Location = new System.Drawing.Point(801, 578);
            this.uiSymbolButton_save.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_save.Name = "uiSymbolButton_save";
            this.uiSymbolButton_save.Size = new System.Drawing.Size(90, 24);
            this.uiSymbolButton_save.TabIndex = 4;
            this.uiSymbolButton_save.Text = "确认";
            this.uiSymbolButton_save.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_save.Click += new System.EventHandler(this.uiSymbolButton_save_Click);
            // 
            // uiSymbolButton_exit
            // 
            this.uiSymbolButton_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_exit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_exit.LightStyle = true;
            this.uiSymbolButton_exit.Location = new System.Drawing.Point(917, 578);
            this.uiSymbolButton_exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_exit.Name = "uiSymbolButton_exit";
            this.uiSymbolButton_exit.Size = new System.Drawing.Size(90, 24);
            this.uiSymbolButton_exit.Symbol = 61453;
            this.uiSymbolButton_exit.TabIndex = 5;
            this.uiSymbolButton_exit.Text = "取消";
            this.uiSymbolButton_exit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_exit.Click += new System.EventHandler(this.uiSymbolButton_exit_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.Red;
            this.uiLabel3.Location = new System.Drawing.Point(7, 573);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(229, 33);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 6;
            this.uiLabel3.Text = "注：双击可快捷选中";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormChoseClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 611);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiSymbolButton_exit);
            this.Controls.Add(this.uiSymbolButton_save);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiTextBox_keyword);
            this.Controls.Add(this.uiLabel1);
            this.Name = "FormChoseClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChoseClient";
            this.Load += new System.EventHandler(this.FormChoseClient_Load);
            this.Shown += new System.EventHandler(this.FormChoseClient_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox_keyword;
        private Sunny.UI.UILabel uiLabel2;
        private FlexCell.Grid grid1;
        private Sunny.UI.UISymbolButton uiSymbolButton_save;
        private Sunny.UI.UISymbolButton uiSymbolButton_exit;
        private Sunny.UI.UILabel uiLabel3;
    }
}