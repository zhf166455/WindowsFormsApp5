namespace WindowsFormsApp5
{
    partial class Form_Inputprice
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
            this.uiTextBox_price = new Sunny.UI.UITextBox();
            this.uiSymbolButton_ok = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_exit = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(12, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(158, 36);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "请输入商品单价";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_price
            // 
            this.uiTextBox_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_price.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_price.Location = new System.Drawing.Point(16, 45);
            this.uiTextBox_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_price.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_price.Name = "uiTextBox_price";
            this.uiTextBox_price.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_price.Radius = 0;
            this.uiTextBox_price.ShowText = false;
            this.uiTextBox_price.Size = new System.Drawing.Size(333, 33);
            this.uiTextBox_price.TabIndex = 1;
            this.uiTextBox_price.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_price.Watermark = "";
            // 
            // uiSymbolButton_ok
            // 
            this.uiSymbolButton_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_ok.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_ok.Location = new System.Drawing.Point(61, 98);
            this.uiSymbolButton_ok.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_ok.Name = "uiSymbolButton_ok";
            this.uiSymbolButton_ok.Size = new System.Drawing.Size(94, 34);
            this.uiSymbolButton_ok.TabIndex = 2;
            this.uiSymbolButton_ok.Text = "确认";
            this.uiSymbolButton_ok.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_ok.Click += new System.EventHandler(this.uiSymbolButton_ok_Click);
            // 
            // uiSymbolButton_exit
            // 
            this.uiSymbolButton_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_exit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_exit.Location = new System.Drawing.Point(198, 98);
            this.uiSymbolButton_exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_exit.Name = "uiSymbolButton_exit";
            this.uiSymbolButton_exit.Size = new System.Drawing.Size(94, 34);
            this.uiSymbolButton_exit.Symbol = 61453;
            this.uiSymbolButton_exit.TabIndex = 3;
            this.uiSymbolButton_exit.Text = "取消";
            this.uiSymbolButton_exit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_exit.Click += new System.EventHandler(this.uiSymbolButton_exit_Click);
            // 
            // Form_Inputprice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 157);
            this.Controls.Add(this.uiSymbolButton_exit);
            this.Controls.Add(this.uiSymbolButton_ok);
            this.Controls.Add(this.uiTextBox_price);
            this.Controls.Add(this.uiLabel1);
            this.Name = "Form_Inputprice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请输入单价";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox_price;
        private Sunny.UI.UISymbolButton uiSymbolButton_ok;
        private Sunny.UI.UISymbolButton uiSymbolButton_exit;
    }
}