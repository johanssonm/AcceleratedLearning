using System;
using System.Diagnostics;
using System.Text;

namespace Modul5
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("Write a string: ");
            var repeatme = Console.ReadLine();

            Console.WriteLine("Write amount: ");
            int cycles = Convert.ToInt32(Console.ReadLine());



            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            GenerateString_sb(repeatme, cycles);
            stopwatch.Stop();

            var time = stopwatch.ElapsedMilliseconds;

        }

        static string GenerateString_sb(string repeatme, int cycles)
        {

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < cycles; i++)
            {
                sb.Append(repeatme);
            }

            return sb.ToString();

        }

    }
}
