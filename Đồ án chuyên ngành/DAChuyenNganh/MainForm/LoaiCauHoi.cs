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
    public partial class LoaiCauHoi : Form
    {
        public static int typeCauHoi=0;
        public LoaiCauHoi()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            LoaiCauHoi.typeCauHoi = 1;
            this.Dispose();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            LoaiCauHoi.typeCauHoi = 2;
            this.Dispose();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            LoaiCauHoi.typeCauHoi = 3;
            this.Dispose();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            LoaiCauHoi.typeCauHoi = 4;
            this.Dispose();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            LoaiCauHoi.typeCauHoi = 5;
            this.Dispose();
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            LoaiCauHoi.typeCauHoi = 6;
            this.Dispose();
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            LoaiCauHoi.typeCauHoi = 7;
            this.Dispose();
        }
    }
}
