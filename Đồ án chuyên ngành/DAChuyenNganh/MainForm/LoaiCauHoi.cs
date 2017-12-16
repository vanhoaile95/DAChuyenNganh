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

     

        private void btnCauHoi1_Click(object sender, EventArgs e)
        {
            LoaiCauHoi.typeCauHoi = 1;
            this.Dispose();
        }
        private void btnCauHoi2_Click(object sender, EventArgs e)
        {
            LoaiCauHoi.typeCauHoi = 2;
            this.Dispose();
        }
        private void btnCauHoi3_Click(object sender, EventArgs e)
        {
            LoaiCauHoi.typeCauHoi = 3;
            this.Dispose();
        }
        private void btnCauHoi4_Click(object sender, EventArgs e)
        {
            LoaiCauHoi.typeCauHoi = 4;
            this.Dispose();
        }
        private void btnCauHoi5_Click(object sender, EventArgs e)
        { 
            LoaiCauHoi.typeCauHoi = 5;
            this.Dispose();
        }
        
    }
}
