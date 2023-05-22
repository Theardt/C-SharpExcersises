using System.Linq;

class BaskPoints
{
    private static int[] arrPoints = {1,1};
    public static void Main()
    {
        int twoPointers;
        int threePointers;

        Console.WriteLine("How much two pointers did your team score?");
        twoPointers = Convert.ToInt32(Console.ReadLine());
        arrPoints[0] = twoPointers;

        Console.WriteLine("How much three pointers did your team score?");
        threePointers = Convert.ToInt32(Console.ReadLine());
        arrPoints[1] = threePointers;

        int Points = Pointers(arrPoints);
        Console.WriteLine($"Your team's points scored is {Points}");
    }

    private static int Pointers(int[] points)
    {
        int Three = 3;
        int Two = 2;
        int Total = 0;
        Total = points[0] * Two;
        Total += points[1] * Three;

        return Total;
    }
}

