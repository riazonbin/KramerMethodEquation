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
                Console.WriteLine("The system of linear equations has no unique solution.");
                return;
            }

            // Check if the first line is parallel to the x-axis
            if (b1 == 0)
            {
                Console.WriteLine("The first line is parallel to the x-axis.");
            }
            // Check if the first line is parallel to the y-axis
            else if (a1 == 0)
            {
                Console.WriteLine("The first line is parallel to the y-axis.");
            }
            else
            {
                Console.WriteLine("The first line is not parallel to either the x-axis or the y-axis.");
            }

            // Check if the second line is parallel to the x-axis
            if (b2 == 0)
            {
                Console.WriteLine("The second line is parallel to the x-axis.");
            }
            // Check if the second line is parallel to the y-axis
            else if (a2 == 0)
            {
                Console.WriteLine("The second line is parallel to the y-axis.");
            }
            else
            {
                Console.WriteLine("The second line is not parallel to either the x-axis or the y-axis.");
            }
        }
    }
}
