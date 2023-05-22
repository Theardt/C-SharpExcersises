// See https://aka.ms/new-console-template for more information


class MinToSec
{
    private static int minutes = 3;
    public static void Main()
    {
        int seconds = MintoSecFunc(minutes);
        System.Console.WriteLine($"Numbr of seconds is {seconds}");
    }

    private static int MintoSecFunc(int mins)
    {
        int secs = mins * 60;
        return secs;
    } 
}
