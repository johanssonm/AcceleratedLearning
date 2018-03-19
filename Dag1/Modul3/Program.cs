using System;
using System.Text;
using System.Collections.Generic;

namespace Modul3
{
    class Program
    {

        static void Main(string[] args)
        {

            // Trimnames();
            //  OldWithbreak();
            //  Ifstatement();

            // Guessinggame();
            Conditional();

        }



        static void Conditional()
        {

            Console.WriteLine("Enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int magicnumber = 20;

            string highnumber = $"Number is higher than {magicnumber}.";
            string lownumber = $"Number is lower than {magicnumber}.";
            string equalnumber = $"Number is equal to {magicnumber}.";

            
            var result = userNumber == magicnumber ? equalnumber : userNumber < magicnumber ? lownumber : highnumber;

            Console.WriteLine(result);

        }



        static void Guessinggame()
        {

            Console.WriteLine("Guess the magic number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int guesses = 7;
            Random rnd = new Random();

            int magicnumber = rnd.Next(1,100);

            if(userNumber != magicnumber)
            {
                for (int i = 0; i < guesses;)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Guess again:");

                    if (magicnumber < userNumber)
                    {
                        Console.WriteLine("Too low.");
                        i++;
                        continue;
                    }

                    else if(magicnumber > userNumber)
                    {
                        Console.WriteLine("Too high.");
                        i++;
                        continue;
                    }

                   


                }

            
            }

            else if (magicnumber == userNumber)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{userNumber} is correct!");
                Console.ResetColor();
            }
        }
    
        static void Ifstatement()
        {

            Console.WriteLine("Enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter another number: ");
            int userNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (userNumber < userNumber2)
            {
                Console.WriteLine($"{userNumber} is lower than {userNumber2}");

            }

            else if(userNumber == userNumber2)
            {
                Console.WriteLine($"{userNumber} is equal to {userNumber2}");
            }

            else
            {
                Console.WriteLine($"{userNumber} is more than {userNumber2}");
            }


        }


        static void OldWithbreak()
        {

            Console.WriteLine("Enter names (like Anna, Hans, Greta): ");
            string userNames = Console.ReadLine();
            Console.WriteLine();

            // if(userNames.IsNullOrWhiteSpace)

            //Console.WriteLine("Enter a surname: ");
            // string surname = Console.ReadLine();

            Console.WriteLine();

            //string nameTrimmed = userNames.Trim();
            //  string surnnameTrimmed =  surname.Trim();

            // List<string> namesList = new List<string>();

            // namesList.Add(userNames);

            Char delimiter = ',';
            String[] namestrings = userNames.Split(delimiter);

            foreach (var names in namestrings)
            {

                string trimNames = names.Trim();

                //  Console.ForegroundColor = ConsoleColor.Green;
                //  Console.WriteLine($"{trimNames}");
                //   Console.ResetColor();

            }




        }
        static void Trimnames()
        {
             
                Console.WriteLine("Enter names (like Anna, Hans, Greta): ");
                string userNames = Console.ReadLine();
                Console.WriteLine();




                // if(userNames.IsNullOrWhiteSpace)

                Console.WriteLine("Enter a surname: ");
                string surname = Console.ReadLine();

                Console.WriteLine();

                //string nameTrimmed = userNames.Trim();
                //  string surnnameTrimmed =  surname.Trim();

                // List<string> namesList = new List<string>();

                // namesList.Add(userNames);

                Char delimiter = ',';
                String[] namestrings = userNames.Split(delimiter);



                foreach (var names in namestrings)
                {

                    string trimNames = names.Trim();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{trimNames} {surname}");
                    Console.ResetColor();

                }

            Console.WriteLine();

        }

                  
            
        
    }
}
