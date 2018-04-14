using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            BunifuImageButton3.Show();
            BunifuImageButton4.Hide();
            two1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BunifuImageButton3.Show();
            BunifuImageButton4.Hide();
            bunifuImageButton5.Hide();
            bunifuImageButton6.Hide();
            two1.BringToFront();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
            BunifuImageButton4.Show();
            BunifuImageButton3.Hide();
            bunifuImageButton5.Hide();
            three1.BringToFront();
            bunifuImageButton6.Hide();
            two1.Refresh();

        }

        private void three1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            add1.BringToFront();
            BunifuImageButton3.Hide();
            BunifuImageButton4.Hide();
            bunifuImageButton5.Show();
            bunifuImageButton6.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            about1.BringToFront();
            BunifuImageButton3.Hide();
            BunifuImageButton4.Hide();
            bunifuImageButton5.Hide();
            bunifuImageButton6.Show();
        }
    }
}
