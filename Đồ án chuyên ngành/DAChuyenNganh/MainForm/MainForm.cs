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

        #region SplashScreen
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
        #endregion

        public MainForm()
        {
            ShowSplashScreen(false);
            InitializeComponent();
        
            #region Icon
            //Set icon
            Bitmap b =  Properties.Resources.SplashImage;
            IntPtr pIcon = b.GetHicon();
            Icon Ic = Icon.FromHandle(pIcon);
            this.Icon = Ic;
            Ic.Dispose();
            #endregion
        }



        private  void MainForm_Load(object sender, EventArgs e)
        {

            //MessageBox.Show(new LoginBus().Test());

        }

        #region   Controlbox
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximum_Click(object sender, EventArgs e)
        {
           

            if (WindowState != FormWindowState.Maximized)

                WindowState = FormWindowState.Maximized;

            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimum_Click(object sender, EventArgs e)
        {

            //Khi click minimize mà ko ẩn MainPanel thì bị exception , chả hiểu
            MainPanel.Visible = false;
            WindowState = FormWindowState.Minimized;
           
        }
        private void MainForm_ClientSizeChanged(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                //Khi show lại Form thì  hiện lại MainPanel
                MainPanel.Visible = true;
            }
        }
        #endregion

        private void ImageBtnMenu_Click(object sender, EventArgs e)
        {
           
            if (bunifuGradientPanelMenu.Size.Width == 50)
            {
                bunifuGradientPanelMenu.Size = new Size(180, bunifuGradientPanelMenu.Size.Height);
                ImageBtnMenu.Location = new Point(140, 0);
               
            }
            else
            {
                bunifuGradientPanelMenu.Size = new Size(50, bunifuGradientPanelMenu.Size.Height);
                ImageBtnMenu.Location = new Point(5, 0);
            }
           
            
        }




        //Menu Soạn Câu Hỏi
        SoanCauHoi _panel = new SoanCauHoi();
        private void btnSoanCauHoi_Click(object sender, EventArgs e)
        {

            if (!MainPanel.Controls.Contains(_panel))
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(_panel);
                _panel.SoanCauHoiInit();
            }
            
        }

        //Menu Soạn đề thi
        private void btnSoanDeThi_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            if (!MainPanel.Controls.Contains(_panel))
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(_panel);
                //_panel.SoanDeInit();
            }





        }

        //Menu Thư viện đề thi
        private void btnThuVienDeThi_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
        }

        //Menu Thư viện câu hỏi
        private void btnThuVienCauHoi_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Form1 f = new Form1();
                f.Show();
           
        }

      
    }
}
