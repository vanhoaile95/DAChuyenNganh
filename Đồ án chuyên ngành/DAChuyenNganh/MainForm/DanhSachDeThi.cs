using System;
using System.Windows.Forms;
using Bus;

namespace MainForm
{
    public partial class DanhSachDeThi : UserControl
    {
        public DanhSachDeThi()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            cBoxMonHoc.Items.Add("Chọn môn học...");
            cBoxMonHoc.SelectedIndex = 0;
        }

        private void DanhSachDeThi_Load(object sender, EventArgs e)
        {
          

            Cursor.Current = Cursors.WaitCursor;

            //Load Cbox Mon Hoc
            var monhocList = new MonHocBus().GetList();

            for (int i = 0; i < monhocList.Count; i++)
            {
                cBoxMonHoc.Items.Add(monhocList[i].TenMonHoc);
            }



            Cursor.Current = Cursors.Default;
        }

        private void cBoxMonHoc_DropDown(object sender, EventArgs e)
        {
            for (int i = 0; i < cBoxMonHoc.Items.Count; i++)
                if (cBoxMonHoc.Items[i].ToString() == "Chọn môn học...")
                {
                    cBoxMonHoc.Items.RemoveAt(i);
                    break;
                }

        }

        private void cBoxMonHoc_DropDownClosed(object sender, EventArgs e)
        {
            if (cBoxMonHoc.Text == string.Empty)
            {
                cBoxMonHoc.Items.Add("Chọn môn học...");
                cBoxMonHoc.SelectedIndex = cBoxMonHoc.Items.Count - 1;
            }
        }

        public void LoadListDe()
        {
            Cursor.Current = Cursors.WaitCursor;
            listDeThi.Items.Clear();
            //Get list câu hỏi
            var List = new DeThiBus().GetListDeByMonHoc(cBoxMonHoc.Text);
            for (int i = 0; i < List.Count; i++)
            {
                string[] row = { List[i].MaDeThi.ToString(), List[i].TenDeThi, new MonHocBus().GetNameByID(List[i].ID_MonHoc), List[i].ThoiGian_Phut.ToString() + " phút", String.Format("{0:dd/MM/yyyy}", List[i].NgayDeThi) };
                var listViewItem = new ListViewItem(row);
                listDeThi.Items.Add(listViewItem);
            }
            Cursor.Current = Cursors.Default;
        }
        private void cBoxMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListDe();
        }
    }
}
