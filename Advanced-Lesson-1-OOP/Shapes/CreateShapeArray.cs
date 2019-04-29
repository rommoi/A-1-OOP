using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Advanced_Lesson_1_OOP.Shapes
{
    public static class CreateShapeArray
    {
        public static IAmShape[,] ShapeArrayCreate()
        {
            IAmShape[,] array = new IAmShape[3,10];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(i == 0)
                    {
                        array[i, j] = new Square(j+1) { Name = "Square"};
                    }else if(i == 1)
                    {
                        array[i, j] = new Circle(j+1) { Name = "Circle" };
                    }
                    else
                    {
                        array[i, j] = new Triangle(j+1) { Name = "Triangle" };
                    }
                }
                
            }

            return array;
        }
    }
}
