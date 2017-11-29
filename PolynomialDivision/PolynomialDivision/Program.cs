	using System;
	using System.Collections.Generic;

	namespace PolynomialDivision
	{
		public class Program
		{
			public static void Main(string[] args)
			{
				Console.WriteLine("Enter the highest degree of numerator:");
				int degree = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter the coefficients  of the numerator in order of decreasing degree");
				int[] coefficientsNum = new int[degree + 1];
				for (int i = 0; i < coefficientsNum.Length; i++)
				{
					coefficientsNum[i] = int.Parse(Console.ReadLine());
				}
				Console.WriteLine("Enter the highest degree of denominator:");
				int degree2 = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter the coefficients  of the numerator in order of decreasing degree");
				int[] coefficientsDem = new int[degree2 + 1];
				for (int i = 0; i < coefficientsDem.Length; i++)
				{
					coefficientsDem[i] = int.Parse(Console.ReadLine());
				}
				int currentDegree = degree;
				List<int> solutionCoefficients = new List<int>();
				List<int> tempCoefficients = new List<int>();
				tempCoefficients.AddRange(coefficientsNum);
				tempCoefficients.Add(0);
				tempCoefficients.Add(0);


				for (int i = 0; i < coefficientsNum.Length; i++)
				{
					if (currentDegree >= 0)
					{
						solutionCoefficients.Add(tempCoefficients[i] / coefficientsDem[0]);
						for (int e = 0; e < coefficientsDem.Length; e++)
						{
							tempCoefficients[i + e] = tempCoefficients[i + e] - (solutionCoefficients[i] * coefficientsDem[e]);
						}
						currentDegree--;
					}
					else
					{
						solutionCoefficients.Add(tempCoefficients[i] / coefficientsDem[0]);
					}
				}





				Console.WriteLine("Solution:");
				for (int i = 0; i < (degree - degree2) + 1; i++)
				{
					Console.WriteLine(solutionCoefficients[i]);
				}
				Console.WriteLine("Remainder:");
				for(int i = (degree - degree2) + 1; i < solutionCoefficients.Count; i++)
				{
					Console.WriteLine(solutionCoefficients[i]);
				}
				Console.ReadKey();
			}
		}
	}
