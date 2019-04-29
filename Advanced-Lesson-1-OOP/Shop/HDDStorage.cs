using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP.Shop
{
    public class HDDStorage : IProductStorage
    {
        List<IProduct> _allProducts;

        bool _storageStatus = false;

        public HDDStorage()
        {
            _allProducts = new List<IProduct>
            {
                new SimpleProduct(){Name = "prod1", Cost = 5.34M, ProductType = "cool"},
                new SimpleProduct(){Name = "prod2", Cost = 8.34M, ProductType = "cool"},
                new SimpleProduct(){Name = "prod3", Cost = 1.34M, ProductType = "not cool"},
                new SimpleProduct(){Name = "prod4", Cost = 2.34M, ProductType = "cool"},
                new SimpleProduct(){Name = "prod5", Cost = 15.34M, ProductType = "cool"},

                new DiscountedProduct(new SimpleProduct(){Name = "prod5", Cost = 15.34M, ProductType = "cool"}),
                new DiscountedProduct(new SimpleProduct(){Name = "prod2", Cost = 8.34M, ProductType = "cool"})
            };
        }

        public void CloseStorage()
        {
            Console.WriteLine("Storage closed...");
            _storageStatus = false;
        }

        public IEnumerable<IProduct> GetProducts()
        {
            if (_storageStatus)
            {
                return _allProducts;
            }
            Console.WriteLine("please open storage...");
            return null;
        }

        public void OpenStorage()
        {
            Console.WriteLine("Storage opened...");
            _storageStatus = true;
        }
    }
}
