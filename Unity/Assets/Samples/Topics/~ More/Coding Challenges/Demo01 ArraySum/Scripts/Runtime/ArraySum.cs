using System.Collections.Generic;
using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.CodingChallenges.ArraySum
{
	/// <summary>
	///  Question: Given an array of integers,
	///				return indices of the two numbers such
	///				that they add up to a specific target value
	/// </summary>
	public class ArraySum : BaseDemo
	{
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			//Question
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
			var targetSum = 7;
			var result = FindIndexesForTargetSum(numbers, targetSum);
				
			//Results
			Debug.Log($"Which indexes added together equals targetSum = {targetSum}?");
			if (result.Count == 0)
			{
				Debug.Log("No answer found");
			}
			else
			{
				Debug.Log($"Index A = {result[0]}");
				Debug.Log($"Index B = {result[1]}");
			}
		
		}

		//The time complexity of FindIndexesForTargetSum is O(n^2)
        List<int> FindIndexesForTargetSum(List<int> numbers, int targetSum)
        {
	        List<int> result = new List<int>();

	        //Loop n
	        for (int i = 0; i < numbers.Count; i++)
	        {
		        //Loop n
		        for (int j = i + 1; j < numbers.Count; j++)
		        {
			        if (numbers[i] + numbers[j] == targetSum)
			        {
				        result.Add(i);
				        result.Add(j);
				        break;
			        }
		        }
	        }

	        return result;

        }


    }
}