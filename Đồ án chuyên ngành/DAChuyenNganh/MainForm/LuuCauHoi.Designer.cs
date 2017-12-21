namespace MainForm
{
    partial class LuuCauHoi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuuCauHoi));
            this.cboxDoKho = new System.Windows.Forms.ComboBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblDoKho = new DevComponents.DotNetBar.LabelX();
            this.lblMonHoc = new DevComponents.DotNetBar.LabelX();
            this.cboxMonHoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboxDoKho
            // 
            this.cboxDoKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDoKho.FormattingEnabled = true;
            this.cboxDoKho.Location = new System.Drawing.Point(113, 70);
            this.cboxDoKho.Name = "cboxDoKho";
            this.cboxDoKho.Size = new System.Drawing.Size(178, 21);
            this.cboxDoKho.TabIndex = 24;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Lưu câu hỏi";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(322, 28);
            this.bunifuFlatButton1.TabIndex = 23;
            this.bunifuFlatButton1.Text = "Lưu câu hỏi";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.Location = new System.Drawing.Point(182, 149);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 31);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHuy.Location = new System.Drawing.Point(21, 149);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(109, 31);
            this.btnHuy.TabIndex = 29;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblDoKho
            // 
            // 
            // 
            // 
            this.lblDoKho.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDoKho.Location = new System.Drawing.Point(21, 68);
            this.lblDoKho.Name = "lblDoKho";
            this.lblDoKho.Size = new System.Drawing.Size(75, 23);
            this.lblDoKho.TabIndex = 31;
            this.lblDoKho.Text = "Độ khó";
            // 
            // lblMonHoc
            // 
            // 
            // 
            // 
            this.lblMonHoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMonHoc.Location = new System.Drawing.Point(21, 104);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(75, 23);
            this.lblMonHoc.TabIndex = 33;
            this.lblMonHoc.Text = "Môn học";
            // 
            // cboxMonHoc
            // 
            this.cboxMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMonHoc.FormattingEnabled = true;
            this.cboxMonHoc.Location = new System.Drawing.Point(113, 106);
            this.cboxMonHoc.Name = "cboxMonHoc";
            this.cboxMonHoc.Size = new System.Drawing.Size(178, 21);
            this.cboxMonHoc.TabIndex = 32;
            // 
            // LuuCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 193);
            this.ControlBox = false;
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.cboxMonHoc);
            this.Controls.Add(this.lblDoKho);
            this.Controls.Add(this.cboxDoKho);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LuuCauHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LuuCauHoi_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboxDoKho;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private DevComponents.DotNetBar.LabelX lblDoKho;
        private DevComponents.DotNetBar.LabelX lblMonHoc;
        private System.Windows.Forms.ComboBox cboxMonHoc;
    }
}