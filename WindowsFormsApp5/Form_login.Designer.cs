namespace WindowsFormsApp5
{
    partial class from_login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_uid = new System.Windows.Forms.TextBox();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.checkBox_repwd = new System.Windows.Forms.CheckBox();
            this.uiButton_login = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(99, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "小微经营管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "账号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // textBox_uid
            // 
            this.textBox_uid.Location = new System.Drawing.Point(121, 100);
            this.textBox_uid.Name = "textBox_uid";
            this.textBox_uid.Size = new System.Drawing.Size(265, 21);
            this.textBox_uid.TabIndex = 3;
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(121, 137);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(265, 21);
            this.textBox_pwd.TabIndex = 4;
            this.textBox_pwd.UseSystemPasswordChar = true;
            // 
            // checkBox_repwd
            // 
            this.checkBox_repwd.AutoSize = true;
            this.checkBox_repwd.Checked = true;
            this.checkBox_repwd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_repwd.Location = new System.Drawing.Point(124, 171);
            this.checkBox_repwd.Name = "checkBox_repwd";
            this.checkBox_repwd.Size = new System.Drawing.Size(72, 16);
            this.checkBox_repwd.TabIndex = 6;
            this.checkBox_repwd.Text = "记住密码";
            this.checkBox_repwd.UseVisualStyleBackColor = true;
            // 
            // uiButton_login
            // 
            this.uiButton_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_login.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_login.Location = new System.Drawing.Point(189, 213);
            this.uiButton_login.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_login.Name = "uiButton_login";
            this.uiButton_login.Size = new System.Drawing.Size(86, 36);
            this.uiButton_login.TabIndex = 7;
            this.uiButton_login.Text = "登录";
            this.uiButton_login.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_login.Click += new System.EventHandler(this.uiButton_login_Click);
            // 
            // from_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 291);
            this.Controls.Add(this.uiButton_login);
            this.Controls.Add(this.checkBox_repwd);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.textBox_uid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "from_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.Load += new System.EventHandler(this.from_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_uid;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.CheckBox checkBox_repwd;
        private Sunny.UI.UIButton uiButton_login;
    }
}

