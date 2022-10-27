namespace II.Library.FaultyOO;

public class RentalCar : RentalVehicle
{

    private static ConsoleColor _foregroundColro1 = ConsoleColor.Magenta;
    private static ConsoleColor _foregroundColor2 = ConsoleColor.DarkMagenta;

    public RentalCar() : base(_foregroundColro1, _foregroundColor2)
    {
    }

    public RentalCar(ConsoleColor foregroundColor1, ConsoleColor foregroundColor2) : base(foregroundColor1, foregroundColor2)
    {
        _foregroundColro1 = foregroundColor1;
        _foregroundColor2 = foregroundColor2;

    }

    public CarType Style { get; set; }
}