using System;

namespace lib1_Practica
{
    //lib1_Z1
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод а");
            string a = Console.ReadLine();
            Console.WriteLine("Ввод b");
            int b = Convert.ToInt32(Console.ReadLine());

            lib1.stpow(a, b);

            lib1.rev(a);

            Console.WriteLine("Ввод слова");
            string str = Console.ReadLine();
            Console.WriteLine("Ввод буквы");
            string s = Console.ReadLine();

            lib1.remov(str, s);
            lib1.leng(str);
        }


        class lib1
        {
            public static void stpow(string a, int b)
            {
                string rez1 = "";
                for (int i = 1; i <= b; i++)
                {
                    rez1 = rez1 + a;
                }
                Console.WriteLine(rez1);
            }
            public static void rev(string a)
            {
                string rev = string.Empty;
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    rev += a[i];
                }
                Console.WriteLine(rev);
            }
            public static void remov(string str, string s)
            {
                str = str.Replace(s, "");
                Console.WriteLine(str);
            }
            public static void leng(string str)
            {
                int strlen = str.Length;
                Console.WriteLine(strlen);
            }
        }
    }
}
