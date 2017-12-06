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
    public partial class CauHoi_1 : UserControl
    {
        private String[] strThuTu = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public CauHoi_1()
        {
            InitializeComponent();
            this.Name = "CauHoi_1";
        }
        public void Init(string NoiDung, List<DapAn> listDapAn)
        {

            txtCauHoi.Text = NoiDung;

            //Đáp án
            for (int i = 0; i < listDapAn.Count(); i++)
            {
                RichTextBox richTextBox = new RichTextBox();
                richTextBox.ContextMenuStrip = this.MenuCon;
                richTextBox.Dock = System.Windows.Forms.DockStyle.Top;
                richTextBox.Size = new System.Drawing.Size(548, 40);
                richTextBox.Text = listDapAn[i].NoiDungDapAn;
                richTextBox.Name = "richDapAn";

                DevComponents.DotNetBar.Controls.SwitchButton switchButton = new DevComponents.DotNetBar.Controls.SwitchButton();
                switchButton.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                switchButton.Dock = System.Windows.Forms.DockStyle.Top;
                switchButton.Location = new System.Drawing.Point(3, 16);
                switchButton.OffText = "Đáp án sai";
                switchButton.OnText = "Đáp án đúng";
                switchButton.Size = new System.Drawing.Size(548, 22);
                switchButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                switchButton.Name = "switchDapAn";
                switchButton.Value = Convert.ToBoolean(listDapAn[i].DapAnDung);

                GroupBox groupBox = new GroupBox();
                groupBox.Controls.Add(richTextBox);
                groupBox.Controls.Add(switchButton);
                groupBox.Dock = System.Windows.Forms.DockStyle.Top;
                groupBox.Location = new System.Drawing.Point(0, 0);
                groupBox.TabStop = false;
                groupBox.Text = listDapAn[i].TenDapAn;
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
            DevComponents.DotNetBar.Controls.SwitchButton switchButton = new DevComponents.DotNetBar.Controls.SwitchButton();
            switchButton.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            switchButton.Dock = System.Windows.Forms.DockStyle.Top;
            switchButton.Location = new System.Drawing.Point(3, 16);
            switchButton.OffText = "Đáp án sai";
            switchButton.OnText = "Đáp án đúng";
            switchButton.Size = new System.Drawing.Size(548, 22);
            switchButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            switchButton.Name = "switchDapAn";

            RichTextBox richTextBox = new RichTextBox();
            richTextBox.ContextMenuStrip = this.MenuCon;
            richTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            richTextBox.Size = new System.Drawing.Size(548, 40);
            richTextBox.Text = "";
            richTextBox.Name = "richDapAn";

            GroupBox groupBox = new GroupBox();
            groupBox.Controls.Add(richTextBox);
            groupBox.Controls.Add(switchButton);
            groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox.Location = new System.Drawing.Point(0, 0);
            groupBox.TabStop = false;
            groupBox.Text = strThuTu[panelListDapAn.Controls.Count - 1];
            groupBox.AutoSize = true;
            groupBox.Name = "groupDapAn";



            panelListDapAn.Controls.Add(groupBox);
            groupBox.BringToFront();
            panelListDapAn.ScrollControlIntoView(btnThemDapAn);
        }
       
    }
}
