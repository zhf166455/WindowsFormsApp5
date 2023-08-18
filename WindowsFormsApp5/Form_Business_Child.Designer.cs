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
            this.grid2 = new FlexCell.Grid();
            this.grid1 = new FlexCell.Grid();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // grid2
            // 
            this.grid2.DefaultFont = new System.Drawing.Font("宋体", 9F);
            this.grid2.Location = new System.Drawing.Point(683, 50);
            this.grid2.Name = "grid2";
            this.grid2.Rows = 3;
            this.grid2.Size = new System.Drawing.Size(1213, 856);
            this.grid2.TabIndex = 7;
            // 
            // grid1
            // 
            this.grid1.DefaultFont = new System.Drawing.Font("宋体", 9F);
            this.grid1.Location = new System.Drawing.Point(6, 51);
            this.grid1.Name = "grid1";
            this.grid1.Rows = 3;
            this.grid1.Size = new System.Drawing.Size(664, 856);
            this.grid1.TabIndex = 6;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(96, 13);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(176, 25);
            this.uiTextBox1.TabIndex = 5;
            this.uiTextBox1.Text = "uiTextBox1";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(9, 13);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(71, 26);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "uiLabel1";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Business_Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1903, 922);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Business_Child";
            this.Text = "Form_Business_Child";
            this.Load += new System.EventHandler(this.Form_Business_Child_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlexCell.Grid grid2;
        private FlexCell.Grid grid1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel1;
    }
}