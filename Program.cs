using System;

namespace kursovoi_project_sharangiya
{
    class Program
    {
        static void Main(string[] args)
        {
            //Нижний и верхний пределы интегрирования, погрешность.
            double b, a, Steps;
            Console.Write("Нижний предел интегрирования = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Верхний предел интегрирования = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Верхний Количество шагов = ");
            Steps = Convert.ToDouble(Console.ReadLine());
            double h = (b - a) / (2 * Steps);
            double x0 = a, x1 = a + h, sumEvent = 0, sumOdd = 0, sum;
            //N<=4 - чтобы не сравнивал на 1 шаге, т.к. newValue = 0
            for (int i = 1; i <= (Steps - 1); i++)
            {
                if (i % 2 == 0) {
                    sumEvent += functionIntegral(x0);
                        x0 += h * i;
                }
              
            }
            for (int i = 1; i <= (Steps - 1); i++)
            {
                if (i % 2 == 0)
                {
                    sumOdd += functionIntegral(x0);
                    x0 += h * i;
                }

            }
            sum = functionIntegral(x0)+ functionIntegral(x2n) +4*()
            Console.WriteLine((b-a / 6*h) * sum);
        }

        static double functionIntegral(double x)
        {
            return x * x * Math.Sqrt(4 - x * x);
        }


    }
}
