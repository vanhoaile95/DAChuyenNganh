namespace MainForm
{
    partial class CauHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CauHoi));
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bntSymbol = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRemove = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnTitle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.richNoiDung = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaĐápÁnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDapAn = new System.Windows.Forms.Panel();
            this.bntThemDapAn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bntSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panelDapAn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 10;
            this.bunifuElipse.TargetControl = this;
            // 
            // bntSymbol
            // 
            this.bntSymbol.BackColor = System.Drawing.Color.Transparent;
            this.bntSymbol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSymbol.Dock = System.Windows.Forms.DockStyle.Left;
            this.bntSymbol.Image = ((System.Drawing.Image)(resources.GetObject("bntSymbol.Image")));
            this.bntSymbol.ImageActive = null;
            this.bntSymbol.Location = new System.Drawing.Point(0, 0);
            this.bntSymbol.Name = "bntSymbol";
            this.bntSymbol.Size = new System.Drawing.Size(31, 38);
            this.bntSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntSymbol.TabIndex = 10;
            this.bntSymbol.TabStop = false;
            this.toolTip2.SetToolTip(this.bntSymbol, "Chèn Symbol");
            this.bntSymbol.Zoom = 10;
            this.bntSymbol.Click += new System.EventHandler(this.bntSymbol_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageActive = null;
            this.btnRemove.Location = new System.Drawing.Point(532, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(31, 38);
            this.btnRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRemove.TabIndex = 9;
            this.btnRemove.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRemove, "Xóa Câu Hỏi");
            this.btnRemove.Zoom = 10;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.ActiveBorderThickness = 1;
            this.btnTitle.ActiveCornerRadius = 20;
            this.btnTitle.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnTitle.ActiveForecolor = System.Drawing.Color.White;
            this.btnTitle.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTitle.BackColor = System.Drawing.Color.Transparent;
            this.btnTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTitle.BackgroundImage")));
            this.btnTitle.ButtonText = "Câu hỏi ";
            this.btnTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTitle.IdleBorderThickness = 1;
            this.btnTitle.IdleCornerRadius = 20;
            this.btnTitle.IdleFillColor = System.Drawing.Color.White;
            this.btnTitle.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnTitle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnTitle.Location = new System.Drawing.Point(0, 0);
            this.btnTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(563, 30);
            this.btnTitle.TabIndex = 7;
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richNoiDung
            // 
            this.richNoiDung.BackColor = System.Drawing.SystemColors.Control;
            this.richNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richNoiDung.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richNoiDung.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richNoiDung.Location = new System.Drawing.Point(0, 128);
            this.richNoiDung.Name = "richNoiDung";
            this.richNoiDung.Size = new System.Drawing.Size(563, 100);
            this.richNoiDung.TabIndex = 0;
            this.richNoiDung.Text = "";
            this.richNoiDung.Enter += new System.EventHandler(this.richNoiDung_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaĐápÁnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            // 
            // xóaĐápÁnToolStripMenuItem
            // 
            this.xóaĐápÁnToolStripMenuItem.Name = "xóaĐápÁnToolStripMenuItem";
            this.xóaĐápÁnToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.xóaĐápÁnToolStripMenuItem.Text = "Xóa Đáp Án";
            this.xóaĐápÁnToolStripMenuItem.Click += new System.EventHandler(this.xóaĐápÁnToolStripMenuItem_Click);
            // 
            // panelDapAn
            // 
            this.panelDapAn.AutoSize = true;
            this.panelDapAn.Controls.Add(this.bntThemDapAn);
            this.panelDapAn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDapAn.Location = new System.Drawing.Point(0, 228);
            this.panelDapAn.Name = "panelDapAn";
            this.panelDapAn.Size = new System.Drawing.Size(563, 30);
            this.panelDapAn.TabIndex = 12;
            // 
            // bntThemDapAn
            // 
            this.bntThemDapAn.ActiveBorderThickness = 1;
            this.bntThemDapAn.ActiveCornerRadius = 20;
            this.bntThemDapAn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bntThemDapAn.ActiveForecolor = System.Drawing.Color.White;
            this.bntThemDapAn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bntThemDapAn.BackColor = System.Drawing.Color.Transparent;
            this.bntThemDapAn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntThemDapAn.BackgroundImage")));
            this.bntThemDapAn.ButtonText = "Thêm Đáp Án";
            this.bntThemDapAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntThemDapAn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bntThemDapAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThemDapAn.ForeColor = System.Drawing.Color.SeaGreen;
            this.bntThemDapAn.IdleBorderThickness = 1;
            this.bntThemDapAn.IdleCornerRadius = 20;
            this.bntThemDapAn.IdleFillColor = System.Drawing.Color.White;
            this.bntThemDapAn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bntThemDapAn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bntThemDapAn.Location = new System.Drawing.Point(0, 0);
            this.bntThemDapAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntThemDapAn.Name = "bntThemDapAn";
            this.bntThemDapAn.Size = new System.Drawing.Size(563, 30);
            this.bntThemDapAn.TabIndex = 8;
            this.bntThemDapAn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntThemDapAn.Click += new System.EventHandler(this.bntThemDapAn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.bntSymbol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 38);
            this.panel1.TabIndex = 13;
            // 
            // CauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richNoiDung);
            this.Controls.Add(this.panelDapAn);
            this.Controls.Add(this.btnTitle);
            this.Name = "CauHoi";
            this.Size = new System.Drawing.Size(563, 258);
            this.Load += new System.EventHandler(this.CauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bntSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelDapAn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private Bunifu.Framework.UI.BunifuImageButton btnRemove;
        private Bunifu.Framework.UI.BunifuImageButton bntSymbol;
        private System.Windows.Forms.RichTextBox richNoiDung;
        private System.Windows.Forms.Panel panelDapAn;
        private Bunifu.Framework.UI.BunifuThinButton2 bntThemDapAn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaĐápÁnToolStripMenuItem;
        public Bunifu.Framework.UI.BunifuThinButton2 btnTitle;
    }
}
