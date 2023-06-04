// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам

using System;
namespace ControlWork
{
	class ControlWork
	{
		static void Main()
		{
			Console.Clear();
			System.Console.WriteLine("Enter number off array");
			int length = int.Parse(Console.ReadLine()!);
			string[] Array = CreateArr(length);
			ShowArr(Array);
			string[] result = CreateNewArr(Array);
			ShowArr(result);
		}

		public static string[] CreateArr(int length)
		{
			string[] Arr = new string[length];
			for (int i = 0; i < Arr.GetLength(0); i++)
			{
				System.Console.WriteLine($"Enter string to {i + 1} elem");
				string input = Console.ReadLine()!;
				Arr[i] = input;
			}
			return Arr;
		}
	}
}