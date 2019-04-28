using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Advanced_Lesson_1_OOP.Shapes;

namespace Advanced_Lesson_1_OOP
{
    public class Practice
    {
        /// <summary>
        /// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
        /// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
        /// </summary>
        public static void A_L1_P1_OOP()
        {
            IAmShape[,] shapeArray = CreateShapeArray.ShapeArrayCreate();
            Console.WriteLine("      {0,-8} {1,-20} {2} ", shapeArray[0,0].Name, shapeArray[1,0].Name, shapeArray[2,0].Name);
            for (int j = 0; j < 10; j++)
            { 
                Console.WriteLine("{0,2}  : {1,-8} {2, -20} {3}", j + 1, shapeArray[0, j].GetArea(), shapeArray[1, j].GetArea(), shapeArray[2, j].GetArea());
            }
        }


        /// <summary>
        /// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P6_OperatorsOverloading()
        {
        }

        /// <summary>
        /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P7_OperatorsOverloading()
        {            
        }        
    }
}
