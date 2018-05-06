
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix101
{
    class i
    {
        double a, b, c, d;
        double det;
        double mma, mmb, mmc, mmd;
        double sa, sb, sc, sd;
        double na, nb, nc, nd;
        double ssa, ssb, ssc, ssd;
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
        public void Det()
        {
            det = (a * d) - (b * c);
        }
        public void MatrixMinors()
        {
            mma = d;
            mmb = c;
            mmc = b;
            mmd = a;
            nega();
        }
        public void nega()
        {
            na = mma * 1;
            nb = mmb * -1;
            nc = mmc * -1;
            nd = mmd * 1;
            s();
        }
        public void s()
        {
            sa = na;
            sc = nb;
            sb = nc;
            sd = nd;
            ans();
        }
        public void ans()
        {
            ssa = sa / det;
            ssb = sb / det;
            ssc = sc / det;
            ssd = sd / det;
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
        public double gdet()
        {
            return this.det;
        }
        public double getmma()
        {
            return this.mma;
        }
        public double getmmb()
        {
            return this.mmb;
        }
        public double getmmc()
        {
            return this.mmc;
        }
        public double getmmd()
        {
            return this.mmd;
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
    }

}