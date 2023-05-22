You are counting points for a basketball game, given the amount of 3-pointers scored and 2-pointers scored, find the final points for the team and return that value ([2 -pointers scored, 3-pointers scored]).

Examples
points(1, 1) ➞ 5

points(7, 5) ➞ 29

points(38, 8) ➞ 100

Call the function at least 5 times to test code in the main function

public abstract class Program
{
    private static int[] pointsarray = {1, 1};
    public static void main()
    {
        int pointsScored = basketBallPoints(pointsarray);

        Console.WriteLine($"Your scored points is {pointsScored}");
    }

    private static int basketBallPoints(Array points)
    {
        int threePoints = 3;
        int twoPoints = 2;

        foreach (var aaa in points)
        {
            Console.WriteLine(aaa);
        }

   //     int totalthree = points[0] * threePoints;
   //     int totaltwo = points[1] * threePoints;

        int pointsint = 0;
        return 0;
    }
}
