using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class Drob
    {
        public int chisl;
        public int znam;

        public Drob(int chisl, int znam)
        {
            this.chisl = chisl;
            this.znam = znam;
            this.Sokr();
        }

        #region operations
        public Drob Summ(Drob d2)
        {
            Drob dresult = new Drob((chisl * d2.znam + d2.chisl * znam), (znam * d2.znam));
            return dresult;
        }

        public Drob Razn(Drob d2)
        {
            Drob dresult = new Drob((chisl * d2.znam - d2.chisl * znam), (znam * d2.znam));
            return dresult;
        }

        public Drob Mult(Drob d2)
        {
            Drob dresult = new Drob((chisl * d2.chisl), (znam * d2.znam));
            return dresult;
        }

        public Drob Del(Drob d2)
        {
            Drob dresult = new Drob((chisl * d2.znam), (znam * d2.chisl));
            return dresult;
        }
        #endregion


        #region functions

        public void Sokr()
        {
            int nod = NOD(chisl, znam);
            chisl = chisl / nod;
            znam = znam / nod;
        }

        private int NOD(int m, int n)
        {
            int nod = 1;
            m = Math.Abs(m);
            n = Math.Abs(n);

            while (m != n)
            {
                if (m > n)
                {
                    m = m - n;
                }
                else
                {
                    n = n - m;
                }
            }

            nod = Math.Abs(n);

            return nod;
        }

        public override string ToString()
        {
            string result = $"{this.chisl}/{this.znam}";
            return result;
        }
        #endregion


        #region operators
        public static Drob  operator+ (Drob d1, Drob d2)
        {
            Drob result = d1.Summ(d2);
            return result;
        }

        public static Drob operator- (Drob d1, Drob d2)
        {
            Drob result = d1.Razn(d2);
            return result;
        }

        public static Drob operator* (Drob d1, Drob d2)
        {
            Drob result = d1.Mult(d2);
            return result;
        }

        public static Drob operator/ (Drob d1, Drob d2)
        {
            Drob result = d1.Del(d2);
            return result;
        }
        #endregion
    }
}
