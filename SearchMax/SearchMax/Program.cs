using System;

namespace SearchMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[0];
            Console.WriteLine("Enter array. Enter 0 for end.");
            int b = 0;
            int i = 0;
            do
            {
                b = Int32.Parse(Console.ReadLine());
                Array.Resize(ref a, a.Length + 1);
                a[i] = b;                
                i++;

            } while (b!=0);
            b = Search_Max(a);
            Console.WriteLine();
            Console.WriteLine(b);
            Console.ReadKey();
        }


    static int Search_Max(int[] a)
        {
            if (a.Length > 2)
            {
                int[] b = new int[a.Length/2];
                int[] c = new int[a.Length - a.Length / 2];
                int j = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (i < a.Length / 2)
                    {
                        b[i] = a[i];
                    }
                    else
                    {
                        c[j] = a[i];
                        j++;
                    }
                }
                int res_b = Search_Max(b);
                int res_c = Search_Max(c);
                if (res_b > res_c) return res_b;
                else return res_c;
            }
            if (a.Length == 2)
            {
                if (a[0] > a[1]) return a[0];
                else return a[1];
            }
            else return a[0];
        }
    }
}
