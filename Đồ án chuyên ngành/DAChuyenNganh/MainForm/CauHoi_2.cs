using System;
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
    
    public partial class CauHoi_2 : UserControl
    {
        public static int SoDapAn = 0;
    
        public CauHoi_2()
        {
            InitializeComponent();
            this.Name = "CauHoi_2";
        }

        public void Init(string NoiDung, List<DapAn> listDapAn)
        {

            txtCauHoi.Text = NoiDung;

            SoDapAn = listDapAn.Count;
            //Đáp án
            for (int i = listDapAn.Count - 1; i >= 0; i--)
            {
                //Nội dung chỗ trống
                RichTextBox richTextBox = new RichTextBox();
                richTextBox.ContextMenuStrip = MenuCon;
                richTextBox.Dock = DockStyle.Top;
                richTextBox.Size = new Size(548, 40);
                richTextBox.Text = listDapAn[i].NoiDungDapAn;
                richTextBox.Name = "richDapAn";

                //Groupbox Đáp án
                GroupBox groupBox = new GroupBox();
                groupBox.Controls.Add(richTextBox);
                groupBox.Dock = DockStyle.Top;
                groupBox.Location = new Point(0, 0);
                groupBox.TabStop = false;
                groupBox.Text = listDapAn[i].TenDapAn;
                groupBox.AutoSize = true;
                groupBox.Name = "groupDapAn";

                panelChoTrong.Controls.Add(groupBox);
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

        private void btnThemChoTrong_Click(object sender, EventArgs e)
        {
            SoDapAn++;
            txtCauHoi.Text += " ... ";


            //Nội dung chỗ trống
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.ContextMenuStrip = MenuCon;
            richTextBox.Dock = DockStyle.Top;
            richTextBox.Size = new Size(548, 40);
            richTextBox.Text = "";
            richTextBox.Name = "richDapAn";

            //Groupbox Đáp án
            GroupBox groupBox = new GroupBox();
            groupBox.Controls.Add(richTextBox);
            groupBox.Dock = DockStyle.Top;
            groupBox.Location = new Point(0, 0);
            groupBox.TabStop = false;
            groupBox.Text = "Chỗ trống " + SoDapAn;
            groupBox.AutoSize = true;
            groupBox.Name = "groupDapAn";

            panelChoTrong.Controls.Add(groupBox);
            groupBox.BringToFront();
            panelChoTrong.ScrollControlIntoView(btnThemChoTrong);
        }
     
        //Khi xóa chỗ trống trên richtextbox thì groupbox sẽ xóa theo
        private void txtCauHoi_TextChanged(object sender, EventArgs e)
        {
            int DemSoChoTrong = 0;
            string[] ChoTrong = txtCauHoi.Text.Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string temp in ChoTrong)
            {
                if (temp.Contains("..."))
                    DemSoChoTrong++;
            }
            if (DemSoChoTrong < SoDapAn)
            {
                int temp = SoDapAn - DemSoChoTrong;
                SoDapAn -= temp;
                for (int i = 0; i < temp; i++)
                {
                    panelChoTrong.Controls.Remove(panelChoTrong.Controls[0]);
                }
               
            }
            else if (DemSoChoTrong > SoDapAn)
            {
                int temp = DemSoChoTrong - SoDapAn;
                SoDapAn+= temp;

                for (int i = 0; i < temp; i++)
                {
                    RichTextBox richTextBox = new RichTextBox();
                    richTextBox.ContextMenuStrip = this.MenuCon;
                    richTextBox.Dock = System.Windows.Forms.DockStyle.Top;
                    richTextBox.Size = new System.Drawing.Size(548, 40);
                    richTextBox.Text = "";

                    GroupBox groupBox = new GroupBox();
                    groupBox.Controls.Add(richTextBox);
                    groupBox.Dock = System.Windows.Forms.DockStyle.Top;
                    groupBox.Location = new System.Drawing.Point(0, 0);
                    groupBox.TabStop = false;

                    groupBox.Text = "Chỗ trống " + SoDapAn;
                    groupBox.AutoSize = true;
                    panelChoTrong.Controls.Add(groupBox);
                    groupBox.BringToFront();
                }
                

              
                panelChoTrong.ScrollControlIntoView(btnThemChoTrong);
               
            }

          

           
            
        }
    }
}
