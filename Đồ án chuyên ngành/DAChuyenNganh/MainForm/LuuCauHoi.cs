using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bus;
namespace MainForm
{
    public partial class LuuCauHoi : Form
    {
        public int DoKho { get; set; }
        public int MonHoc { get; set; }

        public LuuCauHoi()
        {
            InitializeComponent();
            cboxDoKho.Items.Add("Chọn độ khó...");
            cboxDoKho.SelectedIndex = 0;
            cboxMonHoc.Items.Add("Chọn môn học...");
            cboxMonHoc.SelectedIndex = 0;

            cboxDoKho.DropDown += cBox_DropDown;
            cboxMonHoc.DropDown += cBox_DropDown;
            cboxDoKho.DropDownClosed += cBox_DropDownClosed;
            cboxMonHoc.DropDownClosed += cBox_DropDownClosed;

        }
        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LuuCauHoi_Load(object sender, EventArgs e)
        {
            var dokhoList = new DoKhoBus().GetList();
            var monhocList = new MonHocBus().GetList();

            for (int i = 0; i < dokhoList.Count; i++)
            {
                cboxDoKho.Items.Add(dokhoList[i].MoTa);
            }
            for (int i = 0; i < monhocList.Count; i++)
            {
                cboxMonHoc.Items.Add(monhocList[i].TenMonHoc);
            }
        }

        private void cBox_DropDown(object sender, EventArgs e)
        {
            ComboBox cbox = (ComboBox)sender;
            for (int i = 0; i < cbox.Items.Count; i++)
                if ( (cbox.Name == cboxDoKho.Name && cbox.Items[i].ToString().Contains("Chọn độ khó...")) || (cbox.Name == cboxMonHoc.Name && cbox.Items[i].ToString().Contains("Chọn môn học...")) )
                {
                    cbox.Items.RemoveAt(i);
                    break;
                }

        }

        private void cBox_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox cbox = (ComboBox)sender;
            if (cbox.Text == string.Empty)
            {
                if (cbox.Name == cboxDoKho.Name)
                cbox.Items.Add("Chọn độ khó...");
                else
                    cbox.Items.Add("Chọn môn học...");

                cbox.SelectedIndex = cbox.Items.Count - 1;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DoKho = new DoKhoBus().GetIDByName(cboxDoKho.Text);
            MonHoc = new MonHocBus().GetIdByName(cboxMonHoc.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
