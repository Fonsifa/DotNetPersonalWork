namespace ChatWork.Forms
{
    partial class CreateRoom
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
            this.Theme_box = new Sunny.UI.UITextBox();
            this.Introu_box = new Sunny.UI.UIRichTextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.Create_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Theme_box
            // 
            this.Theme_box.ButtonSymbol = 61761;
            this.Theme_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Theme_box.FillColor = System.Drawing.Color.White;
            this.Theme_box.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Theme_box.Location = new System.Drawing.Point(214, 59);
            this.Theme_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Theme_box.Maximum = 2147483647D;
            this.Theme_box.Minimum = -2147483648D;
            this.Theme_box.MinimumSize = new System.Drawing.Size(1, 1);
            this.Theme_box.Name = "Theme_box";
            this.Theme_box.RectColor = System.Drawing.Color.Gray;
            this.Theme_box.Size = new System.Drawing.Size(247, 34);
            this.Theme_box.Style = Sunny.UI.UIStyle.Custom;
            this.Theme_box.TabIndex = 0;
            this.Theme_box.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Introu_box
            // 
            this.Introu_box.AutoWordSelection = true;
            this.Introu_box.FillColor = System.Drawing.Color.White;
            this.Introu_box.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Introu_box.Location = new System.Drawing.Point(214, 137);
            this.Introu_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Introu_box.MinimumSize = new System.Drawing.Size(1, 1);
            this.Introu_box.Name = "Introu_box";
            this.Introu_box.Padding = new System.Windows.Forms.Padding(2);
            this.Introu_box.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Introu_box.Size = new System.Drawing.Size(270, 180);
            this.Introu_box.Style = Sunny.UI.UIStyle.Custom;
            this.Introu_box.TabIndex = 3;
            this.Introu_box.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Introu_box.WordWrap = true;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(96, 70);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "主题：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(96, 137);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "简介：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Create_button
            // 
            this.Create_button.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Create_button.Location = new System.Drawing.Point(241, 361);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(104, 39);
            this.Create_button.TabIndex = 3;
            this.Create_button.Text = "创建";
            this.Create_button.UseVisualStyleBackColor = true;
            this.Create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // CreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 426);
            this.Controls.Add(this.Create_button);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.Introu_box);
            this.Controls.Add(this.Theme_box);
            this.Name = "CreateRoom";
            this.Text = "创建聊天室";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox Theme_box;
        private Sunny.UI.UIRichTextBox Introu_box;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.Button Create_button;
    }
}