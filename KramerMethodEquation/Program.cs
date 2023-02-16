using System;

namespace KramerMethodEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты первого уравнения (ax + by = c):");

            double a1 = ValidateInput("a");
            double b1 = ValidateInput("b");
            double c1 = ValidateInput("c");

            Console.WriteLine("Введите коэффициенты второго уравнения (dx + ey = f):");

            double a2 = ValidateInput("d");
            double b2 = ValidateInput("e");
            double c2 = ValidateInput("f");

            SolveSystem(a1, b1, c1, a2, b2, c2);
        }

        private static double ValidateInput(string variableName)
        {
            double value;
            while (true)
            {
                Console.Write($"{variableName} = ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
                }
            }
        }

        private static void SolveSystem(double a1, double b1, double c1, double a2, double b2, double c2)
        {
            double det = a1 * b2 - a2 * b1;
            double detX = c1 * b2 - b1 * c2;
            double detY = a1 * c2 - c1 * a2;
            double x, y;

            if (det != 0)
            {
                x = (c1 * b2 - c2 * b1) / det;
                y = (a1 * c2 - a2 * c1) / det;
                Console.WriteLine("Решение системы линейных уравнений:");
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
            }
            else
            {
                if (c1 == 0 && c2 == 0)
                {
                    Console.WriteLine("Система линейных уравнений имеет множество решений.");
                }
                else
                {
                    Console.WriteLine("Система линейных уравнений не имеет решений");
                }
            }

            Console.Write("Первая прямая:");
            CheckLineType(a1, b1, c1);

            Console.Write("Вторая прямая:");
            CheckLineType(a2, b2, c2);
        }

        private static void CheckLineType(double a, double b, double c)
        {
            if(a == 0 && b != 0 && c != 0)
            {
                Console.WriteLine("Прямая параллельна оси Oy");
            }
            else if(a != 0 && b != 0)
            {
                Console.WriteLine("Прямая общего положения");
            }
            else if(a != 0 && b == 0 && c != 0)
            {
                Console.WriteLine("Прямая параллельна оси Ox");
            }
            else if(a != 0 && b == 0 && c == 0)
            {
                Console.WriteLine("Ось Ox");
            }
            else if (a == 0 && b != 0 && c == 0)
            {
                Console.WriteLine("Ось Oy");
            }
            else
            {
                Console.WriteLine("Множество точек");
            }
        }
    }
}
