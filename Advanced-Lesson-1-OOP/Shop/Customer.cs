using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP.Shop
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        private IEnumerable<IProduct> _shoppingBasket;

        public Customer()
        {
            _shoppingBasket = new List<IProduct>();
        }

        public void AddProduct(IProduct p)
        {
            ((List<IProduct>)_shoppingBasket).Add(p);
        }

        public void ConfirmCheckout()
        {
            Console.WriteLine("Thank you shop for confirmation!");
        }
        public IEnumerable<IProduct> GetBasket()
        {
            return _shoppingBasket;
        }
    }
}
