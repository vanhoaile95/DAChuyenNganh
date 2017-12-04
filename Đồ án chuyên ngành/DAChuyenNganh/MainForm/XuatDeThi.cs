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
    public partial class XuatDeThi : Form
    {
        public XuatDeThi()
        {
            InitializeComponent();
        }

        

        private void XuatDeThi_Load(object sender, EventArgs e)
        {
            cbSoDe.SelectedIndex = cbSoDe.FindStringExact("1 Đề");
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
            txtDuongDan.Text = save.FileName;
        }
    }
}
