using System;

namespace Triangle
{
    struct Triangle
    {
        double _a;
        double _b;
        double _c;
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides can't be 0");   
            }
            else if (a + b < c || a + c < b || b + c < a)
            {
                throw new ArgumentException("The sum of two sides must be smaller than 3rd side");
            }
            _a = a;
            _b = b;
            _c = c;
        }
        public double Perimetr() => _a + _b + _c;
        public double Area()
        {
            double p = Perimetr() / 2;
            double Area = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
            return Area;
        }
        public static bool operator ==(Triangle t1, Triangle t2)
            => ((t1._a == t2._a) && (t1._b == t2._b) && (t1._c == t2._c));
        public static bool operator !=(Triangle t1, Triangle t2)
            => !(t1 == t2);
        public static bool operator >=(Triangle t1, Triangle t2)
            => (t1.Area() > t2.Area() || t1 == t2);
        public static bool operator <(Triangle t1, Triangle t2)
            => !(t1 >= t2);
        public static bool operator <=(Triangle t1, Triangle t2)
            => (t1 < t2 || t1 == t2);
        public static bool operator >(Triangle t1, Triangle t2)
            => !(t1 <= t2);
        public override string ToString()
        {
            return $"a = {_a},b = {_b},c = {_c}, Perimetr = {Perimetr()}, Area = {Area()}";
        }


    }
}
