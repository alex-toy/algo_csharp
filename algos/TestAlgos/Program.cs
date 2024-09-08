using Exercises;

Algos algo = new();

int[] nums = [2, 7, 11, 15];

int[] result = algo.TwoSum(nums, 9);
result = algo.TwoSumBetter(nums, 9);

nums = [3, 2, 4];

result = algo.TwoSum(nums, 6);
result = algo.TwoSumBetter(nums, 6);


Console.ReadLine();