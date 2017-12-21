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
    public partial class CauHoi_2 : CauHoi_1
    {
        public CauHoi_2()
        {
            InitializeComponent();
        }
        public CauHoi_2(int loaicauhoi)
        {
            InitializeComponent();
            this.Name = "CauHoi_2";
            loaiCauHoi = loaicauhoi;
        }
    }
}
