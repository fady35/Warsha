using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class profile : Form
    {
        int move;
        int movx;
        int movy;
        public profile()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to update the user", "UPDATE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    uSERNAMEWTableAdapter.UpdateQuery(textBox2.Text, textBox3.Text, textBox4.Text, textBox1.Text);
                    MessageBox.Show("DATA HAS BEEN UPDATED");
                }
                catch
                {
                    MessageBox.Show("something went wrong");
                }
            }
            else
            {

            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
                var x = this.uSERNAMEWTableAdapter.GetDataBylog(textBox1.Text,textBox2.Text);
                if (x.Count == 1)
                {
                if (MessageBox.Show("are you sure you want to delete the user", "delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.uSERNAMEWTableAdapter.DeleteQuery(textBox1.Text, textBox2.Text);
                    MessageBox.Show("USERNAME HAS BEEN DELETED");
                    login l = new login();
                    this.Hide();
                    l.Show();
                }
                else
                {

                }
                }
                else if(x.Count == 0)
                {
                    MessageBox.Show("USERNAME DOSEN'T EXIST");
                }
            }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           var x = this.uSERNAMEWTableAdapter.GetDataBylog(textBox1.Text,textBox2.Text);
            if (textBox1.Text == null)
            {
                labusername.Visible = true;
                textBox1.Focus();
                return;
            }
            else if (textBox2.Text == null)
            {
                labpassword.Visible = true;
                textBox1.Focus();
                return;
            }
            else
            {
                try
                {
                    textBox3.Text = x.First().PHONENO;
                    textBox4.Text = x.First().ADDRESS;
                }
                catch
                {
                    MessageBox.Show("YOU HAVE TO ENTER BOTH USERNAEM AND PASSWORD");
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_In s = new Sign_In();
            this.Hide();
            s.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainPage m1 = new MainPage();
            this.Hide();
            m1.Show();
        }

        private void panel10_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
    }
