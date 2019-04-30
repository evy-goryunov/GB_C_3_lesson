using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Горюнов Евгений
 * *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
 * Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, 
 * демонстрирующую все разработанные элементы класса. 
 * Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
 * ArgumentException("Знаменатель не может быть равен 0");
 * Добавить упрощение дробей.
 */
namespace NumberFraction
{
	class Program
	{
		static void Main(string[] args)
		{
			Fraction fr1 = new Fraction(30, 0);
			Fraction fr2 = new Fraction(20, 0);
			Fraction fr3 = new Fraction();

			Console.WriteLine("Результат сложения");
			fr3.numerator = Fraction.Adding(fr1, fr2).numerator;
			fr3.denominator = Fraction.Adding(fr1, fr2).denominator;
			Console.WriteLine(fr3.numerator + "/" + fr3.denominator);

			Console.WriteLine("Результат вычитания");
			fr3.numerator = Fraction.Subtracting(fr1, fr2).numerator;
			fr3.denominator = Fraction.Subtracting(fr1, fr2).denominator;
			Console.WriteLine(fr3.numerator + "/" + fr3.denominator);

			Console.WriteLine("Результат умножения");
			fr3.numerator = Fraction.Multiplication(fr1, fr2).numerator;
			fr3.denominator = Fraction.Multiplication(fr1, fr2).denominator;
			Console.WriteLine(fr3.numerator + "/" + fr3.denominator);

			Console.WriteLine("Результат деления");
			fr3.numerator = Fraction.Division(fr1, fr2).numerator;
			fr3.denominator = Fraction.Division(fr1, fr2).denominator;
			Console.WriteLine(fr3.numerator + "/" + fr3.denominator);

			Console.WriteLine("Упрощение дроби");
			fr3.numerator = Fraction.GreatestCommonDivisor(fr3).numerator;
			fr3.denominator = Fraction.GreatestCommonDivisor(fr3).denominator;
			Console.WriteLine(fr3.numerator + "/" + fr3.denominator);



			Console.ReadKey();
		}
	}
}
