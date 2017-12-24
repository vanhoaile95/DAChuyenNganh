namespace MainForm
{
    partial class DanhSachCauHoi
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
            this.lblMonHoc = new DevComponents.DotNetBar.LabelX();
            this.cBoxMonHoc = new System.Windows.Forms.ComboBox();
            this.listCauHoi = new System.Windows.Forms.ListView();
            this.maCauHoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.noiDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doKho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.thamKhảoĐềTHiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMonHoc
            // 
            // 
            // 
            // 
            this.lblMonHoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMonHoc.Location = new System.Drawing.Point(12, 16);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(61, 23);
            this.lblMonHoc.TabIndex = 1;
            this.lblMonHoc.Text = "Môn học";
            // 
            // cBoxMonHoc
            // 
            this.cBoxMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMonHoc.FormattingEnabled = true;
            this.cBoxMonHoc.Location = new System.Drawing.Point(79, 18);
            this.cBoxMonHoc.Name = "cBoxMonHoc";
            this.cBoxMonHoc.Size = new System.Drawing.Size(162, 21);
            this.cBoxMonHoc.TabIndex = 0;
            this.cBoxMonHoc.DropDown += new System.EventHandler(this.cBoxMonHoc_DropDown);
            this.cBoxMonHoc.SelectedIndexChanged += new System.EventHandler(this.cBoxMonHoc_SelectedIndexChanged);
            this.cBoxMonHoc.DropDownClosed += new System.EventHandler(this.cBoxMonHoc_DropDownClosed);
            // 
            // listCauHoi
            // 
            this.listCauHoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maCauHoi,
            this.noiDung,
            this.monHoc,
            this.doKho});
            this.listCauHoi.ContextMenuStrip = this.contextMenu;
            this.listCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCauHoi.FullRowSelect = true;
            this.listCauHoi.GridLines = true;
            this.listCauHoi.Location = new System.Drawing.Point(0, 0);
            this.listCauHoi.MultiSelect = false;
            this.listCauHoi.Name = "listCauHoi";
            this.listCauHoi.Size = new System.Drawing.Size(596, 368);
            this.listCauHoi.TabIndex = 0;
            this.listCauHoi.UseCompatibleStateImageBehavior = false;
            this.listCauHoi.View = System.Windows.Forms.View.Details;
            // 
            // maCauHoi
            // 
            this.maCauHoi.Text = "Mã Câu Hỏi";
            // 
            // noiDung
            // 
            this.noiDung.Text = "Nội dung";
            // 
            // monHoc
            // 
            this.monHoc.Text = "Môn học";
            // 
            // doKho
            // 
            this.doKho.Text = "Độ khó";
            this.doKho.Width = 121;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.thamKhảoĐềTHiToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(195, 92);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Enabled = false;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cBoxMonHoc);
            this.splitContainer1.Panel1.Controls.Add(this.lblMonHoc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listCauHoi);
            this.splitContainer1.Size = new System.Drawing.Size(596, 434);
            this.splitContainer1.SplitterDistance = 62;
            this.splitContainer1.TabIndex = 2;
            // 
            // thamKhảoĐềTHiToolStripMenuItem
            // 
            this.thamKhảoĐềTHiToolStripMenuItem.Name = "thamKhảoĐềTHiToolStripMenuItem";
            this.thamKhảoĐềTHiToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.thamKhảoĐềTHiToolStripMenuItem.Text = "Tham Khảo Vào Đề Thi";
            this.thamKhảoĐềTHiToolStripMenuItem.Click += new System.EventHandler(this.thamKhảoĐềTHiToolStripMenuItem_Click);
            // 
            // DanhSachCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitContainer1);
            this.Name = "DanhSachCauHoi";
            this.Size = new System.Drawing.Size(596, 434);
            this.Load += new System.EventHandler(this.DanhSachCauHoi_Load);
            this.contextMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX lblMonHoc;
        private System.Windows.Forms.ComboBox cBoxMonHoc;
        private System.Windows.Forms.ListView listCauHoi;
        private System.Windows.Forms.ColumnHeader maCauHoi;
        private System.Windows.Forms.ColumnHeader noiDung;
        private System.Windows.Forms.ColumnHeader monHoc;
        private System.Windows.Forms.ColumnHeader doKho;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thamKhảoĐềTHiToolStripMenuItem;
    }
}
