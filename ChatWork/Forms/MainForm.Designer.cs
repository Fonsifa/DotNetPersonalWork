namespace ChatWork.Forms
{
    partial class MainForm
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
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.createRoom_button = new Sunny.UI.UIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.Room_list = new System.Windows.Forms.ListView();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.createRoom_button);
            this.uiPanel1.Controls.Add(this.label1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.Silver;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Silver;
            this.uiPanel1.Size = new System.Drawing.Size(793, 77);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createRoom_button
            // 
            this.createRoom_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createRoom_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.createRoom_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createRoom_button.FillColor = System.Drawing.Color.Transparent;
            this.createRoom_button.FillHoverColor = System.Drawing.Color.Gray;
            this.createRoom_button.FillPressColor = System.Drawing.Color.Gray;
            this.createRoom_button.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createRoom_button.Font = new System.Drawing.Font("方正粗黑宋简体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.createRoom_button.ForeColor = System.Drawing.Color.Black;
            this.createRoom_button.Location = new System.Drawing.Point(370, 20);
            this.createRoom_button.MinimumSize = new System.Drawing.Size(1, 1);
            this.createRoom_button.Name = "createRoom_button";
            this.createRoom_button.RectColor = System.Drawing.Color.Gray;
            this.createRoom_button.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createRoom_button.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createRoom_button.RectSelectedColor = System.Drawing.Color.Gray;
            this.createRoom_button.Size = new System.Drawing.Size(147, 37);
            this.createRoom_button.Style = Sunny.UI.UIStyle.Custom;
            this.createRoom_button.TabIndex = 1;
            this.createRoom_button.Text = "新建聊天室";
            this.createRoom_button.Click += new System.EventHandler(this.createRoom_button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("方正粗黑宋简体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(135, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "聊天室列表";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.Room_list);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.FillColor = System.Drawing.Color.White;
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 77);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.Silver;
            this.uiPanel2.Size = new System.Drawing.Size(793, 419);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.TabIndex = 0;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Room_list
            // 
            this.Room_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Room_list.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Room_list.HideSelection = false;
            this.Room_list.Location = new System.Drawing.Point(0, 0);
            this.Room_list.Name = "Room_list";
            this.Room_list.Size = new System.Drawing.Size(793, 419);
            this.Room_list.TabIndex = 0;
            this.Room_list.UseCompatibleStateImageBehavior = false;
            this.Room_list.View = System.Windows.Forms.View.Details;
            this.Room_list.SelectedIndexChanged += new System.EventHandler(this.Room_list_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 496);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎进入";
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.uiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton createRoom_button;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIPanel uiPanel2;
        private System.Windows.Forms.ListView Room_list;
    }
}