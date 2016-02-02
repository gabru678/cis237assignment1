using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Dont forget to add here the System.IO
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        public bool ImportCSV(string pathToCSVFile, WineItem[] allTheWines)
        {
            StreamReader streaming = null;

            try
            {
                //declare a string to represent a line we read
                string line;

                //Create a new instance of the StreamReader class
                streaming = new StreamReader(pathToCSVFile);

                //Create a counter to know what index to place the new object
                int counter = 0;

                //This line is doing a bunch of stuff. It is reading a line from
                //the file. It is assigning that info to the 'line' variable, and
                //lastly it is making sure that what it just read was not null.
                //if it is null, we are done reading the file and we can exit the
                //loop.
                while ((line = streaming.ReadLine()) != null)
                {
                    // In this section isnt the counter useless?
                    // Why do we need to keep track of it?
                    processLine(line, allTheWines, counter++);
                }

                return true;
            }

            catch (Exception e)
            {
                //Spit out the errors that occured
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                //If an instance of the streamreader was made, we want to ensure
                //that we close it. The finally block is a perfect spot to put it
                //since it will get called regardless of whether or not the try
                //succeeded
                if (streaming != null)
                {
                    streaming.Close();
                }
            }
            return false;
        }

        // This is the private method we use in this class to add a read in WineItem into the array of allTheWines
        private void processLine(string line, WineItem[] allTheWines, int index)
        {
            //Split the line into parts, and assign the parts to a string array
            string[] parts = line.Split(',');

            //Create some local variables and assign the various parts to them.
            int id = int.Parse(parts[0]);
            string description = parts[1];
            decimal pack = decimal.Parse(parts[2]);

            //Now we just need to add a new WineItem to the array and use the parts
            //we parsed out. If you had a collection class, I would hope that it has
            //a method that you made called 'add' that would then do the work of
            //adding a new WineItem to the collection.
            allTheWines[index] = new WineItem(id, description, pack);
        }
    }
}
