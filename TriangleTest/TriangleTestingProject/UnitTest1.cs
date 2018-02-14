using System;
using TriangleTest;
using Xunit;


namespace TriangleTestingProject
{
    public class UnitTest1
    {
        [Fact]
        public void OldTest1()
        {
            Triangle t = new Triangle(1, 1, 1);
            Assert.Equal(Triangle.TriangleType.Equilateral, t.CalculateTriangleType());
        }
        [Fact]
        public void OldTest2()
        {
            Triangle t = new Triangle(4, 4, 4);
            Assert.Equal(Triangle.TriangleType.Equilateral, t.CalculateTriangleType());
        }
        [Fact]
        public void OldTest3()
        {
            Triangle t = null;
            Action act = () => t = new Triangle(4, 1, 1);
            Assert.Throws<ArgumentException>(act);
        }
        [Fact]
        public void OldTest4()
        {
            Triangle t = new Triangle(1, 3, 3);
            Assert.Equal(Triangle.TriangleType.Isoceles, t.CalculateTriangleType());
        }
        [Fact]
        public void OldTest5()
        {
            Triangle t = new Triangle(10000, 10000, 10000);
            Assert.Equal(Triangle.TriangleType.Equilateral, t.CalculateTriangleType());
        }
        [Fact]
        public void OldTest6()
        {
            Triangle t = null;
            Action act = () => t = new Triangle(0, 1, 1);
            Assert.Throws<ArgumentException>(act);
        }
        [Fact]
        public void OldTest7()
        {
            Triangle t = null;
            Action act = () => t = new Triangle(3, -3, 3);
            Assert.Throws<ArgumentException>(act);
        }
        [Fact]
        public void OldTest8()
        {
            /// Trying to create an object of a triangle that is impossible. 1, 2 and 3 does not comply with being a triangle.
            Triangle t = null;
            Action act = () => t = new Triangle(1, 2, 3);
            Assert.Throws<ArgumentException>(act);
        }
        [Fact]
        public void OldTest9()
        {
            Triangle t = null;
            Action act = () => t = new Triangle(2147483648, 1147483647, 200000);
            Assert.Throws<ArgumentException>(act);
        }
        [Fact]
        public void OldTest10()
        {
            Triangle t = new Triangle(1.5, 3.8, 2.5);
            Assert.Equal(Triangle.TriangleType.Scalene, t.CalculateTriangleType());
        }
        [Fact]
        public void OldTest11()
        {
            Triangle t = new Triangle(67, 67, 32);
            Assert.Equal(Triangle.TriangleType.Isoceles, t.CalculateTriangleType());
        }
        [Fact]
        public void OldTest12()
        {
            Triangle t = new Triangle(1994, 1994, 1994);
            Assert.Equal(Triangle.TriangleType.Equilateral, t.CalculateTriangleType());
        }
        [Fact]
        public void TestingChangingSidesPass1()
        {
            Triangle t = new Triangle(32, 32, 45);
            t.Sides[2] = 40;
            Assert.True(t.AmITriangle());
        }
        [Fact]
        public void TestingChangingSidesPass2()
        {
            Triangle t = new Triangle(5, 5, 5);
            t.Sides[0] = 3.5;
            Assert.True(t.AmITriangle());
        }
        [Fact]
        public void AreaFailTest()
        {
            Triangle t = new Triangle(1, 1, 1);
            Assert.False(0.5 == t.Area());
        }
        [Fact]
        public void AreaPassTest1()
        {
            Triangle t = new Triangle(1.5, 3.8, 2.5);
            Assert.Equal(1.14, t.Area());
        }
        [Fact]
        public void AreaPassTest2()
        {
            Triangle t = new Triangle(67, 65, 32);
            Assert.Equal(1022.50, t.Area());
        }
        [Fact]
        public void AreaPassTest3()
        {
            Triangle t = new Triangle(1, 1, 1);
            Assert.Equal(0.43, t.Area());
        }
        [Fact]
        public void AnglePassTest1()
        {
            Triangle t = new Triangle(1.5, 3.8, 2.5);
            var angles = t.GetAngles();
            Assert.Contains(23.68, angles);
            Assert.Contains(142.37, angles);
            Assert.Contains(13.95, angles);
        }
        [Fact]
        public void AnglePassTest2()
        {
            Triangle t = new Triangle(67, 65, 32);
            var angles = t.GetAngles();
            Assert.Contains(79.47, angles);
            Assert.Contains(72.52, angles);
            Assert.Contains(28.01, angles);
        }
        [Fact]
        public void AnglePassTest3()
        {
            Triangle t = new Triangle(1, 1, 1);
            var angles = t.GetAngles();
            Assert.Equal(60.0, angles[0]);
            Assert.Equal(60.0, angles[1]);
            Assert.Equal(60.0, angles[2]);
        }

    }
}
