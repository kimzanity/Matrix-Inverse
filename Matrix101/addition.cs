using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix101
{
    class addition
    {
        int a, b, c, d, aa, bb, cc, dd, aaa, bbb, ccc, ddd;
        public void Seta(int a)
        {
            this.a = a;
        }
        public void Setb(int b)
        {
            this.b = b;
        }
        public void Setc(int c)
        {
            this.c = c;
        }
        public void Setd(int d)
        {
            this.d = d;
        }
        public void Setaa(int aa)
        {
            this.aa = aa;
        }
        public void Setbb(int bb)
        {
            this.bb = bb;
        }
        public void Setcc(int cc)
        {
            this.cc = cc;
        }
        public void Setdd(int dd)
        {
            this.dd = dd;
        }
        public void Setaaa(int aaa)
        {
            this.aaa = aaa;
        }
        public void Setbbb(int bbb)
        {
            this.bbb = bbb;
        }
        public void Setccc(int ccc)
        {
            this.ccc = ccc;
        }
        public void Setddd(int ddd)
        {
            this.ddd = ddd;
        }
        public void sum()
        {
            aaa = a + aa;
            bbb = b + bb;
            ccc = c + cc;
            ddd = d + dd;
        }
        public int getA()
        {
            return this.aaa;
        }
        public int getB()
        {
            return this.bbb;
        }
        public int getC()
        {
            return this.ccc;
        }
        public int getD()
        {
            return this.ddd;
        }
    }
}
