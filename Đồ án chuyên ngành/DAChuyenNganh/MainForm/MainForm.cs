using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Common;
using Bus;
namespace MainForm
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            //Set icon
            Bitmap b = (Bitmap)Properties.Resources.SplashImage;
            IntPtr pIcon = b.GetHicon();
            Icon Ic = Icon.FromHandle(pIcon);
            this.Icon = Ic;
            Ic.Dispose();

            //Splash screen
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            InitializeComponent();
            //Loading data
            

            string str = string.Empty;
            for (int i = 0; i < 100000; i++)
            {
                str += i.ToString();
            }


            //Loading data Complete
            t.Abort();

           

        }
        public void Splash()
        {
            SplashScreenForm frm = new SplashScreenForm();
            frm.Text = "Soạn thảo câu hỏi trắc nghiệm";
            Application.Run(frm);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(new LoginBus().Test());
            
        }
       
    }
}
