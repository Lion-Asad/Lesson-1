using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
       //1
            double a = 16.80;
            double b = 12.40;
            double res = Math.Sqrt(a*b);
            Console.WriteLine(res);
            
        }
       //2 
        {
            double A = 1.40;
            double B = -5.50;
            double C = 0.60;
            double AC = Math.Abs(A - C);
            double BC = Math.Abs(B - C);
            double res = AC + BC;
            Console.WriteLine(res);
        }
       //3 
        {
            double x1 = -6.20, y1 = 5.20, x2 = 2.10, y2 = 9.80;
            double res = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
            Console.WriteLine(res);
        }
       //4 
        {
            int a=41;
            int res = a%10*10+a/10;
            Console.WriteLine(res);
        }
       //5 
        {
            int N = 10985;
            int res = N/60;
            Console.WriteLine(res);
        }
       //6 
        {
            int k = 202;
            int res = k % 7;
            Console.WriteLine(res);
        }
    }
}
