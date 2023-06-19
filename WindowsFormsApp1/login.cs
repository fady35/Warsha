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
    public partial class login : Form
    {
        int move;
        int movx;
        int movy;
        public login()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    textBox1.Text = "Password";
                    return;
                }
                textBox2.ForeColor = Color.White;
                textBox2.PasswordChar ='*';
                label4.Visible = false;
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "User Name";
                    return;
                }
                textBox1.ForeColor = Color.White;
                label3.Visible = false;
            }
            catch
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "User Name")
            {
                label3.Visible = true;
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "Password")
            {
                label4.Visible = true;
                textBox2.Focus();
                return;
            }
            //if (textBox1.Text != String.Empty && textBox2.Text != String.Empty)
            //{
            //    this.Hide();
            //    MainPage mainPage = new MainPage();
            //    mainPage.Show();
            //}
            var c = this.uSERNAMEWTableAdapter.GetDataBylog(textBox1.Text,textBox2.Text);
            if (c.Count == 0)
            {
                label4.Visible = true;
                textBox2.Focus();
                return;
            }
            else if (c.Count == 1)
            { 
                MainPage m1 = new MainPage();
                this.Hide();
                m1.Show();
               
            }
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        

        private void bunifuImageButton6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }



        private void linkLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Sign_In sign_In = new Sign_In();
                sign_In.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            move=0;
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if(move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx , MousePosition.Y - movy);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signinwar war = new signinwar();
            this.Hide();
            war.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_In i = new Sign_In();
            this.Hide();
            i.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
