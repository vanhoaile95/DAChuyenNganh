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
        private void buttonX2_Click(object sender, EventArgs e)
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

            ///Loại câu hỏi
            ///
            LoaiCauHoi loaiCauHoi = new LoaiCauHoi();
            
            loaiCauHoi.ShowDialog();




            //Tạo câu hỏi & thêm vào expandable panel câu hỏi
            UserControl temp;

            switch (LoaiCauHoi.typeCauHoi)
            {
                case 1:
                    temp = new CauHoi();
                    break;
                case 2:
                    temp = new CauHoi();
                    break;
                case 3:
                    temp = new CauHoi();
                    break;
                case 4:
                    temp = new CauHoi_4();
                    break;
                case 5:
                    temp = new CauHoi_5();
                    break;
                case 6:
                    temp = new CauHoi_6();
                    break;
                case 7:
                    temp = new CauHoi();
                    break;
                default:
                    temp = new CauHoi();
                    break;
            }
            
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
            //foreach (var item in listCauHoi)
            //{
            //    MessageBox.Show(((DevComponents.DotNetBar.ExpandablePanel)item).TitleText);
            //    MessageBox.Show((((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0]).GetType().ToString());
              
               
            //}
          
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
            for (int i= 0; i < listCauHoi.Count;i++)
            {
                ((DevComponents.DotNetBar.ExpandablePanel)listCauHoi.ElementAt(i)).TitleText = "Câu Hỏi " + (i+1);
                //messagebox.show((((devcomponents.dotnetbar.expandablepanel)item).controls[0]).gettype().tostring());


            }

        }


    }
}
