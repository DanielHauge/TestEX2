using System;

namespace TriangleTest
{
    public class Triangle
    {
        private double[] sides { get; set; }

        public double[] Sides
        {
            get
            {
                return sides;
            }
            set
            {
                sides = value;
                if (!AmITriangle())
                {
                    throw new ArgumentException("Hey!!!, invalid sides for a triangle. Cannot make up a triangle!");

                }
            }
        }
        public Triangle(double a, double b, double c)
        {
            var array = new [] { a, b, c };
            
            Sides = array;

        }
        public Triangle(double[] array)
        {
            Sides = array;
        }
        public Triangle(int[] a)
        {
            var array = new double[] { a[0], a[1], a[2] };

            Sides = array;

        }
        private bool AmITriangle()
        {
            var s = Sides;
            return s[0] + s[1] > s[2] && s[0] + s[2] > s[1] && s[1] + s[2] > s[0];
        }
        public double Area()
        {
            var temp = (sides[0] + sides[1] + sides[2]) / 2;
            return Math.Sqrt(temp * (temp - sides[0]) * (temp - sides[1]) * (temp - sides[2]));
        }
        public TriangleType CalculateTriangleType()
        {

            if (AmITriangle())
            {
                return TriangleType.Error;
            }
            if (AmIEquilateral())
            {
                return TriangleType.Equilateral;
            }
            if (AmIIsoceles()) 
            {
                return TriangleType.Isoceles;
            }
            return TriangleType.Scalene;
            
        }
        private bool AmIIsoceles()
        {
            return sides[0] == sides[1] || sides[1] == sides[2] || sides[0] == sides[2];
        }
        private bool AmIEquilateral()
        {
            return sides[0] == sides[1] && sides[1] == sides[2];
        }
        public double[] GetAngles()
        {
            var result = new double[3];
            var upper = Math.Pow(Sides[1], 2) + Math.Pow(Sides[2], 2) - Math.Pow(Sides[0], 2);
            var lower = 2 * Sides[1] * Sides[2];
            var radian = Math.Acos(upper / lower);
            result[0] = Math.Round(radian * (180.0 / Math.PI), 2);

            upper = Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) - Math.Pow(Sides[2], 2);
            lower = 2 * Sides[0] * Sides[1];
            radian = Math.Acos(upper / lower);
            result[1] = Math.Round(radian * (180.0 / Math.PI), 2);
            //result[1] = Math.Cos(res1);
            result[2] = 180 - result[0] - result[1];
            return result;
        }
        public string InfoString()
        {
            var result = "";
            result += "Sides: (" + Sides[0] + ") - (" + Sides[1] + ") - (" + Sides[2] + ") \n";
            result += "Angles: (" + GetAngles()[0] + "°) - (" + GetAngles()[1] + "°) - (" + GetAngles()[2] + "°) \n";
            result += "Area: " + Area() + "\n";
            result += "Type: " + CalculateTriangleType();

            return result;

        }

        public enum TriangleType
        {
            Error,
            Equilateral,
            Isoceles,
            Scalene

        }
    }
    
}
