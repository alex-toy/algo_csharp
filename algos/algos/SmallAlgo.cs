namespace algos
{
    public static class SmallAlgo
    {

        public static void DisplayArray<T>(T[] array)
        {
            foreach (var item in array) { Console.WriteLine(item); }
        }

        public static int[] FilterDuplicates(int[] data)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < data.Length; i++)
            {
                if (!result.Contains(data[i])) result.Add(data[i]);
            }
            return result.ToArray();
        }

        public static int[] FilterDuplicatesLinq(int[] data)
        {
            return data.ToList().Distinct().ToArray();
        }

        public static string[] FilterWordsLinq(string[] words, string letters)
        {
            return words.ToList().Where(w => w.Any(w => letters.Contains(w))).ToArray();
        }

        public static string[] FilterWords(string[] words, string letters)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (words[i].Contains(letters[j]))
                    {
                        result.Add(words[i]);
                    }
                }

            }
            return result.ToArray();
        }

        public static int[] FindSumPair(int[] numbers, int k)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == k) return new int[] { i, j };
                }
            }
            return new int[] { 0, 0 };
        }
    }
}
