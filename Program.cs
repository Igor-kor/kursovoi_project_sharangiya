using System;

namespace kursovoi_project_sharangiya
{
    class Program
    {
        static void Main(string[] args)
        {
            //Нижний и верхний пределы интегрирования, погрешность.
            double a, b, steps;
            Console.Write("Нижний предел интегрирования = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Верхний предел интегрирования = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Погрешность интегрирования = ");
            steps = Convert.ToDouble(Console.ReadLine());

            double h, sumEven = 0, sumOdd = 0;
            //Шаг интегрирования.
            h = (b - a) / (2 * steps);
            for (int i = 1; i <= 2 * steps - 1; i += 2)
            {
                //Значения с нечётными индексами, которые нужно умножить на 4.
                sumOdd += function_integral(a + h * i);
                //Значения с чётными индексами, которые нужно умножить на 2.
                sumEven += function_integral(a + h * (i + 1));
            }
            //Отнимаем значение function_integral так как ранее прибавили его дважды. 
            Console.Write("Ответ:");
            Console.Write((b - a) / (6 * steps) * (function_integral(a) + 4 * sumOdd + 2 * sumEven - function_integral(b)));
        }

        static double function_integral(double x)
        {
            return x * x * Math.Sqrt(4 - x * x);
        }

    }
}
