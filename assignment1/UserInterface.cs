using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        //Make this static so we dont have to instatiate it in the main

        public static int GetUserInput()
        {
            printMenu();

            String input = Console.ReadLine();

            //While the input is NOT valid
            while (input != "1" && input != "2" && input != "3")
            {
                //Tell them that they did not enter a valid choice
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice");
                Console.WriteLine();
                //Reprint the menu for the user.
                printMenu();
                //Re-fetch the user input from the console
                input = Console.ReadLine();
            }

            //I know since we are out of the while loop that it must be either
            //a 1 or a 2, so there is no need for me to use a try / catch here.
            //I could, but it should NEVER hit the catch.
            return Int32.Parse(input);
        }

        //Dont quite know the purpose of this yet?
        public static void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

        private static void printMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Add to the List");
            Console.WriteLine("3. Search through the List by Item ID");
            Console.WriteLine("4. Exit");
        }
    }
}
