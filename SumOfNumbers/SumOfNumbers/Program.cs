﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Горюнов Евгений
 *  а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
 *	   Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
	б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
	   При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
 */


namespace SumOfNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int a;
			int temp = 0;
			ArrayList list = new ArrayList();
			

			Console.WriteLine("Вводите числа.");

			while (true)
			{

				a = Convert.ToInt32(Console.ReadLine());

				if (a % 2 != 0 && a > 0)
				{
					temp = temp + a;
					list.Add(a);
				}
				else if (a == 0)
				{
					break;
				}
			}
			for (int i = 0; i < list.Count; i++)
			{
				Console.WriteLine("Нечетное положительное число:" + list[i]);
			}
			Console.WriteLine("Сумма всех нечетных положительных чисел: {0:F0}", temp);
			Console.ReadKey();

			//Int32.TryParse(Console.ReadLine());
		}
	}
}
