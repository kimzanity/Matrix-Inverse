using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix101
{
    public partial class two : UserControl
    {
        public two()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            a.Text = "";
            b.Text = "";
            c.Text = "";
            d.Text = "";
            aa.Text = "";
            bb.Text = "";
            cc.Text = "";
            dd.Text = "";
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            i kim = new i();
            try
            {
                double ta = double.Parse(a.Text);
                double tb = double.Parse(b.Text);
                double tc = double.Parse(c.Text);
                double td = double.Parse(d.Text);

                kim.SetA(ta);
                kim.SetB(tb);
                kim.SetC(tc);
                kim.SetD(td);

                kim.Det();
                if (kim.gdet()==0)
                {
                    MessageBox.Show("Determinant is 0 can't perform the operation");
                }
                else
                {
                    kim.MatrixMinors();

                    aa.Text = "" + kim.ga();
                    bb.Text = "" + kim.gb();
                    cc.Text = "" + kim.gc();
                    dd.Text = "" + kim.gd();
                }
               
            }
            catch (Exception)
            {

                MessageBox.Show("You inputed incomplete data!");
            }
        }

        private void aa_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void d_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void aa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void b_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }
    }
}
