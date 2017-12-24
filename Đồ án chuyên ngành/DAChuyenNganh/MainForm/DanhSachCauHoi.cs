using System;
using System.Windows.Forms;
using Bus;
using Common;

namespace MainForm
{
    public partial class DanhSachCauHoi : UserControl
    {
        public DanhSachCauHoi()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            cBoxMonHoc.Items.Add("Chọn môn học...");
            cBoxMonHoc.SelectedIndex = 0;
        }

        private void DanhSachCauHoi_Load(object sender, EventArgs e)
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

        public void LoadListCauHoi()
        {
            Cursor.Current = Cursors.WaitCursor;
            listCauHoi.Items.Clear();
            //Get list câu hỏi
            var List = new CauHoiBus().GetListCauHoiByMonHoc( new MonHocBus().GetIdByName(cBoxMonHoc.Text));

            for (int i = 0; i < List.Count; i++)
            {
                string[] row = { List[i].MaCauHoi.ToString(), List[i].NoiDung,  new MonHocBus().GetNameByID(List[i].ID_MonHoc), new DoKhoBus().GetNameById( List[i].ID_DoKho ) };
                var listViewItem = new ListViewItem(row);
                listCauHoi.Items.Add(listViewItem);
            }
            Cursor.Current = Cursors.Default;
        }
        private void cBoxMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListCauHoi();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem row = listCauHoi.SelectedItems[0];
            if (new CauHoiBus().DeleteCauHoi(new CauHoiBus().GetIDByMa(row.SubItems[0].Text)))
            {
                MessageBox.Show("Xóa thành công");
                LoadListCauHoi();

            }
            else
                MessageBox.Show("Xóa thất bại");

        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem row = listCauHoi.SelectedItems[0];
                //MessageBox.Show(row.SubItems[0].Text);
                var cauhoi = new CauHoiBus().GetListCauHoiByID(new CauHoiBus().GetIDByMa(row.SubItems[0].Text));
                var dapanList = new CauHoiBus().GetListDapAn(new CauHoiBus().GetIDByMa(row.SubItems[0].Text));

                EditForm form = new EditForm();
                form.Init(cauhoi, dapanList);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadListCauHoi();
            }
            catch
            {

            }
            

        }

        private void thamKhảoĐềTHiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem row = listCauHoi.SelectedItems[0];
                //MessageBox.Show(row.SubItems[0].Text);
                var cauhoi = new CauHoiBus().GetListCauHoiByID(new CauHoiBus().GetIDByMa(row.SubItems[0].Text));
                thamkhaoCauHoi(cauhoi);
            }
            catch (Exception)
            {

                
            }
        }
        public delegate void ThamKhao(CauHoi cauhoi);
        public ThamKhao thamkhaoCauHoi;
    }
}
