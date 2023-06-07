using System;
using AreaOfFiguresLibrary;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Curcle(5);

            Console.WriteLine(figure.Area);
        }
    }
}
