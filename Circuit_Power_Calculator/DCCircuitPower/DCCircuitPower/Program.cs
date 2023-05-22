public abstract class DCCircuitPower
{
    private static readonly int[] CircuitArray = new int[2];
    private static int _voltage;
    private static int _current;
    public static void Main()
    {

        Console.WriteLine("What is your voltage?");
        _voltage = Convert.ToInt32(Console.ReadLine());
        CircuitArray[0] = _voltage;



        Console.WriteLine("What is your current?");
        _current = Convert.ToInt32(Console.ReadLine());
        CircuitArray[1] = _current;

        var circuitPower = CircuitPower(CircuitArray);

        Console.WriteLine($"Your total circuit power is {circuitPower}");
    }

    private static int CircuitPower(int[] circuits)
    {

        var totalCircuitPower = circuits[0]* circuits[1];

        return totalCircuitPower;
    }
}
