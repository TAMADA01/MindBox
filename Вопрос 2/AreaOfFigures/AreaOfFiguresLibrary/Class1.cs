using System;

namespace AreaOfFiguresLibrary
{
    public abstract class Figure
    {
        public double Area { get; protected set; }

        public Figure()
        {
        }

        public abstract void CalculateArea();
    }

    public class Curcle : Figure
    {
        private double _radius;
        public double Radius
        {
            get => _radius;
            set 
            { 
                _radius = value;
                CalculateArea();
            }
        }

        public Curcle(double radius) : base() 
        {
            Radius = radius;
        }

        public override void CalculateArea()
        {
            Area = Math.PI * Radius * Radius;
        }
    }

    public class Triangle : Figure
    {
        private double _sideA, _sideB, _sideC;
        public double SideA
        {
            get => _sideA;
            set
            {
                _sideA = value;
                CalculateArea();
            }
        }

        public double SideB
        {
            get => _sideB;
            set
            {
                _sideB = value;
                CalculateArea();
            }
        }

        public double SideC
        {
            get => _sideC;
            set
            {
                _sideC = value;
                CalculateArea();
            }
        }

        public Triangle(double a, double b, double c) : base()
        {
            _sideA = a;
            _sideB = b;
            _sideC = c;
            CalculateArea();
        }

        public override void CalculateArea()
        {
            double p = (SideA + SideB + SideC) / 2;

            Area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsRightAngle()
        {
            return (SideA * SideA + SideB * SideB == SideC * SideC) || (SideA * SideA + SideC * SideC == SideB * SideB) || (SideC * SideC + SideB * SideB == SideA * SideA);
        }
    }
}
