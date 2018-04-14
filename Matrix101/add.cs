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
    public partial class add : UserControl
    {
        public add()
        {
            InitializeComponent();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            addition kim = new addition();
            try
            {
                int na = int.Parse(a.Text);
                int nb = int.Parse(b.Text);
                int nc = int.Parse(c.Text);
                int nd = int.Parse(d.Text);
                int nna = int.Parse(aa.Text);
                int nnb = int.Parse(bb.Text);
                int nnc = int.Parse(cc.Text);
                int nnd = int.Parse(dd.Text);

                kim.Seta(na);
                kim.Setb(nb);
                kim.Setc(nc);
                kim.Setd(nd);
                kim.Setaa(nna);
                kim.Setbb(nnb);
                kim.Setcc(nnc);
                kim.Setdd(nnd);

                kim.sum();

                aaa.Text = "" + kim.getA();
                bbb.Text = "" + kim.getB();
                ccc.Text = "" + kim.getC();
                ddd.Text = "" + kim.getD();
            }
            catch (Exception)   
            {

                MessageBox.Show("You inputed incomplete data!");
            }
        }
    }
}
