
class AgetoDays
{
    private static int age;

    public static void Main()
    {
        Console.WriteLine("Enter your age");
        var inputvalue = Console.ReadLine();

        if (inputvalue != null)
        {
            int.TryParse(inputvalue, out age);
            if (age == 0)
            {
                Console.WriteLine("Not valid number");
                return;
            }
        }
        else
        {
            Console.WriteLine("Not valid number");
            return;
        }

        var ageDays = CurrentAge(age);
        Console.WriteLine($"Your age is {ageDays}");
    }

    private static int CurrentAge(int age)
    {
        var ageInDays = age * 365;
        return ageInDays;
    }

}

