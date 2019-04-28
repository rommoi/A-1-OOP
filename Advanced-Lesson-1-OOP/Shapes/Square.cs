using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP.Shapes
{
    public class Square : IAmShape
    {
        private double _side;

        public string Name { get; set; }

        public Square(double a)
        {
            _side = Math.Abs(a);
        }

        public double GetArea()
        {
            return (_side * _side);
        }
    }
}
