using System;

namespace Evklid
{
    public class Class1
    {
        private int[] a;

        public Class1(int[] b)
        {
            a = b;
        }

        public int res_gdc()
        {
            int res = 1;
            for (int i = 1; i < a.Length; i++)
            {
                if (i == 1)
                {
                    res = gdc(a[0], a[1]);
                    continue;
                }
                res = gdc(res, a[i]);
            }

            return res;
        }

        static int gdc(int a, int b)

        {

            int shift = 0;

            if (a == 0) return b;

            if (b == 0) return a;

            if (a == b) return b;

            if ((a % 2 == 0) && (b % 2 == 0)) shift = 2 * gdc(a / 2, b / 2);

            if ((a % 2 != 0) && (b % 2 == 0)) shift = gdc(a, b / 2);

            if ((a % 2 == 0) && (b % 2 != 0)) shift = gdc(a / 2, b);

            if (((a % 2 != 0) && (b % 2 != 0)) && a > b) shift = gdc((a - b) / 2, b);

            if (((a % 2 != 0) && (b % 2 != 0)) && a < b) shift = gdc((b - a) / 2, a);



            return shift;

        }
    }
}
