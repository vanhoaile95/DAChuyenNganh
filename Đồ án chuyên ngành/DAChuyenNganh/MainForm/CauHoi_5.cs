﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace MainForm
{
    public partial class CauHoi_5 : UserControl
    {
        public List<RichTextBox> DanhSachY;
        public List<GroupBox> DanhSachYGr;
        public List<RichTextBox> DanhSachDapAn;
        public List<GroupBox> DanhSachDapAnGr;
        private String[] strThuTu = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public CauHoi_5()
        {
            InitializeComponent();
            DanhSachY = new List<RichTextBox>();
            DanhSachYGr = new List<GroupBox>();
            DanhSachDapAn = new List<RichTextBox>();
            DanhSachDapAnGr = new List<GroupBox>();
            this.Name = "CauHoi_5";
        }
        public void Init(string NoiDung, List<DapAn> listDapAn)
        {

            txtCauHoi.Text = NoiDung;
            for (int i = listDapAn.Count - 1; i >= 0; i--)
            {
                if (!listDapAn[i].TenDapAn.All(char.IsDigit))
                {
                    RichTextBox richTemt = new RichTextBox();
                    richTemt.Dock = DockStyle.Fill;
                    richTemt.BorderStyle = BorderStyle.None;
                    richTemt.BackColor = SystemColors.Control;
                    richTemt.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(163)));
                    richTemt.ContextMenuStrip = this.contextMenuStrip1;
                    richTemt.Text = listDapAn[i].NoiDungDapAn;
                    richTemt.Name = "richDapAn";
                    DanhSachY.Add(richTemt);



                    GroupBox groupTemt = new GroupBox();
                    groupTemt.Size = new Size(563, 50);
                    groupTemt.Dock = DockStyle.Top;
                    groupTemt.Text = this.strThuTu[DanhSachY.Count - 1];
                    groupTemt.Name = "groupDapAn";
                    groupTemt.Text = listDapAn[i].TenDapAn;
                    groupTemt.Controls.Add(richTemt);

                    DanhSachYGr.Add(groupTemt);
                    this.panel1.Controls.Clear();
                    for (int j = DanhSachY.Count - 1; j >= 0; j--)
                    {
                        this.panel1.Controls.Add(DanhSachYGr.ElementAt(j));
                    }
                    this.panel1.Controls.Add(this.btnThemY);
                    this.groupPanel1.Height += groupTemt.Height;

                    //Đáp án đúng
                    for (int jj = 0; jj < listDapAn.Count; jj++)
                    {
                        if (listDapAn[jj].NoiDungDapAn == listDapAn[i].TenDapAn && listDapAn[jj].DapAnDung == true)
                        {

                            RichTextBox richTemtDa = new RichTextBox();
                            richTemtDa.Dock = DockStyle.Fill;
                            richTemtDa.BorderStyle = BorderStyle.None;
                            richTemtDa.BackColor = SystemColors.Control;
                            richTemtDa.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(163)));
                            richTemtDa.Name = "richDapAnCorrect";
                            richTemtDa.Text = listDapAn[jj].NoiDungDapAn;
                            DanhSachDapAn.Add(richTemtDa);

                            GroupBox groupTemtDa = new GroupBox();
                            groupTemtDa.Size = new Size(563, 50);
                            groupTemtDa.Dock = DockStyle.Top;
                            groupTemtDa.Text = DanhSachY.Count.ToString();
                            groupTemtDa.Name = "groupDapAnCorrect";
                            groupTemtDa.Text = listDapAn[jj].TenDapAn;
                            groupTemtDa.Controls.Add(richTemtDa);

                            DanhSachDapAnGr.Add(groupTemtDa);
                            this.groupPanel2.Controls.Clear();
                            for (int j = DanhSachDapAnGr.Count - 1; j >= 0; j--)
                            {
                                DanhSachDapAn.ElementAt(j).Text = strThuTu[j];
                                this.groupPanel2.Controls.Add(DanhSachDapAnGr.ElementAt(j));
                            }

                            this.groupPanel1.Height += groupTemtDa.Height;
                            this.groupPanel2.Height += groupTemtDa.Height;
                            break;
                        }
                       
                    }

                }
            }
        }

        private void btnThemY_Click(object sender, EventArgs e)
        {

            RichTextBox richTemt = new RichTextBox();
            richTemt.Dock = DockStyle.Fill;
            richTemt.BorderStyle = BorderStyle.None;
            richTemt.BackColor = SystemColors.Control;
            richTemt.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(163)));
            richTemt.ContextMenuStrip = this.contextMenuStrip1;
            richTemt.Text = "";
            richTemt.Name = "richDapAn";
            DanhSachY.Add(richTemt);



            GroupBox groupTemt = new GroupBox();
            groupTemt.Size = new Size(563, 50);
            groupTemt.Dock = DockStyle.Top;
            groupTemt.Text = this.strThuTu[DanhSachY.Count - 1];
            groupTemt.Name = "groupDapAn";
            groupTemt.Controls.Add(richTemt);

            DanhSachYGr.Add(groupTemt);
            this.panel1.Controls.Clear();
            for (int i = DanhSachY.Count - 1; i >= 0; i--)
            {
                this.panel1.Controls.Add(DanhSachYGr.ElementAt(i));
            }
            this.panel1.Controls.Add(this.btnThemY);
            this.groupPanel1.Height += groupTemt.Height;

            ///Đáp án đúng
            RichTextBox richTemtDa = new RichTextBox();
            richTemtDa.Dock = DockStyle.Fill;
            richTemtDa.BorderStyle = BorderStyle.None;
            richTemtDa.BackColor = SystemColors.Control;
            richTemtDa.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(163)));
            richTemtDa.Name = "richDapAnCorrect";
            DanhSachDapAn.Add(richTemtDa);

            GroupBox groupTemtDa = new GroupBox();
            groupTemtDa.Size = new Size(563, 50);
            groupTemtDa.Dock = DockStyle.Top;
            groupTemtDa.Text = DanhSachY.Count.ToString();
            groupTemtDa.Name = "groupDapAnCorrect";
            groupTemtDa.Controls.Add(richTemtDa);

            DanhSachDapAnGr.Add(groupTemtDa);
            this.groupPanel2.Controls.Clear();
            for (int i = DanhSachDapAnGr.Count - 1; i >= 0; i--)
            {
                DanhSachDapAn.ElementAt(i).Text = strThuTu[i];
                this.groupPanel2.Controls.Add(DanhSachDapAnGr.ElementAt(i));
            }

            this.groupPanel1.Height += groupTemtDa.Height;
            this.groupPanel2.Height += groupTemtDa.Height;
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

        private void xóaÝToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            RichTextBox rtbTempt;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    Control sourceControl = owner.SourceControl;
                    rtbTempt = (RichTextBox)sourceControl;

                    GroupBox grbTempt = DanhSachYGr.ElementAt(0);
                    this.groupPanel1.Height -= grbTempt.Height;
                    for (int i = 0; i < DanhSachY.Count; i++)
                    {
                        if (DanhSachY.ElementAt(i).Text.Equals(rtbTempt.Text))
                        {
                            DanhSachY.RemoveAt(i);
                            DanhSachYGr.RemoveAt(i);
                            break;
                        }
                    }

                    this.panel1.Controls.Clear();
                    for (int i = DanhSachY.Count - 1; i >= 0; i--)
                    {
                        this.panel1.Controls.Add(DanhSachYGr.ElementAt(i));
                        DanhSachYGr.ElementAt(i).Text = strThuTu[i];
                    }
                    this.panel1.Controls.Add(this.btnThemY);

                    ///Xóa Đáp Án
                    ///
                    grbTempt = DanhSachDapAnGr.ElementAt(0);
                    DanhSachDapAnGr.RemoveAt(DanhSachDapAnGr.Count - 1);
                    DanhSachDapAn.RemoveAt(DanhSachDapAn.Count - 1);
                    this.groupPanel2.Controls.Clear();
                    for (int i = DanhSachDapAn.Count - 1; i >= 0; i--)
                    {
                        DanhSachDapAn.ElementAt(i).Text = DanhSachYGr.ElementAt(i).Text;
                        this.groupPanel2.Controls.Add(DanhSachDapAnGr.ElementAt(i));
                    }

                    this.groupPanel1.Height -= grbTempt.Height;
                    this.groupPanel2.Height -= grbTempt.Height;
                }
            }
        }

        private void CauHoi_5_SizeChanged(object sender, EventArgs e)
        {
            this.groupPanel1.Width = this.Width;
        }
    }
}
