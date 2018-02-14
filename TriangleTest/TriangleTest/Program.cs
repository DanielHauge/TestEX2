using System;

namespace TriangleTest
{
    internal class Program
    {
        private static void Main()
        {

            var t = new Triangle(5, 5, 5);
            t.Sides[1] = 9999;
            Console.WriteLine(t.InfoString());

            Console.ReadLine();
        }
    }
}
