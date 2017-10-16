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
        List<Color> colors = new List<Color>();
        public SplashScreenForm()
        {
            //Change icon
            Bitmap b = (Bitmap)Properties.Resources.SplashImage;
            IntPtr pIcon = b.GetHicon();
            Icon Ic = Icon.FromHandle(pIcon);
            this.Icon = Ic;
            Ic.Dispose();

            InitializeComponent();

            //Add color transition
            colors.Add(Color.FromArgb(0, 158, 71));
            colors.Add(Color.FromArgb(112, 191, 83));
            colors.Add(Color.FromArgb(216, 155, 40));
            colors.Add(Color.FromArgb(217, 102, 41));
            colors.Add(Color.FromArgb(217, 102, 41));
            colors.Add(Color.FromArgb(235, 83, 104));
            colors.Add(Color.FromArgb(223, 128, 255));
            colors.Add(Color.FromArgb(112, 48, 160));
            colors.Add(Color.FromArgb(107, 122, 187));
            colors.Add(Color.FromArgb(95, 136, 176));
            colors.Add(Color.FromArgb(70, 175, 227));
            colors.Add(Color.FromArgb(0, 158, 71));
        }

        int curcolor = 0;
        int loop = 0;
        private void splashtimer_Tick(object sender, EventArgs e)
        {
            
            if (curcolor < colors.Count - 1 )
            {
                bunifuFlatButton1.Textcolor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(loop, colors[curcolor], colors[curcolor + 1]);
                if (loop < 100)
                    loop++;
                else
                {
                    loop = 0;
                    curcolor++;
                }
               
            }
            else
            {
                curcolor = 0;
                loop = 0;
            }
        }
    }
}
