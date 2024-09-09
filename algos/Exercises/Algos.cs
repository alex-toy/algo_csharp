namespace Exercises;

public class Algos
{
    public int[] GetAverages(int[] nums, int k)
    {
        if (k == 0) return nums;

        int span = 2 * k + 1;
        int[] avgs = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            int lower = i - k;
            if (lower < 0)
            {
                avgs[i] = -1;
                continue;
            }
                
            int upper = i + k;
            if (upper > nums.Length - 1)
            {
                avgs[i] = -1;
                continue;
            }

            int current = 0;
            for (int j = lower; j <= upper; j++)
            {
                current += nums[j];
            }
            avgs[i] = current / span;
        }

        return avgs;
    }

    public int LargestAltitude(int[] gains)
    {
        int current = 0;
        int highest = 0;
        for (int i = 0; i < gains.Length; i++)
        {
            current += gains[i];
            if (current > highest) highest = current;
        }
        return highest;
    }

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
