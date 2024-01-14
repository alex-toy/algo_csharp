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

        public static Boolean CheckString(string str)
        {
            List<Char> opens = new List<Char>();
            foreach (Char c in str)
            {
                if (c == '(' || c == '[') opens.Add(c);
                if (c == ')' || c == ']')
                {
                    if (opens.Count == 0) return false;
                    if ((c == ')' && opens[opens.Count - 1] != '(') || (c == ']' && opens[opens.Count - 1] != '['))
                    {
                        return false;
                    }
                    opens = opens.Take(opens.Count - 1).ToList();
                }
            }
            return opens.Count == 0;
        }

        public static int ClosestToZero(int[] ints)
        {
            int closest = ints[0];
            int closestDist = Math.Abs(closest);

            for (int i = 0; i < ints.Length; i++)
            {
                int current = ints[i];
                int currentDist = Math.Abs(current);
                if (currentDist < closestDist || (currentDist == closestDist && current > 0))
                {
                    closest = current;
                    closestDist = currentDist;
                }
            }

            return closest;
        }

        public static int FindSmallestInterval(int[] ints)
        {
            int smallest = Math.Abs(ints[0] - ints[1]);
            for (int k = 0; k < ints.Length - 1; k++)
            {
                for (int i = k + 1; i < ints.Length; i++)
                {
                    int currentInterval = Math.Abs(ints[i] - ints[k]);
                    if (currentInterval < smallest) smallest = currentInterval;
                }
            }

            return smallest;
        }

        public static int FindBiggestInterval(int[] ints)
        {
            int biggest = Math.Abs(ints[0] - ints[1]);
            for (int k = 0; k < ints.Length - 1; k++)
            {
                for (int i = k + 1; i < ints.Length; i++)
                {
                    int currentInterval = Math.Abs(ints[i] - ints[k]);
                    if (currentInterval > biggest) biggest = currentInterval;
                }
            }

            return biggest;
        }

        public static double Approx(Point[] pts)
        {
            double insideDiscCount = 0;
            for (int i = 0; i < pts.Length; i++)
            {
                double x = pts[i].x;
                double y = pts[i].y;
                double dist = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                Boolean isInsideDisc = dist <= 1;
                if (isInsideDisc) insideDiscCount++;
            }
            return insideDiscCount / pts.Length * 4;
        }

        public static int PGCD(int a, int b)
        {
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);

            if (min == 0) return max;

            int a_mod_b = max % min;

            return PGCD(b, a_mod_b);
        }

        public static int[] PGCD_Extended(int a, int b)
        {
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);

            int u_min_2 = 1;
            int v_min_2 = 0;
            int c_min_2 = Math.Max(a, b);

            int u_min_1 = 0;
            int v_min_1 = 1;
            int c_min_1 = Math.Min(a, b);
            int q_min_1 = c_min_2 / c_min_1;

            int u = u_min_2 - q_min_1 * u_min_1;
            int v = v_min_2 - q_min_1 * v_min_1;
            int c = u * max + v * min;
            int q = c_min_1 / c;
            int r = c_min_1 % c;

            while (r != 0)
            {
                u_min_2 = u_min_1; v_min_2 = v_min_1; q_min_1 = q; u_min_1 = u; v_min_1 = v;
                u = u_min_2 - q_min_1 * u_min_1;
                v = v_min_2 - q_min_1 * v_min_1;
                c_min_1 = c;
                c = u * max + v * min;
                q = c_min_1 / c;
                r = c_min_1 % c;
            }

            int[] results = new int[] { u, v, c };
            return results;
        }
    }
}
