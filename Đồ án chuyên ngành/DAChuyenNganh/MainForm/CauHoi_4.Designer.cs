namespace MainForm
{
    partial class CauHoi_4
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
            this.groupPanelDapAn = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtCauHoi = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chènSymbolToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaÝToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemY2 = new DevComponents.DotNetBar.ButtonX();
            this.btnThemY1 = new DevComponents.DotNetBar.ButtonX();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupPanelNoiDung = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.MenuCon.SuspendLayout();
            this.groupPanelDapAn.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuCon
            // 
            this.MenuCon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.chènSymbolToolStripMenuItem});
            this.MenuCon.Name = "MenuCon";
            this.MenuCon.Size = new System.Drawing.Size(146, 48);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // chènSymbolToolStripMenuItem
            // 
            this.chènSymbolToolStripMenuItem.Name = "chènSymbolToolStripMenuItem";
            this.chènSymbolToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.chènSymbolToolStripMenuItem.Text = "Chèn Symbol";
            this.chènSymbolToolStripMenuItem.Click += new System.EventHandler(this.chènSymbolToolStripMenuItem_Click);
            // 
            // groupPanelDapAn
            // 
            this.groupPanelDapAn.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelDapAn.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelDapAn.Controls.Add(this.splitContainer1);
            this.groupPanelDapAn.Controls.Add(this.groupPanelNoiDung);
            this.groupPanelDapAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelDapAn.Location = new System.Drawing.Point(0, 90);
            this.groupPanelDapAn.Name = "groupPanelDapAn";
            this.groupPanelDapAn.Size = new System.Drawing.Size(550, 109);
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
            this.groupPanelDapAn.TabIndex = 12;
            this.groupPanelDapAn.Text = "Nội Dung";
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.ContextMenuStrip = this.MenuCon;
            this.txtCauHoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCauHoi.Location = new System.Drawing.Point(0, 0);
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(550, 90);
            this.txtCauHoi.TabIndex = 10;
            this.txtCauHoi.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem1,
            this.chènSymbolToolStripMenuItem1,
            this.xóaÝToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 70);
            // 
            // fontToolStripMenuItem1
            // 
            this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            this.fontToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.fontToolStripMenuItem1.Text = "Font";
            this.fontToolStripMenuItem1.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // chènSymbolToolStripMenuItem1
            // 
            this.chènSymbolToolStripMenuItem1.Name = "chènSymbolToolStripMenuItem1";
            this.chènSymbolToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.chènSymbolToolStripMenuItem1.Text = "Chèn Symbol";
            this.chènSymbolToolStripMenuItem1.Click += new System.EventHandler(this.chènSymbolToolStripMenuItem_Click);
            // 
            // xóaÝToolStripMenuItem
            // 
            this.xóaÝToolStripMenuItem.Name = "xóaÝToolStripMenuItem";
            this.xóaÝToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.xóaÝToolStripMenuItem.Text = "Xóa Ý";
            this.xóaÝToolStripMenuItem.Click += new System.EventHandler(this.xóaÝToolStripMenuItem_Click);
            // 
            // btnThemY2
            // 
            this.btnThemY2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemY2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemY2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemY2.Location = new System.Drawing.Point(0, 0);
            this.btnThemY2.Name = "btnThemY2";
            this.btnThemY2.Size = new System.Drawing.Size(268, 25);
            this.btnThemY2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemY2.TabIndex = 0;
            this.btnThemY2.Text = "Thêm Ý";
            this.btnThemY2.Click += new System.EventHandler(this.btnThemY2_Click);
            // 
            // btnThemY1
            // 
            this.btnThemY1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemY1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemY1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemY1.Location = new System.Drawing.Point(0, 0);
            this.btnThemY1.Name = "btnThemY1";
            this.btnThemY1.Size = new System.Drawing.Size(272, 25);
            this.btnThemY1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemY1.TabIndex = 0;
            this.btnThemY1.Text = "Thêm Ý";
            this.btnThemY1.Click += new System.EventHandler(this.btnThemY1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnThemY1);
            this.splitContainer1.Panel1.MouseEnter += new System.EventHandler(this.splitContainer1_Panel1_MouseEnter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnThemY2);
            this.splitContainer1.Panel2.MouseEnter += new System.EventHandler(this.splitContainer1_Panel2_MouseEnter);
            this.splitContainer1.Size = new System.Drawing.Size(544, 49);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupPanelNoiDung
            // 
            this.groupPanelNoiDung.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelNoiDung.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelNoiDung.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanelNoiDung.Location = new System.Drawing.Point(0, 49);
            this.groupPanelNoiDung.Name = "groupPanelNoiDung";
            this.groupPanelNoiDung.Size = new System.Drawing.Size(544, 39);
            // 
            // 
            // 
            this.groupPanelNoiDung.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelNoiDung.Style.BackColorGradientAngle = 90;
            this.groupPanelNoiDung.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelNoiDung.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelNoiDung.Style.BorderBottomWidth = 1;
            this.groupPanelNoiDung.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelNoiDung.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelNoiDung.Style.BorderLeftWidth = 1;
            this.groupPanelNoiDung.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelNoiDung.Style.BorderRightWidth = 1;
            this.groupPanelNoiDung.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelNoiDung.Style.BorderTopWidth = 1;
            this.groupPanelNoiDung.Style.CornerDiameter = 4;
            this.groupPanelNoiDung.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelNoiDung.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelNoiDung.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelNoiDung.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelNoiDung.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelNoiDung.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelNoiDung.TabIndex = 13;
            this.groupPanelNoiDung.Text = "Đáp Án";
            // 
            // CauHoi_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupPanelDapAn);
            this.Controls.Add(this.txtCauHoi);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "CauHoi_4";
            this.Size = new System.Drawing.Size(550, 214);
            this.SizeChanged += new System.EventHandler(this.CauHoi_4_SizeChanged);
            this.MenuCon.ResumeLayout(false);
            this.groupPanelDapAn.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip MenuCon;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chènSymbolToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelDapAn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chènSymbolToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xóaÝToolStripMenuItem;
        public System.Windows.Forms.RichTextBox txtCauHoi;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.ButtonX btnThemY1;
        private DevComponents.DotNetBar.ButtonX btnThemY2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelNoiDung;
    }
}
