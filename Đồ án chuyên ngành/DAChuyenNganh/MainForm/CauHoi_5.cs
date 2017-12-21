using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common;

namespace MainForm
{
    public partial class CauHoi_5 : UserControl
    {
        public int loaiCauHoi;
        public CauHoi_5()
        {
            InitializeComponent();
        }
        public CauHoi_5(int loaicauhoi)
        {
            InitializeComponent();
            loaiCauHoi = loaicauhoi;
            this.Name = "CauHoi_5";
        }
        public void Init(string NoiDung, List<DapAn> listDapAn)
        {

            txtCauHoi.Text = NoiDung;
            richDapAn.Text = listDapAn[0].NoiDungDapAn;

        }


        private void CauHoi_5_SizeChanged(object sender, EventArgs e)
        {
            this.groupPanel1.Width = this.Width;
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
    }
}
