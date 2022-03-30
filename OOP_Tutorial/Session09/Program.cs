using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session09
{
    class Product
    {
        // Fields
        private int _id;
        private string _name;
        private string _description;

        // Indexer
        private int[] prices = new int[5];
        public int this[int pos]
        {
            get { return prices[pos]; }
            set { prices[pos] = value; }
        }

        // Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }    
        }

        public string Name 
        { 
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
            
        }

        public Product()
        {
        }

        public Product(int id, string name, string description)
        {
            _id = id;
            _name = name;
            _description = description;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product
            {
                Id = 1,
                Name = "Note 10",
                Description = "Dom"
            };
        }
    }
}
