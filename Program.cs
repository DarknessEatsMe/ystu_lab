namespace fyff
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double a;
			double b;
			double res;
			char operation;

			Console.WriteLine("Введите 1-е число: ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите 2-е число: ");
			b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите операцию: ");
			operation = Convert.ToChar(Console.ReadLine());

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
					res = a / b;
					Console.WriteLine("Частное = " + res);
					break;
			}

		}
	}
}
