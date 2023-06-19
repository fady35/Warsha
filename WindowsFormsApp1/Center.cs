using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Center : Form
    {
        int move;
        int movx;
        int movy;
        public Center()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile pr = new profile();
            pr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cars cars = new Cars();
            cars.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            AudiWarsha1 audiWarsha1 = new AudiWarsha1();
            audiWarsha1.Show();

        }
        private int myVariable;
        public int MyVariable
        {
            get { return myVariable; }
            set { myVariable = value; }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var x = this.wARSHA1TableAdapter.searchbyname(label1.Text);
            if (x.Count == 0)
            {
                MessageBox.Show("Not Found");
            }
            else
            {
                string taxno =x.First().TAXNO;
                this.Hide();
                MercWarsha1 m2 = new MercWarsha1();
                m2.loaddata(taxno);
                m2.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var x = this.wARSHA1TableAdapter.searchbyname(label6.Text);
            if (x.Count == 0)
            {
                MessageBox.Show("Not Found");
            }
            else
            {
                MercWarsha1 m1 = new MercWarsha1();
                m1.loaddata("192837465");
                this.Hide();
                m1.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var x = this.wARSHA1TableAdapter.searchbyname(label9.Text);
            if (x.Count == 0)
            {
                MessageBox.Show("Not Found");
            }
            else
            {
                MercWarsha1 m1 = new MercWarsha1();
                m1.loaddata("87654321");
                this.Hide();
                m1.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var x = this.wARSHA1TableAdapter.searchbyname(label6.Text);
            if (x.Count == 0)
            {
                MessageBox.Show("Not Found");
            }
            else
            {
                myVariable = 1;
                BMWarsha1 m1 = new BMWarsha1();
                m1.loaddata("1234512678");
                this.Hide();
                m1.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var x = this.wARSHA1TableAdapter.searchbyname(label15.Text);
            if (x.Count == 0)
            {
                MessageBox.Show("Not Found");
            }
            else
            {
                myVariable = 1;
                BMWarsha1 m1 = new BMWarsha1();
                m1.loaddata("1234512678");
                m1.ShowDialog();
            }



        }

        private void button9_Click(object sender, EventArgs e)
        {
            MainPage m2 = new MainPage();
            this.Hide();
            m2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            profile p1=new profile();
            this.Hide();
            p1.Show();
        }
    }
}
