using System;


namespace Calculate.Square.Library
{
    public class Triangle : ISquare
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public double square
        {
            get
            {
                var p = (A + B + C) / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }

        public Triangle()
        {
            A = B = C = 0;
        }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool TriangleCheck()
        {
            bool check = (A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2))
                || B == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(C, 2))
                || C == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(A, 2)));

            return check;
        }

    }
}
