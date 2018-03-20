using System;

namespace Modul6
{
    class Kub
    {
        double _volym;
        double _area;

        public Kub(double x, double y, double z)
        {
            _volym = Math.Abs(x * y * z);
            _area = Math.Abs(2 * (Math.Abs(x * z) + Math.Abs(x * y ) + Math.Abs(y * z)));
            _area = Math.Abs(2 * (Math.Abs(x * z) + Math.Abs(x * y ) + Math.Abs(y * z)));
        }

        public double Volym
        {
            get { return _volym; }
        }

        public double Area
        {
            get { return _area; }
        }

        public void WriteVolume()
        {
            Console.WriteLine($"The volume of the cube is {_volym}!");
        }

        public void WriteArea()
        {
            Console.WriteLine($"The are of the cube is {_area}!");
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            // Cirkel();
            Kub();

        }


        static void Kub()
        {
            Kub mycube = new Modul6.Kub(2, 3, 4);
            Kub supercube = new Kub(100, 200, 300);

            mycube.WriteVolume();
            var x1 = mycube.Volym;
            var x2 = mycube.Area;
            Console.WriteLine(x2);

            Console.WriteLine();

            supercube.WriteVolume();
            var y = supercube.Volym;
            Console.WriteLine(y);

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
