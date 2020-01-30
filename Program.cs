using System;

namespace kursovoi_project_sharangiya
{
	class Program
    {
        static void Main(string[] args)
        {
			//Нижний и верхний пределы интегрирования, погрешность.
			double lowerLimit, upperLimit, steps;
			Console.Write("Нижний предел интегрирования = ");
			lowerLimit = Convert.ToDouble( Console.ReadLine());
			Console.Write("Верхний предел интегрирования = ");
			upperLimit = Convert.ToDouble(Console.ReadLine());
			Console.Write("Погрешность интегрирования = ");
			steps = Convert.ToDouble(Console.ReadLine());
			//N<=4 - чтобы не сравнивал на 1 шаге, т.к. newValue = 0

				double h, sumEven = 0, sumOdd = 0;
				//Шаг интегрирования.
				h = (upperLimit - lowerLimit) / (2 * steps);
				for (int i = 1; i <= 2 * steps - 1; i += 2)
				{
					//Значения с нечётными индексами, которые нужно умножить на 4.
					sumOdd += function_integral(lowerLimit + h * i);
					//Значения с чётными индексами, которые нужно умножить на 2.
					sumEven += function_integral(lowerLimit + h * (i + 1));
				}
				//Отнимаем значение function_integral так как ранее прибавили его дважды. 

			Console.Write("Ответ:");
			Console.Write((upperLimit - lowerLimit) / (6 * steps) * (function_integral(lowerLimit) + 4 * sumOdd + 2 * sumEven - function_integral(upperLimit)));
		}

		static double function_integral(double x)
		{
			return x * x *Math.Sqrt(4-x*x);
		}


	}
}
