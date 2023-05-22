
class AgetoDays
{
    private static readonly int age = 65;
    public static void Main()
    {

        Console.WriteLine("Hello, World!");
        var ageDays = CurrentAge(age);
        Console.WriteLine($"Your age is {ageDays}");
    }

    private static int CurrentAge(int age)
    {
        var ageInDays = age * 365;
        return ageInDays;
    }

}

