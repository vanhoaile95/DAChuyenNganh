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
            temp.XoaCauHoi = XoaCauHoi;//gán delegate
            panelSoanCauHoi.Controls.Add(temp);
            temp.Dock = DockStyle.Top;
            temp.BringToFront();
            btnAddCauHoi.BringToFront();
            panelSoanCauHoi.ScrollControlIntoView(btnAddCauHoi);


            listCauHoi.Add(temp);
        }


        public void XoaCauHoi(String CauHoi)
        {
            for(int i=0;i<listCauHoi.Count;i++)
            {
                if(listCauHoi.ElementAt(i).btnTitle.ButtonText== CauHoi)
                {
                    listCauHoi.RemoveAt(i);
                    
                    break;
                }
            }


            panelSoanCauHoi.Controls.Clear();
            panelSoanCauHoi.Controls.Add(btnAddCauHoi);
            panelSoanCauHoi.ScrollControlIntoView(btnAddCauHoi);
            for (int i = listCauHoi.Count-1; i >=0; i--)
            {
                listCauHoi.ElementAt(i).btnTitle.ButtonText = "Câu hỏi " + (i + 1).ToString();
                panelSoanCauHoi.Controls.Add(listCauHoi.ElementAt(i));
            }
        }
    }
}
