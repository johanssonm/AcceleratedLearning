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
}
