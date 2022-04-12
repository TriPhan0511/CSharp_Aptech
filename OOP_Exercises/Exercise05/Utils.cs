using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    public class Utils
    {
        public static GioiTinh ReadGioiTinh(string prompt)
        {
            string gioiTinhString;
            while (true)
            {
                gioiTinhString = ReadString(prompt);
                if (String.Equals(gioiTinhString, "nam", StringComparison.OrdinalIgnoreCase))
                {
                    return GioiTinh.Nam;
                }
                else if (String.Equals(gioiTinhString, "nu", StringComparison.OrdinalIgnoreCase))
                {
                    return GioiTinh.Nu;
                }
                else
                {
                    Console.WriteLine("Sai gioi tinh. Chi duoc phep nhap nam hoac nu.\n" +
                        "Vui long nhap lai.");
                }
            }
        }

        public static decimal ReadDecimal(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                try
                {
                    return decimal.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    //Console.WriteLine("Wrong format. You should enter a number.");
                    Console.WriteLine("Sai dinh dang. Vui long nhap vao mot so.");
                }
            }
        }

        public static DateTime ReadDateTime(string prompt)
        {
            while (true)
            {
                Console.Write(prompt + "(mm/dd/yyyy hh:mm:ss): ");
                string s = Console.ReadLine();
                try
                {
                    return DateTime.Parse(s);
                }
                catch (FormatException)
                {
                    //Console.WriteLine("Invalid date time. You should enter a date time as format: mm/dd/yyyy hh:mm:ss\n" +
                    //    "Please try again.");
                    Console.WriteLine("Sai dinh dang ngay gio. Ban nen nhap vao mot ngay gio co dinh dang nhu sau: mm/dd/yyyy hh:mm:ss\n" +
                        "Vui long nhap lai ngay gio.");
                }
            }
        }

        public static string ReadString(string prompt)
        {

            string s;
            while (true)
            {
                Console.Write(prompt);
                s = Console.ReadLine();
                if (s == null || s.Trim().Length == 0)
                {
                    //Console.WriteLine("You should not enter an empty string.\n" +
                    //    "Please try again.");
                    Console.WriteLine("Ban khong nen nhap vao mot chuoi trong.\n" +
                        "Vui long nhap lai.");
                }
                else
                {
                    break;
                }
            }
            return s;
        }

        public static char ReadChar(string prompt)
        {
            string s = ReadString(prompt);
            return s[0];
        }

        public static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    //Console.WriteLine("Wrong format. You should enter a whole number.");
                    Console.WriteLine("Sai dinh dang. Vui long nhap vao mot so nguyen.");
                }
            }
        }

        public static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                try
                {
                    return double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    //Console.WriteLine("Wrong format. You should enter a number.");
                    Console.WriteLine("Sai dinh dang. Vui long nhap vao mot so.");
                }
            }
        }
    }
}
