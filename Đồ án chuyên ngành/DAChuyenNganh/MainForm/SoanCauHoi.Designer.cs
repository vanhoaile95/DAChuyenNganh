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
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.panelSoanCauHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSoanCauHoi
            // 
            this.panelSoanCauHoi.AutoScroll = true;
            this.panelSoanCauHoi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSoanCauHoi.Controls.Add(this.buttonX2);
            this.panelSoanCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSoanCauHoi.Location = new System.Drawing.Point(0, 0);
            this.panelSoanCauHoi.Name = "panelSoanCauHoi";
            this.panelSoanCauHoi.Size = new System.Drawing.Size(613, 417);
            this.panelSoanCauHoi.TabIndex = 3;
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
            this.buttonX2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem2});
            this.buttonX2.TabIndex = 3;
            this.buttonX2.Text = "Thêm câu hỏi";
            // 
            // buttonItem1
            // 
            this.buttonItem1.GlobalItem = false;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Câu hỏi 1 đáp án đúng";
            this.buttonItem1.Click += new System.EventHandler(this.CauHoiDang1_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.GlobalItem = false;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "Câu hỏi điền chỗ trống";
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
    }
}
