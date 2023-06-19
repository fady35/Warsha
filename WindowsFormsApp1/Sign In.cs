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
    public partial class Sign_In : Form
    {
        int move;
        int movx;
        int movy;
        public Sign_In()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    textBox1.Text = "Password";
                    return;
                }
                textBox2.ForeColor = Color.White;
                textBox2.PasswordChar = '*';
                labpassword.Visible = false;
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "User Name";
                    return;
                }
                textBox1.ForeColor = Color.White;
                labusername.Visible = false;
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="User Name")
            {
                labusername.Visible = true;
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "Password")
            {
                labpassword.Visible = true;
                textBox2.Focus();
                return;
            }
            if (textBox3.Text == "Phone No.")
            {
                labphone.Visible = true;
                textBox3.Focus();
                return;
            }
            if (textBox4.Text == "Address")
            {
                labaddress.Visible = true;
                textBox4.Focus();
                return;
            }
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty && textBox3.Text != String.Empty && textBox4.Text != String.Empty)
            {
              var c =  this.uSERNAMEWTableAdapter.GetDataBy1(textBox1.Text);
                if (c.Count == 0)
                {
                    this.uSERNAMEWTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                    MainPage m1 = new MainPage();
                    this.Hide();
                    m1.Show();
                }
                else if (c.Count == 1)
                {
                    MessageBox.Show("SIGN IN FAILED USERNAME ALREADY USED");
                }
            }

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.SelectAll();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.SelectAll();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "")
                {
                    textBox3.Text = "Phone No.";
                    return;
                }
                textBox1.ForeColor = Color.White;
                labphone.Visible = false;
            }
            catch
            {

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text == "")
                {
                    textBox4.Text = "Address";
                    return;
                }
                textBox1.ForeColor = Color.White;
                labaddress.Visible = false;
            }
            catch
            {

            }
        }

        private void panel10_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel10_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labpassword_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labusername_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labaddress_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labphone_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login log_In = new login();
            log_In.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signinwar war=new signinwar();
            this.Hide();
            war.Show();
        }

        private void Sign_In_Load(object sender, EventArgs e)
        {

        }
    }
}
