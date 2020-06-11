using System;
using System.Collections.Generic;

namespace PromotionEngine
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<ProductUnitPrice> products = new List<ProductUnitPrice>();
            List<object> skuList = new List<object>();

            foreach (var skuId in Enum.GetValues(typeof(SKUId.SKU)))
            {
                Console.WriteLine("total number of order for SKU Id " + skuId);
                int count = Convert.ToInt32(Console.ReadLine());
                ProductUnitPrice p = new ProductUnitPrice(skuId.ToString(), count);
                products.Add(p);
            }

            GetCalculatePrice(products);

            foreach (var product in products)
            {
                Console.WriteLine(product.Count + " * " + product.Id + " = " + product.Result);
            }

            Console.ReadLine();
        }

        private static void GetCalculatePrice(List<ProductUnitPrice> products)
        {
            foreach (ProductUnitPrice item in products)
            {
                AbstactSKU baseSKU = null;
                switch (item.Id)
                {
                    case "A":
                        baseSKU = new A();
                        item.Result = (item.Count / baseSKU.PromotionCount) * baseSKU.PromotionPrice + (item.Count % baseSKU.PromotionCount * item.Price);
                        break;
                    case "B":
                        baseSKU = new B();
                        item.Result = (item.Count / baseSKU.PromotionCount) * baseSKU.PromotionPrice + (item.Count % baseSKU.PromotionCount * item.Price);
                        break;
                    case "C":
                        baseSKU = new C();
                        item.Result = item.Count * item.Price;
                        break;
                }

            }
        }
    }
}
