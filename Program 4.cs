using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        class Circle
        {
            private double circleRadius;
            private double area;
            public Circle(double radius)
            {
                radius = circleRadius;
            }
            public void GetArea()
            {
                area = circleRadius * circleRadius * Math.PI;
                Console.WriteLine($"Площадь круга: {area}");
            }
            public double GetRadius
            {
                get { return circleRadius; }
                set { circleRadius = value; }
            }
            static void Main(string[] args)
            {
                Circle newCircle = new Circle(0);

                Console.Write("Введите радиус: ");
                if (!double.TryParse(Console.ReadLine(), out double num) || num <= 0)
                {
                    Console.WriteLine("Ошибка: Радиус должен быть больше 0");
                    return;
                }
                newCircle.GetRadius = num;
                newCircle.GetArea();
            }
        }
    }
}

