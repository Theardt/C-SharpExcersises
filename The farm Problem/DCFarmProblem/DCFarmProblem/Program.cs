public abstract class DCFarmProblem
{
    private static readonly int[] animalsArray = new int[3];
    private static int _chickens;
    private static int _cows;
    private static int _pigs;
    const int ChickenLegs = 2;
    const int CowLegs = 4;
    const int PigLegs = 4;
    public static void Main()
    {

        Console.WriteLine("How many chickens?");
        _chickens = Convert.ToInt32(Console.ReadLine());
        animalsArray[0] = _chickens;

        Console.WriteLine("How many cows?");
        _cows = Convert.ToInt32(Console.ReadLine());
        animalsArray[1] = _cows;

        Console.WriteLine("How many pigs?");
        _pigs = Convert.ToInt32(Console.ReadLine());
        animalsArray[2] = _pigs;

        var totalAnimalLegs = TotalLegs(animalsArray);

        Console.WriteLine($"Total legs is {totalAnimalLegs}");
    }

    private static int TotalLegs(int[] legs)
    {
        var chickenLegscount = ChickenLegs * legs[0];
        var cowLegscount = CowLegs * legs[1];
        var pigLegscount = PigLegs * legs[2];

        var totalLegs = chickenLegscount + cowLegscount + pigLegscount;

        return totalLegs;
    }
}
