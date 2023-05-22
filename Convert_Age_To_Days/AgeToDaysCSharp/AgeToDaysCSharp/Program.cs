// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class AgeToDays
{
    public static void Main()
    {
        Console.WriteLine("Hello, what is your age?");
        var ageText = 65;
        var ageDays = CalcAge(ageText);
        Console.WriteLine($"Your age is {ageDays}");
    }

    public static int CalcAge(int age)
    {
        var dayAgeint = age * 365;
        return dayAgeint;
    }

}
