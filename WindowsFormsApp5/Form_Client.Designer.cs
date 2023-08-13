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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("(000)本公司");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("(001)供应商");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("(998)内部分销");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("(999)零售对应客户");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("全部客户", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiButton_update = new Sunny.UI.UIButton();
            this.uiButton_del = new Sunny.UI.UIButton();
            this.uiButton_add = new Sunny.UI.UIButton();
            this.uiButton_get = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiTreeView1 = new Sunny.UI.UITreeView();
            this.grid_client = new FlexCell.Grid();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiButton_update);
            this.uiPanel1.Controls.Add(this.uiButton_del);
            this.uiPanel1.Controls.Add(this.uiButton_add);
            this.uiPanel1.Controls.Add(this.uiButton_get);
            this.uiPanel1.Controls.Add(this.uiButton1);
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(3, 6);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1894, 77);
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
            // uiTreeView1
            // 
            this.uiTreeView1.FillColor = System.Drawing.Color.White;
            this.uiTreeView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTreeView1.Location = new System.Drawing.Point(3, 91);
            this.uiTreeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTreeView1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTreeView1.Name = "uiTreeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "(000)本公司";
            treeNode2.Name = "节点2";
            treeNode2.Text = "(001)供应商";
            treeNode3.Name = "节点3";
            treeNode3.Text = "(998)内部分销";
            treeNode4.Name = "节点4";
            treeNode4.Text = "(999)零售对应客户";
            treeNode5.Name = "节点0";
            treeNode5.Text = "全部客户";
            this.uiTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.uiTreeView1.ShowLines = true;
            this.uiTreeView1.ShowText = false;
            this.uiTreeView1.Size = new System.Drawing.Size(283, 821);
            this.uiTreeView1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTreeView1.TabIndex = 1;
            this.uiTreeView1.Text = "uiTreeView1";
            this.uiTreeView1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTreeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.uiTreeView1_MouseDoubleClick);
            // 
            // grid_client
            // 
            this.grid_client.AllowUserSort = true;
            this.grid_client.BackColorActiveCellSel = System.Drawing.SystemColors.Highlight;
            this.grid_client.BackColorBkg = System.Drawing.Color.White;
            this.grid_client.Cols = 10;
            this.grid_client.DefaultFont = new System.Drawing.Font("宋体", 9F);
            this.grid_client.DisplayRowArrow = true;
            this.grid_client.FixedRows = 2;
            this.grid_client.Location = new System.Drawing.Point(297, 91);
            this.grid_client.Name = "grid_client";
            this.grid_client.Rows = 3;
            this.grid_client.SelectionMode = FlexCell.SelectionModeEnum.ByRow;
            this.grid_client.Size = new System.Drawing.Size(1601, 823);
            this.grid_client.TabIndex = 2;
            this.grid_client.TopRow = 2;
            this.grid_client.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grid_client_MouseDoubleClick);
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 926);
            this.Controls.Add(this.grid_client);
            this.Controls.Add(this.uiTreeView1);
            this.Controls.Add(this.uiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Client";
            this.Text = "Form_Client";
            this.Load += new System.EventHandler(this.Form_Client_Load);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Sunny.UI.UIPanel uiPanel1;
        public Sunny.UI.UITreeView uiTreeView1;
        public FlexCell.Grid grid_client;
        public Sunny.UI.UIButton uiButton_update;
        public Sunny.UI.UIButton uiButton_del;
        public Sunny.UI.UIButton uiButton_add;
        public Sunny.UI.UIButton uiButton_get;
        public Sunny.UI.UIButton uiButton1;
    }
}