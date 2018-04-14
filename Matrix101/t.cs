using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix101
{
    class t
    {
         double a, b, c, d, e, f, g, h, i;
        double det;
        double mma, mmb, mmc, mmd, mme, mmf, mmg, mmh, mmi;
        double sa, sb, sc, sd, se, sf, sg, sh, si;
        public void SetA(double a)
        {
            this.a = a;
        }
        public void SetB(double b)
        {
            this.b = b;
        }
        public void SetC(double c)
        {
            this.c = c;
        }
        public void SetD(double d)
        {
            this.d = d;
        }
        public void SetE(double e)
        {
            this.e = e;
        }
        public void SetF(double f)
        {
            this.f = f;
        }
        public void SetG(double g)
        {
            this.g = g;
        }
        public void SetH(double h)
        {
            this.h = h;
        }
        public void SetI(double i)
        {
            this.i = i;
        }
        public void Det()
        {
            det = (a * (e * i) - (f * h)) - (b * (d * i) - (f * g)) + (c * (d * h) - (e * g));
        }
        public void MatrixMinors()
        {
            mma = (e * i) - (f * h);
            mmb = (d * i) - (f * g);
            mmc = (d * h) - (e * g);
            mmd = (b * i) - (c * h);
            mme = (a * i) - (c * g);
            mmf = (a * h) - (b * g);
            mmg = (b * f) - (c * h);
            mmh = (a * f) - (c * d);
            mmi = (a * e) - (b * d);
            nega();
        }
        public void nega()
        {
            mma = mma * 1;
            mmb = mmb * -1;
            mmc = mmc * 1;
            mmd = mmd * -1;
            mme = mme * 1;
            mmf = mmf * -1;
            mmg = mmg * 1;
            mmh = mmh * -1;
            mmi = mmi * 1;
            s();

        }
        public void s()
        {
            sa = mma;
            sb = mmd;
            sc = mmg;
            sd = mmb;
            se = mme;
            sf = mmh;
            sg = mmc;
            sh = mmf;
            si = mmi;
            ans();

        }
        public void ans()
        {
            sa = sa / det;
            sb = sb / det;
            sc = sc / det;
            sd = sd / det;
            se = se / det;
            sf = sf / det;
            sg = sg / det;
            sh = sh / det;
            si = si / det;

        }
        public double ga()
        {
            return this.sa;
        }
        public double gb()
        {
            return this.sb;
        }
        public double gc()
        {
            return this.sc;
        }
        public double gd()
        {
            return this.sd;
        }
        public double ge()
        {
            return this.se;
        }
        public double gf()
        {
            return this.sf;
        }
        public double gg()
        {
            return this.sg;
        }
        public double gh()
        {
            return this.sh;
        }
        public double gi()
        {
            return this.si;
        }
        public double gdet()
        {
            return this.det;
        }

    }
    }

