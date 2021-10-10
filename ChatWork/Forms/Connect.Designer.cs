namespace ChatWork.Forms
{
    partial class Connect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect));
            this.Port_Box = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.IP_Box = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.connect_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Port_Box.SuspendLayout();
            this.IP_Box.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Port_Box
            // 
            resources.ApplyResources(this.Port_Box, "Port_Box");
            this.Port_Box.ButtonSymbol = 61761;
            this.Port_Box.Controls.Add(this.uiLabel5);
            this.Port_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Port_Box.DoubleValue = 8750D;
            this.Port_Box.FillColor = System.Drawing.Color.White;
            this.Port_Box.IntValue = 8750;
            this.Port_Box.Maximum = 2147483647D;
            this.Port_Box.Minimum = -2147483648D;
            this.Port_Box.Name = "Port_Box";
            this.Port_Box.RectColor = System.Drawing.Color.Gray;
            this.Port_Box.Style = Sunny.UI.UIStyle.Custom;
            this.Port_Box.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            resources.ApplyResources(this.uiLabel5, "uiLabel5");
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            // 
            // IP_Box
            // 
            resources.ApplyResources(this.IP_Box, "IP_Box");
            this.IP_Box.ButtonSymbol = 61761;
            this.IP_Box.Controls.Add(this.uiLabel1);
            this.IP_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IP_Box.FillColor = System.Drawing.Color.White;
            this.IP_Box.Maximum = 2147483647D;
            this.IP_Box.Minimum = -2147483648D;
            this.IP_Box.Name = "IP_Box";
            this.IP_Box.RectColor = System.Drawing.Color.Gray;
            this.IP_Box.Style = Sunny.UI.UIStyle.Custom;
            this.IP_Box.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            resources.ApplyResources(this.uiLabel1, "uiLabel1");
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            // 
            // connect_button
            // 
            resources.ApplyResources(this.connect_button, "connect_button");
            this.connect_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.connect_button.Name = "connect_button";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.connect_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Port_Box);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IP_Box);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Connect
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panel1);
            this.Name = "Connect";
            this.Port_Box.ResumeLayout(false);
            this.Port_Box.PerformLayout();
            this.IP_Box.ResumeLayout(false);
            this.IP_Box.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox Port_Box;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox IP_Box;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}