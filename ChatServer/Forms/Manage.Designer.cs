namespace ChatServer
{
    partial class Manage
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IP_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.start_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.People_label = new System.Windows.Forms.Label();
            this.Limited_box = new System.Windows.Forms.TextBox();
            this.Peo_online_box = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Msg_richbox = new System.Windows.Forms.RichTextBox();
            this.Room_list = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(163, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "10.135.33.106:8750";
            // 
            // IP_label
            // 
            this.IP_label.AutoSize = true;
            this.IP_label.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IP_label.Location = new System.Drawing.Point(9, 37);
            this.IP_label.Name = "IP_label";
            this.IP_label.Size = new System.Drawing.Size(132, 25);
            this.IP_label.TabIndex = 1;
            this.IP_label.Text = "服务器端口：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.start_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.People_label);
            this.panel1.Controls.Add(this.IP_label);
            this.panel1.Controls.Add(this.Limited_box);
            this.panel1.Controls.Add(this.Peo_online_box);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 89);
            this.panel1.TabIndex = 2;
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start_button.Location = new System.Drawing.Point(1076, 27);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(123, 44);
            this.start_button.TabIndex = 5;
            this.start_button.Text = "开启服务器";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(747, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "在线人数上限：";
            // 
            // People_label
            // 
            this.People_label.AutoSize = true;
            this.People_label.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.People_label.Location = new System.Drawing.Point(414, 37);
            this.People_label.Name = "People_label";
            this.People_label.Size = new System.Drawing.Size(132, 25);
            this.People_label.TabIndex = 4;
            this.People_label.Text = "在线总人数：";
            // 
            // Limited_box
            // 
            this.Limited_box.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Limited_box.Location = new System.Drawing.Point(918, 27);
            this.Limited_box.Multiline = true;
            this.Limited_box.Name = "Limited_box";
            this.Limited_box.Size = new System.Drawing.Size(125, 35);
            this.Limited_box.TabIndex = 0;
            this.Limited_box.Text = "50";
            // 
            // Peo_online_box
            // 
            this.Peo_online_box.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Peo_online_box.Location = new System.Drawing.Point(564, 27);
            this.Peo_online_box.Multiline = true;
            this.Peo_online_box.Name = "Peo_online_box";
            this.Peo_online_box.ReadOnly = true;
            this.Peo_online_box.Size = new System.Drawing.Size(160, 35);
            this.Peo_online_box.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1211, 485);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Msg_richbox);
            this.panel4.Controls.Add(this.Room_list);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1211, 417);
            this.panel4.TabIndex = 2;
            // 
            // Msg_richbox
            // 
            this.Msg_richbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Msg_richbox.Location = new System.Drawing.Point(825, 0);
            this.Msg_richbox.Name = "Msg_richbox";
            this.Msg_richbox.Size = new System.Drawing.Size(386, 417);
            this.Msg_richbox.TabIndex = 1;
            this.Msg_richbox.Text = "";
            // 
            // Room_list
            // 
            this.Room_list.Dock = System.Windows.Forms.DockStyle.Left;
            this.Room_list.Font = new System.Drawing.Font("方正粗黑宋简体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Room_list.HideSelection = false;
            this.Room_list.Location = new System.Drawing.Point(0, 0);
            this.Room_list.Name = "Room_list";
            this.Room_list.Size = new System.Drawing.Size(825, 417);
            this.Room_list.TabIndex = 0;
            this.Room_list.UseCompatibleStateImageBehavior = false;
            this.Room_list.View = System.Windows.Forms.View.Details;
            this.Room_list.SelectedIndexChanged += new System.EventHandler(this.Room_list_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1211, 68);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("方正粗黑宋简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(980, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("方正粗黑宋简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(303, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "公共聊天室列表";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理聊天";
            this.Load += new System.EventHandler(this.Manage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label IP_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label People_label;
        private System.Windows.Forms.TextBox Peo_online_box;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView Room_list;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Limited_box;
        private System.Windows.Forms.RichTextBox Msg_richbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start_button;
    }
}

