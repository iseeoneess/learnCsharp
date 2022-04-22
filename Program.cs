using System;
using System.Threading;



namespace sumarr
{
	class Program
	{

	  static void exampleSumArrays()
		{
			int[] randomArr = { 12, 44, 16, 97, 36, 84 };

			int buferResult = 0;
			int result = 0;

			for (int i = 0; i < randomArr.Length; i++)
			{
				buferResult = randomArr[i];

				result += buferResult;
			}
			Console.WriteLine(result);
		}




	  static void sumArraysRecursiveMetod (int [] arr, int i, int result, int buferResult)
		{
			buferResult = arr[i];
			result += buferResult;
			i++;
			if (i == arr.Length)
			{
				Console.WriteLine(result);
			}
			if (i == arr.Length)
				return;
			sumArraysRecursiveMetod(arr, i, result, buferResult);




		}

	  static void Main(string[] args)
		{
			int i = 0;
			int result = 0;
			int buferResult = 0;
	  

			int [] randomArr = { 44, 16};
			sumArraysRecursiveMetod(randomArr, i, result, buferResult);
		}
	}
}