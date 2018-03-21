using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace Modul6
{
    public class Adress
    {
        public string Street;
        public int StreetNumber;
        public string City;
        public string ZipCode;
        public string FullStreet;

        public void SetStreet(string street, int streetnumber)
        {
            Street = street;
            StreetNumber = streetnumber;

        }

        public void SetCity(string city)
        {
            City = city;

        }

        public void SetZip(string zip)
        {
            if (ValidateZip(zip) == true)
            {
                ZipCode = zip;
            }

            

            else
            {
                var format = zip.Trim();
                ZipCode = format.Insert(3, " ");
            }

        }

        public string GetFullStreet()
        {
           return $"{Street} {StreetNumber}" ;
        }

        public bool  ValidateZip(string zip)
        {

            var pattern = (@"^{3}[0-9]{1}[\s]{2}[0-9]");

            return Regex.IsMatch(zip,pattern);

            }

    }
    class Program
    {

        private static void Main(string[] args)
        {
            // Cirkel();
            // Kub();
             //Override();
             // Person();

               // Gatuadress();
                SetAccessor();


        }

        private static void SetAccessor()
        {
            Adress adress = new Adress();;
            Console.WriteLine();
            
            Console.WriteLine("Try set zipcode to \t 111 22");
            adress.SetZip("111 22");

            Console.WriteLine($"Zipcode \t\t {adress.ZipCode}");
            Console.WriteLine("Try set zipcode to \t 22222");
            adress.SetZip("22222");

            Console.WriteLine($"Zipcode \t\t {adress.ZipCode}");
            Console.WriteLine("Try set zipcode to \t HELLO");
            adress.SetZip("HELLO");

            Console.WriteLine($"Zipcode \t\t {adress.ZipCode}");


            Console.WriteLine();
        }

        private static void Gatuadress()
        {

            Adress adress = new Adress();
            adress.SetStreet("Göteborgsvägen", 44);
            adress.SetCity("Göteborg");
            adress.SetZip("12345");
            var fullstreet = adress.GetFullStreet();

            Console.WriteLine();
            Console.WriteLine("Street" + "\t\t\t" + adress.Street);
            Console.WriteLine("Street number" + "\t\t" + adress.StreetNumber);
            Console.WriteLine("City" + "\t\t\t" + adress.City);
            Console.WriteLine("Zip" + "\t\t\t" + adress.ZipCode);
            Console.WriteLine("Full street" + "\t\t" + fullstreet);

            Console.WriteLine();
        }

        private static void Person()
        {

            Console.WriteLine();
    
            Person lisa = new Person();
                
            lisa.MakePerson("Lisa", "Namnsson");
            lisa.Gender = Modul6.Person.SetGender.Female;
            lisa.Sport = Sport.Soccer;

            var lisaName = lisa.FirstName + " " + lisa.LastName;
            var lisaGender = lisa.Gender;
            var lisaSport = lisa.Sport;

            Console.WriteLine(lisaName);
            Console.WriteLine(lisaGender);
            Console.WriteLine(lisaSport);

            Console.WriteLine();

            foreach (var sport in Enum.GetValues(typeof(Sport)) )
            {
                Console.WriteLine($"* {sport}");
            }

            var list = Enum.GetNames(typeof(Sport)).ToList();

            list = list.Select((item) => item.ToLower()).ToList();

            list.Contains("tennis");

            String input = Console.ReadLine();

            Console.WriteLine();
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

            var triangle = new Triangle(5,7);

            var z = rectangle.ToString();

            Console.WriteLine(z);

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
