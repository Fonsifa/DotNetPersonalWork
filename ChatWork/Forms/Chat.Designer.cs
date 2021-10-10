namespace ChatWork.Forms
{
    partial class Chat
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
            this.Send_button = new System.Windows.Forms.Button();
            this.leave_button = new System.Windows.Forms.Button();
            this.File_Button = new System.Windows.Forms.Button();
            this.MsgSend_Box = new Sunny.UI.UIRichTextBox();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.Msg_Box = new System.Windows.Forms.RichTextBox();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.Member_List = new System.Windows.Forms.ListView();
            this.ChatInfo_Box = new System.Windows.Forms.RichTextBox();
            this.Tiltle = new Sunny.UI.UITitlePanel();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.Send_button);
            this.uiPanel1.Controls.Add(this.leave_button);
            this.uiPanel1.Controls.Add(this.File_Button);
            this.uiPanel1.Controls.Add(this.MsgSend_Box);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 414);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Black;
            this.uiPanel1.Size = new System.Drawing.Size(1105, 172);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = "uiPanel1";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Send_button
            // 
            this.Send_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Send_button.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Send_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Send_button.Location = new System.Drawing.Point(703, 45);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(402, 75);
            this.Send_button.TabIndex = 6;
            this.Send_button.Text = "发送";
            this.Send_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // leave_button
            // 
            this.leave_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.leave_button.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leave_button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.leave_button.Location = new System.Drawing.Point(703, 120);
            this.leave_button.Name = "leave_button";
            this.leave_button.Size = new System.Drawing.Size(402, 52);
            this.leave_button.TabIndex = 2;
            this.leave_button.Text = "离开";
            this.leave_button.UseVisualStyleBackColor = true;
            this.leave_button.Click += new System.EventHandler(this.Leave_button_Click);
            // 
            // File_Button
            // 
            this.File_Button.AutoSize = true;
            this.File_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.File_Button.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.File_Button.Location = new System.Drawing.Point(703, 0);
            this.File_Button.Name = "File_Button";
            this.File_Button.Size = new System.Drawing.Size(402, 45);
            this.File_Button.TabIndex = 5;
            this.File_Button.Text = "选择文件";
            this.File_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.File_Button.UseVisualStyleBackColor = true;
            this.File_Button.Click += new System.EventHandler(this.File_Button_Click);
            // 
            // MsgSend_Box
            // 
            this.MsgSend_Box.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MsgSend_Box.AutoWordSelection = true;
            this.MsgSend_Box.Dock = System.Windows.Forms.DockStyle.Left;
            this.MsgSend_Box.FillColor = System.Drawing.Color.White;
            this.MsgSend_Box.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MsgSend_Box.Location = new System.Drawing.Point(0, 0);
            this.MsgSend_Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MsgSend_Box.MinimumSize = new System.Drawing.Size(1, 1);
            this.MsgSend_Box.Name = "MsgSend_Box";
            this.MsgSend_Box.Padding = new System.Windows.Forms.Padding(2);
            this.MsgSend_Box.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MsgSend_Box.Size = new System.Drawing.Size(703, 172);
            this.MsgSend_Box.Style = Sunny.UI.UIStyle.Custom;
            this.MsgSend_Box.TabIndex = 0;
            this.MsgSend_Box.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MsgSend_Box.WordWrap = true;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.Msg_Box);
            this.uiPanel2.Controls.Add(this.uiPanel3);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 40);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(1105, 374);
            this.uiPanel2.TabIndex = 0;
            this.uiPanel2.Text = "uiPanel2";
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Msg_Box
            // 
            this.Msg_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Msg_Box.Location = new System.Drawing.Point(0, 0);
            this.Msg_Box.Name = "Msg_Box";
            this.Msg_Box.Size = new System.Drawing.Size(857, 374);
            this.Msg_Box.TabIndex = 1;
            this.Msg_Box.Text = "";
            this.Msg_Box.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.Msg_Box_LinkClicked);
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.Member_List);
            this.uiPanel3.Controls.Add(this.ChatInfo_Box);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(857, 0);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Size = new System.Drawing.Size(248, 374);
            this.uiPanel3.TabIndex = 0;
            this.uiPanel3.Text = "uiPanel3";
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Member_List
            // 
            this.Member_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Member_List.HideSelection = false;
            this.Member_List.Location = new System.Drawing.Point(0, 107);
            this.Member_List.Name = "Member_List";
            this.Member_List.Size = new System.Drawing.Size(248, 267);
            this.Member_List.TabIndex = 1;
            this.Member_List.UseCompatibleStateImageBehavior = false;
            this.Member_List.View = System.Windows.Forms.View.Details;
            this.Member_List.SelectedIndexChanged += new System.EventHandler(this.Member_List_SelectedIndexChanged);
            // 
            // ChatInfo_Box
            // 
            this.ChatInfo_Box.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChatInfo_Box.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChatInfo_Box.Location = new System.Drawing.Point(0, 0);
            this.ChatInfo_Box.Name = "ChatInfo_Box";
            this.ChatInfo_Box.ReadOnly = true;
            this.ChatInfo_Box.Size = new System.Drawing.Size(248, 107);
            this.ChatInfo_Box.TabIndex = 0;
            this.ChatInfo_Box.Text = "聊天简介：";
            // 
            // Tiltle
            // 
            this.Tiltle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tiltle.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tiltle.Location = new System.Drawing.Point(0, 0);
            this.Tiltle.Margin = new System.Windows.Forms.Padding(5);
            this.Tiltle.MinimumSize = new System.Drawing.Size(1, 1);
            this.Tiltle.Name = "Tiltle";
            this.Tiltle.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.Tiltle.RectColor = System.Drawing.Color.Black;
            this.Tiltle.Size = new System.Drawing.Size(1105, 40);
            this.Tiltle.Style = Sunny.UI.UIStyle.Custom;
            this.Tiltle.TabIndex = 0;
            this.Tiltle.Text = "xxx的聊天";
            this.Tiltle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tiltle.TitleColor = System.Drawing.Color.Gray;
            // 
            // Chat
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1105, 586);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.Tiltle);
            this.Name = "Chat";
            this.Text = "聊天室";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIRichTextBox MsgSend_Box;
        private System.Windows.Forms.RichTextBox Msg_Box;
        private System.Windows.Forms.Button File_Button;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.RichTextBox ChatInfo_Box;
        private Sunny.UI.UITitlePanel Tiltle;
        private System.Windows.Forms.Button leave_button;
        private System.Windows.Forms.ListView Member_List;
    }
}