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

int[] data = new int[] {1, 2, 3, 2, 3, 4};

int[] filtered = FilterDuplicates(data);
DisplayArray<int>(filtered);