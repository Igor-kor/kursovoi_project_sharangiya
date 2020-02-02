using System;

namespace kursovoi_project_sharangiya
{
    class Program
    {
        static void Main(string[] args)
        {
            // Нижний и верхний пределы интегрирования, количество шагов.
            double a = 0, b = 2, steps;         
            Console.Write("Количество шагов = ");
            steps = Convert.ToDouble(Console.ReadLine());
            // Шаг интегрирования, сумма четных и нечетных элементов
            double h, sumEven = 0, sumOdd = 0;
            h = (b - a) / (2 * steps);
            for (int i = 1; i <= 2 * steps - 1; i += 2)
            {
                // Значения с нечётными индексами, которые нужно умножить на 4.
                sumOdd += function_integral(a + h * i);
                // Значения с чётными индексами, которые нужно умножить на 2.
                sumEven += function_integral(a + h * (i + 1));
            }
            Console.Write("Ответ:" + (b - a) / (6 * steps) * (function_integral(a) + 4 * sumOdd + 2 * (sumEven - function_integral(b))));
            Console.ReadKey();
        }

        // Функция интеграла
        static double function_integral(double x)
        {
            return x * x * Math.Sqrt(4 - x * x);
        }

    }
}
