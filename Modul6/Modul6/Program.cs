using System;

namespace Modul6
{
    class Triangle
    {
        double _x;
        double _y;
        double _z;

        public Triangle(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;

        }
        public override string ToString()
        {
            return $"I'm a triangle where side 1={_x}, side 2={_y}, side 3={_z}";
        }

    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Cirkel();
            // Kub();

            Override();


        }

        private static void Override()
        {

            Console.WriteLine();

            Cirkel cirkel = new Cirkel(3);

            var x = cirkel.ToString();

            Console.WriteLine(x);

            var rectangle = new Rectangle(12,16);

            var y = rectangle.ToString();

            Console.WriteLine(y);

            Console.WriteLine();
        }

        private static void Kub()
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

        private static void Cirkel()
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
