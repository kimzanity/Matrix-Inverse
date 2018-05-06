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
    public partial class three : UserControl
    {
        public three()
        {
            InitializeComponent();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            lala.Text = "Inverse";
            t kim = new t();
            try
            {
                double ta = double.Parse(a.Text);
                double tb = double.Parse(b.Text);
                double tc = double.Parse(c.Text);
                double td = double.Parse(d.Text);
                double te = double.Parse(ewan.Text);
                double tf = double.Parse(f.Text);
                double tg = double.Parse(g.Text);
                double th = double.Parse(h.Text);
                double ti = double.Parse(i.Text);

                kim.SetA(ta);
                kim.SetB(tb);
                kim.SetC(tc);
                kim.SetD(td);
                kim.SetE(te);
                kim.SetF(tf);
                kim.SetG(tg);
                kim.SetH(th);
                kim.SetI(ti);

                kim.Det();
                if (kim.gdet() == 0)
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
                    ee.Text = "" + kim.ge();
                    ff.Text = "" + kim.gf();
                    gg.Text = "" + kim.gg();
                    hh.Text = "" + kim.gh();
                    ii.Text = "" + kim.gi();
                }
                
            
            }
            catch (Exception)
            {

                MessageBox.Show("You inputed incomplete data!");
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            a.Text = "";
            b.Text = "";
            c.Text = "";
            d.Text = "";
            ewan.Text = "";
            f.Text = "";
            g.Text = "";
            h.Text = "";
            i.Text = "";
            aa.Text = "";
            bb.Text = "";
            cc.Text = "";
            dd.Text = "";
            ee.Text = "";
            ff.Text = "";
            gg.Text = "";
            hh.Text = "";
            ii.Text = "";
           
        }

        private void a_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void b_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void c_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void d_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ewan_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void f_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void g_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void h_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void i_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            lala.Text = "Cofactors";
            t kim = new t();
            try
            {
                double ta = double.Parse(a.Text);
                double tb = double.Parse(b.Text);
                double tc = double.Parse(c.Text);
                double td = double.Parse(d.Text);
                double te = double.Parse(ewan.Text);
                double tf = double.Parse(f.Text);
                double tg = double.Parse(g.Text);
                double th = double.Parse(h.Text);
                double ti = double.Parse(i.Text);

                kim.SetA(ta);
                kim.SetB(tb);
                kim.SetC(tc);
                kim.SetD(td);
                kim.SetE(te);
                kim.SetF(tf);
                kim.SetG(tg);
                kim.SetH(th);
                kim.SetI(ti);

                kim.Det();
                if (kim.gdet() == 0)
                {
                    MessageBox.Show("Determinant is 0 can't perform the operation");
                }
                else
                {
                    kim.MatrixMinors();

                    aa.Text = "" + kim.getna();
                    bb.Text = "" + kim.getnb();
                    cc.Text = "" + kim.getnc();
                    dd.Text = "" + kim.getnd();
                    ee.Text = "" + kim.getne();
                    ff.Text = "" + kim.getnf();
                    gg.Text = "" + kim.getng();
                    hh.Text = "" + kim.getnh();
                    ii.Text = "" + kim.getni();
                }


            }
            catch (Exception)
            {

                MessageBox.Show("You inputed incomplete data!");
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            lala.Text = "Matrix Minors";
            t kim = new t();
            try
            {
                double ta = double.Parse(a.Text);
                double tb = double.Parse(b.Text);
                double tc = double.Parse(c.Text);
                double td = double.Parse(d.Text);
                double te = double.Parse(ewan.Text);
                double tf = double.Parse(f.Text);
                double tg = double.Parse(g.Text);
                double th = double.Parse(h.Text);
                double ti = double.Parse(i.Text);

                kim.SetA(ta);
                kim.SetB(tb);
                kim.SetC(tc);
                kim.SetD(td);
                kim.SetE(te);
                kim.SetF(tf);
                kim.SetG(tg);
                kim.SetH(th);
                kim.SetI(ti);

                kim.Det();
                if (kim.gdet() == 0)
                {
                    MessageBox.Show("Determinant is 0 can't perform the operation");
                }
                else
                {
                    kim.MatrixMinors();

                    aa.Text = "" + kim.getma();
                    bb.Text = "" + kim.getmb();
                    cc.Text = "" + kim.getmc();
                    dd.Text = "" + kim.getmd();
                    ee.Text = "" + kim.getme();
                    ff.Text = "" + kim.getmf();
                    gg.Text = "" + kim.getmg();
                    hh.Text = "" + kim.getmh();
                    ii.Text = "" + kim.getmi();
                }


            }
            catch (Exception)
            {

                MessageBox.Show("You inputed incomplete data!");
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            lala.Text = "Adjugate";
            t kim = new t();
            try
            {
                double ta = double.Parse(a.Text);
                double tb = double.Parse(b.Text);
                double tc = double.Parse(c.Text);
                double td = double.Parse(d.Text);
                double te = double.Parse(ewan.Text);
                double tf = double.Parse(f.Text);
                double tg = double.Parse(g.Text);
                double th = double.Parse(h.Text);
                double ti = double.Parse(i.Text);

                kim.SetA(ta);
                kim.SetB(tb);
                kim.SetC(tc);
                kim.SetD(td);
                kim.SetE(te);
                kim.SetF(tf);
                kim.SetG(tg);
                kim.SetH(th);
                kim.SetI(ti);

                kim.Det();
                if (kim.gdet() == 0)
                {
                    MessageBox.Show("Determinant is 0 can't perform the operation");
                }
                else
                {
                    kim.MatrixMinors();

                    aa.Text = "" + kim.getsa();
                    bb.Text = "" + kim.getsb();
                    cc.Text = "" + kim.getsc();
                    dd.Text = "" + kim.getsd();
                    ee.Text = "" + kim.getse();
                    ff.Text = "" + kim.getsf();
                    gg.Text = "" + kim.getsg();
                    hh.Text = "" + kim.getsh();
                    ii.Text = "" + kim.getsi();
                }


            }
            catch (Exception)
            {

                MessageBox.Show("You inputed incomplete data!");
            }
        }
    }
}
