using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP.Shapes
{
    public class Triangle : IAmShape
    {
        private double _side;

        public string Name { get; set; }

        public Triangle(double a)
        {
            _side = Math.Abs(a);
        }

        public double GetArea()
        {
            return ((Math.Sqrt(3) / 4) * _side * _side);
        }
    }
}
