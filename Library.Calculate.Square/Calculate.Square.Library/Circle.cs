using System;


namespace Calculate.Square.Library
{
    public class Circle : ISquare
    {
        public int radius { get; set; }

        public double square => Math.PI * Math.Pow(radius, 2);

        public Circle()
        {
            radius = 0;
        }
        public Circle(int rad)
        {
            radius = rad;
        }

    }
}
