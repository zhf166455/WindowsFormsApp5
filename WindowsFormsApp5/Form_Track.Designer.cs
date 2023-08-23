namespace WindowsFormsApp5
{
    partial class Form_Track
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
            this.uiTextBox_kwd = new Sunny.UI.UITextBox();
            this.grid1 = new FlexCell.Grid();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(10, 7);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(51, 36);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "IMEI";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_kwd
            // 
            this.uiTextBox_kwd.ButtonForeColor = System.Drawing.Color.Khaki;
            this.uiTextBox_kwd.ButtonSymbol = 61452;
            this.uiTextBox_kwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_kwd.FillColor = System.Drawing.Color.Yellow;
            this.uiTextBox_kwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_kwd.Location = new System.Drawing.Point(58, 12);
            this.uiTextBox_kwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_kwd.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_kwd.Name = "uiTextBox_kwd";
            this.uiTextBox_kwd.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_kwd.Radius = 0;
            this.uiTextBox_kwd.ShowText = false;
            this.uiTextBox_kwd.Size = new System.Drawing.Size(258, 27);
            this.uiTextBox_kwd.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox_kwd.TabIndex = 1;
            this.uiTextBox_kwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_kwd.Watermark = "";
            this.uiTextBox_kwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uiTextBox1_KeyPress);
            // 
            // grid1
            // 
            this.grid1.BackColorBkg = System.Drawing.Color.White;
            this.grid1.Cols = 10;
            this.grid1.DefaultFont = new System.Drawing.Font("宋体", 9F);
            this.grid1.Location = new System.Drawing.Point(10, 53);
            this.grid1.Name = "grid1";
            this.grid1.Rows = 2;
            this.grid1.Size = new System.Drawing.Size(1888, 846);
            this.grid1.TabIndex = 2;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(323, 7);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(250, 36);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "(输入后回车，可输入4位以上)";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Track
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1910, 926);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.uiTextBox_kwd);
            this.Controls.Add(this.uiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Track";
            this.Text = "Form_Track";
            this.Load += new System.EventHandler(this.Form_Track_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox_kwd;
        private FlexCell.Grid grid1;
        private Sunny.UI.UILabel uiLabel2;
    }
}