using System;
using System.Collections.Generic;

namespace Classer
{
    class Product
    {
        public int ProductId { get; set; }
    }
    class Book : Product
    {
        private string _isbn;
        private string _author;
        private int _pages;
        private int _weightingram;
        private string _review;

        public int ISBN { get; set; }

        public string Author { get; set; }

        public int Pages
        {
            get
            {
                if (_pages < 200)
                {
                    return _pages;
                }
                return 200;
            }
            set
            {
                _pages = value;
            }
        }

        public int GetPages()
        {
            return _pages;
        }


        public int GetWeight()
        {
            return _pages * 3;
        }

        public string GetReview()
        {
            if (Pages < 100)
            {
                return "ok bok";
            }

            else if (Pages <= 200)
            {
                return "perfekt bok";
            }

            else
            {
                return "Lång bok";
            }
        }

        static public Book CreateBook()
        {
            return new Book();
        }

    }
    class ElectronicBook : Book
    {
        private string v;

        public void SendAsEmail(string epost)
        {
            Console.WriteLine($"Boken skickades via epost till {epost}.");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var b1 = new Book();
            var b2 = new Book();

            b1.ISBN = 1234567;
            b1.Author = "Ann Annasson";

            b1.Pages = 75;
            var weight = b1.GetWeight();
            var review = b1.GetReview();

            var produktid = b1.ProductId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"* Bokens isbn är: {b1.ISBN} \n* Vikt är: {weight} \n* Det är {review} \n{produktid}");

            var ebok = new ElectronicBook();

            ebok.SendAsEmail("hej@hej.se");



        }
    }
}
