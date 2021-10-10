namespace ChatServer.Forms
{
    partial class Manage_a_Room
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dele_button = new System.Windows.Forms.Button();
            this.Title_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.User_list = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Info_box = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dele_button);
            this.panel1.Controls.Add(this.Title_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 54);
            this.panel1.TabIndex = 0;
            // 
            // Dele_button
            // 
            this.Dele_button.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Dele_button.Location = new System.Drawing.Point(690, 12);
            this.Dele_button.Name = "Dele_button";
            this.Dele_button.Size = new System.Drawing.Size(92, 40);
            this.Dele_button.TabIndex = 1;
            this.Dele_button.Text = "删除";
            this.Dele_button.UseVisualStyleBackColor = true;
            this.Dele_button.Click += new System.EventHandler(this.Dele_button_Click);
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("方正粗黑宋简体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title_label.Location = new System.Drawing.Point(267, 9);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(234, 34);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "xxx聊天室的信息";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.User_list);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(573, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 396);
            this.panel2.TabIndex = 0;
            // 
            // User_list
            // 
            this.User_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_list.HideSelection = false;
            this.User_list.Location = new System.Drawing.Point(0, 0);
            this.User_list.Name = "User_list";
            this.User_list.Size = new System.Drawing.Size(330, 396);
            this.User_list.TabIndex = 0;
            this.User_list.UseCompatibleStateImageBehavior = false;
            this.User_list.View = System.Windows.Forms.View.Details;
            this.User_list.SelectedIndexChanged += new System.EventHandler(this.User_list_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Info_box);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 396);
            this.panel3.TabIndex = 0;
            // 
            // Info_box
            // 
            this.Info_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Info_box.Location = new System.Drawing.Point(0, 0);
            this.Info_box.Name = "Info_box";
            this.Info_box.Size = new System.Drawing.Size(573, 396);
            this.Info_box.TabIndex = 0;
            this.Info_box.Text = "";
            // 
            // Manage_a_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Manage_a_Room";
            this.Text = "管理房间";
            this.Load += new System.EventHandler(this.Manage_a_Room_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox Info_box;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.ListView User_list;
        private System.Windows.Forms.Button Dele_button;
    }
}