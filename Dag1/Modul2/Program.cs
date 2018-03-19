using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Modul2
{
    class Program
    {
        static void Main(string[] args)
        {
            // UserInput();

            // WorkingWithDifferentTypes();

            // Fruits();

            // Sleep();

            // UseWhile();

             UseFor();

        }

           public static void UseFor()
            {
                Console.WriteLine("Enter your name or type quit to exit: ");
                string userName = Console.ReadLine();

            //    Console.WriteLine("Times to repeat: ");
             //   int userNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Rows: ");
                int getRows = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Columns: ");
                int getColumns = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Repetitions in a cell: ");
                int getRepetitions = Convert.ToInt32(Console.ReadLine());

            // userNamereversed = string.(userName);


            for (int i = 0; i < getRows; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(String.Concat(Enumerable.Repeat($"{(userName)}\t\t", getColumns)));
                Console.ResetColor();
            }



            //     for (int count = 0; count < userNumber; count++ ) 
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"Your name is {userName}");
            //        Console.ResetColor();
            //    }



        }

        static void UseWhile()
        {
            while(true)
            {
                Console.WriteLine("Enter your name or type quit to exit: ");
                string userName = Console.ReadLine();

                Console.WriteLine("Times to repeat: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());


                if (userName == "quit")
                {
                    break;
                }

                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    var result = string.Concat(Enumerable.Repeat($"{userName}\n", userNumber));
                    Console.WriteLine(result);
                    Console.ResetColor();
                    continue;
                }
                

            }

        }

        static void Sleep()
        {
           // const int hoursDay = 24; 

            Console.WriteLine("Enter when you went to bed (HH:MM) : ");
            var bedtime = (Console.ReadLine());

            Console.WriteLine("When did you wake up? (HH:MM)");
            var wokeup = (Console.ReadLine());


            TimeSpan parseSleep = DateTime.Parse(wokeup).Subtract(DateTime.Parse(bedtime));

            TimeSpan asleep =  parseSleep;

            Console.WriteLine(asleep);

            //if (asleep < 6)
            //{
            //    Console.WriteLine("You need more sleep.");
            //}

            //else if (asleep < 12)
            //{
            //    Console.WriteLine("You've slept well");
            //}

            //else if(asleep > 13)
            //{
            //    Console.WriteLine("You've slept a lot" );

            //}

            Console.WriteLine();


        }


        static void Fruits()
        {

            Console.WriteLine("How many fruits do you want to add?");
            var fruitamount = Convert.ToInt32(Console.ReadLine());

           


            Console.WriteLine("Enter fruit 1");
            string fruit1 = Console.ReadLine();
            Console.WriteLine("Enter fruit 2");
            string fruit2 = Console.ReadLine();
            Console.WriteLine("Enter fruit 3");
            string fruit3 = Console.ReadLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("You've entered three fruits; " + fruit1 + ", " + fruit2 + ", " + fruit3 + "!");
            Console.WriteLine("You've entered three fruits; {0}, {1}, {2}!", fruit1, fruit2, fruit3);
            Console.WriteLine($"You've entered three fruits; {fruit1}, {fruit2}, {fruit3}!");

            Console.WriteLine();




        }
        static void WorkingWithDifferentTypes()
        {
            while(true)
            {

                Console.WriteLine("What is your name?");
                var userName = Console.ReadLine();

                Console.WriteLine("How old are you?");
                var userAge = Convert.ToInt32(Console.ReadLine());

                var userRetirement = 65 - userAge;

                Console.WriteLine("What is your favorite letter?");
                var userLetter = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your name is " + userName);

                if (userAge == 65)
                {
                    Console.Beep();
                    Console.WriteLine("Congratulations! You can retire.");
                }

                else
                {
                    Console.WriteLine("You have " + userRetirement + "years to retirement");
                }

                int value;
                if (int.TryParse(userLetter, out value))
                {
                    Console.WriteLine("You like numbers.");
                }

                else
                {
                    Console.WriteLine("You like letters.");
                }
                //  Console.WriteLine("Your favorite letter is " + userLetter);

                Console.ResetColor();

                Console.WriteLine();
                continue;
            }
        }
        public static void UserInput()
        {
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            var userAge = Console.ReadLine();

            Console.WriteLine("What is your favorite letter?");
            var userLetter = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var userColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var userAnimal = Console.ReadLine();

            Console.WriteLine("\nThank you!\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your name is " + userName);
            Console.WriteLine("Your age is " + userAge);
            Console.WriteLine("Your favorite letter is " + userLetter);
            Console.WriteLine("Your favorite color " + userColor);
            Console.WriteLine("And your favorit animal is " + userAnimal + "\n");
            Console.ResetColor();
        }
    }
}
