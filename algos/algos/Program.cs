using algos;
using files;

//int[] data = new int[] { 1, 2, 3, 2, 3, 4 };
//int[] filtered = SmallAlgo.FilterDuplicatesLinq(data);
//SmallAlgo.DisplayArray<int>(filtered);

//string[] words = new string[] { "the", "dog", "got", "a", "bone" };
//string letters = "ae";
//string[] filteredWords = SmallAlgo.FilterWords(words, letters);
//SmallAlgo.DisplayArray<string>(filteredWords);

//int[] numbers = { 1, 5, 8, 1, 2 };
//int k = 9;
//int[] result = SmallAlgo.FindSumPair(numbers, k);
//SmallAlgo.DisplayArray<int>(result);

string path = @"C:\sources\test";

//string[] dirs = FileManager.GetDirectoriesRecur(path);
//SmallAlgo.DisplayArray<string>(dirs);
//string[] files = FileManager.GetFilesRecur(path, true);
//SmallAlgo.DisplayArray<string>(files);

string file = "mondoc.txt";
//string filepath = FileManager.PathToFile(path, file, true);
//Console.WriteLine(filepath);

string[] filepaths = FileManager.AllPathsToFile(path, file, false);
SmallAlgo.DisplayArray<string>(filepaths);