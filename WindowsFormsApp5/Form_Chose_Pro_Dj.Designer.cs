namespace WindowsFormsApp5
{
    partial class Form_Chose_Pro_Dj
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
            this.uiSymbolButton_refrsh = new Sunny.UI.UISymbolButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTextBox_kwd = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiTreeView1 = new Sunny.UI.UITreeView();
            this.grid1 = new FlexCell.Grid();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiSymbolButton_ok = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_exit = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // uiSymbolButton_refrsh
            // 
            this.uiSymbolButton_refrsh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_refrsh.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_refrsh.Location = new System.Drawing.Point(17, 14);
            this.uiSymbolButton_refrsh.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_refrsh.Name = "uiSymbolButton_refrsh";
            this.uiSymbolButton_refrsh.Size = new System.Drawing.Size(87, 32);
            this.uiSymbolButton_refrsh.Symbol = 61473;
            this.uiSymbolButton_refrsh.TabIndex = 0;
            this.uiSymbolButton_refrsh.Text = "刷新";
            this.uiSymbolButton_refrsh.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(119, 17);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(78, 28);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "模糊查询";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_kwd
            // 
            this.uiTextBox_kwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_kwd.FillColor = System.Drawing.Color.Yellow;
            this.uiTextBox_kwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_kwd.Location = new System.Drawing.Point(216, 18);
            this.uiTextBox_kwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_kwd.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_kwd.Name = "uiTextBox_kwd";
            this.uiTextBox_kwd.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_kwd.Radius = 0;
            this.uiTextBox_kwd.ShowText = false;
            this.uiTextBox_kwd.Size = new System.Drawing.Size(253, 27);
            this.uiTextBox_kwd.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox_kwd.TabIndex = 2;
            this.uiTextBox_kwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_kwd.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(490, 18);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(140, 26);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "(支持拼音首字母)";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTreeView1
            // 
            this.uiTreeView1.FillColor = System.Drawing.Color.White;
            this.uiTreeView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTreeView1.HideSelection = false;
            this.uiTreeView1.Location = new System.Drawing.Point(13, 58);
            this.uiTreeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTreeView1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTreeView1.Name = "uiTreeView1";
            this.uiTreeView1.ShowLines = true;
            this.uiTreeView1.ShowText = false;
            this.uiTreeView1.Size = new System.Drawing.Size(232, 567);
            this.uiTreeView1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTreeView1.TabIndex = 4;
            this.uiTreeView1.Text = "uiTreeView1";
            this.uiTreeView1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTreeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.uiTreeView1_MouseDoubleClick);
            // 
            // grid1
            // 
            this.grid1.BackColorBkg = System.Drawing.Color.White;
            this.grid1.Cols = 8;
            this.grid1.DefaultFont = new System.Drawing.Font("宋体", 9F);
            this.grid1.DisplayFocusRect = false;
            this.grid1.DisplayRowArrow = true;
            this.grid1.Location = new System.Drawing.Point(259, 60);
            this.grid1.Name = "grid1";
            this.grid1.Rows = 2;
            this.grid1.Size = new System.Drawing.Size(866, 564);
            this.grid1.TabIndex = 5;
            this.grid1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grid1_MouseDoubleClick);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(18, 633);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(168, 30);
            this.uiLabel3.TabIndex = 6;
            this.uiLabel3.Text = "注:双击可快捷选中";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolButton_ok
            // 
            this.uiSymbolButton_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_ok.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_ok.Location = new System.Drawing.Point(862, 634);
            this.uiSymbolButton_ok.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_ok.Name = "uiSymbolButton_ok";
            this.uiSymbolButton_ok.Size = new System.Drawing.Size(89, 28);
            this.uiSymbolButton_ok.TabIndex = 7;
            this.uiSymbolButton_ok.Text = "确认";
            this.uiSymbolButton_ok.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiSymbolButton_exit
            // 
            this.uiSymbolButton_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_exit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_exit.Location = new System.Drawing.Point(987, 634);
            this.uiSymbolButton_exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_exit.Name = "uiSymbolButton_exit";
            this.uiSymbolButton_exit.Size = new System.Drawing.Size(89, 28);
            this.uiSymbolButton_exit.Symbol = 61453;
            this.uiSymbolButton_exit.TabIndex = 9;
            this.uiSymbolButton_exit.Text = "取消";
            this.uiSymbolButton_exit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_exit.Click += new System.EventHandler(this.uiSymbolButton_exit_Click);
            // 
            // Form_Chose_Pro_Dj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 675);
            this.Controls.Add(this.uiSymbolButton_exit);
            this.Controls.Add(this.uiSymbolButton_ok);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.uiTreeView1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiTextBox_kwd);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiSymbolButton_refrsh);
            this.Name = "Form_Chose_Pro_Dj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Chose_Pro_Dj";
            this.Load += new System.EventHandler(this.Form_Chose_Pro_Dj_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton uiSymbolButton_refrsh;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox_kwd;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITreeView uiTreeView1;
        private FlexCell.Grid grid1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UISymbolButton uiSymbolButton_ok;
        private Sunny.UI.UISymbolButton uiSymbolButton_exit;
    }
}