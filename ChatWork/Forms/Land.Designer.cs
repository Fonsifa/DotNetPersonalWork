namespace ChatWork
{
    partial class Land
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
            this.Account = new Sunny.UI.UITextBox();
            this.Password = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.Acc_Label = new Sunny.UI.UILabel();
            this.Psw_Label = new Sunny.UI.UILabel();
            this.Login_button = new Sunny.UI.UIButton();
            this.Regist_button = new Sunny.UI.UIButton();
            this.Password.SuspendLayout();
            this.SuspendLayout();
            // 
            // Account
            // 
            this.Account.ButtonSymbol = 61761;
            this.Account.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Account.FillColor = System.Drawing.Color.White;
            this.Account.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Account.Location = new System.Drawing.Point(270, 82);
            this.Account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Account.Maximum = 2147483647D;
            this.Account.Minimum = -2147483648D;
            this.Account.MinimumSize = new System.Drawing.Size(1, 1);
            this.Account.Name = "Account";
            this.Account.RectColor = System.Drawing.Color.Gray;
            this.Account.Size = new System.Drawing.Size(275, 34);
            this.Account.Style = Sunny.UI.UIStyle.Custom;
            this.Account.TabIndex = 0;
            this.Account.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Password
            // 
            this.Password.ButtonSymbol = 61761;
            this.Password.Controls.Add(this.uiLabel2);
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.FillColor = System.Drawing.Color.White;
            this.Password.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Password.Location = new System.Drawing.Point(270, 201);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.Maximum = 2147483647D;
            this.Password.Minimum = -2147483648D;
            this.Password.MinimumSize = new System.Drawing.Size(1, 1);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.RectColor = System.Drawing.Color.Gray;
            this.Password.Size = new System.Drawing.Size(275, 34);
            this.Password.Style = Sunny.UI.UIStyle.Custom;
            this.Password.TabIndex = 1;
            this.Password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(250, 100);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "密码:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Acc_Label
            // 
            this.Acc_Label.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Acc_Label.Location = new System.Drawing.Point(145, 93);
            this.Acc_Label.Name = "Acc_Label";
            this.Acc_Label.Size = new System.Drawing.Size(100, 23);
            this.Acc_Label.TabIndex = 2;
            this.Acc_Label.Text = "账户:";
            this.Acc_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Psw_Label
            // 
            this.Psw_Label.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Psw_Label.Location = new System.Drawing.Point(145, 212);
            this.Psw_Label.Name = "Psw_Label";
            this.Psw_Label.Size = new System.Drawing.Size(100, 23);
            this.Psw_Label.TabIndex = 2;
            this.Psw_Label.Text = "密码:";
            this.Psw_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Login_button
            // 
            this.Login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Login_button.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Login_button.Location = new System.Drawing.Point(201, 334);
            this.Login_button.MinimumSize = new System.Drawing.Size(1, 1);
            this.Login_button.Name = "Login_button";
            this.Login_button.RectColor = System.Drawing.Color.Black;
            this.Login_button.Size = new System.Drawing.Size(100, 35);
            this.Login_button.Style = Sunny.UI.UIStyle.Custom;
            this.Login_button.TabIndex = 3;
            this.Login_button.Text = "登录";
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Regist_button
            // 
            this.Regist_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Regist_button.FillColor = System.Drawing.Color.Teal;
            this.Regist_button.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Regist_button.Location = new System.Drawing.Point(414, 334);
            this.Regist_button.MinimumSize = new System.Drawing.Size(1, 1);
            this.Regist_button.Name = "Regist_button";
            this.Regist_button.RectColor = System.Drawing.Color.Black;
            this.Regist_button.Size = new System.Drawing.Size(100, 35);
            this.Regist_button.Style = Sunny.UI.UIStyle.Custom;
            this.Regist_button.TabIndex = 3;
            this.Regist_button.Text = "注册";
            this.Regist_button.Click += new System.EventHandler(this.Regist_button_Click);
            // 
            // Land
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 420);
            this.Controls.Add(this.Regist_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Psw_Label);
            this.Controls.Add(this.Acc_Label);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Account);
            this.Location = new System.Drawing.Point(200, 100);
            this.Name = "Land";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Password.ResumeLayout(false);
            this.Password.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox Account;
        private Sunny.UI.UITextBox Password;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel Acc_Label;
        private Sunny.UI.UILabel Psw_Label;
        private Sunny.UI.UIButton Login_button;
        private Sunny.UI.UIButton Regist_button;
    }
}

