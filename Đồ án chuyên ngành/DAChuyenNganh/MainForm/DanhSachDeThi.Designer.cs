namespace MainForm
{
    partial class DanhSachDeThi
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
            this.listDeThi = new System.Windows.Forms.ListView();
            this.maDe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenDe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thoiGian = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngayThi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cBoxMonHoc = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listDeThi
            // 
            this.listDeThi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maDe,
            this.tenDe,
            this.monHoc,
            this.thoiGian,
            this.ngayThi});
            this.listDeThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDeThi.FullRowSelect = true;
            this.listDeThi.GridLines = true;
            this.listDeThi.Location = new System.Drawing.Point(0, 0);
            this.listDeThi.MultiSelect = false;
            this.listDeThi.Name = "listDeThi";
            this.listDeThi.Size = new System.Drawing.Size(624, 387);
            this.listDeThi.TabIndex = 0;
            this.listDeThi.UseCompatibleStateImageBehavior = false;
            this.listDeThi.View = System.Windows.Forms.View.Details;
            // 
            // maDe
            // 
            this.maDe.Text = "Mã đề";
            // 
            // tenDe
            // 
            this.tenDe.Text = "Tên đề";
            // 
            // monHoc
            // 
            this.monHoc.Text = "Môn học";
            // 
            // thoiGian
            // 
            this.thoiGian.Text = "Thời Gian";
            // 
            // ngayThi
            // 
            this.ngayThi.Text = "Ngày thi";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(11, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(61, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Môn học";
            // 
            // cBoxMonHoc
            // 
            this.cBoxMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMonHoc.FormattingEnabled = true;
            this.cBoxMonHoc.Location = new System.Drawing.Point(78, 18);
            this.cBoxMonHoc.Name = "cBoxMonHoc";
            this.cBoxMonHoc.Size = new System.Drawing.Size(162, 21);
            this.cBoxMonHoc.TabIndex = 0;
            this.cBoxMonHoc.DropDown += new System.EventHandler(this.cBoxMonHoc_DropDown);
            this.cBoxMonHoc.SelectedIndexChanged += new System.EventHandler(this.cBoxMonHoc_SelectedIndexChanged);
            this.cBoxMonHoc.DropDownClosed += new System.EventHandler(this.cBoxMonHoc_DropDownClosed);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 456);
            this.panel2.TabIndex = 3;
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
            this.splitContainer1.Panel1.Controls.Add(this.labelX1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listDeThi);
            this.splitContainer1.Size = new System.Drawing.Size(624, 456);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.TabIndex = 2;
            // 
            // DanhSachDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Name = "DanhSachDeThi";
            this.Size = new System.Drawing.Size(624, 456);
            this.Load += new System.EventHandler(this.DanhSachDeThi_Load);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listDeThi;
        private System.Windows.Forms.ColumnHeader maDe;
        private System.Windows.Forms.ColumnHeader tenDe;
        private System.Windows.Forms.ColumnHeader monHoc;
        private System.Windows.Forms.ColumnHeader thoiGian;
        private System.Windows.Forms.ColumnHeader ngayThi;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox cBoxMonHoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
