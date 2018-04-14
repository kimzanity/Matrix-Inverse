
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
            mma = mma * 1;
            mmb = mmb * -1;
            mmc = mmc * -1;
            mmd = mmd * 1;
            s();
        }
        public void s()
        {
            sa = mma;
            sb = mmc;
            sc = mmb;
            sd = mmd;
            ans();
        }
        public void ans()
        {
            sa = sa / det;
            sb = sb / det;
            sc = sc / det;
            sd = sd / det;
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
        public double gdet()
        {
            return this.det;
        }
    }
    }

