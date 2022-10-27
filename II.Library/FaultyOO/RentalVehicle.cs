
namespace II.Library.FaultyOO;

/*
We have cornered ourselves with 
1. Style so moved it to RentalCars and RentalTruck. Removed for RetalBoat and RentalSailBoat
2. StartEngine and StopEngine do not apply to RentalSailBoat. So made then virtual and override with throw exception in RentalSailBoat
*/
public class RentalVehicle
{
    public readonly ConsoleLogSingleton consoleLogSingleton;
    private readonly ConsoleColor _foregroundColro1;
    private readonly ConsoleColor _foregroundColor2;

    public RentalVehicle()
    {
        consoleLogSingleton = ConsoleLogSingleton.GetInstance;
        _foregroundColro1 = ConsoleColor.Magenta;
        _foregroundColor2 = ConsoleColor.DarkMagenta;
    }

    public RentalVehicle(ConsoleColor foregroundColor1, ConsoleColor foregroundColor2)
    {
        consoleLogSingleton = ConsoleLogSingleton.GetInstance;
        _foregroundColro1 = foregroundColor1;
        _foregroundColor2 = foregroundColor2;
    }

    public int RentalId { get; set; }
    public string CurrentRenter { get; set; }
    public decimal PricePerDay { get; set; }
    public int NumberOfPassengers { get; set; }

    public virtual void StartEngine()
    {
        consoleLogSingleton.WriteLine("Turn key to ignition setting", _foregroundColro1, false);
        consoleLogSingleton.WriteLine("Turn key to on", true);
        consoleLogSingleton.WriteLine();
    }

    public virtual void StopEngine()
    {
        consoleLogSingleton.WriteLine("Turn key to of", _foregroundColor2, true);
        consoleLogSingleton.WriteLine();
    }
}
