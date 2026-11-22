using System;
using System.Diagnostics;
using System.Text;

namespace Lab4_Block1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть n: ");
            int n = int.Parse(Console.ReadLine());

            Stopwatch sw = new Stopwatch();

            sw.Restart();
            string res1 = "";
            for (int i = 1; i <= n; i++)
            {
                if (i == 1) res1 += i;
                else res1 += " " + i;
            }
            sw.Stop();
            Console.WriteLine($"Версія 1 (string += у кінець): {sw.ElapsedMilliseconds} мс");

            sw.Restart();
            string res2 = "";
            for (int i = n; i >= 1; i--)
            {
                if (i == n) res2 = i.ToString();
                else res2 = i + " " + res2;
            }
            sw.Stop();
            Console.WriteLine($"Версія 2 (string + у початок): {sw.ElapsedMilliseconds} мс");

            sw.Restart();
            StringBuilder sb3 = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                if (i > 1) sb3.Append(' ');
                sb3.Append(i);
            }
            string res3 = sb3.ToString();
            sw.Stop();
            Console.WriteLine($"Версія 3 (StringBuilder.Append): {sw.ElapsedMilliseconds} мс");

            sw.Restart();
            StringBuilder sb4 = new StringBuilder();
            for (int i = n; i >= 1; i--)
            {
                if (i < n) sb4.Insert(0, ' ');
                sb4.Insert(0, i);
            }
            string res4 = sb4.ToString();
            sw.Stop();
            Console.WriteLine($"Версія 4 (StringBuilder.Insert): {sw.ElapsedMilliseconds} мс");

            if (res1 == res2 && res2 == res3 && res3 == res4)
            {
                Console.WriteLine("Усі 4 рядки однакові!");
            }
        }
    }
}