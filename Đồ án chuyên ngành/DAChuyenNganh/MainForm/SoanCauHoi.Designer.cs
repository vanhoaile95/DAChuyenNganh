﻿namespace MainForm
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
            this.btnXuatDe = new DevComponents.DotNetBar.ButtonX();
            this.btnLuuDe = new DevComponents.DotNetBar.ButtonX();
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
            this.panelSoanCauHoi.Controls.Add(this.btnXuatDe);
            this.panelSoanCauHoi.Controls.Add(this.btnLuuDe);
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
            this.btnLuuCauHoi.TabIndex = 7;
            this.btnLuuCauHoi.Text = "Lưu câu hỏi";
            this.btnLuuCauHoi.TextColor = System.Drawing.Color.White;
            this.btnLuuCauHoi.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXuatDe
            // 
            this.btnXuatDe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatDe.AutoExpandOnClick = true;
            this.btnXuatDe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXuatDe.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnXuatDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXuatDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatDe.Location = new System.Drawing.Point(0, 60);
            this.btnXuatDe.Name = "btnXuatDe";
            this.btnXuatDe.Size = new System.Drawing.Size(613, 30);
            this.btnXuatDe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuatDe.TabIndex = 5;
            this.btnXuatDe.Text = "Xuất đề thi";
            this.btnXuatDe.TextColor = System.Drawing.Color.White;
            this.btnXuatDe.Click += new System.EventHandler(this.btnXuatDe_Click);
            // 
            // btnLuuDe
            // 
            this.btnLuuDe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuDe.AutoExpandOnClick = true;
            this.btnLuuDe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuuDe.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnLuuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLuuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuDe.Location = new System.Drawing.Point(0, 30);
            this.btnLuuDe.Name = "btnLuuDe";
            this.btnLuuDe.Size = new System.Drawing.Size(613, 30);
            this.btnLuuDe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuuDe.TabIndex = 4;
            this.btnLuuDe.Text = "Lưu đề thi";
            this.btnLuuDe.TextColor = System.Drawing.Color.White;
            this.btnLuuDe.Click += new System.EventHandler(this.btnLuuDe_Click);
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
        private DevComponents.DotNetBar.ButtonX btnLuuDe;
        private DevComponents.DotNetBar.ButtonX btnXuatDe;
        private DevComponents.DotNetBar.ButtonX btnLuuCauHoi;
    }
}
