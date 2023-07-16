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

//string path = @"C:\source\SashaBachiri";

//string[] dirs = FileManager.GetDirectoriesRecur(path);
//SmallAlgo.DisplayArray<string>(dirs);
//string[] files = FileManager.GetFilesRecur(path, true);
//SmallAlgo.DisplayArray<string>(files);

//string file = "Extraction WE tickets 13022023.xlsx";
//string filepath = FileManager.PathToFile(path, file, true);
//Console.WriteLine(filepath);

//string[] filepaths = FileManager.AllPathsToFile(path, file, false);
//SmallAlgo.DisplayArray<string>(filepaths);

//string str = "[]";
//Boolean isOK = SmallAlgo.CheckString(str);
//Console.WriteLine(isOK);

//int[] data = new int[] { -100, 20, -2, -3, -20, -3, 2 };
//int closest = SmallAlgo.ClosestToZero(data);
//Console.WriteLine(closest);

//List<Point> points = new List<Point>();
//for (int i = 0; i < 10000000; i++)
//{
//    Random random = new Random();
//    Point point = new Point() { x = random.NextDouble(), y = random.NextDouble() };
//    points.Add(point);
//}
//double pi = SmallAlgo.Approx(points.ToArray());
//Console.WriteLine(pi);

//int a = 50;
//int b = 17;
//int results = SmallAlgo.PGCD(a, b);
//Console.WriteLine(results);


int a = 50;
int b = 17;
int[] results = SmallAlgo.PGCD_Extended(a, b);
Console.WriteLine(results[0]);
Console.WriteLine(results[1]);
Console.WriteLine(results[2]);
