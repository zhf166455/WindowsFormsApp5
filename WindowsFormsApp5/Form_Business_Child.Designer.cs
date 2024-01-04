namespace WindowsFormsApp5
{
    partial class Form_Business_Child
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
            this.components = new System.ComponentModel.Container();
            this.grid2 = new FlexCell.Grid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.导出到excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grid1 = new FlexCell.Grid();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.导出到excelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid2
            // 
            this.grid2.AllowUserResizing = FlexCell.ResizeEnum.Columns;
            this.grid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.grid2.BackColorActiveCellSel = System.Drawing.Color.Blue;
            this.grid2.BackColorBkg = System.Drawing.Color.White;
            this.grid2.BackColorSel = System.Drawing.Color.Blue;
            this.grid2.ClearBlankArea = true;
            this.grid2.Cols = 16;
            this.grid2.ContextMenuStrip = this.contextMenuStrip1;
            this.grid2.DefaultFont = new System.Drawing.Font("宋体", 9F);
            this.grid2.DisplayFocusRect = false;
            this.grid2.DisplayRowArrow = true;
            this.grid2.EnterKeyMoveTo = FlexCell.MoveToEnum.NextRow;
            this.grid2.FrozenBottomRows = 1;
            this.grid2.Location = new System.Drawing.Point(683, 50);
            this.grid2.MultiSelect = false;
            this.grid2.Name = "grid2";
            this.grid2.Rows = 3;
            this.grid2.SelectionBorderColor = System.Drawing.Color.Transparent;
            this.grid2.SelectionMode = FlexCell.SelectionModeEnum.ByRow;
            this.grid2.Size = new System.Drawing.Size(1213, 869);
            this.grid2.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出到excelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 26);
            // 
            // 导出到excelToolStripMenuItem
            // 
            this.导出到excelToolStripMenuItem.Name = "导出到excelToolStripMenuItem";
            this.导出到excelToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.导出到excelToolStripMenuItem.Text = "导出到excel";
            this.导出到excelToolStripMenuItem.Click += new System.EventHandler(this.导出到excelToolStripMenuItem_Click);
            // 
            // grid1
            // 
            this.grid1.AllowUserResizing = FlexCell.ResizeEnum.Columns;
            this.grid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.grid1.BackColorActiveCellSel = System.Drawing.Color.Blue;
            this.grid1.BackColorBkg = System.Drawing.Color.White;
            this.grid1.BackColorSel = System.Drawing.Color.Blue;
            this.grid1.ClearBlankArea = true;
            this.grid1.Cols = 8;
            this.grid1.ContextMenuStrip = this.contextMenuStrip2;
            this.grid1.DefaultFont = new System.Drawing.Font("宋体", 9F);
            this.grid1.DisplayFocusRect = false;
            this.grid1.DisplayRowArrow = true;
            this.grid1.EnterKeyMoveTo = FlexCell.MoveToEnum.NextRow;
            this.grid1.FrozenBottomRows = 1;
            this.grid1.Location = new System.Drawing.Point(6, 51);
            this.grid1.MultiSelect = false;
            this.grid1.Name = "grid1";
            this.grid1.Rows = 3;
            this.grid1.SelectionBorderColor = System.Drawing.Color.Transparent;
            this.grid1.SelectionMode = FlexCell.SelectionModeEnum.ByRow;
            this.grid1.Size = new System.Drawing.Size(664, 868);
            this.grid1.TabIndex = 6;
            this.grid1.RowColChange += new FlexCell.Grid.RowColChangeEventHandler(this.grid1_RowColChange);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.Yellow;
            this.uiTextBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(74, 13);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.Radius = 0;
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(176, 25);
            this.uiTextBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox1.TabIndex = 5;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(9, 13);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(71, 26);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "模糊查询";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Red;
            this.uiLabel2.Location = new System.Drawing.Point(687, 10);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(563, 27);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 8;
            this.uiLabel2.Text = "业务详细 ";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xls";
            this.saveFileDialog1.Filter = "表格文件|*.xls";
            this.saveFileDialog1.Title = "导出到excel";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出到excelToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 48);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.DefaultExt = "xls";
            this.saveFileDialog2.Filter = "表格文件|*.xls";
            this.saveFileDialog2.Title = "导出到excel";
            // 
            // 导出到excelToolStripMenuItem1
            // 
            this.导出到excelToolStripMenuItem1.Name = "导出到excelToolStripMenuItem1";
            this.导出到excelToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.导出到excelToolStripMenuItem1.Text = "导出到excel";
            this.导出到excelToolStripMenuItem1.Click += new System.EventHandler(this.导出到excelToolStripMenuItem1_Click);
            // 
            // Form_Business_Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1903, 922);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Business_Child";
            this.Text = "Form_Business_Child";
            this.Load += new System.EventHandler(this.Form_Business_Child_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlexCell.Grid grid2;
        private FlexCell.Grid grid1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 导出到excelToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem 导出到excelToolStripMenuItem1;
    }
}