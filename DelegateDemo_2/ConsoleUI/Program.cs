using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Run();
        }

        void Run()
        {
            ShoppingCartModel cart = new ShoppingCartModel();
            PopulateData(cart);
            Console.WriteLine($"Total is {cart.GenerateTotal(SubTotalAlert):C2}");
        }

        private void SubTotalAlert(decimal subTotal)
        {
            Console.WriteLine($"subtotaL is {subTotal:C2}");
        }

        private static void PopulateData(ShoppingCartModel cart)
        {
            cart.Items.Add(new ProductModel() { ItemName = "Cereal", Price = 99.99M });
            cart.Items.Add(new ProductModel() { ItemName = "Milk", Price = 58.89M });
            cart.Items.Add(new ProductModel() { ItemName = "Beer", Price = 60.99M });
            cart.Items.Add(new ProductModel() { ItemName = "Beverage", Price = 25.99M });
        }
    }
}
