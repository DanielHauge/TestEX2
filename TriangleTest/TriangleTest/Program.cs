using System;

namespace TriangleTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle t = new Triangle(5, 5, 5);
            Console.WriteLine(t.InfoString());

            Console.ReadLine();
        }
    }
}
