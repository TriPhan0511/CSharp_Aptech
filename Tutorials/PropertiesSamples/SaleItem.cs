using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This sample illustrates the use of expression body definitions for both accessors.
namespace PropertiesSamples
{
    internal class SaleItem
    {
        private string _name;
        private decimal _cost;

        public SaleItem(string name, decimal price)
        {
            _name = name;
            _cost = price;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public decimal Price
        {
            get => _cost;
            set => _cost = value;
        }
    }
}
