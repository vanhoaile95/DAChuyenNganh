namespace MainForm
{
    partial class CauHoi_3
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
            this.components = new System.ComponentModel.Container();
            this.txtCauHoi = new System.Windows.Forms.RichTextBox();
            this.MenuCon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chènSymbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelChoTrong = new System.Windows.Forms.Panel();
            this.btnThemChoTrong = new DevComponents.DotNetBar.ButtonX();
            this.MenuCon.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.panelChoTrong.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.ContextMenuStrip = this.MenuCon;
            this.txtCauHoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCauHoi.Location = new System.Drawing.Point(0, 0);
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(560, 90);
            this.txtCauHoi.TabIndex = 10;
            this.txtCauHoi.Text = "";
            this.txtCauHoi.TextChanged += new System.EventHandler(this.txtCauHoi_TextChanged);
            // 
            // MenuCon
            // 
            this.MenuCon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.chènSymbolToolStripMenuItem});
            this.MenuCon.Name = "MenuCon";
            this.MenuCon.Size = new System.Drawing.Size(145, 48);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // chènSymbolToolStripMenuItem
            // 
            this.chènSymbolToolStripMenuItem.Name = "chènSymbolToolStripMenuItem";
            this.chènSymbolToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.chènSymbolToolStripMenuItem.Text = "Chèn symbol";
            this.chènSymbolToolStripMenuItem.Click += new System.EventHandler(this.chènSymbolToolStripMenuItem_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.panelChoTrong);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 90);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(560, 150);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 11;
            this.groupPanel1.Text = "Đáp án";
            // 
            // panelChoTrong
            // 
            this.panelChoTrong.AutoScroll = true;
            this.panelChoTrong.BackColor = System.Drawing.Color.Transparent;
            this.panelChoTrong.Controls.Add(this.btnThemChoTrong);
            this.panelChoTrong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChoTrong.Location = new System.Drawing.Point(0, 0);
            this.panelChoTrong.Name = "panelChoTrong";
            this.panelChoTrong.Size = new System.Drawing.Size(554, 129);
            this.panelChoTrong.TabIndex = 0;
            // 
            // btnThemChoTrong
            // 
            this.btnThemChoTrong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemChoTrong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemChoTrong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThemChoTrong.Location = new System.Drawing.Point(0, 98);
            this.btnThemChoTrong.Name = "btnThemChoTrong";
            this.btnThemChoTrong.Size = new System.Drawing.Size(554, 31);
            this.btnThemChoTrong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemChoTrong.TabIndex = 17;
            this.btnThemChoTrong.Text = "Thêm chỗ trống";
            this.btnThemChoTrong.Click += new System.EventHandler(this.btnThemChoTrong_Click);
            // 
            // CauHoi_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.txtCauHoi);
            this.Name = "CauHoi_3";
            this.Size = new System.Drawing.Size(560, 280);
            this.MenuCon.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.panelChoTrong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Panel panelChoTrong;
        private DevComponents.DotNetBar.ButtonX btnThemChoTrong;
        private System.Windows.Forms.ContextMenuStrip MenuCon;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chènSymbolToolStripMenuItem;
        public System.Windows.Forms.RichTextBox txtCauHoi;
    }
}
