
namespace II.Library.BetterOO;
public class Car : LandVehicle, IRental
{
    private static ConsoleColor _foregroundColro1 = ConsoleColor.Magenta;
    private static ConsoleColor _foregroundColor2 = ConsoleColor.DarkMagenta;

    public Car() : base(_foregroundColro1, _foregroundColor2)
    {
    }

    public Car(ConsoleColor foregroundColor1, ConsoleColor foregroundColor2) : base(foregroundColor1, foregroundColor2)
    {
        _foregroundColro1 = foregroundColor1;
        _foregroundColor2 = foregroundColor2;

    }

    public int RentalId { get; set; }
    public string CurrentRenter { get; set; }
    public decimal PricePerDay { get; set; }

    public CarType Style { get; set; }
}
