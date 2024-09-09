namespace Exercises;

public static class WebReview
{
    public static void Ex3()
    {
        string name = Console.ReadLine();
        string ageInput = Console.ReadLine();
        bool isAgeInterger = int.TryParse(ageInput, out int age);
        string message = isAgeInterger ? $"Name : {name} - Age : {age}" : $"age is wrong";
        Console.WriteLine(message);
    }
}
