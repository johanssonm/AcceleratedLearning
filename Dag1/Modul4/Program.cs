using System;


namespace Modul4
{
    class Program
    {
        static void Main(string[] args)
            {

                Console.WriteLine("Enter names (like Anna, Hans, Greta): ");
                string userNames = Console.ReadLine();
                Console.WriteLine();

                Char delimiter = ',';
                String[] namestrings = userNames.Split(delimiter);

                



                foreach (var names in namestrings)
                {

                    string trimNames = names.Trim();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"***SUPER-{trimNames.ToUpper()}***");
                    Console.ResetColor();

                }

                Console.WriteLine();

            }
        }
    }

