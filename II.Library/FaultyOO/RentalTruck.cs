
namespace II.Library.FaultyOO;
public class RentalTruck : RentalVehicle
{
    private static ConsoleColor _foregroundColro1 = ConsoleColor.Yellow;
    private static ConsoleColor _foregroundColor2 = ConsoleColor.DarkYellow;

    public RentalTruck() : base(_foregroundColro1, _foregroundColor2)
    {
    }

    public RentalTruck(ConsoleColor foregroundColor1, ConsoleColor foregroundColor2) : base(foregroundColor1, foregroundColor2)
    {
        _foregroundColro1 = foregroundColor1;
        _foregroundColor2 = foregroundColor2;
    }

    public TruckType Style { get; set; }
}
