using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Common;

namespace MainForm
{
    public partial class CauHoi_4 : UserControl
    {
        private int mousePanel;
        public List<RichTextBox> DanhSachY1;
        public List<GroupBox> DanhSachYGr1;
        public List<RichTextBox> DanhSachY2;
        public List<GroupBox> DanhSachYGr2;
        public List<RichTextBox> DanhSachDapAn;
        public List<GroupBox> DanhSachDapAnGr;
        private String[] strThuTu = { "A", "B", "C", "D", "E", "F", "G", "H","I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S","T","U","V","W","X","Y","Z" };
        public int loaiCauHoi;
        public CauHoi_4()
        {
            InitializeComponent();
            DanhSachY1 = new List<RichTextBox>();
            DanhSachYGr1 = new List<GroupBox>();
            DanhSachY2 = new List<RichTextBox>();
            DanhSachYGr2 = new List<GroupBox>();
            DanhSachDapAn = new List<RichTextBox>();
            DanhSachDapAnGr = new List<GroupBox>();
            
        }
        public CauHoi_4(int loaicauhoi)
        {
            InitializeComponent();
            DanhSachY1 = new List<RichTextBox>();
            DanhSachYGr1 = new List<GroupBox>();
            DanhSachY2 = new List<RichTextBox>();
            DanhSachYGr2 = new List<GroupBox>();
            DanhSachDapAn = new List<RichTextBox>();
            DanhSachDapAnGr = new List<GroupBox>();
            loaiCauHoi = loaicauhoi;
            this.Name = "CauHoi_4";

        }

        public void Init(string NoiDung, List<DapAn> listDapAn)
        {

            txtCauHoi.Text = NoiDung;
            for (int i = listDapAn.Count - 1; i >= 0; i--)
            {
                if (listDapAn[i].TenDapAn.All(char.IsDigit))
                {
                    if (listDapAn[i].DapAnDung == false)
                    {
                        //ThemY1

                        //Nội dung đáp án
                        RichTextBox richTemt = new RichTextBox();
                        richTemt.Dock = DockStyle.Fill;
                        richTemt.BorderStyle = BorderStyle.None;
                        richTemt.BackColor = SystemColors.Control;
                        richTemt.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(163)));
                        richTemt.ContextMenuStrip = this.contextMenuStrip1;
                        richTemt.Text = listDapAn[i].NoiDungDapAn;
                        richTemt.Name = "richDapAn";
                        richTemt.MouseEnter += new EventHandler(this.splitContainer1_Panel1_MouseEnter);
                        DanhSachY1.Add(richTemt);


                        //Groupbox đáp án
                        GroupBox groupTemt = new GroupBox();
                        groupTemt.Size = new Size(563, 70);
                        groupTemt.Dock = DockStyle.Top;
                        groupTemt.Text = listDapAn[i].TenDapAn;
                        groupTemt.Name = "groupDapAn";
                        groupTemt.Controls.Add(richTemt);

                        DanhSachYGr1.Add(groupTemt);
                        this.splitContainer1.Panel1.Controls.Clear();
                        for (int j = DanhSachY1.Count - 1; j >= 0; j--)
                        {
                            this.splitContainer1.Panel1.Controls.Add(DanhSachYGr1.ElementAt(j));
                        }
                        this.splitContainer1.Panel1.Controls.Add(this.btnThemY1);
                        this.groupPanelDapAn.Height += groupTemt.Height * (DanhSachYGr1.Count > DanhSachYGr2.Count ? 1 : 0);


                        //Them Dap An Đúng
                        for (int jj = 0; jj < listDapAn.Count; jj++)
                        {
                            if (listDapAn[jj].TenDapAn == listDapAn[i].TenDapAn && listDapAn[jj].DapAnDung == true)
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
                                groupTemtDa.Text = listDapAn[jj].TenDapAn;
                                groupTemtDa.Name = "groupDapAnCorrect";
                                groupTemtDa.Controls.Add(richTemtDa);
                                DanhSachDapAnGr.Add(groupTemtDa);

                                this.groupPanelNoiDung.Controls.Clear();
                                for (int j = DanhSachY1.Count - 1; j >= 0; j--)
                                {
                                    this.groupPanelNoiDung.Controls.Add(DanhSachDapAnGr.ElementAt(j));
                                }

                                this.groupPanelDapAn.Height += groupTemtDa.Height;
                                this.groupPanelNoiDung.Height += groupTemtDa.Height;
                                break;
                            }
                        }
                    }

                }
                else
                {
                    //Thêm Y2

                    RichTextBox richTemt = new RichTextBox();
                    richTemt.Dock = DockStyle.Fill;
                    richTemt.BorderStyle = BorderStyle.None;
                    richTemt.BackColor = SystemColors.Control;
                    richTemt.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(163)));
                    richTemt.ContextMenuStrip = this.contextMenuStrip1;
                    richTemt.Text = listDapAn[i].NoiDungDapAn;
                    richTemt.Name = "richDapAn";
                    richTemt.MouseEnter += new EventHandler(this.splitContainer1_Panel2_MouseEnter);
                    DanhSachY2.Add(richTemt);



                    GroupBox groupTemt = new GroupBox();
                    groupTemt.Size = new Size(563, 70);
                    groupTemt.Dock = DockStyle.Top;
                    groupTemt.Text = listDapAn[i].TenDapAn;
                    groupTemt.Name = "groupDapAn";
                    groupTemt.Controls.Add(richTemt);

                    DanhSachYGr2.Add(groupTemt);
                    this.splitContainer1.Panel2.Controls.Clear();
                    for (int j = DanhSachY2.Count - 1; j >= 0; j--)
                    {
                        this.splitContainer1.Panel2.Controls.Add(DanhSachYGr2.ElementAt(j));
                    }
                    this.splitContainer1.Panel2.Controls.Add(this.btnThemY2);
                    this.groupPanelDapAn.Height += groupTemt.Height * (DanhSachYGr1.Count >= DanhSachYGr2.Count ? 0 : 1);
                }
            }

        }

        private void CauHoi_4_SizeChanged(object sender, EventArgs e)
        {
            this.groupPanelDapAn.Width = this.Width;
            
        }

        private void btnThemY1_Click(object sender, EventArgs e)
        {
            //Nội dung đáp án
            RichTextBox richTemt = new RichTextBox();
            richTemt.Dock = DockStyle.Fill;
            richTemt.BorderStyle = BorderStyle.None;
            richTemt.BackColor = SystemColors.Control;
            richTemt.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(163)));
            richTemt.ContextMenuStrip = this.contextMenuStrip1;
            richTemt.Text = "";
            richTemt.Name = "richDapAn";
            richTemt.MouseEnter += new EventHandler(this.splitContainer1_Panel1_MouseEnter);
            DanhSachY1.Add(richTemt);



            //Groupbox đáp án
            GroupBox groupTemt = new GroupBox();
            groupTemt.Size = new Size(563, 70);
            groupTemt.Dock = DockStyle.Top;
            groupTemt.Text = DanhSachY1.Count.ToString();
            groupTemt.Name = "groupDapAn";
            groupTemt.Controls.Add(richTemt);

            DanhSachYGr1.Add(groupTemt);
            this.splitContainer1.Panel1.Controls.Clear();
            for (int i = DanhSachY1.Count - 1; i >= 0; i--)
            {
                this.splitContainer1.Panel1.Controls.Add(DanhSachYGr1.ElementAt(i));
            }
            this.splitContainer1.Panel1.Controls.Add(this.btnThemY1);
            this.groupPanelDapAn.Height += groupTemt.Height * (DanhSachYGr1.Count > DanhSachYGr2.Count ? 1 : 0);

            //Đáp án đúng
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
            groupTemtDa.Text = DanhSachY1.Count.ToString();
            groupTemtDa.Name = "groupDapAnCorrect";
            groupTemtDa.Controls.Add(richTemtDa);
            DanhSachDapAnGr.Add(groupTemtDa);

            this.groupPanelNoiDung.Controls.Clear();
            for (int i = DanhSachY1.Count - 1; i >= 0; i--)
            {
                this.groupPanelNoiDung.Controls.Add(DanhSachDapAnGr.ElementAt(i));
            }

            this.groupPanelDapAn.Height += groupTemtDa.Height;
            this.groupPanelNoiDung.Height += groupTemtDa.Height;
            
        }

        private void btnThemY2_Click(object sender, EventArgs e)
        {
            RichTextBox richTemt = new RichTextBox();
            richTemt.Dock = DockStyle.Fill;
            richTemt.BorderStyle = BorderStyle.None;
            richTemt.BackColor = SystemColors.Control;
            richTemt.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(163)));
            richTemt.ContextMenuStrip = this.contextMenuStrip1;
            richTemt.Text = "";
            richTemt.Name = "richDapAn";
            richTemt.MouseEnter += new EventHandler(this.splitContainer1_Panel2_MouseEnter);
            DanhSachY2.Add(richTemt);



            GroupBox groupTemt = new GroupBox();
            groupTemt.Size = new Size(563, 70);
            groupTemt.Dock = DockStyle.Top;
            groupTemt.Text = this.strThuTu[DanhSachY2.Count - 1];
            groupTemt.Name = "groupDapAn";
            groupTemt.Controls.Add(richTemt);

            DanhSachYGr2.Add(groupTemt);
            this.splitContainer1.Panel2.Controls.Clear();
            for (int i = DanhSachY2.Count - 1; i >= 0; i--)
            {
                this.splitContainer1.Panel2.Controls.Add(DanhSachYGr2.ElementAt(i));
            }
            this.splitContainer1.Panel2.Controls.Add(this.btnThemY2);
            this.groupPanelDapAn.Height += groupTemt.Height * (DanhSachYGr1.Count >= DanhSachYGr2.Count ? 0 : 1);
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
                    try
                    {
                        if (this.mousePanel == 1)
                        {
                            XoaY1(rtbTempt.Text);
                        }
                        else
                        {
                            XoaY2(rtbTempt.Text);
                        }
                    }
                    catch
                    {

                    }
                    
                }
            }

        }

        private void splitContainer1_Panel1_MouseEnter(object sender, EventArgs e)
        {
            this.mousePanel = 1;
        }

        private void splitContainer1_Panel2_MouseEnter(object sender, EventArgs e)
        {
            this.mousePanel = 2;
        }

        private void XoaY1(string noidung)
        {
            
            GroupBox grbTempt = DanhSachYGr1.ElementAt(0);
            this.groupPanelDapAn.Height -= grbTempt.Height * (DanhSachYGr1.Count > DanhSachYGr2.Count ? 1 : 0);
            for (int i=0; i<DanhSachY1.Count;i++)
            {
                if(DanhSachY1.ElementAt(i).Text.Equals(noidung))
                {
                    DanhSachY1.RemoveAt(i);
                    DanhSachYGr1.RemoveAt(i);
                    break;
                }
            }
            
            this.splitContainer1.Panel1.Controls.Clear();
            for (int i = DanhSachY1.Count - 1; i >= 0; i--)
            {
                this.splitContainer1.Panel1.Controls.Add(DanhSachYGr1.ElementAt(i));
                DanhSachYGr1.ElementAt(i).Text = (i+1).ToString();
            }
            this.splitContainer1.Panel1.Controls.Add(this.btnThemY1);
            
            ///xóa ý đáp án
            grbTempt = DanhSachDapAnGr.ElementAt(0);
            DanhSachDapAnGr.RemoveAt(DanhSachDapAnGr.Count - 1);
            this.groupPanelNoiDung.Controls.Clear();
            for (int i = DanhSachY1.Count - 1; i >= 0; i--)
            {
                this.groupPanelNoiDung.Controls.Add(DanhSachDapAnGr.ElementAt(i));
            }

            this.groupPanelDapAn.Height -= grbTempt.Height;
            this.groupPanelNoiDung.Height -= grbTempt.Height;

        }
        private void XoaY2(string noidung)
        {
            
            GroupBox grbTempt = DanhSachYGr2.ElementAt(0);
            this.groupPanelDapAn.Height -= grbTempt.Height * (DanhSachYGr2.Count > DanhSachYGr1.Count ? 1 : 0);
            for (int i = 0; i < DanhSachY2.Count; i++)
            {
                if (DanhSachY2.ElementAt(i).Text.Equals(noidung))
                {
                    DanhSachY2.RemoveAt(i);
                    DanhSachYGr2.RemoveAt(i);
                    break;
                }
            }

            this.splitContainer1.Panel2.Controls.Clear();
            for (int i = DanhSachY2.Count - 1; i >= 0; i--)
            {
                this.splitContainer1.Panel2.Controls.Add(DanhSachYGr2.ElementAt(i));
                DanhSachYGr2.ElementAt(i).Text = strThuTu[i];
            }
            this.splitContainer1.Panel2.Controls.Add(this.btnThemY2);
            
        }
    }
}
