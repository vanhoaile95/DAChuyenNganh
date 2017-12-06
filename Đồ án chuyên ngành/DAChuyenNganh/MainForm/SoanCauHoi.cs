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
using DevComponents.DotNetBar;
using Bus;
using DevComponents.DotNetBar.Controls;

namespace MainForm
{
    public partial class SoanCauHoi : UserControl
    {
        public string Style;
        public SoanCauHoi()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
           
        }

        public List<Object> listCauHoi = new List<Object>();

       
        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (Style == "CauHoi" && listCauHoi.Count > 0)
                return;
            
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
            LoaiCauHoi loaiCauHoi = new LoaiCauHoi();
            loaiCauHoi.ShowDialog();

            


            //Tạo câu hỏi & thêm vào expandable panel câu hỏi
            UserControl temp;

            switch (LoaiCauHoi.typeCauHoi)
            {
                case 1:
                    temp = new CauHoi_1();
                    break;
                case 2:
                    temp = new CauHoi_1();
                    break;
                case 3:
                    temp = new CauHoi_3();
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
                    temp = new CauHoi_1();
                    break;
                default:
                    temp = new CauHoi_1();
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


            btnThemCauHoi.BringToFront();
            btnLuuCauHoi.BringToFront();
            btnLuuDe.BringToFront();
            btnXuatDe.BringToFront();

        
            panelSoanCauHoi.ScrollControlIntoView(btnThemCauHoi);
           
           
            //Thêm câu hỏi vào list để dễ quản lý
            listCauHoi.Add(TitleCauHoi);
          
          
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
            }

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            LuuDeThi luude = new LuuDeThi();
            luude.ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            XuatDeThi xuatDe = new XuatDeThi();
            xuatDe.ShowDialog();
        }

        public void SoanDeInit()
        {
            Style = "DeThi";
            btnLuuDe.Show();
            btnXuatDe.Show();
            btnLuuCauHoi.Hide();
        }

        public void SoanCauHoiInit()
        {
            Style = "CauHoi";
            btnLuuDe.Hide();
            btnXuatDe.Hide();
            btnLuuCauHoi.Show();
        }
        public void ThuVienCauHoiInit()
        {
            
            Cursor.Current = Cursors.WaitCursor;
            listCauHoi.Clear();
            panelSoanCauHoi.Controls.Clear();
            panelSoanCauHoi.Visible = false;
            btnLuuCauHoi.Hide();
            btnLuuDe.Hide();
            btnXuatDe.Hide();
            btnThemCauHoi.Hide();
            var List = new CauHoiBus().GetListCauHoi();
            for (int i = 0; i < List.Count; i++)
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

                UserControl temp;
                switch (List[i].ID_LoaiCauHoi)
                {
                    case 1:
                       
                        temp = new CauHoi_1();
                        var listDapAn = new CauHoiBus().GetListDapAn(List[i].ID);
                        ((CauHoi_1)temp).Init(List[i].NoiDung,listDapAn);
                       
                        break;
                    case 2:
                        temp = new CauHoi_1();
                        break;
                    case 3:
                        temp = new CauHoi_3();
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
                        temp = new CauHoi_1();
                        break;
                    default:
                        temp = new CauHoi_1();
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

                
                //Thêm câu hỏi vào list để dễ quản lý
                listCauHoi.Add(TitleCauHoi);


            }
            Cursor.Current = Cursors.Default;
            panelSoanCauHoi.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (listCauHoi.Count > 0)
            {
                string LoaiCauHoi = ((ExpandablePanel)listCauHoi[0]).Controls[0].GetType().ToString();
                if (LoaiCauHoi.Contains("CauHoi_1"))
                {
                    CauHoi_1 ch1 = (CauHoi_1)((ExpandablePanel)listCauHoi[0]).Controls[0];

                    try
                    {
                        if (ch1.Controls["txtCauHoi"].Text.Length == 0)
                        {
                            MessageBox.Show("Chưa nhập nội dung");
                            return;
                        }
                        //Thêm câu hỏi
                        CauHoi ch = new CauHoi();
                        ch.NoiDung = ch1.Controls["txtCauHoi"].Text;
                        ch.ID_DoKho = 1;
                        ch.ID_MonHoc = 1;
                        ch.ID_LoaiCauHoi = 1;

                        if (new CauHoiBus().AddCauHoi(ch))
                        {
                            //Thêm đáp án
                            var listDapAn = ch1.Controls.Find("groupDapAn", true);
                            if (listDapAn.Count() == 0)
                            {
                                MessageBox.Show("Chưa có đáp án");
                                return;
                            }
                            for (int i = 0; i < listDapAn.Count(); i++)
                            {
                                DapAn da = new DapAn();
                                da.ID_CauHoi = ch.ID;
                                da.TenDapAn = listDapAn[i].Text;
                                da.NoiDungDapAn = listDapAn[i].Controls.Find("richDapAn", true)[0].Text;
                                da.DapAnDung = ((SwitchButton)listDapAn[i].Controls.Find("switchDapAn", true)[0]).Value;

                                new CauHoiBus().AddDapAn(da);
                            }
                            MessageBox.Show("Lưu thành công !");

                            //Reset Add câu hỏi
                            string CauHoiName = "CH" + (listCauHoi.Count);
                            panelSoanCauHoi.Controls[CauHoiName].Dispose();
                            listCauHoi.Clear();


                        }
                        else
                            MessageBox.Show("Lưu thất bại !");

                        
                    }
                    catch (Exception ex)
                    { MessageBox.Show("Lưu thất bại !"); }

                }

            }
        }
    }
}
