using System;
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
    public partial class Mercedes : Form
    {
        int move;
        int movx;
        int movy;
        public Mercedes()
        {
            InitializeComponent();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Center center = new Center();
            center.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cars cars = new Cars();
            cars.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MercWarsha1 mercWarsha1 = new MercWarsha1();
            mercWarsha1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MercWarsha1 mercWarsha1 = new MercWarsha1();
            mercWarsha1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MercWarsha1 mercWarsha1 = new MercWarsha1();
            mercWarsha1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile pr = new profile();
            pr.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile pr = new profile();
            pr.Show();
        }
    }
}
