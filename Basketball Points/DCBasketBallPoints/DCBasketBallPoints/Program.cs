
public abstract class DCBasketBallPoints
{
    private static int[] pointsarray = new int[2];
    private static int twoPointers;
    private static int threePointers;
    public static void Main()
    {

        Console.WriteLine("How much two pointers did your team score?");
        twoPointers = Convert.ToInt32(Console.ReadLine());
        pointsarray[0] = twoPointers;



        Console.WriteLine("How much three pointers did your team score?");
        threePointers = Convert.ToInt32(Console.ReadLine());
        pointsarray[1] = threePointers;

        int pointsScored = basketBallPoints(pointsarray);

        Console.WriteLine($"Your scored points is {pointsScored}");
    }

    private static int basketBallPoints(int[] points)
    {
        var threePoints = 3;
        var twoPoints = 2;


        var totalThree = points[0] * threePoints;
        var totalTwo = points[1] * twoPoints;
        var totalPoints = totalThree + totalTwo;

        return totalPoints;
    }
}