﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FIRSTFORM : Form
    {
        public FIRSTFORM()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
       

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LOGINWHARcs m = new LOGINWHARcs();
            m.Show();
        }
    }
}
