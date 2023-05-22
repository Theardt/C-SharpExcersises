
public abstract class DCBasketBallPoints
{
    private static readonly int[] PointsArray = new int[2];
    private static int _twoPointers;
    private static int _threePointers;
    public static void Main()
    {

        Console.WriteLine("How much two pointers did your team score?");
        _twoPointers = Convert.ToInt32(Console.ReadLine());
        PointsArray[0] = _twoPointers;



        Console.WriteLine("How much three pointers did your team score?");
        _threePointers = Convert.ToInt32(Console.ReadLine());
        PointsArray[1] = _threePointers;

        var pointsScored = BasketBallPoints(PointsArray);

        Console.WriteLine($"Your scored points is {pointsScored}");
    }

    private static int BasketBallPoints(int[] points)
    {
        var threePoints = 3;
        var twoPoints = 2;


        var totalThree = points[0] * threePoints;
        var totalTwo = points[1] * twoPoints;
        var totalPoints = totalThree + totalTwo;

        return totalPoints;
    }
}