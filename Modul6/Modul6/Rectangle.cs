namespace Modul6
{
    internal class Rectangle
    {
        private static double _x;
        private static double _y;
        private static double _area;

        public Rectangle(double x, double y)
        {
            _x = x;
            _y = y;
            _area = y * x;
        }

        public override string ToString()
        {
            return $"I'm a rectangle where x={_x}, y={_y} & the area is {_area}";
        }

    }
}