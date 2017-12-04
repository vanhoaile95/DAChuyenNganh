namespace MainForm
{
    partial class SoanCauHoi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSoanCauHoi = new System.Windows.Forms.Panel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.panelSoanCauHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSoanCauHoi
            // 
            this.panelSoanCauHoi.AutoScroll = true;
            this.panelSoanCauHoi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSoanCauHoi.Controls.Add(this.buttonX3);
            this.panelSoanCauHoi.Controls.Add(this.buttonX1);
            this.panelSoanCauHoi.Controls.Add(this.buttonX2);
            this.panelSoanCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSoanCauHoi.Location = new System.Drawing.Point(0, 0);
            this.panelSoanCauHoi.Name = "panelSoanCauHoi";
            this.panelSoanCauHoi.Size = new System.Drawing.Size(613, 417);
            this.panelSoanCauHoi.TabIndex = 3;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.AutoExpandOnClick = true;
            this.buttonX1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonX1.Location = new System.Drawing.Point(0, 30);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(613, 30);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 4;
            this.buttonX1.Text = "Lưu đề thi";
            this.buttonX1.TextColor = System.Drawing.Color.White;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.AutoExpandOnClick = true;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonX2.Location = new System.Drawing.Point(0, 0);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(613, 30);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 3;
            this.buttonX2.Text = "Thêm câu hỏi";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.AutoExpandOnClick = true;
            this.buttonX3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX3.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonX3.Location = new System.Drawing.Point(0, 60);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(613, 30);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 5;
            this.buttonX3.Text = "Xuất đề thi";
            this.buttonX3.TextColor = System.Drawing.Color.White;
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // SoanCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSoanCauHoi);
            this.Name = "SoanCauHoi";
            this.Size = new System.Drawing.Size(613, 417);
            this.panelSoanCauHoi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSoanCauHoi;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX3;
    }
}
