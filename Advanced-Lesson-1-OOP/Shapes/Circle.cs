using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP.Shapes
{
    public class Circle : IAmShape
    {
        private double _radius;
        public string Name { get; set; }

        public Circle(double r)
        {
            _radius = Math.Abs(r);
        }

        public double GetArea()
        {
            return (Math.PI * _radius * _radius);
        }
    }
}
