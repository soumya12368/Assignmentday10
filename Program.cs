using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Build
{
    class Product
    {
        public string PName { get; set; }
        public decimal PPrice { get; set; }
        public string PBrand { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var productList = new List<Product>
        {
            new Product
            {
                PName = "Kitkat",
                PPrice = 100,
                PBrand = "Nestle",
                ManufacturingDate = DateTime.Parse("2023-01-15"),
                ExpiryDate = DateTime.Parse("2023-12-31")
            },
            new Product
            {
                PName = "GoodDay",
                PPrice = 30,
                PBrand = "Britannia",
                ManufacturingDate = DateTime.Parse("2022-12-01"),
                ExpiryDate = DateTime.Parse("2023-11-30")
            },
            new Product
            {
                PName = "Oreo",
                PPrice = 40,
                PBrand = "Mondelez International",
                ManufacturingDate = DateTime.Parse("2023-02-10"),
                ExpiryDate = DateTime.Parse("2023-10-31")
            },
            new Product
            {
                PName = "Fish Oil",
                PPrice = 900,
                PBrand = "MuscleBlaze",
                ManufacturingDate = DateTime.Parse("2023-03-05"),
                ExpiryDate = DateTime.Parse("2023-09-30")
            },
            new Product
            {
                PName = "Creatine",
                PPrice = 1200,
                PBrand = "MuscleTech",
                ManufacturingDate = DateTime.Parse("2023-04-20"),
                ExpiryDate = DateTime.Parse("2023-08-31")
            }
        };

            DisplayProductDetails(productList);
        }
        static void DisplayProductDetails(List<Product> productList)
        {
            Console.WriteLine($"{"Index Key",-10}{"PName",-20}{"Price",-10}{"Brand",-15}{"MfDate",-20}{"ExpDate"}");

            for (var i = 0; i < productList.Count; i++)
            {
                var product = productList[i];
                Console.WriteLine($"{i,-10}{product.PName,-20}{product.PPrice,-10}{product.PBrand,-15}{product.ManufacturingDate,-20}{product.ExpiryDate}");
            }
        }
    }
}