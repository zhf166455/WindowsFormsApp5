namespace WindowsFormsApp5
{
    partial class Form_Client
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
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("(000)本公司");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("(001)供应商");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("(998)内部分销");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("(999)零售对应客户");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("全部客户", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiButton_update = new Sunny.UI.UIButton();
            this.uiButton_del = new Sunny.UI.UIButton();
            this.uiButton_add = new Sunny.UI.UIButton();
            this.uiButton_get = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.grid_client = new FlexCell.Grid();
            this.uiTreeView1 = new Sunny.UI.UITreeView();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiButton_update);
            this.uiPanel1.Controls.Add(this.uiButton_del);
            this.uiPanel1.Controls.Add(this.uiButton_add);
            this.uiPanel1.Controls.Add(this.uiButton_get);
            this.uiPanel1.Controls.Add(this.uiButton1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(3, 3);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.uiPanel1.Size = new System.Drawing.Size(1904, 77);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton_update
            // 
            this.uiButton_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_update.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_update.Location = new System.Drawing.Point(715, 19);
            this.uiButton_update.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_update.Name = "uiButton_update";
            this.uiButton_update.Size = new System.Drawing.Size(100, 37);
            this.uiButton_update.TabIndex = 4;
            this.uiButton_update.Text = "修改";
            this.uiButton_update.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_update.Click += new System.EventHandler(this.uiButton_update_Click);
            // 
            // uiButton_del
            // 
            this.uiButton_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_del.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_del.Location = new System.Drawing.Point(574, 19);
            this.uiButton_del.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_del.Name = "uiButton_del";
            this.uiButton_del.Size = new System.Drawing.Size(100, 37);
            this.uiButton_del.TabIndex = 3;
            this.uiButton_del.Text = "删除";
            this.uiButton_del.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_del.Click += new System.EventHandler(this.uiButton_del_Click);
            // 
            // uiButton_add
            // 
            this.uiButton_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_add.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_add.Location = new System.Drawing.Point(435, 19);
            this.uiButton_add.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_add.Name = "uiButton_add";
            this.uiButton_add.Size = new System.Drawing.Size(100, 37);
            this.uiButton_add.TabIndex = 2;
            this.uiButton_add.Text = "新建";
            this.uiButton_add.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_add.Click += new System.EventHandler(this.uiButton_add_Click);
            // 
            // uiButton_get
            // 
            this.uiButton_get.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_get.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_get.Location = new System.Drawing.Point(294, 19);
            this.uiButton_get.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_get.Name = "uiButton_get";
            this.uiButton_get.Size = new System.Drawing.Size(100, 37);
            this.uiButton_get.TabIndex = 1;
            this.uiButton_get.Text = "刷新";
            this.uiButton_get.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_get.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(7, 19);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 37);
            this.uiButton1.TabIndex = 0;
            this.uiButton1.Text = "分类管理";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uiPanel3);
            this.uiPanel2.Controls.Add(this.uiTreeView1);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.Location = new System.Drawing.Point(3, 80);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.uiPanel2.RectColor = System.Drawing.Color.White;
            this.uiPanel2.Size = new System.Drawing.Size(1904, 843);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.TabIndex = 3;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.grid_client);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel3.Location = new System.Drawing.Point(283, 3);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.uiPanel3.RectColor = System.Drawing.Color.White;
            this.uiPanel3.Size = new System.Drawing.Size(1621, 840);
            this.uiPanel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel3.TabIndex = 4;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grid_client
            // 
            this.grid_client.AllowUserResizing = FlexCell.ResizeEnum.Columns;
            this.grid_client.AllowUserSort = true;
            this.grid_client.BackColorActiveCellSel = System.Drawing.Color.Blue;
            this.grid_client.BackColorBkg = System.Drawing.Color.White;
            this.grid_client.BackColorSel = System.Drawing.Color.Blue;
            this.grid_client.Cols = 10;
            this.grid_client.DefaultFont = new System.Drawing.Font("宋体", 9F);
            this.grid_client.DisplayRowArrow = true;
            this.grid_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_client.FixedRows = 2;
            this.grid_client.Location = new System.Drawing.Point(3, 0);
            this.grid_client.Name = "grid_client";
            this.grid_client.Rows = 3;
            this.grid_client.SelectionBorderColor = System.Drawing.Color.Transparent;
            this.grid_client.SelectionMode = FlexCell.SelectionModeEnum.ByRow;
            this.grid_client.Size = new System.Drawing.Size(1618, 840);
            this.grid_client.TabIndex = 4;
            this.grid_client.TopRow = 2;
            this.grid_client.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grid_client_MouseDoubleClick);
            // 
            // uiTreeView1
            // 
            this.uiTreeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiTreeView1.FillColor = System.Drawing.Color.White;
            this.uiTreeView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTreeView1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiTreeView1.Location = new System.Drawing.Point(0, 3);
            this.uiTreeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTreeView1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTreeView1.Name = "uiTreeView1";
            treeNode21.Name = "节点1";
            treeNode21.Text = "(000)本公司";
            treeNode22.Name = "节点2";
            treeNode22.Text = "(001)供应商";
            treeNode23.Name = "节点3";
            treeNode23.Text = "(998)内部分销";
            treeNode24.Name = "节点4";
            treeNode24.Text = "(999)零售对应客户";
            treeNode25.Name = "节点0";
            treeNode25.Text = "全部客户";
            this.uiTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode25});
            this.uiTreeView1.ShowLines = true;
            this.uiTreeView1.ShowText = false;
            this.uiTreeView1.Size = new System.Drawing.Size(283, 840);
            this.uiTreeView1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTreeView1.TabIndex = 2;
            this.uiTreeView1.Text = "uiTreeView1";
            this.uiTreeView1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTreeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.uiTreeView1_MouseDoubleClick);
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 926);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Client";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Form_Client";
            this.Load += new System.EventHandler(this.Form_Client_Load);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Sunny.UI.UIPanel uiPanel1;
        public Sunny.UI.UIButton uiButton_update;
        public Sunny.UI.UIButton uiButton_del;
        public Sunny.UI.UIButton uiButton_add;
        public Sunny.UI.UIButton uiButton_get;
        public Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel3;
        public FlexCell.Grid grid_client;
        public Sunny.UI.UITreeView uiTreeView1;
    }
}