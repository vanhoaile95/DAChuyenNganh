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
            this.btnLuuCauHoi = new DevComponents.DotNetBar.ButtonX();
            this.btnXuatDeThi = new DevComponents.DotNetBar.ButtonX();
            this.btnLuuDeThi = new DevComponents.DotNetBar.ButtonX();
            this.btnThemCauHoi = new DevComponents.DotNetBar.ButtonX();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.panelSoanCauHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSoanCauHoi
            // 
            this.panelSoanCauHoi.AutoScroll = true;
            this.panelSoanCauHoi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSoanCauHoi.Controls.Add(this.btnLuuCauHoi);
            this.panelSoanCauHoi.Controls.Add(this.btnXuatDeThi);
            this.panelSoanCauHoi.Controls.Add(this.btnLuuDeThi);
            this.panelSoanCauHoi.Controls.Add(this.btnThemCauHoi);
            this.panelSoanCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSoanCauHoi.Location = new System.Drawing.Point(0, 0);
            this.panelSoanCauHoi.Name = "panelSoanCauHoi";
            this.panelSoanCauHoi.Size = new System.Drawing.Size(613, 417);
            this.panelSoanCauHoi.TabIndex = 3;
            // 
            // btnLuuCauHoi
            // 
            this.btnLuuCauHoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuCauHoi.AutoExpandOnClick = true;
            this.btnLuuCauHoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuuCauHoi.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnLuuCauHoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLuuCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuCauHoi.Location = new System.Drawing.Point(0, 90);
            this.btnLuuCauHoi.Name = "btnLuuCauHoi";
            this.btnLuuCauHoi.Size = new System.Drawing.Size(613, 30);
            this.btnLuuCauHoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuuCauHoi.TabIndex = 6;
            this.btnLuuCauHoi.Text = "Lưu câu hỏi";
            this.btnLuuCauHoi.TextColor = System.Drawing.Color.White;
            this.btnLuuCauHoi.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXuatDeThi
            // 
            this.btnXuatDeThi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatDeThi.AutoExpandOnClick = true;
            this.btnXuatDeThi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXuatDeThi.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnXuatDeThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXuatDeThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatDeThi.Location = new System.Drawing.Point(0, 60);
            this.btnXuatDeThi.Name = "btnXuatDeThi";
            this.btnXuatDeThi.Size = new System.Drawing.Size(613, 30);
            this.btnXuatDeThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuatDeThi.TabIndex = 5;
            this.btnXuatDeThi.Text = "Xuất đề thi";
            this.btnXuatDeThi.TextColor = System.Drawing.Color.White;
            this.btnXuatDeThi.Click += new System.EventHandler(this.btnXuatDe_Click);
            // 
            // btnLuuDeThi
            // 
            this.btnLuuDeThi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuDeThi.AutoExpandOnClick = true;
            this.btnLuuDeThi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuuDeThi.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnLuuDeThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLuuDeThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuDeThi.Location = new System.Drawing.Point(0, 30);
            this.btnLuuDeThi.Name = "btnLuuDeThi";
            this.btnLuuDeThi.Size = new System.Drawing.Size(613, 30);
            this.btnLuuDeThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuuDeThi.TabIndex = 4;
            this.btnLuuDeThi.Text = "Lưu đề thi";
            this.btnLuuDeThi.TextColor = System.Drawing.Color.White;
            this.btnLuuDeThi.Click += new System.EventHandler(this.btnLuuDe_Click);
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemCauHoi.AutoExpandOnClick = true;
            this.btnThemCauHoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemCauHoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemCauHoi.Location = new System.Drawing.Point(0, 0);
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.Size = new System.Drawing.Size(613, 30);
            this.btnThemCauHoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemCauHoi.TabIndex = 3;
            this.btnThemCauHoi.Text = "Thêm câu hỏi";
            this.btnThemCauHoi.Click += new System.EventHandler(this.btnThemCauHoi_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
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
        private DevComponents.DotNetBar.ButtonX btnThemCauHoi;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonX btnLuuDeThi;
        private DevComponents.DotNetBar.ButtonX btnXuatDeThi;
        private DevComponents.DotNetBar.ButtonX btnLuuCauHoi;
    }
}
