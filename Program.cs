using ConsoleApp2.Models;
using System;
using ConsoleApp2.Enums;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("corek", 0.65, ProductType.Bakery);
            Console.WriteLine(product);
        }
    }
}
