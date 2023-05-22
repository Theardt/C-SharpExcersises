// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

class MinToSec
{
    private static int Minutes = 5;
    public static void Main()
    {
        int Seconds = FuncMinToSec(Minutes);
        System.Console.WriteLine($"Number of seconds is {Seconds}");    
    }

    private static int FuncMinToSec(int Mins)
    { 
        int secs = Mins * 60;
        return secs; 
    }
}
