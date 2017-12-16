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
            this.groupDapAn = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.richDapAn = new System.Windows.Forms.RichTextBox();
            this.txtCauHoi = new System.Windows.Forms.RichTextBox();
            this.MenuCon.SuspendLayout();
            this.groupDapAn.SuspendLayout();
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
            // groupDapAn
            // 
            this.groupDapAn.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupDapAn.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupDapAn.Controls.Add(this.richDapAn);
            this.groupDapAn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupDapAn.Location = new System.Drawing.Point(0, 123);
            this.groupDapAn.Name = "groupDapAn";
            this.groupDapAn.Size = new System.Drawing.Size(518, 125);
            // 
            // 
            // 
            this.groupDapAn.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupDapAn.Style.BackColorGradientAngle = 90;
            this.groupDapAn.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupDapAn.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDapAn.Style.BorderBottomWidth = 1;
            this.groupDapAn.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupDapAn.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDapAn.Style.BorderLeftWidth = 1;
            this.groupDapAn.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDapAn.Style.BorderRightWidth = 1;
            this.groupDapAn.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDapAn.Style.BorderTopWidth = 1;
            this.groupDapAn.Style.CornerDiameter = 4;
            this.groupDapAn.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupDapAn.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupDapAn.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupDapAn.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupDapAn.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupDapAn.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupDapAn.TabIndex = 14;
            this.groupDapAn.Text = "Đáp Án";
            // 
            // richDapAn
            // 
            this.richDapAn.ContextMenuStrip = this.MenuCon;
            this.richDapAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richDapAn.Location = new System.Drawing.Point(0, 0);
            this.richDapAn.Name = "richDapAn";
            this.richDapAn.Size = new System.Drawing.Size(512, 104);
            this.richDapAn.TabIndex = 14;
            this.richDapAn.Text = "";
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.ContextMenuStrip = this.MenuCon;
            this.txtCauHoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCauHoi.Location = new System.Drawing.Point(0, 0);
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(518, 120);
            this.txtCauHoi.TabIndex = 13;
            this.txtCauHoi.Text = "";
            // 
            // CauHoi_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupDapAn);
            this.Controls.Add(this.txtCauHoi);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "CauHoi_4";
            this.Size = new System.Drawing.Size(518, 248);
            this.MenuCon.ResumeLayout(false);
            this.groupDapAn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MenuCon;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chènSymbolToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.GroupPanel groupDapAn;
        private System.Windows.Forms.RichTextBox richDapAn;
        private System.Windows.Forms.RichTextBox txtCauHoi;
    }
}
