
using Exercises;

//WebReview.Ex3();

Algos algos = new Algos();

//int[] gains = [-5, 1, 5, 0, -7];
//int result = algos.LargestAltitude(gains);

//gains = [-4, -3, -2, -1, 4, 3, 2];
//result = algos.LargestAltitude(gains);

int[] nums = [-4, -3, -2, -1, 4, 3, 2];
int[] result = algos.GetAverages(nums, 2);

result = algos.GetAverages(nums, 0);

Console.ReadLine();