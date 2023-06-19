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
    public partial class BMWarsha1 : Form
    {
        int move;
        int movx;
        int movy;
        public BMWarsha1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cars cars = new Cars();
            cars.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Center center = new Center();
            center.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Center c = new Center();
            c.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel7_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
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

        public void loaddata(string x)
        {

            var m = this.wARSHA1TableAdapter.GetDataByTAXNO(x);
            label1.Text = m.First().WARSHANAME;
            label16.Text = m.First().OWNERNAME;
            label4.Text = m.First().PHONENO;
            label17.Text = m.First().ADDRESS;
            label8.Text = m.First().SPECIALITY;


        }
    }
}
