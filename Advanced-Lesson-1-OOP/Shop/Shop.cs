using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP.Shop
{
    public class Shop
    {
        IProductStorage _prodStorage;
        IEnumerable<IProduct> _prodList;
        Customer _customer;

        public string Name { get; private set; }
        public string ShopAddress { get; private set; }

        public Shop(Customer c)
        {
            Name = "some shop";
            ShopAddress = "some Address";

            _prodStorage = new HDDStorage();
            _prodStorage.OpenStorage();

            _prodList = (List<IProduct>)_prodStorage.GetProducts();

            _customer = c;
        }


        public void MakeCheckout(IEnumerable<IProduct> prodList)
        {
            Console.WriteLine("Thanks you!!!You choose:");
            foreach (var item in prodList)
            {
                Console.WriteLine($"{item.ProductType} {item.Name} {item.Cost}");
            }

            _customer.ConfirmCheckout();
        }
        public void ShowProducts()
        {
            foreach (var item in _prodStorage.GetProducts())
            {
                Console.WriteLine($"{item.ProductType} {item.Name} {item.Cost}");
            }
        }
        public void Filter(IProductFilter filter)
        {
            Console.WriteLine("Filtering");
            for (int i = 0; i < ((List<IProduct>)_prodList).Count; i++)
            {
                if (!filter.FilterProduct(((List<IProduct>)_prodList)[i])) ((List<IProduct>)_prodList).Remove(((List<IProduct>)_prodList)[i]);
            }
            
            foreach (var item in _prodList)
            {
                Console.WriteLine($"{item.ProductType} {item.Name} {item.Cost}");
            }
        }
        public void SelectProduct(IProduct p)
        {
            _customer.AddProduct(p);
        }
        public decimal GetTotalPrice()
        {
            Console.WriteLine("Total price is : ");
            decimal total = 0;
            foreach (var item in _customer.GetBasket())
            {
                total += item.Cost;
            }
            Console.WriteLine($"Total price is : {total}");
            return total;
        }

        public IProduct GetMostExpensive()
        {
            Console.WriteLine("Most expensive is :");
            List<IProduct> l = (List<IProduct>)_prodStorage.GetProducts();
            
            SimpleProduct p = (SimpleProduct)l[0];
            foreach (var item in l)
            {
                if(item is SimpleProduct)
                {
                    if ((item as SimpleProduct) > p) p = (item as SimpleProduct);
                }
                
            }
            Console.WriteLine($"{p.ProductType} {p.Name} {p.Cost}");
            return null;
        }
    }
}
