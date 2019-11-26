using System;
using System.Collections.Generic;

namespace IcelandProductTest.Console
{
    public class ProductChecker
    {
        public List<Product> ProductUpdater(List<Product> products)
        {
            foreach (var product in products)
            {
                if(product.Type != "Soap")
                    product.SellInDays--;

                switch (product.Type)
                {
                    case "Aged Brie":
                        product.Quality = IncreaseQuality(product.Quality, 1);
                        break;
                    case "Christmas Crackers":

                        if (product.SellInDays > 10)
                        {
                            product.Quality = IncreaseQuality(product.Quality, 1);
                            break;
                        }

                        if (product.SellInDays <= 10 && product.SellInDays > 5)
                        {
                            product.Quality = IncreaseQuality(product.Quality, 2);
                            break;
                        }

                        if (product.SellInDays <= 5 && product.SellInDays >= 0)
                        {
                            product.Quality = IncreaseQuality(product.Quality, 3);
                            break;
                        }

                        if (product.SellInDays < 0)
                            product.Quality = 0;

                        break;
                    case "Soap":
                        break;
                    case "Frozen Food":
                        product.Quality = DecreaseQuality(product.Quality, 1);
                        break;
                    case "Fresh Item":
                        if (product.SellInDays > 0)
                        {
                            product.Quality = DecreaseQuality(product.Quality, 2);
                            break;
                        }

                        if (product.SellInDays < 0)
                            product.Quality = DecreaseQuality(product.Quality, 4);

                        break;
                    default:
                        product.Type = "No Such Item";
                        product.SellInDays = 0;
                        product.Quality = 0;
                        break;
                }
            }

            return products;
        }

        public int IncreaseQuality(int productQuality, int amount)
        {
            int newQualityTotal = productQuality + amount;

            if (newQualityTotal > 50)
                return 50;

            return newQualityTotal;
        }

        public int DecreaseQuality(int productQuality, int amount)
        {
            int newQualityTotal = productQuality - amount;

            if (newQualityTotal > 50)
                return 50;

            if (newQualityTotal < 0)
                return 0;

            return newQualityTotal;
        }


    }
}
