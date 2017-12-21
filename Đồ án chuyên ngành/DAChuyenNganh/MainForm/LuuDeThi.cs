using Bus;
using DevComponents.DotNetBar;
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
    public partial class LuuDeThi : Form
    {
        public string TenDe { get; set; }
        public int MonHoc { get; set; }
        public int ThoiGian { get; set; }
        public string NgayThi { get; set; }
        public LuuDeThi()
        {
            InitializeComponent();
        }

        private void LuuDeThi_Load(object sender, EventArgs e)
        {
            txtTenDeThi.Text = "";
            DatePickerNgayThi.Value = DateTime.Now;
            cbThoiGianLamBai.SelectedIndex = 0;

            var monhocList = new MonHocBus().GetList();
            for (int i = 0; i < monhocList.Count; i++)
            {
                cbMonHoc.Items.Add(monhocList[i].TenMonHoc);
            }
            cbMonHoc.SelectedIndex = 0;
          

        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDeThi.Text == string.Empty)
                MessageBox.Show("Chưa nhập tên đề thi");
            else
            {
                TenDe = txtTenDeThi.Text;
                MonHoc = new MonHocBus().GetIdByName(cbMonHoc.Text);
                ThoiGian = Convert.ToInt32(cbThoiGianLamBai.Text.Split(' ')[0]);
                NgayThi = String.Format("{0:dd/MM/yyyy}", DatePickerNgayThi.Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
