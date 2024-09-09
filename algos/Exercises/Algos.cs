namespace Exercises;

public class Algos
{
    public bool IsPalindrome(int x)
    {
        int original = x;
        int reversed = 0;
        while (original > 0)
        {
            int unit = original % 10;
            original /= 10;
            reversed = reversed * 10 + unit;
        }

        return reversed == x;
    }

    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target) return [i, j];
            }
        }

        return [];
    }

    public int[] TwoSumBetter(int[] nums, int target)
    {
        Dictionary<int, int> complements = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (complements.ContainsKey(complement)) return [i, complements[complement]];

            complements[nums[i]] = i;
        }

        return [];
    }
}
