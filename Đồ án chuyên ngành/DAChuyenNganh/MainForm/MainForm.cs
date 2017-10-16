using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Common;
using Bus;
using System.Collections.Generic;

namespace MainForm
{
   
    public partial class MainForm : Form
    {
        public void ShowSplashScreen(bool option)
        {
            //Splash screen
            if (option)
            {
                Thread t = new Thread(new ThreadStart(Splash));
                t.Start();

                //Loading data
                string str = string.Empty;
                for (int i = 0; i < 100000; i++)
                {
                    str += i.ToString();
                }


                //Loading data Complete
                t.Abort();
            }
            else
            {
                //Loading data
               
                //Loading data Complete
            }
        }
        public void Splash()
        {
            SplashScreenForm frm = new SplashScreenForm();
            frm.Text = "Soạn thảo câu hỏi trắc nghiệm";
            Application.Run(frm);
        }
        public MainForm()
        {
            ShowSplashScreen(false);
            InitializeComponent();

            //Set icon
            Bitmap b = (Bitmap)Properties.Resources.SplashImage;
            IntPtr pIcon = b.GetHicon();
            Icon Ic = Icon.FromHandle(pIcon);
            this.Icon = Ic;
            Ic.Dispose();
        }
       

        private void MainForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(new LoginBus().Test());


           


        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }
        

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (bunifuGradientPanel1.Width == 50)
            {
                bunifuGradientPanel1.Visible = false;
                bunifuGradientPanel1.Width = 180;
                bunifuImageButton1.Location = new Point(140, 0);

                bunifuTransition1.ShowSync(bunifuGradientPanel1);
                


            }
            else
            {
                bunifuGradientPanel1.Visible = false;
                bunifuGradientPanel1.Width = 50;
                bunifuImageButton1.Location = new Point(5, 0);

                bunifuTransition1.ShowSync(bunifuGradientPanel1);
               

            }
        }
    }
}
