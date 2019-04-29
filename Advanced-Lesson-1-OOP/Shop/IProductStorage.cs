using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP.Shop
{
    public interface IProductStorage
    {
        void OpenStorage();
        void CloseStorage();
        IEnumerable<IProduct> GetProducts();

        
    }

    public interface IProduct
    {
        string Name { get; set; }
        string ProductType { get; set; }
        decimal Cost { get; set; }
    }

    public interface IProductFilter
    {
        bool FilterProduct(IProduct p);
    }
}
