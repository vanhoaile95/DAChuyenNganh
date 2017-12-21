﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Common;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;

namespace MainForm
{
    public partial class CauHoi_1 : UserControl
    {
        private String[] strThuTu = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public int loaiCauHoi;
        public List<GroupBox> listDapAn = new List<GroupBox>();

        public CauHoi_1()
        {
            InitializeComponent();
        }
        public CauHoi_1(int loaicauhoi)
        {
            InitializeComponent();
            this.Name = "CauHoi_1";
            loaiCauHoi = loaicauhoi;
            this.Dock = DockStyle.Fill;
        }

        public void Init(string NoiDung, List<DapAn> _listDapAn)
        {
            txtCauHoi.Text = NoiDung;
            //Đáp án
            for (int i = _listDapAn.Count - 1; i >= 0; i--)
            {
                RichTextBox richTextBox = new RichTextBox();
                richTextBox.ContextMenuStrip = this.MenuCon;
                richTextBox.Dock = DockStyle.Top;
                richTextBox.Size = new Size(548, 40);
                richTextBox.Text = _listDapAn[i].NoiDungDapAn;
                richTextBox.Name = "richDapAn";

                SwitchButton switchButton = new SwitchButton();
                switchButton.BackgroundStyle.CornerType = eCornerType.Square;
                switchButton.Dock = DockStyle.Top;
                switchButton.Location = new Point(3, 16);
                switchButton.OffText = "Đáp án sai";
                switchButton.OnText = "Đáp án đúng";
                switchButton.Size = new Size(548, 22);
                switchButton.Style = eDotNetBarStyle.StyleManagerControlled;
                switchButton.Name = "switchDapAn";
                switchButton.Value = Convert.ToBoolean(_listDapAn[i].DapAnDung);

                GroupBox groupBox = new GroupBox();
                groupBox.Controls.Add(richTextBox);
                groupBox.Controls.Add(switchButton);
                groupBox.Dock = DockStyle.Top;
                groupBox.Location = new Point(0, 0);
                groupBox.TabStop = false;
                groupBox.Text = _listDapAn[i].TenDapAn;
                groupBox.AutoSize = true;
                groupBox.Name = "groupDapAn";

                panelListDapAn.Controls.Add(groupBox);
                groupBox.BringToFront();
            }




        }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                ToolStripItem menuItem = sender as ToolStripItem;
                if (menuItem != null)
                {
                    ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                    if (owner != null)
                    {
                        Control sourceControl = owner.SourceControl;
                        ((RichTextBox)sourceControl).Font = font.Font;
                    }
                }
            }
            

        }
        private void chènSymbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    Control sourceControl = owner.SourceControl;
                    ((RichTextBox)sourceControl).SelectedRtf = Properties.Resources.Document;
                }
            }
           
        }

        public void btnThemDapAn_Click(object sender, EventArgs e)
        {
            //Nút đúng sai
            SwitchButton switchButton = new SwitchButton();
            switchButton.BackgroundStyle.CornerType = eCornerType.Square;
            switchButton.Dock = DockStyle.Top;
            switchButton.Location = new Point(3, 16);
            switchButton.OffText = "Đáp án sai";
            switchButton.OnText = "Đáp án đúng";
            switchButton.Size = new Size(548, 22);
            switchButton.Style = eDotNetBarStyle.StyleManagerControlled;
            switchButton.Name = "switchDapAn";

            //Nội dung đáp án
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.ContextMenuStrip = MenuCon;
            richTextBox.Dock = DockStyle.Top;
            richTextBox.Size = new Size(548, 40);
            richTextBox.Text = "";
            richTextBox.Name = "richDapAn";

            //Groupbox đáp án
            GroupBox groupBox = new GroupBox();
            groupBox.Controls.Add(richTextBox);
            groupBox.Controls.Add(switchButton);
            groupBox.Dock = DockStyle.Top;
            groupBox.Location = new Point(0, 0);
            groupBox.TabStop = false;
            groupBox.Text = strThuTu[panelListDapAn.Controls.Count - 1];
            groupBox.AutoSize = true;
            groupBox.Name = "groupDapAn";


            listDapAn.Add(groupBox);
            panelListDapAn.Controls.Add(groupBox);
            groupBox.BringToFront();
            panelListDapAn.ScrollControlIntoView(btnThemDapAn);
        }
    }
}
