using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        // These need to be lowercase and the constructors and return are UpperCase
        private int id;
        private String description;
        private Decimal pack;

        // Properties for the backing fields
        // These can be used outside
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public decimal Pack
        {
            get { return pack; }
            set { pack = value; }
        }

        // Public method that can be accessed outside
        public string GetFullList()
        {
            return this.id + " " + this.description + " " + this.pack;
        }

        // We dont need to ovveride the public method because the GetFullList aready
        // prints out all that we need right?
        // Wait, it was required
        public override string ToString()
        {
            return base.ToString();
        }


        // Now we need out constructor

        public WineItem(int id, string description, decimal pack)
        {
            this.id = id;
            this.description = description;

            // Do we need to pass by value in this one?
            this.pack = pack;
        }

        // Blank Defult constructor?
        public WineItem()
        {
            // Leave blank because we did in class?
        }
    }
}
