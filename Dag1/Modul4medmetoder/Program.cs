using System;
using System.Linq;


namespace Modul4
{
    class Program
    {
        static void Main()
        {
            //  var x = AskUserSeparator();
            //  var y = AskErrorReport();
            //  var z = GetUserInput();

            // Console.WriteLine($"{x} \t {y} \t {z}");

        }


        static private string GetUserInput()
        {
            Console.WriteLine("Enter names (like Anna, Hans, Greta): ");
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}

        //static private string[] FormatUserInput()
        //{
        //    var names = GetUserInput();
        //    Char delimiter = AskUserSeparator();
        //    string[] namestrings = names.Split(delimiter);
        //    return namestrings;
        //}

//        static private bool PeopleArrayIsValid()
//        {

//            var namestrings = GetUserInput().Split();
            


//            if (trimNames.Length >= 2 && trimNames.Length <= 9 || trimNames == null)
//            { return false;  }



//        }

//        private static void PrintUserInput()
//        {
//            string[] namestrings = FormatUserInput();

//            foreach (var names in namestrings)
//            {

//                string trimNames = names.Trim();

//                Console.ForegroundColor = ConsoleColor.Green;
//                Console.WriteLine($"***SUPER-{trimNames.ToUpper()}***");
//                Console.ResetColor();

//            }
//        }

//        static char AskUserSeparator()
//        {
//            Console.WriteLine("Enter a character for separation: ");
//            var separator = Convert.ToChar(Console.ReadLine());
//            return separator;

//        }

//        static bool AskErrorReport()
//        {
//            Console.WriteLine("Do you want error messages? (default is yes)  ");

//            var error = Console.ReadLine();

//            switch (error.ToLower())
//            {
//                case "no":
//                    return false;

//                default:
//                   return true;
//            }



//        }
//    }
//}

