using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cars : Form
    {
        int move;
        int movx;
        int movy;
        public Cars()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Center center = new Center();
            center.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var x = this.wARSHA1TableAdapter.GetDataBy1(cars1.Text);
                if (x.Count == 0)
                {
                    MessageBox.Show("Not Found");
                }
                else
                {
                    this.Hide();
                    string taxno = x.First().TAXNO;
                    MercWarsha1 m2 = new MercWarsha1();
                    m2.loaddata(taxno);
                    m2.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile pr = new profile();
            pr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile pr = new profile();
            pr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Cars_Load_2(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-7707DF4; Initial Catalog = WARSHADB; Integrated Security = True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT SPECIALITY FROM dbo.WARSHA1";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cars1.Items.Add(reader["SPECIALITY"].ToString());
            }

            // Close the database connection and the SqlDataReader object
            reader.Close();
            connection.Close();

        }
    }
}
