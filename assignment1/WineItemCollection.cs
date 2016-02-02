using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        // Create an array of WineItems here
        WineItem[] WineArray = new WineItem[4000];

        //There may be a loop to print them out?
        // but couldnt we call the PrintAllValues from the WineItem class?


        // have to add a mtehod to find one that the user wanted in here or WineItem
        public int FindWine()
        {
            Console.WriteLine("Enter what ID you are looking for: ");
            int findID = int.Parse(Console.ReadLine());
            // int IDNum;
            // int index = 0;

            //return WineArray.First<IDNum>;

            //placeholder
            return findID;

        }

        // adding a WineItem
        // keeping track of the open spot where we would add one in

        public int AddWine()
        {
            Console.WriteLine("Ok we are going to have to get some information first. \n Please enter the ID number.");
            //Would also like to check if its a valid input soon
            int IDAdd = int.Parse(Console.ReadLine());

            Console.WriteLine("Now enter the Description: ");
            string DescriptionAdd = Console.ReadLine();

            Console.WriteLine("Finally enter in an amount in each wine.");
            decimal PackAdd = decimal.Parse(Console.ReadLine());

            //Create a new wine Item and add it to the array
            foreach (WineItem ToBeAdding in WineArray)
            {
                if (ToBeAdding != null)
                {
                    //int counter;
                    //counter++;

                }
            }

            //Welp that doestn work
            //return Console.WriteLine(" The Wine with\n ID: " +  IDAdd + "\n Description: " + DescriptionAdd + "\n Pack: " + PackAdd + "\n Has been added to the list!");

            //Placeholder
            return IDAdd;
        }
    }
}
