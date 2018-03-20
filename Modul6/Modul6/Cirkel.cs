using System;

namespace Modul6
{
    class Cirkel
    {
        public string _name;
        public double _radie;
        public Cirkel(string name, double radie)
        {
            _name = name;
            _radie = radie;
        }

        public double Area
        {
            get { return Math.Round(_radie * _radie * Math.PI,2); }
        }

        public string Name
        {
            get { return _name; }
        }

        public void SayHello()
        {
            Console.WriteLine($"I'm a circle with the name of {_name}!");
        }

        public void WriteArea()
        {
            Console.WriteLine($"My name is {_name}. I have a radius of {_radie} and an area of " + Area + "!");
        }

    }
}
