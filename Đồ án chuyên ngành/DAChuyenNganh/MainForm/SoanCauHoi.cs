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
    public partial class SoanCauHoi : UserControl
    {
        public SoanCauHoi()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
           
        }

        public List<Object> listCauHoi = new List<Object>();

        //Câu hỏi dạng 1
        private void CauHoiDang1_Click(object sender, EventArgs e)
        {
            //Tạo expandable panel câu hỏi
            DevComponents.DotNetBar.ExpandablePanel TitleCauHoi = new DevComponents.DotNetBar.ExpandablePanel();

            TitleCauHoi.CanvasColor = System.Drawing.SystemColors.Control;
            TitleCauHoi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            TitleCauHoi.HideControlsWhenCollapsed = true;
            TitleCauHoi.ExpandButtonAlignment = DevComponents.DotNetBar.eTitleButtonAlignment.Left;
            TitleCauHoi.ExpandOnTitleClick = true;
            TitleCauHoi.AnimationTime = 0;

            TitleCauHoi.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            TitleCauHoi.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            TitleCauHoi.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            TitleCauHoi.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            TitleCauHoi.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            TitleCauHoi.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            TitleCauHoi.TitleStyle.GradientAngle = 90;
            TitleCauHoi.TitleText = "Câu hỏi " + (listCauHoi.Count + 1);
            TitleCauHoi.Name = "CH" + (listCauHoi.Count + 1);

          

            //Nút xóa câu hỏi
            DevComponents.DotNetBar.ButtonX xoa = new DevComponents.DotNetBar.ButtonX();
            xoa.BackColor = Color.Transparent;
            xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            xoa.Dock = DockStyle.Right;
            xoa.Image = Properties.Resources.buttonExit_Image;

            xoa.Size = new System.Drawing.Size(20, 20);
            xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            xoa.Click += Xoa_Click;
            TitleCauHoi.TitlePanel.Controls.Add(xoa);

           




            //Tạo câu hỏi & thêm vào expandable panel câu hỏi
            CauHoi temp = new CauHoi();
            temp.Location = new Point(0, TitleCauHoi.TitleHeight);
            temp.Dock = DockStyle.Bottom;
            TitleCauHoi.AutoSize = true;
            TitleCauHoi.Controls.Add(temp);




            //Add expandable câu hỏi vào panel SoanCauHoi
            panelSoanCauHoi.Controls.Add(TitleCauHoi);

            TitleCauHoi.Dock = DockStyle.Top;
            TitleCauHoi.BringToFront();
            buttonX2.BringToFront();
            panelSoanCauHoi.ScrollControlIntoView(buttonX2);

            //Thêm câu hỏi vào list để dễ quản lý
            listCauHoi.Add(TitleCauHoi);
        }

        //Chèn symbol
        private void Symbol_Click(object sender, EventArgs e)
        {
            Control panel = ((Control)sender).Parent.Parent;
            foreach (Control item in panel.Controls)
            {
                foreach (Control _item in item.Controls)
                {
                    MessageBox.Show(_item.Name);
                }
            }
           
            //richTextBoxEx1.SelectedRtf = Properties.Resources.Document;
        }

        //Định dạng font
        private void Font_Click(object sender, EventArgs e)
        {
            
        }

        //Xóa câu hỏi
        private void Xoa_Click(object sender, EventArgs e)
        {
           //Xóa câu hỏi khỏi listCauHoi
            listCauHoi.Remove(((DevComponents.DotNetBar.ButtonX)sender).Parent.Parent);
            //Xóa giao diện câu hỏi
            panelSoanCauHoi.Controls.Remove(((DevComponents.DotNetBar.ButtonX)sender).Parent.Parent);
        }
       
       


    }
}
