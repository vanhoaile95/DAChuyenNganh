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
    public partial class Form1 : DevComponents.DotNetBar.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            buttonX1.Command = commandBold;
            
        }

        private void commandBold_Executed(object sender, EventArgs e)
        {
            MessageBox.Show("dsd");
        }
    }
}
