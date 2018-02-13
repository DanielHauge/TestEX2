using System;

namespace TriangleTest
{
    internal class Program
    {
        private static void Main()
        {

            var t = new Triangle(5, 5, 5);
            Console.WriteLine(t.InfoString());

            Console.ReadLine();
        }
    }
}
