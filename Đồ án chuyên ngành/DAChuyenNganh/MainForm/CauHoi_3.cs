using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    
    public partial class CauHoi_3 : UserControl
    {
        public static int SoDapAn = 0;
        public int loaiCauHoi;
        public CauHoi_3()
        {
            InitializeComponent();
            this.Name = "CauHoi_3";
        }

        public CauHoi_3(int loaicauhoi)
        {
            InitializeComponent();
            this.Name = "CauHoi_3";
            loaiCauHoi = loaicauhoi;
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

       
        private void buttonX1_Click(object sender, EventArgs e)
        {
            SoDapAn++;
            txtCauHoi.Text += " ... ";
        
            

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

            panel1.Controls.Add(groupBox);
            groupBox.BringToFront();
            panel1.ScrollControlIntoView(buttonX1);


        }

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
                    panel1.Controls.Remove(panel1.Controls[0]);
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
                    panel1.Controls.Add(groupBox);
                    groupBox.BringToFront();
                }
                

              
                panel1.ScrollControlIntoView(buttonX1);
               
            }

          

           
            
        }
    }
}
