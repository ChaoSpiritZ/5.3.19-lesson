using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._19
{
	class Program
	{
		static void Main(string[] args)
		{
			//question 1
			/*
			for (int i = 1; i < 101; i++)
			{
				while (i % 7 == 0)
				{
					Console.WriteLine(i);
					i++;				
				}
			}
			*/
			//question 2
			/*
			int x = 1;
			int y = 1;
			while(x < 100000)
			{
				Console.WriteLine(x);
				x = x * 10;
				y++;
				x = x + y;
				
			}
			*/
			//question 2 take 2
			/*
			for (int i = 1; i <= 50; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(j);
				}
				Console.WriteLine();
			}
			*/

			//question 3
			/*
			int twohundred = 0;
			int hundred = 0;
			int fifty = 0;
			int twenty = 0;
			int five = 0;

			Console.WriteLine("Please enter the amount you want to pull:");
			int x = Convert.ToInt32(Console.ReadLine());
			
			while (x >= 200)
			{
				x = x - 200;
				twohundred++;
			}
			while(x >= 100)
			{
				x = x - 100;
				hundred++;
			}
			while(x >= 50)
			{
				x = x - 50;
				fifty++;
			}
			while(x >= 20)
			{
				x = x - 20;
				twenty++;
			}
			while (x >= 5)
			{
				x = x - 5;
				five++;
			}
			Console.WriteLine("you get:");
			Console.WriteLine($"{twohundred} 200s");
			Console.WriteLine($"{hundred} 100s");
			Console.WriteLine($"{fifty} 50s");
			Console.WriteLine($"{twenty} 20s");
			Console.WriteLine($"{five} 5s");
			Console.WriteLine($"{x} 1s");
			*/

			// practice question 1
			/*
			int x = Convert.ToInt32(Console.ReadLine());
			for (int i = x; i > 0; i--)
			{
				for (int j = i; j > 0; j--)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			*/
			// practice question 2

			Console.WriteLine("prime numbers will add up, non prime will show you the sum of the primes");
			int sum = 0;
			int x = Convert.ToInt32(Console.ReadLine());
			while (PrimeCheck(x) == true)
			{
				sum = sum + x;
				x = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine($"the sum is {sum}");
		}

		private static bool PrimeCheck(int x)
		{
			int i = 2;
			while (x % i != 0 && x > 1)
			{
				i++;
			}
			if (x == i)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
