using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleTest
{
    public class Triangle
    {
        private double[] sides { get; set; }

        public double[] Sides
        {
            get
            {
                return this.sides;
            }
            set
            {
                this.sides = value;
                if (!AmIATriangle(sides))
                {
                    throw new ArgumentException("Hey!!!, invalid sides for a triangle. Cannot make up a triangle!", "original");

                }
            }
        }

        public Triangle(double a, double b, double c)
        {
            double[] array = new double[] { a, b, c };
            
            this.Sides = array;

        }

        public Triangle(double[] array)
        {
            this.Sides = array;
        }

        public Triangle(int[] a)
        {
            double[] array = new double[] { a[0], a[1], a[2] };

            this.Sides = array;

        }

        public enum TriangleType
        {
            Error,
            Equilateral,
            Isoceles,
            Scalene

        }

        private bool AmIATriangle(double[] s)
        {
            if (s[0] + s[1] > s[2] && s[0] + s[2] > s[1] && s[1] + s[2] > s[0])
            {
                return true;
                Console.WriteLine("It Was a Triangle");
            }
            else
            {
                return false;
                Console.WriteLine("It was Not a a triangle");
            }
        }


        public double Area()
        {
            var temp = (sides[0] + sides[1] + sides[2]) / 2;
            return Math.Sqrt(temp * (temp - sides[0]) * (temp - sides[1]) * (temp - sides[2]));
        }


        public TriangleType CalculateTriangleType()
        {

            if (!(sides[0] > 0 && sides[1] > 0 && sides[2] > 0))
            {
                return TriangleType.Error;
            }
            else if (sides[0] == sides[1] && sides[1] == sides[2])
            {
                return TriangleType.Equilateral;
            }
            else if (sides[0] == sides[1] || sides[1] == sides[2] || sides[0] == sides[2])
            {
                return TriangleType.Isoceles;
            }
            else
            {
                return TriangleType.Scalene;
            }
        }

        public double[] GetAngles()
        {
            double[] result = new double[3];
            var upper = (Math.Pow(Sides[1], 2)) + (Math.Pow(Sides[2], 2)) - (Math.Pow(Sides[0], 2));
            var lower = 2 * Sides[1] * Sides[2];
            var radian = Math.Acos(upper / lower);
            result[0] = Math.Round(radian * (180.0 / Math.PI), 2);

            upper = (Math.Pow(Sides[0], 2)) + (Math.Pow(Sides[1], 2)) - (Math.Pow(Sides[2], 2));
            lower = 2 * Sides[0] * Sides[1];
            radian = Math.Acos(upper / lower);
            result[1] = Math.Round(radian * (180.0 / Math.PI), 2);
            //result[1] = Math.Cos(res1);
            result[2] = 180 - result[0] - result[1];
            return result;
        }


        public string InfoString()
        {
            string result = "";
            result += "Sides: (" + Sides[0] + ") - (" + Sides[1] + ") - (" + Sides[2] + ") \n";
            result += "Angles: (" + GetAngles()[0] + "°) - (" + GetAngles()[1] + "°) - (" + GetAngles()[2] + "°) \n";
            result += "Area: " + Area() + "\n";
            result += "Type: " + CalculateTriangleType().ToString();

            return result;

        }


    }
    
}
