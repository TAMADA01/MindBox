using System;

namespace AreaOfFiguresLibrary
{
    public abstract class Figure
    {
        public double Area { get; protected set; }

        public Figure()
        {
        }

        protected abstract double CalculateArea();
    }

    public class Curcle : Figure
    {
        public readonly double Radius;

        public Curcle(double radius) : base() 
        {
            Radius = radius;
            Area = CalculateArea();
        }

        protected override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Triangle : Figure
    {
        public readonly double SideA, SideB, SideC;

        public Triangle(double a, double b, double c) : base()
        {
            SideA = a;
            SideB = b;
            SideC = c;
            Area = CalculateArea();
        }

        protected override double CalculateArea()
        {
            double p = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
    }
}
