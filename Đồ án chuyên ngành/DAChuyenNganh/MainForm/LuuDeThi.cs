﻿using DevComponents.DotNetBar;
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
    public partial class LuuDeThi : Form
    {
        public LuuDeThi()
        {
            InitializeComponent();
        }

        private void LuuDeThi_Load(object sender, EventArgs e)
        {
            txtTenDeThi.Text = "";
            //MessageBox.Show(String.Format("{0:dd/MM/yyyy}", NgayThi.Value));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
