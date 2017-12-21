using Bus;
using Common;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class EditForm : Form
    {
        CauHoi cauhoi;
        List<DapAn> dapanList;
        public static List<Object> listCauHoi = new List<Object>();
        public EditForm()
        {
            InitializeComponent();
            listCauHoi.Clear();
        }
        public void Init(CauHoi cauhoi,List<DapAn> dapanList)
        {
            this.cauhoi = cauhoi;
            this.dapanList = dapanList;
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
            TitleCauHoi.TitleText = "Câu hỏi";
            TitleCauHoi.Name = "CH" ;

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
            for (int j = 0; j < dokhoList.Count; j++)
            {
                ButtonItem item = new ButtonItem();
                item.Text = dokhoList[j].MoTa;
                item.Click += Item_Click;
                dokho.SubItems.Add(item);
            }

            dokho.Text = new DoKhoBus().GetNameById(cauhoi.ID_DoKho);
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
            for (int j = 0; j < monhocList.Count; j++)
            {
                ButtonItem item = new ButtonItem();
                item.Text = monhocList[j].TenMonHoc;
                item.Click += Item_Click;
                monhoc.SubItems.Add(item);
            }
            monhoc.Text = new MonHocBus().GetNameByID(cauhoi.ID_MonHoc);


            monhoc.Size = new Size(100, 20);
            monhoc.Style = eDotNetBarStyle.StyleManagerControlled;
            TitleCauHoi.TitlePanel.Controls.Add(monhoc);
            

            //Tạo câu hỏi & thêm vào expandable panel câu hỏi
            UserControl _temp = null;
            object listDapAn;
            switch (cauhoi.ID_LoaiCauHoi)
            {
                case 1:
                    _temp = new CauHoi_1();
                    listDapAn = new CauHoiBus().GetListDapAn(cauhoi.ID);
                    ((CauHoi_1)_temp).Init(cauhoi.NoiDung, (List<DapAn>)listDapAn);
                    break;
                case 2:
                    _temp = new CauHoi_2();
                    listDapAn = new CauHoiBus().GetListDapAn(cauhoi.ID);
                    ((CauHoi_2)_temp).Init(cauhoi.NoiDung, (List<DapAn>)listDapAn);
                    break;
                case 3:
                    _temp = new CauHoi_3();
                    listDapAn = new CauHoiBus().GetListDapAn(cauhoi.ID);
                    ((CauHoi_3)_temp).Init(cauhoi.NoiDung, (List<DapAn>)listDapAn);
                    break;
                case 4:
                    _temp = new CauHoi_4();
                    listDapAn = new CauHoiBus().GetListDapAn(cauhoi.ID);
                    ((CauHoi_4)_temp).Init(cauhoi.NoiDung, (List<DapAn>)listDapAn);
                    break;
                case 5:
                    _temp = new CauHoi_5();
                    listDapAn = new CauHoiBus().GetListDapAn(cauhoi.ID);
                    ((CauHoi_5)_temp).Init(cauhoi.NoiDung, (List<DapAn>)listDapAn);
                    break;
                case 6:
                    _temp = new CauHoi_6();
                    listDapAn = new CauHoiBus().GetListDapAn(cauhoi.ID);
                    ((CauHoi_6)_temp).Init(cauhoi.NoiDung, (List<DapAn>)listDapAn);
                    break;
                case 7:
                    _temp = new CauHoi_7();
                    listDapAn = new CauHoiBus().GetListDapAn(cauhoi.ID);
                    ((CauHoi_7)_temp).Init(cauhoi.NoiDung, (List<DapAn>)listDapAn);
                    break;
            }

            _temp.Location = new Point(0, TitleCauHoi.TitleHeight);
            _temp.Dock = DockStyle.Bottom;
            TitleCauHoi.AutoSize = true;
            TitleCauHoi.Controls.Add(_temp);
            TitleCauHoi.Dock = DockStyle.Top;

            listCauHoi.Add(TitleCauHoi);
            this.Size = new Size(640, 400);
            this.Controls.Add(TitleCauHoi);
        }
        private void Item_Click(object sender, EventArgs e)
        {
            ButtonX parent = (((ButtonItem)sender).Parent.ContainerControl) as ButtonX;
            parent.Text = ((ButtonItem)sender).Text; ;
        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Xóa câu hỏi
            new CauHoiBus().DeleteCauHoi(cauhoi.ID);
            //Add lại câu hỏi
            
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
                    break;
            }
            DialogResult = DialogResult.OK;
        }

        public int LuuDanhSachCauHoi(string LoaiCauHoi, int DoKho, int MonHoc, Control _ConTrol = null)
        {


            if (!CheckCoNoiDung(_ConTrol)) return -1;
            if (!CheckCoDapAn(_ConTrol)) return -2;

            //Thêm câu hỏi
            CauHoi ch = new CauHoi();
            ch.NoiDung = _ConTrol.Controls["txtCauHoi"].Text;
            ch.ID_DoKho = DoKho;
            ch.MaCauHoi = cauhoi.MaCauHoi;
            ch.ID_MonHoc = MonHoc;
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
    }
}
