using System;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[0];
            double b = 0;
            int i = 0;
            Console.WriteLine("Enter numbers.Enter -1 for end.");
            do
            {
                try
                {
                    b = Double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format Exception");
                    continue;
                }
                
                Array.Resize(ref a, a.Length + 1);
                a[i] = b;
                i++;
            } while (b!=-1);
            i = Search_index(a);
            Console.WriteLine();
            Console.WriteLine(i);
            Console.ReadKey();
        }

        static int Search_index(double [] a)
        {            
            double l = 0;
            double r = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j >=0; j--)
                {
                    if (j == i) continue;
                    l += a[j];
                }
                for (int j = i; j < a.Length; j++)
                {
                    if (j == i) continue;
                    r += a[j];
                }
                if (l == r) return i;
                else
                {
                    l = 0;
                    r = 0;
                }
            }

            return -1;
        }
    }
}
