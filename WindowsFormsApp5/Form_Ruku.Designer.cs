namespace WindowsFormsApp5
{
    partial class Form_Ruku
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
            this.grid_ruku = new FlexCell.Grid();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiButton4 = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton_update = new Sunny.UI.UIButton();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiComboBox2 = new Sunny.UI.UIComboBox();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_ruku
            // 
            this.grid_ruku.AllowUserSort = true;
            this.grid_ruku.BackColorActiveCellSel = System.Drawing.SystemColors.ActiveCaption;
            this.grid_ruku.BackColorBkg = System.Drawing.Color.White;
            this.grid_ruku.BackColorSel = System.Drawing.SystemColors.ActiveCaption;
            this.grid_ruku.BorderColor = System.Drawing.Color.Empty;
            this.grid_ruku.CellBorderColor = System.Drawing.Color.Empty;
            this.grid_ruku.ClearBlankArea = true;
            this.grid_ruku.Cols = 15;
            this.grid_ruku.DefaultFont = new System.Drawing.Font("宋体", 9F);
            this.grid_ruku.DisplayFocusRect = false;
            this.grid_ruku.DisplayRowArrow = true;
            this.grid_ruku.EnterKeyMoveTo = FlexCell.MoveToEnum.NextRow;
            this.grid_ruku.FixedRows = 2;
            this.grid_ruku.FrozenBottomRows = 1;
            this.grid_ruku.Location = new System.Drawing.Point(4, 56);
            this.grid_ruku.MultiSelect = false;
            this.grid_ruku.Name = "grid_ruku";
            this.grid_ruku.Rows = 4;
            this.grid_ruku.SelectionBorderColor = System.Drawing.Color.Transparent;
            this.grid_ruku.SelectionMode = FlexCell.SelectionModeEnum.ByRow;
            this.grid_ruku.Size = new System.Drawing.Size(1900, 858);
            this.grid_ruku.SortIndicatorColor = System.Drawing.Color.Green;
            this.grid_ruku.TabIndex = 3;
            this.grid_ruku.TopRow = 2;
            this.grid_ruku.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grid_ruku_MouseDoubleClick);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiComboBox2);
            this.uiPanel1.Controls.Add(this.uiButton4);
            this.uiPanel1.Controls.Add(this.uiButton3);
            this.uiPanel1.Controls.Add(this.uiButton2);
            this.uiPanel1.Controls.Add(this.uiButton_update);
            this.uiPanel1.Controls.Add(this.uiComboBox1);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(5, 3);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1899, 50);
            this.uiPanel1.TabIndex = 5;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton4
            // 
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton4.Location = new System.Drawing.Point(553, 15);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.Size = new System.Drawing.Size(61, 19);
            this.uiButton4.TabIndex = 14;
            this.uiButton4.Text = "修改";
            this.uiButton4.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton4.Click += new System.EventHandler(this.uiButton4_Click);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Location = new System.Drawing.Point(468, 15);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(61, 19);
            this.uiButton3.TabIndex = 13;
            this.uiButton3.Text = "删除";
            this.uiButton3.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(384, 15);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(61, 19);
            this.uiButton2.TabIndex = 12;
            this.uiButton2.Text = "新建";
            this.uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiButton_update
            // 
            this.uiButton_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_update.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_update.Location = new System.Drawing.Point(299, 14);
            this.uiButton_update.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_update.Name = "uiButton_update";
            this.uiButton_update.Size = new System.Drawing.Size(61, 19);
            this.uiButton_update.TabIndex = 11;
            this.uiButton_update.Text = "刷新";
            this.uiButton_update.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_update.Click += new System.EventHandler(this.uiButton_update_Click);
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboBox1.Items.AddRange(new object[] {
            "今日",
            "近7日",
            "近30日",
            "近90日"});
            this.uiComboBox1.Location = new System.Drawing.Point(94, 11);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(83, 22);
            this.uiComboBox1.TabIndex = 10;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "";
            this.uiComboBox1.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(9, 12);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(80, 22);
            this.uiLabel1.TabIndex = 9;
            this.uiLabel1.Text = "显示选项";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox2
            // 
            this.uiComboBox2.DataSource = null;
            this.uiComboBox2.FillColor = System.Drawing.Color.White;
            this.uiComboBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboBox2.Items.AddRange(new object[] {
            "全部",
            "未过账",
            "已过帐",
            "未核销",
            "已核销"});
            this.uiComboBox2.Location = new System.Drawing.Point(194, 11);
            this.uiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox2.Name = "uiComboBox2";
            this.uiComboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox2.Size = new System.Drawing.Size(83, 22);
            this.uiComboBox2.TabIndex = 15;
            this.uiComboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox2.Watermark = "";
            this.uiComboBox2.SelectedIndexChanged += new System.EventHandler(this.uiComboBox2_SelectedIndexChanged);
            // 
            // Form_Ruku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1910, 920);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.grid_ruku);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Ruku";
            this.Text = "Form_Ruku";
            this.Load += new System.EventHandler(this.Form_Ruku_Load);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public FlexCell.Grid grid_ruku;
        public Sunny.UI.UIPanel uiPanel1;
        public Sunny.UI.UIButton uiButton4;
        public Sunny.UI.UIButton uiButton3;
        public Sunny.UI.UIButton uiButton2;
        public Sunny.UI.UIButton uiButton_update;
        public Sunny.UI.UIComboBox uiComboBox1;
        public Sunny.UI.UILabel uiLabel1;
        public Sunny.UI.UIComboBox uiComboBox2;
    }
}