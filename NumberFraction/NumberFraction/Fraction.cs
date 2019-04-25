using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFraction
{
	/// <summary>
	/// класс дробей - рациональных чисел.
	/// </summary>
	class Fraction
	{
		public int numerator;
		public int denominator;

		/// <summary>
		/// Пустой конструктор
		/// </summary>
		public Fraction() { } // для создания пустого объекта в который запишем результат операции

		/// <summary>
		/// конструктор класса Fraction
		/// </summary>
		/// <param name="numer"></param>
		/// <param name="denomi"></param>
		public Fraction(int numer, int denomi)
		{
			numerator = numer;
			denominator = denomi;
		}

		/// <summary>
		/// сложение дробей
		/// </summary>
		/// <param name="fr1"></param>
		/// <param name="fr2"></param>
		/// <returns></returns>
		public static Fraction Adding(Fraction fr1, Fraction fr2) // метод ожидает 2 объекта типа Fraction
		{
			Fraction resultOfFractions = new Fraction(); // новый объект типа Fraction для хранения результата операции

			if (fr1.denominator != fr2.denominator)
			{
				resultOfFractions.denominator = fr1.denominator * fr2.denominator;
				resultOfFractions.numerator = fr1.numerator * fr2.denominator + fr2.numerator * fr1.denominator;
			}
			else
			{
				resultOfFractions.denominator = fr1.denominator;
				resultOfFractions.numerator = fr1.numerator + fr2.numerator;
			}

			return resultOfFractions;
		}

		/// <summary>
		/// вычитание дробей
		/// </summary>
		/// <param name="fr1"></param>
		/// <param name="fr2"></param>
		/// <returns></returns>
		public static Fraction Subtracting(Fraction fr1, Fraction fr2)
		{
			Fraction resultOfFractions = new Fraction();

			if (fr1.denominator != fr2.denominator)
			{
				resultOfFractions.denominator = fr1.denominator * fr2.denominator;
				resultOfFractions.numerator = fr1.numerator * fr2.denominator - fr2.numerator * fr1.denominator;
			}
			else
			{
				resultOfFractions.denominator = fr1.denominator;
				resultOfFractions.numerator = fr1.numerator - fr2.numerator;
			}

			return resultOfFractions;
		}

		/// <summary>
		/// умножение дробей
		/// </summary>
		/// <param name="fr1"></param>
		/// <param name="fr2"></param>
		/// <returns></returns>
		public static Fraction Multiplication(Fraction fr1, Fraction fr2)
		{
			Fraction resultOfFractions = new Fraction();

			resultOfFractions.denominator = fr1.denominator * fr2.denominator;
			resultOfFractions.numerator = fr1.numerator * fr2.numerator;

			return resultOfFractions;
		}
	}
}
