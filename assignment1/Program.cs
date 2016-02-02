using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our wacky and wild wine list! \n");

            int UserIn = UserInterface.GetUserInput();

            // Assuming GetUserInput returns an integer of input
            // Well it still wants an integer?
            // Needed an extra = so it wasnt an assignment
            if (UserIn == 1)
            {
                // reading in the .CSV file
                // Find it using ../../../datafiles

                CSVProcessor csvProcessr = new CSVProcessor();


                //Dont know why this isnt working?
                csvProcessr.ImportCSV("../../../datafiles.csv", allTheWines);
            }
            else if (UserIn == 2)
            {
                // add to the list
                // use a method created in the WineItemCollection

                Console.WriteLine(" We will now add a new Item to the list!");
            }
            else if (UserIn == 3)
            {
                // loop through the array by the first index of a newly created WineItem with the input
                // as the first index and when they == each other
                // print out that array
                Console.WriteLine(" We will now look for an ID in the list!");
            }
            else if (UserIn == 4)
            {
                Console.WriteLine(" We will see you later! ");

                Environment.Exit(0);
            }


            }
        }
    }

