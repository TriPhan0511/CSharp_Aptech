using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_6_7_8
{
    internal class ConNguoi
    {
        // Identity
        internal int id;


        // State
        internal string ten;
        internal bool tay;
        internal bool chan;
        internal bool trangThai;

        // Constructor



        // Behavior
        public void Noi()
        {
            Console.WriteLine($"{ten} dang noi");
        }

    }
}
