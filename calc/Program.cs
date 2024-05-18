﻿namespace calc
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Добро пожаловать в калькулятор");
			double a;
			double b;
			double res;
			char quit;
			char operation;

			Console.WriteLine("Введите 1-е число: ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите 2-е число: ");
			b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите операцию: ");
			operation = Convert.ToChar(Console.ReadLine());

			while (true)
			{
				switch (operation)
				{
					case '+':
						res = a + b;
						Console.WriteLine("Сумма = " + res);
						break;

					case '-':
						res = a - b;
						Console.WriteLine("Разница = " + res);
						break;

					case '*':
						res = a * b;
						Console.WriteLine("Произведение = " + res);
						break;

					case '/':
						if(b== 0)
						{
							Console.WriteLine("Ошибка. Деление на 0");
						}
						else
						{
							res = a / b;
							Console.WriteLine("Частное = " + res);
						}
						break;

					case '^':
						res = Math.Pow(a,b);
						Console.WriteLine($"{a} в степени {b} = {res}");
						break;

				}
				Console.WriteLine("Завершить работу программы (Y / N)?");
				quit = Convert.ToChar(Console.ReadLine());
				if (quit == 'y')
				{
					break;
				}
				else if (quit == 'n')
				{
					continue;
				}



			}
		}
	}
}
