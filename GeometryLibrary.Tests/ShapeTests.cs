using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLibrary.Models;

namespace GeometryLibrary.Tests
{
    public class ShapeTests
    {
        [Fact]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle(5);
            Assert.Equal(78.54, circle.CalculateArea(), 2);
        }

        [Fact]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.CalculateArea(), 2);
        }

        [Fact]
        public void RightAngledTriangleCheck()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightAngled());

            Triangle nonRightAngledTriangle = new Triangle(2, 3, 4);
            Assert.False(nonRightAngledTriangle.IsRightAngled());
        }
    }
}
