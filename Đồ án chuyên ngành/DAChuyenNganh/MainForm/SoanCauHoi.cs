using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Bus;
using Common;
using DevComponents.DotNetBar.Controls;

namespace MainForm
{
    public partial class SoanCauHoi : UserControl
    {
        int soanCauHoi = 0;
        public SoanCauHoi()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
           
        }

        public static List<Object> listCauHoi = new List<Object>();


        private void btnThemCauHoi_Click(object sender, EventArgs e)
        {
           
            if (soanCauHoi == 1)
            {
                btnThemCauHoi.Hide();
            }

            //Tạo expandable panel câu hỏi
            ExpandablePanel TitleCauHoi = new ExpandablePanel();

            TitleCauHoi.CanvasColor = SystemColors.Control;
            TitleCauHoi.ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            TitleCauHoi.HideControlsWhenCollapsed = true;
            TitleCauHoi.ExpandButtonAlignment = eTitleButtonAlignment.Left;
            TitleCauHoi.ExpandOnTitleClick = true;
            TitleCauHoi.AnimationTime = 0;

            TitleCauHoi.TitleStyle.Alignment = StringAlignment.Center;
            TitleCauHoi.TitleStyle.BackColor1.ColorSchemePart = eColorSchemePart.PanelBackground;
            TitleCauHoi.TitleStyle.BackColor2.ColorSchemePart = eColorSchemePart.PanelBackground2;
            TitleCauHoi.TitleStyle.Border = eBorderType.RaisedInner;
            TitleCauHoi.TitleStyle.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
            TitleCauHoi.TitleStyle.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            TitleCauHoi.TitleStyle.GradientAngle = 90;
            TitleCauHoi.TitleText = "Câu hỏi " + (listCauHoi.Count + 1);
            TitleCauHoi.Name = "CH" + (listCauHoi.Count + 1);

            //Nút độ khó
            ButtonX dokho = new ButtonX();
            dokho.AutoExpandOnClick = true;
            dokho.BackColor = Color.Transparent;
            dokho.AccessibleRole = AccessibleRole.PushButton;
            dokho.ColorTable = eButtonColor.Blue;
            dokho.Dock = DockStyle.Right;
            dokho.Name = "dokho";
            dokho.ShowSubItems = true;

            var dokhoList = new DoKhoBus().GetList();
            for (int i = 0; i < dokhoList.Count; i++)
            {
                ButtonItem item = new ButtonItem();
                item.Text = dokhoList[i].MoTa;
                item.Click += Item_Click;
                dokho.SubItems.Add(item);
            }
            dokho.Text = dokho.SubItems[0].Text;
            dokho.Size = new Size(100, 20);
            dokho.Style = eDotNetBarStyle.StyleManagerControlled;
            TitleCauHoi.TitlePanel.Controls.Add(dokho);


            //Nút môn học
            ButtonX monhoc = new ButtonX();
            monhoc.BackColor = Color.Transparent;
            monhoc.AutoExpandOnClick = true;
            monhoc.AccessibleRole = AccessibleRole.PushButton;
            monhoc.ColorTable = eButtonColor.Blue;
            monhoc.Dock = DockStyle.Right;
            
            monhoc.Name = "monhoc";
            monhoc.ShowSubItems = true;

            var monhocList = new MonHocBus().GetList();
            for (int i = 0; i < monhocList.Count; i++)
            {
                ButtonItem item = new ButtonItem();
                item.Text = monhocList[i].TenMonHoc;
                item.Click += Item_Click;
                monhoc.SubItems.Add(item);
            }
            monhoc.Text = monhoc.SubItems[0].Text;


            monhoc.Size = new Size(100, 20);
            monhoc.Style = eDotNetBarStyle.StyleManagerControlled;
            TitleCauHoi.TitlePanel.Controls.Add(monhoc);


            //Nút xóa câu hỏi
            ButtonX xoa = new ButtonX();
            xoa.BackColor = Color.Transparent;
            xoa.AccessibleRole = AccessibleRole.PushButton;
            xoa.ColorTable = eButtonColor.Blue;
            xoa.Dock = DockStyle.Right;
            xoa.Image = Properties.Resources.buttonExit_Image;

            xoa.Size = new Size(20, 20);
            xoa.Style = eDotNetBarStyle.StyleManagerControlled;
            xoa.Click += Xoa_Click;
            TitleCauHoi.TitlePanel.Controls.Add(xoa);

           

            ///Loại câu hỏi
            LoaiCauHoi loaiCauHoi = new LoaiCauHoi();
            loaiCauHoi.ShowDialog();



            //Tạo câu hỏi & thêm vào expandable panel câu hỏi
            UserControl temp = null;

            switch (LoaiCauHoi.typeCauHoi)
            {
                case 1:
                    temp = new CauHoi_1(1);
                    break;
                case 2:
                    temp = new CauHoi_2(2);
                    break;
                case 3:
                    temp = new CauHoi_3(3);
                    break;
                case 4:
                    temp = new CauHoi_4(4);
                    break;
                case 5:
                    temp = new CauHoi_5(5);
                    break;
                case 6:
                    temp = new CauHoi_6(6);
                    break;
                case 7:
                    temp = new CauHoi_7(7);
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

            btnLuuDeThi.BringToFront();
            btnThemCauHoi.BringToFront();
            btnXuatDeThi.BringToFront();
            btnLuuCauHoi.BringToFront();
            panelSoanCauHoi.ScrollControlIntoView(btnThemCauHoi);

            //Thêm câu hỏi vào list để dễ quản lý
            listCauHoi.Add(TitleCauHoi);
        }

        private void Item_Click(object sender, EventArgs e)
        {
            ButtonX parent = (((ButtonItem)sender).Parent.ContainerControl) as ButtonX;
            parent.Text = ((ButtonItem)sender).Text; ;
        }
        
        //Xóa câu hỏi
        private void Xoa_Click(object sender, EventArgs e)
        {
            if(soanCauHoi == 1)
            {
                btnThemCauHoi.Show();
            }

            //Xóa câu hỏi khỏi listCauHoi
            listCauHoi.Remove(((ButtonX)sender).Parent.Parent);
            //Xóa giao diện câu hỏi
            panelSoanCauHoi.Controls.Remove(((ButtonX)sender).Parent.Parent);
            for (int i = 0; i < listCauHoi.Count; i++)
            {
                //Sắp xếp lại title câu hỏi
                ((ExpandablePanel)listCauHoi.ElementAt(i)).TitleText = "Câu Hỏi " + (i + 1);
            }

        }
        private void btnLuuDe_Click(object sender, EventArgs e)
        {
            if (listCauHoi.Count > 0)
            {
                using (var form = new LuuDeThi())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {

                        DeThi de = new DeThi();
                        de.TenDeThi = form.TenDe;
                        de.MaDeThi = "MA" + DateTime.Now.Millisecond;
                        de.ID_MonHoc = form.MonHoc;
                        de.ThoiGian_Phut = form.ThoiGian;
                        de.NgayDeThi = Convert.ToDateTime(form.NgayThi);
                        if (new DeThiBus().LuuDeThi(de))
                        {
                            for (int i = 0; i < listCauHoi.Count; i++)
                            {
                                int DoKho = new DoKhoBus().GetIDByName(((ExpandablePanel)listCauHoi[0]).TitlePanel.Controls.Find("dokho", true)[0].Text);
                                int MonHoc = new MonHocBus().GetIdByName(((ExpandablePanel)listCauHoi[0]).TitlePanel.Controls.Find("monhoc", true)[0].Text);
                                string LoaiCauHoi = ((ExpandablePanel)listCauHoi[i]).Controls[0].GetType().ToString();
                                int IDCauHoi = LuuDanhSachCauHoi(LoaiCauHoi,DoKho,MonHoc,((ExpandablePanel)listCauHoi[i]).Controls[0]);
                                if (IDCauHoi > 0)
                                {
                                    ChiTietDeThi detail = new ChiTietDeThi();
                                    detail.ID_CauHoi = IDCauHoi;
                                    detail.ID_DeThi = de.ID;
                                    new DeThiBus().LuuChiTietDe(detail);
                                }
                                else
                                { MessageBox.Show("Lưu thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                                
                            }
                            MessageBox.Show("Lưu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Lưu thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
           
        }
        private void btnXuatDe_Click(object sender, EventArgs e)
        {
            if (listCauHoi.Count > 0)
            {
                for (int i = 0; i < listCauHoi.Count; i++)
                {
                    if (!CheckCoNoiDung(((ExpandablePanel)listCauHoi[i]).Controls[0]))
                    {
                        MessageBox.Show("Chưa nhập nội dung câu hỏi");
                        return;
                    }
                    if (!CheckCoDapAn(((ExpandablePanel)listCauHoi[i]).Controls[0]))
                    {
                        MessageBox.Show("Chưa nhập nội dung đáp án");
                        return;
                    }

                }
                XuatDeThi xuatde = new XuatDeThi();
                xuatde.ShowDialog();
                MessageBox.Show("Xuất đề thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        public void SoanDeInit()
        {
            btnLuuCauHoi.Hide();
        }
        public void SoanCauHoiInit()
        {
            soanCauHoi = 1;
            btnLuuDeThi.Hide();
            btnXuatDeThi.Hide();
        }
 
        //Lưu câu hỏi
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Lưu câu hỏi 
            if (listCauHoi.Count > 0)
            {
                int DoKho = new DoKhoBus().GetIDByName(((ExpandablePanel)listCauHoi[0]).TitlePanel.Controls.Find("dokho", true)[0].Text);
                int MonHoc = new MonHocBus().GetIdByName(((ExpandablePanel)listCauHoi[0]).TitlePanel.Controls.Find("monhoc", true)[0].Text);
                string LoaiCauHoi = ((ExpandablePanel)listCauHoi[0]).Controls[0].GetType().ToString();
                switch (LuuDanhSachCauHoi(LoaiCauHoi, DoKho, MonHoc, ((ExpandablePanel)listCauHoi[0]).Controls[0]))
                {
                    case 0:
                        MessageBox.Show("Lưu thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case -1:
                        MessageBox.Show("Chưa nhập nội dung câu hỏi");
                        break;
                    case -2:
                        MessageBox.Show("Chưa nhập nội dung đáp án");
                        break;
                    default:
                        MessageBox.Show("Lưu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Reset Add câu hỏi
                        string CauHoiName = "CH" + (listCauHoi.Count);
                        panelSoanCauHoi.Controls[CauHoiName].Dispose();
                        listCauHoi.Clear();
                        btnThemCauHoi.Show();
                        break;
                }
                  
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        public bool CheckCoNoiDung(Control _Control)
        {
            if (_Control.Controls["txtCauHoi"].Text.Length == 0)
                return false;
            return true;
        }
        public bool CheckCoDapAn(Control _Control)
        {
            if (_Control.Controls.Find("groupDapAn", true).Count() == 0)
                return false;
            else
                if (_Control.GetType().ToString().Contains("CauHoi_4"))
            {
                if (_Control.Controls.Find("groupDapAn", true).Count() % 2 != 0)
                {
                    return false;
                }
            }
            return true;
        }
        public int LuuDanhSachCauHoi(string LoaiCauHoi,int DoKho,int MonHoc,Control _ConTrol = null)
        {
            

            if (!CheckCoNoiDung(_ConTrol)) return -1;
            if (!CheckCoDapAn(_ConTrol)) return -2;
            
            //Thêm câu hỏi
            CauHoi ch = new CauHoi();
            ch.NoiDung = _ConTrol.Controls["txtCauHoi"].Text;
            ch.ID_DoKho = DoKho;
            ch.ID_MonHoc = MonHoc;
            ch.MaCauHoi = "MA" + new CauHoiBus().GetList().Count;
            ch.ID_LoaiCauHoi = Convert.ToInt32(LoaiCauHoi.Substring(LoaiCauHoi.Length - 1, 1));

            if (new CauHoiBus().AddCauHoi(ch))
            {
                //Thêm đáp án
                var listDapAn = _ConTrol.Controls.Find("groupDapAn", true);
                for (int i = 0; i < listDapAn.Count(); i++)
                {
                    DapAn da = new DapAn();
                    da.ID_CauHoi = ch.ID;
                    da.TenDapAn = listDapAn[i].Text;
                    da.NoiDungDapAn = listDapAn[i].Controls.Find("richDapAn", true)[0].Text;
                    if (LoaiCauHoi.Contains("CauHoi_1") || LoaiCauHoi.Contains("CauHoi_2") || LoaiCauHoi.Contains("CauHoi_7"))
                        da.DapAnDung = ((SwitchButton)listDapAn[i].Controls.Find("switchDapAn", true)[0]).Value;
                    else
                         if (LoaiCauHoi.Contains("CauHoi_3") || LoaiCauHoi.Contains("CauHoi_5"))
                        da.DapAnDung = true;
                    else
                        if (LoaiCauHoi.Contains("CauHoi_4") || LoaiCauHoi.Contains("CauHoi_6"))
                    {
                        da.DapAnDung = false;
                    }
                        new CauHoiBus().AddDapAn(da);
                }

                if (LoaiCauHoi.Contains("CauHoi_4") || LoaiCauHoi.Contains("CauHoi_6"))
                {
                    var listDapAnCorrect = _ConTrol.Controls.Find("groupDapAnCorrect", true);

                    //Lưu đáp án đúng
                    for (int i = 0; i < listDapAnCorrect.Count(); i++)
                    {
                        DapAn da = new DapAn();
                        da.ID_CauHoi = ch.ID;
                        da.TenDapAn = listDapAnCorrect[i].Text;
                        da.NoiDungDapAn = listDapAnCorrect[i].Controls.Find("richDapAnCorrect", true)[0].Text;
                        da.DapAnDung = true;
                        new CauHoiBus().AddDapAn(da);
                    }

                }

            }

            

            return ch.ID;
        }
    }
}
