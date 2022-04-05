using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    internal interface IBook
    {
        string Title { get; set; }
        string Author { get; set; }
        string Publisher { get; set; }
        int Year { get; set; }
        string ISBN { get; set; }
        List<string> Chapters { get; set; }
    }
}
