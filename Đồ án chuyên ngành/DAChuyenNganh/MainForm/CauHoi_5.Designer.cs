namespace MainForm
{
    partial class CauHoi_5
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtCauHoi = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MenuCon.SuspendLayout();
            this.groupPanel1.SuspendLayout();
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
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // chènSymbolToolStripMenuItem
            // 
            this.chènSymbolToolStripMenuItem.Name = "chènSymbolToolStripMenuItem";
            this.chènSymbolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chènSymbolToolStripMenuItem.Text = "Chèn Symbol";
            this.chènSymbolToolStripMenuItem.Click += new System.EventHandler(this.chènSymbolToolStripMenuItem_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.richTextBox1);
            this.groupPanel1.Location = new System.Drawing.Point(3, 122);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(515, 125);
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
            this.groupPanel1.TabIndex = 14;
            this.groupPanel1.Text = "Đáp Án";
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
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.MenuCon;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(509, 104);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // CauHoi_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.txtCauHoi);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "CauHoi_5";
            this.Size = new System.Drawing.Size(518, 268);
            this.SizeChanged += new System.EventHandler(this.CauHoi_5_SizeChanged);
            this.MenuCon.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MenuCon;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chènSymbolToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox txtCauHoi;
    }
}
