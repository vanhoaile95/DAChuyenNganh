using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace MainForm
{
    public partial class CauHoi : UserControl
    {
        private int SoDapDan = 0;
        private BunifuThinButton2 themDapAnTemt;
        private RichTextBox ricTbTemt;
        private RichTextBox ricTbTemt1;
        public List<RichTextBox> DanhSachDapAn;
        public List<GroupBox> DanhSachDapAnGr;
        

        public CauHoi(int Title)
        {
            InitializeComponent();
            btnTitle.ButtonText += Title;
            DanhSachDapAn = new List<RichTextBox>();
            DanhSachDapAnGr = new List<GroupBox>();
            
        }

       
        private void bntSymbol_Click(object sender, EventArgs e)
        {
            try
            {
                ricTbTemt.SelectedRtf = Properties.Resources.Document;
                
            }
            catch
            {

            }
        }

        

        private void bntThemDapAn_Click(object sender, EventArgs e)
        {
            RichTextBox richTemt = new RichTextBox();
            richTemt.Dock = System.Windows.Forms.DockStyle.Fill;
            
            richTemt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTemt.BackColor = System.Drawing.SystemColors.Control;
            richTemt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            
            richTemt.Enter += new System.EventHandler(this.richNoiDung_Enter);
            richTemt.MouseEnter += new System.EventHandler(this.richDapAn_MouseEnter);
            
            
            richTemt.ContextMenuStrip = this.contextMenuStrip1;
            SoDapDan +=1;
            richTemt.Text = "Đáp Án " + SoDapDan.ToString(); ;
            DanhSachDapAn.Add(richTemt);

            GroupBox groupTemt = new GroupBox();
            groupTemt.Size = new System.Drawing.Size(563, 100);
            groupTemt.Dock = System.Windows.Forms.DockStyle.Top;
            groupTemt.Text = "Đáp Án " + SoDapDan.ToString();
            groupTemt.Controls.Add(richTemt);

            DanhSachDapAnGr.Add(groupTemt);

            
            panelDapAn.Controls.Clear();
            panelDapAn.Controls.Add(themDapAnTemt);

            for(int i= DanhSachDapAnGr.Count-1; i>=0;i--)
            {
                panelDapAn.Controls.Add(DanhSachDapAnGr.ElementAt(i));
            }





        }

        private void CauHoi_Load(object sender, EventArgs e)
        {
            themDapAnTemt = bntThemDapAn;
            
        }

        private void richNoiDung_Enter(object sender, EventArgs e)
        {
            ricTbTemt = (RichTextBox)sender;

        }

        private void xóaĐápÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SoDapDan -= 1;
            for(int i=0;i<DanhSachDapAn.Count;i++)
            {
                if(DanhSachDapAn.ElementAt(i).Text== ricTbTemt1.Text)
                {
                    DanhSachDapAnGr.RemoveAt(i);
                    DanhSachDapAn.RemoveAt(i);
                    panelDapAn.Controls.Clear();
                    panelDapAn.Controls.Add(themDapAnTemt);//thêm button thêm đáp án

                    for (int j = DanhSachDapAnGr.Count - 1; j >= 0; j--)
                    {
                        DanhSachDapAnGr.ElementAt(j).Text = "Đáp Án " + (j+1).ToString();
                        panelDapAn.Controls.Add(DanhSachDapAnGr.ElementAt(j));
                    }
                    break;
                }
            }
            
        }

        private void richDapAn_MouseEnter(object sender, EventArgs e)
        {
            ricTbTemt1 = (RichTextBox)sender;
        }

        ///xóa câu hỏi
        public delegate void delagateXoaCauHoi(String CauHoi);

        public delagateXoaCauHoi XoaCauHoi;

        private void btnRemove_Click(object sender, EventArgs e)
        {
            XoaCauHoi(btnTitle.ButtonText);
        }
    }
}
