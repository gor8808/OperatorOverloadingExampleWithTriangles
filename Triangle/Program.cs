using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(6,8,10);
            Triangle triangle2 = new Triangle(6,8,10);
            Console.WriteLine($"|{triangle1}| == |{triangle2}| -- {triangle1 == triangle2}"); 
            Console.WriteLine($"|{triangle1}| != |{triangle2}| -- {triangle1 != triangle2}"); 
            Console.WriteLine($"|{triangle1}| >= |{triangle2}| -- {triangle1 >= triangle2}"); 
            Console.WriteLine($"|{triangle1}| <= |{triangle2}| -- {triangle1 <= triangle2}");
            triangle2 = new Triangle(12,16,20);
            Console.WriteLine($"|{triangle1}| >  |{triangle2}| -- {triangle1 > triangle2}");
            Console.WriteLine($"|{triangle1}| <  |{triangle2}| -- {triangle1 < triangle2}");


        }
    }
}
