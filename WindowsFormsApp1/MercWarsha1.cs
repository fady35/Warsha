using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MercWarsha1 : Form
    {
        int move;
        int movx;
        int movy;
        public MercWarsha1()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Center c = new Center();
            c.Show();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        

        

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
        public void loaddata(string x)
        {
            var m = this.wARSHA1TableAdapter.GetDataByTAXNO(x);
            label1.Text = m.First().WARSHANAME;
            label16.Text = m.First().OWNERNAME;
            label4.Text = m.First().PHONENO;
            label17.Text = m.First().ADDRESS;
            label8.Text = m.First().SPECIALITY;
            label10.Text = m.First().TAXNO;


        }

     
    }
}
