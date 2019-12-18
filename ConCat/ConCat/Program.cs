using System;

namespace ConCat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 strings:");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            
            Console.WriteLine(ResFunc(a, b));
            Console.ReadKey();
        }

        static string ResFunc (string a, string b)
        {
            string s = "";
            s = ConC(a,s);
            s = ConC(b, s);
            return s;
        }

        static string ConC(string a, string s)
        {
            bool f = false;
            for (int i = 0; i < a.Length; i++)
            {
                f = false;
                for (int j = 0; j < s.Length; j++)
                {
                    if (a[i] == s[j])
                    {
                        f = true;
                        break;
                    }
                }
                if (!f) s += a[i];
            }
            return s;
        }
    }
}
