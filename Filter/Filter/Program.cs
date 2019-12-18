using System;

namespace Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[13];
            Console.WriteLine("Enter 13 numbers:");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i]=Int32.Parse(Console.ReadLine());
            }
            int b;
            Console.WriteLine("Enter number for filter:");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            mas = FilterDigit(mas,13, b);
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();
        }

        static int[] FilterDigit(int[] a, int n, int b)
        {
            int j = 0;
            int[] res = new int[j];
            for (int i=0; i<n; i++)
            {
                if (IfDigit(a[i], b))
                {
                    j++;
                    Array.Resize(ref res, res.Length + 1);
                    res[j - 1] = a[i];
                }
            }

            return res;
        }

        static bool IfDigit(int a, int b)
        {
            while (a != 0)
            {
                if (a % 10 != b)
                {
                    a = (a - (a % 10)) / 10;
                }
                else return true;
            }

            return false;
        }
    }
}
