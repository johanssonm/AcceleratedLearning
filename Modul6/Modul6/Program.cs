using System;

namespace Modul6
{

    class Program
    {
        static void Main(string[] args)
        {
            // Cirkel();
            // Kub();

        }


        static void Kub()
        {
            Kub mycube = new Modul6.Kub(2, 3, 4);
            Kub supercube = new Kub(100, 200, 300);

            mycube.WriteVolume();
            var x1 = mycube.Volym;
            var x2 = mycube.Area;
            Console.WriteLine($"Volume {x1} and area {x2}");

            Console.WriteLine();

            supercube.WriteVolume();
            var y1 = supercube.Volym;
            var y2 = supercube.Area;
            Console.WriteLine($"Volume {y1} and area {y2}");

            Console.WriteLine();

        }

        static void Cirkel()
        {
            Cirkel bob = new Cirkel("Bob", 8);
            Cirkel lisa = new Cirkel("Lisa", 30);

            bob.SayHello();
            lisa.SayHello();

            Console.WriteLine();

            bob.WriteArea();
            lisa.WriteArea();

            Console.WriteLine();

        }


    }
}
