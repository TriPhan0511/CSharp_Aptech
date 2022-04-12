using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration_Sample
{
    internal class Fruit
    {
        public string Name { get; set; }
        public Color Color { get; set; }

        public override string ToString()
        {
            //return $"Name: {Name} - Color: {Color}";
            //return $"Name: {Name} - Color: {(int)Color}";
            string colorString = Color == Color.Yellow ? "YELLO" : "Another color";
            return $"Name: {Name} - Color: {colorString}";
        }
    }
}
