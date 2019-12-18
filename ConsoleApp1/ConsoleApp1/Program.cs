using System;
using Evklid;

namespace ConsoleApp1
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
                b=Int32.Parse(Console.ReadLine());
                Array.Resize(ref a, a.Length + 1);
                if (b!=0) a[i] = b;
                i++;
            } while (b!=0);
            Class1 ev = new Class1(a);
            Console.WriteLine();
            Console.WriteLine(ev.res_gdc());
            Console.ReadKey();
        }
    }
}
