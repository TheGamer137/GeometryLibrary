using System;
using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Models
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}