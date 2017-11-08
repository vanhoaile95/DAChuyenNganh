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
    public partial class SoanCauHoi : UserControl
    {
        public SoanCauHoi()
        {
            InitializeComponent();
        }

        public List<CauHoi> listCauHoi = new List<CauHoi>();
        private void btnAddCauHoi_Click(object sender, EventArgs e)
        {
            CauHoi temp = new CauHoi(listCauHoi.Count + 1);
            panelSoanCauHoi.Controls.Add(temp);
            temp.Dock = DockStyle.Top;
            temp.BringToFront();
            btnAddCauHoi.BringToFront();
            panelSoanCauHoi.ScrollControlIntoView(btnAddCauHoi);


            listCauHoi.Add(temp);
        }
    }
}
