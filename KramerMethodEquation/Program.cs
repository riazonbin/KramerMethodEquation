using System;

namespace KramerMethodEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coefficients of the first equation (ax + by = c):");
            Console.Write("a = ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coefficients of the second equation (dx + ey = f):");
            Console.Write("d = ");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("e = ");
            double b2 = double.Parse(Console.ReadLine());
            Console.Write("f = ");
            double c2 = double.Parse(Console.ReadLine());

            double det = a1 * b2 - a2 * b1;
            double x, y;

            if (det != 0)
            {
                x = (c1 * b2 - c2 * b1) / det;
                y = (a1 * c2 - a2 * c1) / det;
                Console.WriteLine("The solution of the system of linear equations is:");
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
            }
            else
            {
                Console.WriteLine("The determinant is zero. The system of linear equations has no unique solution.");
                if (c1 == 0 && c2 == 0)
                {
                    Console.WriteLine("The system of linear equations has infinitely many solutions.");
                }
                else
                {
                    Console.WriteLine("The system of linear equations has no solution.");
                }
            }

            // Check line type of the first equation
            if (b1 == 0)
            {
                Console.WriteLine("The first equation is a vertical line.");
            }
            else if (a1 == 0)
            {
                Console.WriteLine("The first equation is a horizontal line.");
            }
            else
            {
                Console.WriteLine("The first equation is a slanted line.");
            }

            // Check line type of the second equation
            if (b2 == 0)
            {
                Console.WriteLine("The second equation is a vertical line.");
            }
            else if (a2 == 0)
            {
                Console.WriteLine("The second equation is a horizontal line.");
            }
            else
            {
                Console.WriteLine("The second equation is a slanted line.");
            }
        }
    }
}
