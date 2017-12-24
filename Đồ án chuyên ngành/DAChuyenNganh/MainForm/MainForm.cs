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
        int soancauhoi = 0;
        int soandethi = 0;
        int danhsachcauhoi = 0;
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
        
        private void btnSoanCauHoi_Click(object sender, EventArgs e)
        {
            soancauhoi = 1;
            soandethi = 0;
           if(SoanCauHoi.listCauHoi.Count>0)
            {
                if (MessageBox.Show("Dữ liệu các câu hỏi chưa được lưu sẽ bị mất, bạn đã chắc chắn chưa?","Cảnh báo",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SoanCauHoi.listCauHoi.Clear();
                    SoanCauHoi _panelCauHoi = new SoanCauHoi();
                    if (!MainPanel.Controls.Contains(_panelCauHoi))
                    {
                        MainPanel.Controls.Clear();
                        MainPanel.Controls.Add(_panelCauHoi);
                        _panelCauHoi.SoanCauHoiInit();
                    }
                }
            }
           else
            {
                SoanCauHoi _panelCauHoi = new SoanCauHoi();
                if (!MainPanel.Controls.Contains(_panelCauHoi))
                {
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(_panelCauHoi);
                    _panelCauHoi.SoanCauHoiInit();
                }
            }
            

        }

        //Menu Soạn đề thi
        SoanCauHoi _panelDeThi = new SoanCauHoi();
        private void btnSoanDeThi_Click(object sender, EventArgs e)
        {
            if (soancauhoi==1)
            {
                soancauhoi = 0;
                if (SoanCauHoi.listCauHoi.Count > 0)
                {
                    if (MessageBox.Show("Dữ liệu các câu hỏi chưa được lưu sẽ bị mất, bạn đã chắc chắn chưa?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SoanCauHoi.listCauHoi.Clear();
                        _panelDeThi = new SoanCauHoi();
                        if (!MainPanel.Controls.Contains(_panelDeThi))
                        {

                            MainPanel.Controls.Clear();
                            MainPanel.Controls.Add(_panelDeThi);
                            _panelDeThi.SoanDeInit();
                        }
                    }
                }
                else
                {
                    SoanCauHoi.listCauHoi.Clear();
                    _panelDeThi = new SoanCauHoi();
                    if (!MainPanel.Controls.Contains(_panelDeThi))
                    {

                        MainPanel.Controls.Clear();
                        MainPanel.Controls.Add(_panelDeThi);
                        _panelDeThi.SoanDeInit();
                    }
                }
                   
            }
            else
            {
                
                if (!MainPanel.Controls.Contains(_panelDeThi))
                {

                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(_panelDeThi);
                    _panelDeThi.SoanDeInit();
                }
            }
            
            
        }

        //Menu Thư viện đề thi
        DanhSachDeThi _panelListDeThi = new DanhSachDeThi();
        private void btnThuVienDeThi_Click(object sender, EventArgs e)
        {
            if(soancauhoi==1)
            {
                soancauhoi = 0;
                SoanCauHoi.listCauHoi.Clear();
            }
            if (!MainPanel.Controls.Contains(_panelListDeThi))
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(_panelListDeThi);
                _panelListDeThi.Showdethi = ShowDethi;
            }
        }

        //Menu Thư viện câu hỏi
        DanhSachCauHoi _panelListCauHoi = new DanhSachCauHoi();
        private void btnThuVienCauHoi_Click(object sender, EventArgs e)
        {
            if (soancauhoi == 1)
            {
                soancauhoi = 0;
                SoanCauHoi.listCauHoi.Clear();
            }
            if (!MainPanel.Controls.Contains(_panelListCauHoi))
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(_panelListCauHoi);
                _panelListCauHoi.thamkhaoCauHoi = AddCauCauHoi;
            }

        }

        private void ShowDethi(List<CauHoi> listCauHoi)
        {
            _panelDeThi = new SoanCauHoi();
            SoanCauHoi.listCauHoi.Clear();
            if (!MainPanel.Controls.Contains(_panelDeThi))
            {

                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(_panelDeThi);
                _panelDeThi.SoanDeInit();
                _panelDeThi.ShowDeThi(listCauHoi);
            }
        }
      
        private void AddCauCauHoi(CauHoi cauhoi)
        {
            if (!MainPanel.Controls.Contains(_panelDeThi))
            {

                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(_panelDeThi);
                _panelDeThi.SoanDeInit();
                _panelDeThi.AddCauHoi(cauhoi);
            }
            
        }
    }
}
