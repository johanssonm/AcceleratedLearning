using System;

namespace Modul6
{
    class Triangle
    {
        double _x;
        double _y;
        double _z;

        public Triangle(double x, double y)
        {
            _x = x;
            _y = y;
            _z = Math.Sqrt((x * x) + (y * y));

        }
        public override string ToString()
        {
            return $"I'm a triangle where base 1={_x}, side 1={_y}, side 2 ={_z}";
        }

    }
}