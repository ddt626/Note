using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContravariantMethodDemo02
{
    public abstract class Shape
    {
        public abstract Double Area
        { get; }


    }

    public class Circle : Shape
    {

        private Double _radius;

        public Circle(Double radius)
        {
            _radius = radius;
        }


        public override double Area
        {
            get { return Math.PI * _radius * _radius; }
        }
    }

    public class Rectangle : Shape
    {
        private Double _width, _height;

        public Rectangle(Double width, Double height)
        {
            _width = width;
            _height = height;
        }

        public override double Area
        {
            get { return _width * _width; }
        }
    }

    public class ShapeAreaComparer : IComparer<Shape>
    {

        public int Compare(Shape x, Shape y)
        {
            if (x == null)
            {
                if (y == null)
                { return 0; }
                else
                { return -1; }
            }
            else
            {
                if (y == null)
                { return 1; }
                else
                { return x.Area.CompareTo(y.Area); }
            }
        }
    }
}
