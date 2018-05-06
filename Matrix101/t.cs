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
        double ssa, ssb, ssc, ssd, sse, ssf, ssg, ssh, ssi;
        double na, nb, nc, nd, ne, nf, ng, nh, ni;
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
            det = (a * ((e * i) - (f * h))) - (b * ((d * i) - (f * g))) + (c * ((d * h) - (e * g)));
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
            na = mma * 1;
            nb = mmb * -1;
            nc = mmc * 1;
            nd = mmd * -1;
            ne = mme * 1;
            nf = mmf * -1;
            ng = mmg * 1;
            nh = mmh * -1;
            ni = mmi * 1;
            s();

        }
        public void s()
        {
            sa = na;
            sb = nd;
            sc = ng;
            sd = nb;
            se = ne;
            sf = nh;
            sg = nc;
            sh = nf;
            si = ni;
            ans();

        }
        public void ans()
        {
            ssa = sa / det;
            ssb = sb / det;
            ssc = sc / det;
            ssd = sd / det;
            sse = se / det;
            ssf = sf / det;
            ssg = sg / det;
            ssh = sh / det;
            ssi = si / det;

        }
        public double ga()
        {
            return this.ssa;
        }
        public double gb()
        {
            return this.ssb;
        }
        public double gc()
        {
            return this.ssc;
        }
        public double gd()
        {
            return this.ssd;
        }
        public double ge()
        {
            return this.sse;
        }
        public double gf()
        {
            return this.ssf;
        }
        public double gg()
        {
            return this.ssg;
        }
        public double gh()
        {
            return this.ssh;
        }
        public double gi()
        {
            return this.ssi;
        }
        public double gdet()
        {
            return this.det;
        }
        public double getma()
        {
            return this.mma;
        }
        public double getmb()
        {
            return this.mmb;
        }
        public double getmc()
        {
            return this.mmc;
        }
        public double getmd()
        {
            return this.mmd;
        }
        public double getme()
        {
            return this.mme;
        }
        public double getmf()
        {
            return this.mmf;
        }
        public double getmg()
        {
            return this.mmg;
        }
        public double getmh()
        {
            return this.mmh;
        }
        public double getmi()
        {
            return this.mmi;
        }
        public double getna()
        {
            return this.na;
        }
        public double getnb()
        {
            return this.nb;
        }
        public double getnc()
        {
            return this.nc;
        }
        public double getnd()
        {
            return this.nd;
        }
        public double getne()
        {
            return this.ne;
        }
        public double getnf()
        {
            return this.nf;
        }
        public double getng()
        {
            return this.ng;
        }
        public double getnh()
        {
            return this.nh;
        }
        public double getni()
        {
            return this.ni;
        }
        public double getsa()
        {
            return this.sa;
        }
        public double getsb()
        {
            return this.sb;
        }
        public double getsc()
        {
            return this.sc;
        }
        public double getsd()
        {
            return this.sd;
        }
        public double getse()
        {
            return this.se;
        }
        public double getsf()
        {
            return this.sf;
        }
        public double getsg()
        {
            return this.sg;
        }
        public double getsh()
        {
            return this.sh;
        }
        public double getsi()
        {
            return this.si;
        }
    }
    }

