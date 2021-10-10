namespace ChatWork.Forms
{
    partial class Regist
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
            this.Account_Box = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.Psw_Box = new Sunny.UI.UITextBox();
            this.ConfirmPsw_Box = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.Confirm = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // Account_Box
            // 
            this.Account_Box.ButtonSymbol = 61761;
            this.Account_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Account_Box.FillColor = System.Drawing.Color.White;
            this.Account_Box.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Account_Box.Location = new System.Drawing.Point(341, 63);
            this.Account_Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Account_Box.Maximum = 2147483647D;
            this.Account_Box.Minimum = -2147483648D;
            this.Account_Box.MinimumSize = new System.Drawing.Size(1, 1);
            this.Account_Box.Name = "Account_Box";
            this.Account_Box.RectColor = System.Drawing.Color.Black;
            this.Account_Box.Size = new System.Drawing.Size(224, 34);
            this.Account_Box.Style = Sunny.UI.UIStyle.Custom;
            this.Account_Box.TabIndex = 0;
            this.Account_Box.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(231, 74);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "账户：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(204, 264);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(151, 23);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "确认密码：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Psw_Box
            // 
            this.Psw_Box.ButtonSymbol = 61761;
            this.Psw_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Psw_Box.FillColor = System.Drawing.Color.White;
            this.Psw_Box.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Psw_Box.Location = new System.Drawing.Point(341, 156);
            this.Psw_Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Psw_Box.Maximum = 2147483647D;
            this.Psw_Box.Minimum = -2147483648D;
            this.Psw_Box.MinimumSize = new System.Drawing.Size(1, 1);
            this.Psw_Box.Name = "Psw_Box";
            this.Psw_Box.PasswordChar = '*';
            this.Psw_Box.RectColor = System.Drawing.Color.Black;
            this.Psw_Box.Size = new System.Drawing.Size(224, 34);
            this.Psw_Box.Style = Sunny.UI.UIStyle.Custom;
            this.Psw_Box.TabIndex = 3;
            this.Psw_Box.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConfirmPsw_Box
            // 
            this.ConfirmPsw_Box.ButtonSymbol = 61761;
            this.ConfirmPsw_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmPsw_Box.FillColor = System.Drawing.Color.White;
            this.ConfirmPsw_Box.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ConfirmPsw_Box.Location = new System.Drawing.Point(341, 253);
            this.ConfirmPsw_Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConfirmPsw_Box.Maximum = 2147483647D;
            this.ConfirmPsw_Box.Minimum = -2147483648D;
            this.ConfirmPsw_Box.MinimumSize = new System.Drawing.Size(1, 1);
            this.ConfirmPsw_Box.Name = "ConfirmPsw_Box";
            this.ConfirmPsw_Box.PasswordChar = '*';
            this.ConfirmPsw_Box.RectColor = System.Drawing.Color.Black;
            this.ConfirmPsw_Box.Size = new System.Drawing.Size(224, 34);
            this.ConfirmPsw_Box.Style = Sunny.UI.UIStyle.Custom;
            this.ConfirmPsw_Box.TabIndex = 3;
            this.ConfirmPsw_Box.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(231, 167);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "密码：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Confirm
            // 
            this.Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm.FillColor = System.Drawing.Color.DimGray;
            this.Confirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Confirm.Location = new System.Drawing.Point(318, 381);
            this.Confirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.Confirm.Name = "Confirm";
            this.Confirm.RectColor = System.Drawing.Color.Black;
            this.Confirm.Size = new System.Drawing.Size(100, 35);
            this.Confirm.Style = Sunny.UI.UIStyle.Custom;
            this.Confirm.TabIndex = 4;
            this.Confirm.Text = "确认";
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.ConfirmPsw_Box);
            this.Controls.Add(this.Psw_Box);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.Account_Box);
            this.Name = "Regist";
            this.Text = "注册";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox Account_Box;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox Psw_Box;
        private Sunny.UI.UITextBox ConfirmPsw_Box;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton Confirm;
    }
}