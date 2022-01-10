using ConsoleApp2.Enums;
using System;
using System.Collections.Generic;
using System.Text;




namespace ConsoleApp2.Models
{
    class Product
    {
        static int Count=1000;
        static int TotalCount = 0;
        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountedPrice { get; set; }
        public ProductType ProductType { get; set; }
      
        public Product(string name,double price, ProductType Type)
        {
            TotalCount++;
            Count++;
            Name = name;
            Price = price;
        
          
            switch ((int)ProductType)
            {
                case 0:
                    Code += "BA" + (TotalCount + Count);
                    break;

                    DiscountedPrice = price - (price * 0.1);

                case 1:
                    Code += "DR" + (TotalCount + Count);
                    break;
                case 2:
                    Code += "ME" + (TotalCount + Count);
                    break;
                case 3:
                    Code += "FI" + (TotalCount + Count);
                    break;
                default:
                    break;
            }
        }
        public override string ToString()
        {
            return $"{Name}\n{Price}\n{ProductType}";
        }
    }
   
}
