using System;

namespace ExtendT
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            Console.WriteLine("Input number.");
            try
            {
               a = Double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException. Number now is 0.");
            }
            Console.WriteLine(a.StrView());
            Console.ReadKey();
        }
    }

    public static class DoubleExtend
    {
        public static string StrView (this double d)
        {
            int st = 0;
            if (d < 1)
            {
                while (d < 1)
                {
                    d = d * 10;
                    st++;
                }
            }
            if (d > 10)
            {
                while (d > 10)
                {
                    d = d / 10;
                    st--;
                }
            }
            string s = d + "10^(" + st + ")";
            return s;
        }
    }
}
