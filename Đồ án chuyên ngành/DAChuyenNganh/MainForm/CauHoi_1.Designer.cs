namespace MainForm
{
    partial class CauHoi_1
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
            this.MenuCon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chènSymbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCauHoi = new System.Windows.Forms.RichTextBox();
            this.groupPanelDapAn = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelListDapAn = new System.Windows.Forms.Panel();
            this.btnThemDapAn = new DevComponents.DotNetBar.ButtonX();
            this.MenuCon.SuspendLayout();
            this.groupPanelDapAn.SuspendLayout();
            this.panelListDapAn.SuspendLayout();
            this.SuspendLayout();
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
            // txtCauHoi
            // 
            this.txtCauHoi.ContextMenuStrip = this.MenuCon;
            this.txtCauHoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCauHoi.Location = new System.Drawing.Point(0, 0);
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(563, 95);
            this.txtCauHoi.TabIndex = 9;
            this.txtCauHoi.Text = "";
            // 
            // groupPanelDapAn
            // 
            this.groupPanelDapAn.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelDapAn.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelDapAn.Controls.Add(this.panelListDapAn);
            this.groupPanelDapAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelDapAn.Location = new System.Drawing.Point(0, 95);
            this.groupPanelDapAn.Name = "groupPanelDapAn";
            this.groupPanelDapAn.Size = new System.Drawing.Size(563, 167);
            // 
            // 
            // 
            this.groupPanelDapAn.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelDapAn.Style.BackColorGradientAngle = 90;
            this.groupPanelDapAn.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelDapAn.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDapAn.Style.BorderBottomWidth = 1;
            this.groupPanelDapAn.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelDapAn.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDapAn.Style.BorderLeftWidth = 1;
            this.groupPanelDapAn.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDapAn.Style.BorderRightWidth = 1;
            this.groupPanelDapAn.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDapAn.Style.BorderTopWidth = 1;
            this.groupPanelDapAn.Style.CornerDiameter = 4;
            this.groupPanelDapAn.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelDapAn.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelDapAn.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelDapAn.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelDapAn.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelDapAn.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelDapAn.TabIndex = 10;
            this.groupPanelDapAn.Text = "Đáp án";
            // 
            // panelListDapAn
            // 
            this.panelListDapAn.AutoScroll = true;
            this.panelListDapAn.Controls.Add(this.btnThemDapAn);
            this.panelListDapAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListDapAn.Location = new System.Drawing.Point(0, 0);
            this.panelListDapAn.Name = "panelListDapAn";
            this.panelListDapAn.Size = new System.Drawing.Size(557, 146);
            this.panelListDapAn.TabIndex = 0;
            // 
            // btnThemDapAn
            // 
            this.btnThemDapAn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemDapAn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemDapAn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThemDapAn.Location = new System.Drawing.Point(0, 115);
            this.btnThemDapAn.Name = "btnThemDapAn";
            this.btnThemDapAn.Size = new System.Drawing.Size(557, 31);
            this.btnThemDapAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemDapAn.TabIndex = 17;
            this.btnThemDapAn.Text = "Thêm đáp án";
            this.btnThemDapAn.Click += new System.EventHandler(this.btnThemDapAn_Click);
            // 
            // CauHoi_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupPanelDapAn);
            this.Controls.Add(this.txtCauHoi);
            this.Name = "CauHoi_1";
            this.Size = new System.Drawing.Size(563, 270);
            this.MenuCon.ResumeLayout(false);
            this.groupPanelDapAn.ResumeLayout(false);
            this.panelListDapAn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtCauHoi;
        private System.Windows.Forms.ContextMenuStrip MenuCon;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chènSymbolToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelDapAn;
        private System.Windows.Forms.Panel panelListDapAn;
        private DevComponents.DotNetBar.ButtonX btnThemDapAn;
    }
}
