using System;

namespace kursovoi_project_sharangiya
{
	class Program
    {
        static void Main(string[] args)
        {
			//Нижний и верхний пределы интегрирования, погрешность.
			double lowerLimit, upperLimit, calcEror;
			Console.Write("Нижний предел интегрирования = ");
			lowerLimit = Convert.ToDouble( Console.ReadLine());
			Console.Write("Верхний предел интегрирования = ");
			upperLimit = Convert.ToDouble(Console.ReadLine());
			Console.Write("Погрешность интегрирования = ");
			calcEror = Convert.ToDouble(Console.ReadLine());
			//предыдущее вычисленное значение интеграла, новое значение.
			double oldValue = calcEror + 1, newValue = 0;
			//N<=4 - чтобы не сравнивал на 1 шаге, т.к. newValue = 0
			for (int N = 2; (N <= 4) || (Math.Abs(newValue - oldValue) > calcEror); N *= 2)
			{
				double h, sumEven = 0, sumOdd = 0, sum = 0;
				//Шаг интегрирования.
				h = (upperLimit - lowerLimit) / (2 * N);
				for (int i = 1; i <= 2 * N - 1; i += 2)
				{
					//Значения с нечётными индексами, которые нужно умножить на 4.
					sumOdd += function_integral(lowerLimit + h * i);
					//Значения с чётными индексами, которые нужно умножить на 2.
					sumEven += function_integral(lowerLimit + h * (i + 1));
				}
				//Отнимаем значение function_integral так как ранее прибавили его дважды. 
				sum = (upperLimit - lowerLimit)/6 *  function_integral(lowerLimit) + 4 * sumOdd + 2 * sumEven - function_integral(upperLimit);
				oldValue = newValue;
				newValue = (h / 3) * sum;
			}
			Console.WriteLine("Ответ:%d",newValue);
		}

		static double function_integral(double x)
		{
			return x * x *Math.Sqrt(4-x*x);
		}


	}
}
