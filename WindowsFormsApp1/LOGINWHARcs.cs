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
    public partial class LOGINWHARcs : Form
    {
        public LOGINWHARcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "User Name")
            {
                labusername.Visible = true;
                textBox1.Focus();
                return;
            }
           else if (textBox2.Text == "Password")
            {
                labpassword.Visible = true;
                textBox2.Focus();
                return;
            }

            var c = this.wARSHA1TableAdapter.loginwharsh(textBox1.Text,textBox2.Text);
            if (c.Count == 0)
            {
                labusername.Visible = true;
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

        private void labusername_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
