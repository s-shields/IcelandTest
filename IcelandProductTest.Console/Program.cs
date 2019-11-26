using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcelandProductTest.Console
{
    class Program
    {
        private static List<Product> products = new List<Product>();

        static void Main(string[] args)
        {
            SetTestData();

            var productChecker = new ProductChecker();

            productChecker.ProductUpdater(products);

            foreach (var item in products)
            {
                if (item.Type == "No Such Item")
                {
                    System.Console.WriteLine(item.Type);
                    continue;
                }

                System.Console.WriteLine(item.Type + " " +  item.SellInDays + " " + item.Quality);
            }

            System.Console.ReadLine();
        }

        public static void SetTestData()
        {
            products.Add(new Product { Type = "Aged Brie", SellInDays = 1, Quality = 1 });
            products.Add(new Product { Type = "Christmas Crackers", SellInDays = -1, Quality = 2 });
            products.Add(new Product { Type = "Christmas Crackers", SellInDays = 9, Quality = 2 });
            products.Add(new Product { Type = "Soap", SellInDays = 2, Quality = 2 });
            products.Add(new Product { Type = "Frozen Food", SellInDays = -1, Quality = 55 });
            products.Add(new Product { Type = "Frozen Food", SellInDays = 2, Quality = 2 });
            products.Add(new Product { Type = "Invalid Item", SellInDays = 2, Quality = 2 });
            products.Add(new Product { Type = "Fresh Item", SellInDays = 2, Quality = 2 });
            products.Add(new Product { Type = "Fresh Item", SellInDays = -1, Quality = 5 });
        }
    }
}
