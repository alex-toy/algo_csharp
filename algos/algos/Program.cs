void DisplayArray<T>(T[] array)
{
    foreach (var item in array) { Console.WriteLine(item); }
}

int[] FilterDuplicates(int[] data)
{
    List<int> result = new List<int>();
    for (int i = 0; i < data.Length; i++) 
    { 
        if(!result.Contains(data[i])) result.Add(data[i]);
    }
    return result.ToArray();
}

int[] FilterDuplicatesLinq(int[] data)
{
    return data.ToList().Distinct().ToArray();
}

int[] data = new int[] {1, 2, 3, 2, 3, 4};

int[] filtered = FilterDuplicatesLinq(data);
DisplayArray<int>(filtered);



string[] FilterWordsLinq(string[] words, string letters)
{
    return words.ToList().Where(w => w.Any(w => letters.Contains(w))).ToArray();
}

string[] FilterWords(string[] words, string letters)
{
    List<string> result = new List<string>();
    for (int i = 0; i < words.Length; i++)
    {
        for(int j = 0; j < letters.Length; j++)
        {
            if(words[i].Contains(letters[j]))
            {
                result.Add(words[i]);
            }
        }

    }
    return result.ToArray();
}

string[] words = new string[] { "the", "dog", "got", "a", "bone" };
string letters = "ae";
string[] filteredWords = FilterWords(words, letters);
DisplayArray<string>(filteredWords);



int[] FindSumPair(int[] numbers, int k)
{
    for(int i = 0; i < numbers.Length-1; i++)
    {
        for(int j = i+1; j<numbers.Length; j++)
        {
            if(numbers[i] + numbers[j] == k) return new int[] { i, j };   
        }
    }
    return new int[]{ 0, 0};
}

int[] numbers = { 1, 5, 8, 1, 2 };
int k = 25;
int[] result = FindSumPair(numbers, k);
DisplayArray<int>(result);