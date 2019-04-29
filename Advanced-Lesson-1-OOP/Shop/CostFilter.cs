using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP.Shop
{
    public class CostFilter : IProductFilter
    {
        public bool FilterProduct(IProduct p)
        {
            if (p.Cost > 5) return true;
            return false;
        }
    }
    public class TypeFilter : IProductFilter
    {
        public bool FilterProduct(IProduct p)
        {
            if (p.ProductType == "cool") return true;
            return false;
        }
    }
}
