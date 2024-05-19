using System.Collections.Generic;
using System.Linq;
using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.CodingChallenges.Fibonacci
{
	/// <summary>
	/// 
	/// The Fibonacci numbers, commonly denoted F(n) form a sequence,
	/// called the Fibonacci sequence, such that each number is the sum
	/// of the two preceding ones, starting from 0 and 1.
	///
	/// VIDEO: https://www.youtube.com/watch?v=8o8w_vBj9ac
	/// </summary>
	public class Fibonacci : BaseDemo
	{
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			// Question 1: Return the value at the n index
			// of the Fibonacci sequence
			var n1 = 11;
			var result1 = CalculateFibonacciInt(n1);
			Debug.Log($"The Fibonacci at index {n1} is {result1}. ");

			// Question 2: Return list of all value from 0 index
			// to the n index of the Fibonacci sequence
			var from2 = 0;
			var n2 = 11;
			var result2 = CalculateFibonacciSequence(from2, n2);
			Debug.Log($"The Fibonacci sequence from index 0 to index {n2} is {string.Join(",", result2)}. ");

		}
		
		// Exponential Time Complexity: O(2^N)
		protected List<int> CalculateFibonacciSequence(int from, int n)
		{
			List<int> result = new List<int>();
			for (int i = from; i <= n; i++)
			{
				result.Add(CalculateFibonacciInt(i));
			}
			return result;
		}
		
		// Exponential Time Complexity: ?
		protected int CalculateFibonacciInt(int n)
		{
			// Part 1 - The base case, that ends recursion
			if (n == 0)
			{
				return 0;
			}

			if (n == 1)
			{
				return 1;
			}
			
			// Part 2 - The recursive case, that continues recursion
			return CalculateFibonacciInt(n - 1) + CalculateFibonacciInt(n - 2);
		}

	}
}