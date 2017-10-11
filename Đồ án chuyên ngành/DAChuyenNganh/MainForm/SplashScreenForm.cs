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
    public partial class SplashScreenForm : MetroFramework.Forms.MetroForm
    {
        public SplashScreenForm()
        {
            Bitmap b = (Bitmap)Properties.Resources.SplashImage;
            IntPtr pIcon = b.GetHicon();
            Icon Ic = Icon.FromHandle(pIcon);
            this.Icon = Ic;
            Ic.Dispose();

            InitializeComponent();
        }
    }
}
