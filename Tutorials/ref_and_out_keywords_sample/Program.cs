using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_and_out_keywords_sample
{
    //// ref keyword example
    //// The ref keyword passes arguments by reference. It means any changes made to this argument
    //// in the method will be reflected in that variable when control returns to the calling method.
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int i = 1; // We must to initialize i first.
    //        Console.WriteLine($"Before calling getNextName method: {i}");
    //        string _ = GetNextName(ref i);
    //        Console.WriteLine($"After calling getNextName method: {i}");
    //    }

    //    public static string GetNextName(ref int number)
    //    {
    //        number++;
    //        string s = $"Next-{number}";
    //        return s;
    //    }
    //}
    ////--------------------------------------------------------------------------------------------

    //// out keyword example
    //// The out keyword passes arguments by reference. This is very similar to the ref keyword.
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int i; // We don't have to initialize i first.
    //        GetNextNameByOut(out i);
    //        Console.WriteLine($"After calling the method GetNextNameByOut method: {i}"); // 100
    //    }

    //    public static string GetNextNameByOut(out int number)
    //    {
    //        number = 100;
    //        return $"Next-{number}";
    //    }
    //}
    ////--------------------------------------------------------------------------------------------
    
    //// ref / out keywords and overloading example -> error
    //// Both ref and out are treated differently at run time and they are treated the same at compile time,
    //// so methods which use ref or out keyword cannot be overloaded
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    }

    //    public static string GetNextName(ref int i)
    //    {
    //        i++;
    //        return $"Next-{i}";
    //    }

    //    public static string GetNextName(out int i)
    //    {
    //        i += 100;
    //        return $"Next-{i}";
    //    }
    //}
    ////--------------------------------------------------------------------------------------------
}
