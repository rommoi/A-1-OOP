using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public interface IAmShape
    {
        string Name { get; set; }
        double GetArea();
    }
}
