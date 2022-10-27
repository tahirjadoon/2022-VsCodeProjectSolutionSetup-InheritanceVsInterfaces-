
namespace II.Library.FaultyOO;
public class RentalSailBoat : RentalVehicle
{
    private static ConsoleColor _foregroundColro1 = ConsoleColor.Green;
    private static ConsoleColor _foregroundColor2 = ConsoleColor.DarkGreen;

    public RentalSailBoat() : base(_foregroundColro1, _foregroundColor2)
    {
    }

    public RentalSailBoat(ConsoleColor foregroundColor1, ConsoleColor foregroundColor2) : base(foregroundColor1, foregroundColor2)
    {
        _foregroundColro1 = foregroundColor1;
        _foregroundColor2 = foregroundColor2;

    }

    public override void StartEngine()
    {
        throw new Exception("I do not have an engine to start");
    }

    public override void StopEngine()
    {
        throw new Exception("I do not have an engine to stop");
    }
}
