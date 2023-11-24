using System;
using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Models
{
    public class Triangle : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Используется формулу Герона для вычисления площади треугольника
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        /// <summary>
        /// Проверка на прямоугольность треугольника по теореме Пифагора
        /// </summary>
        /// <returns></returns>
        public bool IsRightAngled()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}