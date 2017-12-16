using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        private void btnThemCauHoi_Click(object sender, EventArgs e)
        {
            //Chỉ cho soạn 1 câu hỏi
            if (Style == "CauHoi" && listCauHoi.Count > 0)
                return;

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
                    temp = new CauHoi_1();
                    break;
                case 2:
                    temp = new CauHoi_2();
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
            listCauHoi.Remove(((ButtonX)sender).Parent.Parent);
            //Xóa giao diện câu hỏi
            panelSoanCauHoi.Controls.Remove(((ButtonX)sender).Parent.Parent);
            for (int i= 0; i < listCauHoi.Count;i++)
            {
                ((ExpandablePanel)listCauHoi.ElementAt(i)).TitleText = "Câu Hỏi " + (i+1);
            }

        }

       
        private void btnLuuDe_Click(object sender, EventArgs e)
        {
            LuuDeThi luude = new LuuDeThi();
            luude.ShowDialog();
        }
        private void btnXuatDe_Click(object sender, EventArgs e)
        {
            LuuDeThi luude = new LuuDeThi();
            luude.ShowDialog();
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

            //Get list câu hỏi
            var List = new CauHoiBus().GetListCauHoi();
            for (int i = 0; i < List.Count; i++)
            {
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

                UserControl _temp = null;
                object listDapAn;
                switch (List[i].ID_LoaiCauHoi)
                {
                    case 1:

                        _temp = new CauHoi_1();
                        listDapAn = new CauHoiBus().GetListDapAn(List[i].ID);
                        ((CauHoi_1)_temp).Init(List[i].NoiDung,(List<DapAn>)listDapAn);
                       
                        break;
                    case 2:
                        _temp = new CauHoi_2();
                        listDapAn = new CauHoiBus().GetListDapAn(List[i].ID);
                        ((CauHoi_2)_temp).Init(List[i].NoiDung, (List<DapAn>)listDapAn);
                        break;
                    case 3:
                        _temp = new CauHoi_3();
                        listDapAn = new CauHoiBus().GetListDapAn(List[i].ID);
                        ((CauHoi_3)_temp).Init(List[i].NoiDung, (List<DapAn>)listDapAn);
                        break;
                    case 4:
                        _temp = new CauHoi_4();
                        listDapAn = new CauHoiBus().GetListDapAn(List[i].ID);
                        ((CauHoi_4)_temp).Init(List[i].NoiDung, (List<DapAn>)listDapAn);
                        break;
                    case 5:
                        _temp = new CauHoi_5();
                        listDapAn = new CauHoiBus().GetListDapAn(List[i].ID);
                        ((CauHoi_5)_temp).Init(List[i].NoiDung, (List<DapAn>)listDapAn);
                        break;
                 
                }



                _temp.Location = new Point(0, TitleCauHoi.TitleHeight);
                _temp.Dock = DockStyle.Bottom;
                TitleCauHoi.AutoSize = true;
                TitleCauHoi.Controls.Add(_temp);




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
            //Lưu câu hỏi 
            if (listCauHoi.Count > 0)
            {
                string LoaiCauHoi = ((ExpandablePanel)listCauHoi[0]).Controls[0].GetType().ToString();
                #region CauHoi1
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

                        //Check đáp án có ko
                        var listDapAn = ch1.Controls.Find("groupDapAn", true);
                        if (listDapAn.Count() == 0)
                        {
                            MessageBox.Show("Chưa có đáp án");
                            return;
                        }

                        if (new CauHoiBus().AddCauHoi(ch))
                        {
                            //Thêm đáp án
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
                #endregion
                #region CauHoi2
                if (LoaiCauHoi.Contains("CauHoi_2"))
                {
                    CauHoi_2 ch2 = (CauHoi_2)((ExpandablePanel)listCauHoi[0]).Controls[0];
                    try
                    {
                        if (ch2.Controls["txtCauHoi"].Text.Length == 0)
                        {
                            MessageBox.Show("Chưa nhập nội dung");
                            return;
                        }
                        //Thêm câu hỏi
                        CauHoi ch = new CauHoi();
                        ch.NoiDung = ch2.Controls["txtCauHoi"].Text;
                        ch.ID_DoKho = 1;
                        ch.ID_MonHoc = 1;
                        ch.ID_LoaiCauHoi = 2;
                        

                        //Check đáp án có ko
                        var listDapAn = ch2.Controls.Find("groupDapAn", true);
                        if (listDapAn.Count() == 0)
                        {
                            MessageBox.Show("Chưa có đáp án");
                            return;
                        }
                        if (new CauHoiBus().AddCauHoi(ch))
                        {
                        
                            for (int i = 0; i < listDapAn.Count(); i++)
                            {
                                DapAn da = new DapAn();
                                da.ID_CauHoi = ch.ID;
                                da.TenDapAn = listDapAn[i].Text;
                                da.NoiDungDapAn = listDapAn[i].Controls.Find("richDapAn", true)[0].Text;
                                da.DapAnDung = true;
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
                #endregion
                #region CauHoi3
                if (LoaiCauHoi.Contains("CauHoi_3"))
                {
                    CauHoi_3 ch3 = (CauHoi_3)((ExpandablePanel)listCauHoi[0]).Controls[0];
                    try
                    {
                        if (ch3.Controls["txtCauHoi"].Text.Length == 0)
                        {
                            MessageBox.Show("Chưa nhập nội dung");
                            return;
                        }
                        //Thêm câu hỏi
                        CauHoi ch = new CauHoi();
                        ch.NoiDung = ch3.Controls["txtCauHoi"].Text;
                        ch.ID_DoKho = 1;
                        ch.ID_MonHoc = 1;
                        ch.ID_LoaiCauHoi = 3;

                        //Check đáp án có ko
                        var listDapAnCorrect = ch3.Controls.Find("groupDapAnCorrect", true);
                        var listDapAn = ch3.Controls.Find("groupDapAn", true);
                        if (listDapAn.Count() % 2 != 0)
                        {
                            MessageBox.Show("Đáp án 2 cột chưa đồng đều");
                            return;
                        }
                        if (listDapAnCorrect.Count() == 0)
                        {
                            MessageBox.Show("Chưa có đáp án");
                            return;
                        }
                        if (new CauHoiBus().AddCauHoi(ch))
                        {
                            //Lưu đáp án
                            for (int i = 0; i < listDapAnCorrect.Count(); i++)
                            {
                                DapAn da = new DapAn();
                                da.ID_CauHoi = ch.ID;
                                da.TenDapAn = listDapAnCorrect[i].Text;
                                da.NoiDungDapAn = listDapAnCorrect[i].Controls.Find("richDapAnCorrect", true)[0].Text;
                                da.DapAnDung = true;
                                new CauHoiBus().AddDapAn(da);
                            }
                            //Lưu đáp án đúng
                            for (int i = 0; i < listDapAn.Count(); i++)
                            {
                                DapAn da = new DapAn();
                                da.ID_CauHoi = ch.ID;
                                da.TenDapAn = listDapAn[i].Text;
                                da.NoiDungDapAn = listDapAn[i].Controls.Find("richDapAn", true)[0].Text;
                                da.DapAnDung = false;
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
                #endregion
                #region CauHoi4
                if (LoaiCauHoi.Contains("CauHoi_4"))
                {
                    CauHoi_4 ch4 = (CauHoi_4)((ExpandablePanel)listCauHoi[0]).Controls[0];
                    try
                    {
                        if (ch4.Controls["txtCauHoi"].Text.Length == 0)
                        {
                            MessageBox.Show("Chưa nhập nội dung");
                            return;
                        }
                        //Thêm câu hỏi
                        CauHoi ch = new CauHoi();
                        ch.NoiDung = ch4.Controls["txtCauHoi"].Text;
                        ch.ID_DoKho = 1;
                        ch.ID_MonHoc = 1;
                        ch.ID_LoaiCauHoi = 4;

                        //Check đáp án có ko
                 
                        var listDapAn = ch4.Controls.Find("richDapAn", true);
                        if (listDapAn.Count() == 0)
                        {
                            MessageBox.Show("Chưa nhập đáp án");
                            return;
                        }
                        
                        if (new CauHoiBus().AddCauHoi(ch))
                        {
                            //Lưu đáp án
                            for (int i = 0; i < listDapAn.Count(); i++)
                            {
                                DapAn da = new DapAn();
                                da.ID_CauHoi = ch.ID;
                                da.TenDapAn = "Đáp án";
                                da.NoiDungDapAn = listDapAn[i].Text;
                                da.DapAnDung = true;
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
                #endregion
                #region CauHoi5
                if (LoaiCauHoi.Contains("CauHoi_5"))
                {
                    CauHoi_5 ch5 = (CauHoi_5)((ExpandablePanel)listCauHoi[0]).Controls[0];
                    try
                    {
                        if (ch5.Controls["txtCauHoi"].Text.Length == 0)
                        {
                            MessageBox.Show("Chưa nhập nội dung");
                            return;
                        }
                        //Thêm câu hỏi
                        CauHoi ch = new CauHoi();
                        ch.NoiDung = ch5.Controls["txtCauHoi"].Text;
                        ch.ID_DoKho = 1;
                        ch.ID_MonHoc = 1;
                        ch.ID_LoaiCauHoi = 5;

                        //Check đáp án có ko
                        var listDapAnCorrect = ch5.Controls.Find("groupDapAnCorrect", true);
                        var listDapAn = ch5.Controls.Find("groupDapAn", true);
                        
                        if (listDapAnCorrect.Count() == 0)
                        {
                            MessageBox.Show("Chưa có đáp án");
                            return;
                        }
                        if (new CauHoiBus().AddCauHoi(ch))
                        {
                            //Lưu đáp án
                            for (int i = 0; i < listDapAnCorrect.Count(); i++)
                            {
                                DapAn da = new DapAn();
                                da.ID_CauHoi = ch.ID;
                                da.TenDapAn = listDapAnCorrect[i].Text;
                                da.NoiDungDapAn = listDapAnCorrect[i].Controls.Find("richDapAnCorrect", true)[0].Text;
                                da.DapAnDung = true;
                                new CauHoiBus().AddDapAn(da);
                            }
                            //Lưu đáp án đúng
                            for (int i = 0; i < listDapAn.Count(); i++)
                            {
                                DapAn da = new DapAn();
                                da.ID_CauHoi = ch.ID;
                                da.TenDapAn = listDapAn[i].Text;
                                da.NoiDungDapAn = listDapAn[i].Controls.Find("richDapAn", true)[0].Text;
                                da.DapAnDung = false;
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
                #endregion

            }

        }


    }
}
