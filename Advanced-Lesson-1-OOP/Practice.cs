using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Advanced_Lesson_1_OOP.Shapes;
using Advanced_Lesson_1_OOP.Shop;

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
            Console.WriteLine("      {0,-8} {1,-15} {2} ", shapeArray[0,0].Name, shapeArray[1,0].Name, shapeArray[2,0].Name);
            for (int j = 0; j < 10; j++)
            { 
                Console.WriteLine("{0,2}  : {1,-8} {2, -15:0.0000} {3:0.0000}", j + 1, shapeArray[0, j].GetArea(), shapeArray[1, j].GetArea(), shapeArray[2, j].GetArea());
            }
        }


        /// <summary>
        /// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P6_OperatorsOverloading()
        {
            Car car1 = new Car() { EnginePower = 100 };
            Car car2 = new Car() { EnginePower = 100.1 };
            Car car3 = new FuelCar() { EnginePower = 200 };
            Car car4 = new ElectroCar() { EnginePower = 200 };
            Console.WriteLine($"car1 engine power {car1.EnginePower}. car2 engine power {car2.EnginePower}. car3 engine power {car3.EnginePower}. car4 engine power {car4.EnginePower}.");

            Console.WriteLine($"Car1 > car2 : {car1 > car2}, car1 < car2 : {car1 < car2}, car1 == car2 : {car1 == car2}, car1 != car2 {car1 != car2}");

            Console.WriteLine($"Car1 > car4 : {car1 > car4}, car1 < car4 : {car1 < car4}, car1 == car4 : {car1 == car4}, car1 != car4 {car1 != car4}");

            Console.WriteLine($"Car3 > car4 : {car3 > car4}, car3 < car4 : {car3 < car4}, car3 == car4 : {car3 == car4}, car3 != car4 {car3 != car4}");
        }

        /// <summary>
        /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P7_OperatorsOverloading()
        {
            Shop.Shop shop = new Shop.Shop(new Customer() { Name = "Customer", Email = "@blabla", Phone = "123456789"});
            shop.ShowProducts();

            shop.GetMostExpensive();

            shop.Filter(new CostFilter());
        }        
    }
}
