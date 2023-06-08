using System;
using AreaOfFiguresLibrary;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Curcle(6);
            Triangle triangle = new Triangle(5, 3, 4);

            Console.WriteLine(figure.Area);
            Console.WriteLine(triangle.IsRightAngle());
        }
    }
}
