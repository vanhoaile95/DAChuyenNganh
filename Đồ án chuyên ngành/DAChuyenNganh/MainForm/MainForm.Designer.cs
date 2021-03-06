﻿namespace MainForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.header = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.buttonMinimize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonMaximize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTitle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.bunifuGradientPanelMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnThuVienCauHoi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ImageBtnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnThuVienDeThi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSoanDeThi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSoanCauHoi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.header.SuspendLayout();
            this.bunifuGradientPanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.header;
            this.bunifuDragControl.Vertical = true;
            // 
            // header
            // 
            this.header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("header.BackgroundImage")));
            this.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.header.Controls.Add(this.buttonMinimize);
            this.header.Controls.Add(this.buttonMaximize);
            this.header.Controls.Add(this.buttonExit);
            this.header.Controls.Add(this.btnTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(231)))));
            this.header.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(141)))));
            this.header.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.header.GradientTopRight = System.Drawing.Color.Black;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Quality = 10;
            this.header.Size = new System.Drawing.Size(756, 35);
            this.header.TabIndex = 1;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Activecolor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BackgroundImage = global::MainForm.Properties.Resources.min;
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimize.BorderRadius = 0;
            this.buttonMinimize.ButtonText = "";
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.DisabledColor = System.Drawing.Color.Gray;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonMinimize.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Iconimage")));
            this.buttonMinimize.Iconimage_right = null;
            this.buttonMinimize.Iconimage_right_Selected = null;
            this.buttonMinimize.Iconimage_Selected = null;
            this.buttonMinimize.IconMarginLeft = 0;
            this.buttonMinimize.IconMarginRight = 0;
            this.buttonMinimize.IconRightVisible = true;
            this.buttonMinimize.IconRightZoom = 0D;
            this.buttonMinimize.IconVisible = false;
            this.buttonMinimize.IconZoom = 90D;
            this.buttonMinimize.IsTab = false;
            this.buttonMinimize.Location = new System.Drawing.Point(663, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonMinimize.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.buttonMinimize.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonMinimize.selected = false;
            this.buttonMinimize.Size = new System.Drawing.Size(31, 35);
            this.buttonMinimize.TabIndex = 5;
            this.buttonMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMinimize.Textcolor = System.Drawing.Color.White;
            this.buttonMinimize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.Click += new System.EventHandler(this.btnMinimum_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Activecolor = System.Drawing.Color.Transparent;
            this.buttonMaximize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaximize.BackgroundImage = global::MainForm.Properties.Resources.max;
            this.buttonMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMaximize.BorderRadius = 0;
            this.buttonMaximize.ButtonText = "";
            this.buttonMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaximize.DisabledColor = System.Drawing.Color.Gray;
            this.buttonMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMaximize.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonMaximize.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.Iconimage")));
            this.buttonMaximize.Iconimage_right = null;
            this.buttonMaximize.Iconimage_right_Selected = null;
            this.buttonMaximize.Iconimage_Selected = null;
            this.buttonMaximize.IconMarginLeft = 0;
            this.buttonMaximize.IconMarginRight = 0;
            this.buttonMaximize.IconRightVisible = true;
            this.buttonMaximize.IconRightZoom = 0D;
            this.buttonMaximize.IconVisible = false;
            this.buttonMaximize.IconZoom = 90D;
            this.buttonMaximize.IsTab = false;
            this.buttonMaximize.Location = new System.Drawing.Point(694, 0);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonMaximize.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.buttonMaximize.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonMaximize.selected = false;
            this.buttonMaximize.Size = new System.Drawing.Size(31, 35);
            this.buttonMaximize.TabIndex = 4;
            this.buttonMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMaximize.Textcolor = System.Drawing.Color.White;
            this.buttonMaximize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaximize.Click += new System.EventHandler(this.btnMaximum_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Activecolor = System.Drawing.Color.Transparent;
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = global::MainForm.Properties.Resources.exit;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.BorderRadius = 0;
            this.buttonExit.ButtonText = "";
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.DisabledColor = System.Drawing.Color.Gray;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonExit.Iconimage")));
            this.buttonExit.Iconimage_right = null;
            this.buttonExit.Iconimage_right_Selected = null;
            this.buttonExit.Iconimage_Selected = null;
            this.buttonExit.IconMarginLeft = 0;
            this.buttonExit.IconMarginRight = 0;
            this.buttonExit.IconRightVisible = true;
            this.buttonExit.IconRightZoom = 0D;
            this.buttonExit.IconVisible = false;
            this.buttonExit.IconZoom = 90D;
            this.buttonExit.IsTab = false;
            this.buttonExit.Location = new System.Drawing.Point(725, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonExit.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonExit.selected = false;
            this.buttonExit.Size = new System.Drawing.Size(31, 35);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Textcolor = System.Drawing.Color.White;
            this.buttonExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnTitle.BackColor = System.Drawing.Color.Transparent;
            this.btnTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTitle.BorderRadius = 0;
            this.btnTitle.ButtonText = "Soạn thảo câu hỏi trắc nghiệm";
            this.btnTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTitle.DisabledColor = System.Drawing.Color.Gray;
            this.btnTitle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTitle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTitle.Iconimage")));
            this.btnTitle.Iconimage_right = null;
            this.btnTitle.Iconimage_right_Selected = null;
            this.btnTitle.Iconimage_Selected = null;
            this.btnTitle.IconMarginLeft = 0;
            this.btnTitle.IconMarginRight = 0;
            this.btnTitle.IconRightVisible = true;
            this.btnTitle.IconRightZoom = 0D;
            this.btnTitle.IconVisible = true;
            this.btnTitle.IconZoom = 90D;
            this.btnTitle.IsTab = false;
            this.btnTitle.Location = new System.Drawing.Point(3, 0);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTitle.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnTitle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTitle.selected = false;
            this.btnTitle.Size = new System.Drawing.Size(229, 29);
            this.btnTitle.TabIndex = 0;
            this.btnTitle.Text = "Soạn thảo câu hỏi trắc nghiệm";
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.Textcolor = System.Drawing.Color.White;
            this.btnTitle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(180, 35);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(576, 450);
            this.MainPanel.TabIndex = 2;
            // 
            // bunifuGradientPanelMenu
            // 
            this.bunifuGradientPanelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelMenu.BackgroundImage")));
            this.bunifuGradientPanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelMenu.Controls.Add(this.btnThuVienCauHoi);
            this.bunifuGradientPanelMenu.Controls.Add(this.ImageBtnMenu);
            this.bunifuGradientPanelMenu.Controls.Add(this.btnThuVienDeThi);
            this.bunifuGradientPanelMenu.Controls.Add(this.btnSoanDeThi);
            this.bunifuGradientPanelMenu.Controls.Add(this.btnSoanCauHoi);
            this.bunifuGradientPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanelMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(231)))));
            this.bunifuGradientPanelMenu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(141)))));
            this.bunifuGradientPanelMenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.bunifuGradientPanelMenu.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanelMenu.Location = new System.Drawing.Point(0, 35);
            this.bunifuGradientPanelMenu.Name = "bunifuGradientPanelMenu";
            this.bunifuGradientPanelMenu.Quality = 10;
            this.bunifuGradientPanelMenu.Size = new System.Drawing.Size(180, 450);
            this.bunifuGradientPanelMenu.TabIndex = 0;
            // 
            // btnThuVienCauHoi
            // 
            this.btnThuVienCauHoi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnThuVienCauHoi.BackColor = System.Drawing.Color.Transparent;
            this.btnThuVienCauHoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThuVienCauHoi.BorderRadius = 0;
            this.btnThuVienCauHoi.ButtonText = "Thư viện câu hỏi";
            this.btnThuVienCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThuVienCauHoi.DisabledColor = System.Drawing.Color.Gray;
            this.btnThuVienCauHoi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThuVienCauHoi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThuVienCauHoi.Iconimage")));
            this.btnThuVienCauHoi.Iconimage_right = null;
            this.btnThuVienCauHoi.Iconimage_right_Selected = null;
            this.btnThuVienCauHoi.Iconimage_Selected = null;
            this.btnThuVienCauHoi.IconMarginLeft = 0;
            this.btnThuVienCauHoi.IconMarginRight = 0;
            this.btnThuVienCauHoi.IconRightVisible = true;
            this.btnThuVienCauHoi.IconRightZoom = 0D;
            this.btnThuVienCauHoi.IconVisible = true;
            this.btnThuVienCauHoi.IconZoom = 90D;
            this.btnThuVienCauHoi.IsTab = true;
            this.btnThuVienCauHoi.Location = new System.Drawing.Point(0, 197);
            this.btnThuVienCauHoi.Name = "btnThuVienCauHoi";
            this.btnThuVienCauHoi.Normalcolor = System.Drawing.Color.Transparent;
            this.btnThuVienCauHoi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnThuVienCauHoi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThuVienCauHoi.selected = false;
            this.btnThuVienCauHoi.Size = new System.Drawing.Size(180, 48);
            this.btnThuVienCauHoi.TabIndex = 4;
            this.btnThuVienCauHoi.Text = "Thư viện câu hỏi";
            this.btnThuVienCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuVienCauHoi.Textcolor = System.Drawing.Color.White;
            this.btnThuVienCauHoi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuVienCauHoi.Click += new System.EventHandler(this.btnThuVienCauHoi_Click);
            // 
            // ImageBtnMenu
            // 
            this.ImageBtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.ImageBtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageBtnMenu.Image = global::MainForm.Properties.Resources.sidemenu;
            this.ImageBtnMenu.ImageActive = null;
            this.ImageBtnMenu.InitialImage = global::MainForm.Properties.Resources.max;
            this.ImageBtnMenu.Location = new System.Drawing.Point(140, 0);
            this.ImageBtnMenu.Name = "ImageBtnMenu";
            this.ImageBtnMenu.Size = new System.Drawing.Size(40, 29);
            this.ImageBtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBtnMenu.TabIndex = 3;
            this.ImageBtnMenu.TabStop = false;
            this.ImageBtnMenu.Zoom = 10;
            this.ImageBtnMenu.Click += new System.EventHandler(this.ImageBtnMenu_Click);
            // 
            // btnThuVienDeThi
            // 
            this.btnThuVienDeThi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnThuVienDeThi.BackColor = System.Drawing.Color.Transparent;
            this.btnThuVienDeThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThuVienDeThi.BorderRadius = 0;
            this.btnThuVienDeThi.ButtonText = "Thư viện đề thi";
            this.btnThuVienDeThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThuVienDeThi.DisabledColor = System.Drawing.Color.Gray;
            this.btnThuVienDeThi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThuVienDeThi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThuVienDeThi.Iconimage")));
            this.btnThuVienDeThi.Iconimage_right = null;
            this.btnThuVienDeThi.Iconimage_right_Selected = null;
            this.btnThuVienDeThi.Iconimage_Selected = null;
            this.btnThuVienDeThi.IconMarginLeft = 0;
            this.btnThuVienDeThi.IconMarginRight = 0;
            this.btnThuVienDeThi.IconRightVisible = true;
            this.btnThuVienDeThi.IconRightZoom = 0D;
            this.btnThuVienDeThi.IconVisible = true;
            this.btnThuVienDeThi.IconZoom = 90D;
            this.btnThuVienDeThi.IsTab = true;
            this.btnThuVienDeThi.Location = new System.Drawing.Point(0, 143);
            this.btnThuVienDeThi.Name = "btnThuVienDeThi";
            this.btnThuVienDeThi.Normalcolor = System.Drawing.Color.Transparent;
            this.btnThuVienDeThi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnThuVienDeThi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThuVienDeThi.selected = false;
            this.btnThuVienDeThi.Size = new System.Drawing.Size(180, 48);
            this.btnThuVienDeThi.TabIndex = 2;
            this.btnThuVienDeThi.Text = "Thư viện đề thi";
            this.btnThuVienDeThi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuVienDeThi.Textcolor = System.Drawing.Color.White;
            this.btnThuVienDeThi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuVienDeThi.Click += new System.EventHandler(this.btnThuVienDeThi_Click);
            // 
            // btnSoanDeThi
            // 
            this.btnSoanDeThi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSoanDeThi.BackColor = System.Drawing.Color.Transparent;
            this.btnSoanDeThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSoanDeThi.BorderRadius = 0;
            this.btnSoanDeThi.ButtonText = "Soạn đề thi";
            this.btnSoanDeThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoanDeThi.DisabledColor = System.Drawing.Color.Gray;
            this.btnSoanDeThi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSoanDeThi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSoanDeThi.Iconimage")));
            this.btnSoanDeThi.Iconimage_right = null;
            this.btnSoanDeThi.Iconimage_right_Selected = null;
            this.btnSoanDeThi.Iconimage_Selected = null;
            this.btnSoanDeThi.IconMarginLeft = 0;
            this.btnSoanDeThi.IconMarginRight = 0;
            this.btnSoanDeThi.IconRightVisible = true;
            this.btnSoanDeThi.IconRightZoom = 0D;
            this.btnSoanDeThi.IconVisible = true;
            this.btnSoanDeThi.IconZoom = 90D;
            this.btnSoanDeThi.IsTab = true;
            this.btnSoanDeThi.Location = new System.Drawing.Point(0, 89);
            this.btnSoanDeThi.Name = "btnSoanDeThi";
            this.btnSoanDeThi.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSoanDeThi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSoanDeThi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSoanDeThi.selected = false;
            this.btnSoanDeThi.Size = new System.Drawing.Size(180, 48);
            this.btnSoanDeThi.TabIndex = 1;
            this.btnSoanDeThi.Text = "Soạn đề thi";
            this.btnSoanDeThi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoanDeThi.Textcolor = System.Drawing.Color.White;
            this.btnSoanDeThi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoanDeThi.Click += new System.EventHandler(this.btnSoanDeThi_Click);
            // 
            // btnSoanCauHoi
            // 
            this.btnSoanCauHoi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSoanCauHoi.BackColor = System.Drawing.Color.Transparent;
            this.btnSoanCauHoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSoanCauHoi.BorderRadius = 0;
            this.btnSoanCauHoi.ButtonText = "Soạn câu hỏi";
            this.btnSoanCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoanCauHoi.DisabledColor = System.Drawing.Color.Gray;
            this.btnSoanCauHoi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSoanCauHoi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSoanCauHoi.Iconimage")));
            this.btnSoanCauHoi.Iconimage_right = null;
            this.btnSoanCauHoi.Iconimage_right_Selected = null;
            this.btnSoanCauHoi.Iconimage_Selected = null;
            this.btnSoanCauHoi.IconMarginLeft = 0;
            this.btnSoanCauHoi.IconMarginRight = 0;
            this.btnSoanCauHoi.IconRightVisible = true;
            this.btnSoanCauHoi.IconRightZoom = 0D;
            this.btnSoanCauHoi.IconVisible = true;
            this.btnSoanCauHoi.IconZoom = 90D;
            this.btnSoanCauHoi.IsTab = true;
            this.btnSoanCauHoi.Location = new System.Drawing.Point(0, 35);
            this.btnSoanCauHoi.Name = "btnSoanCauHoi";
            this.btnSoanCauHoi.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSoanCauHoi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSoanCauHoi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSoanCauHoi.selected = false;
            this.btnSoanCauHoi.Size = new System.Drawing.Size(180, 48);
            this.btnSoanCauHoi.TabIndex = 0;
            this.btnSoanCauHoi.Text = "Soạn câu hỏi";
            this.btnSoanCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoanCauHoi.Textcolor = System.Drawing.Color.White;
            this.btnSoanCauHoi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoanCauHoi.Click += new System.EventHandler(this.btnSoanCauHoi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(756, 485);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.bunifuGradientPanelMenu);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ClientSizeChanged += new System.EventHandler(this.MainForm_ClientSizeChanged);
            this.header.ResumeLayout(false);
            this.bunifuGradientPanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnThuVienDeThi;
        private Bunifu.Framework.UI.BunifuFlatButton btnSoanDeThi;
        private Bunifu.Framework.UI.BunifuFlatButton btnSoanCauHoi;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private Bunifu.Framework.UI.BunifuGradientPanel header;
        private Bunifu.Framework.UI.BunifuFlatButton btnTitle;
        private Bunifu.Framework.UI.BunifuImageButton ImageBtnMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnThuVienCauHoi;
        private System.Windows.Forms.Panel MainPanel;
        private Bunifu.Framework.UI.BunifuFlatButton buttonExit;
        private Bunifu.Framework.UI.BunifuFlatButton buttonMinimize;
        private Bunifu.Framework.UI.BunifuFlatButton buttonMaximize;
    }
}

