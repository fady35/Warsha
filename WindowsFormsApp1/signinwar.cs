using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class signinwar : Form
    {
        public signinwar()
        {
            InitializeComponent();
        }
        private void addusercontrol(UserControl userControl)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Center cent = new Center();
            this.wARSHA1TableAdapter.InsertQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            this.Hide();
            cent.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login lol = new login();
            this.Hide();
            lol.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_In i = new Sign_In();
            this.Hide();
            i.Show();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login l=new login();
            this.Hide();
            l.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_In i = new Sign_In();
            this.Hide();
            i.Show();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
