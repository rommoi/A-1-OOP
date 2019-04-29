using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP.Shop
{
    public class SimpleProduct : IProduct
    {
        public string Name { get ; set; }
        public string ProductType { get; set; }
        public decimal Cost { get; set; }

        public static bool operator >(SimpleProduct p1, SimpleProduct p2)
        {
            if (p1.Cost > p2.Cost) return true;
            return false;
        }
        public static bool operator <(SimpleProduct p1, SimpleProduct p2)
        {
            if (p1.Cost < p2.Cost) return true;
            return false;
        }
        public static bool operator ==(SimpleProduct p1, SimpleProduct p2)
        {
            if (p1.Cost == p2.Cost) return true;
            return false;
        }
        public static bool operator !=(SimpleProduct p1, SimpleProduct p2)
        {
            if (p1.Cost != p2.Cost) return true;
            return false;
        }
    }

    public class DiscountedProduct : IProduct
    {
        public string Name { get { return _product.Name + " discounted"; }  set { } }
        public string ProductType { get { return _product.ProductType; }  set { } }
        public decimal Cost { get { return ((decimal)(1 - _discount) * _product.Cost); }  set { } }

        double _discount;
        IProduct _product;

        public DiscountedProduct(SimpleProduct sp)
        {
            _product = sp;
            _discount = 0.1;
        }
    }
}
