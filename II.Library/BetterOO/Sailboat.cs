
namespace II.Library.BetterOO;
public class Sailboat : IRental
{
    private readonly ConsoleLogSingleton consoleLogSingleton;
    private static ConsoleColor _foregroundColro1 = ConsoleColor.Green;
    private static ConsoleColor _foregroundColor2 = ConsoleColor.DarkGreen;

    public Sailboat()
    {
        consoleLogSingleton = ConsoleLogSingleton.GetInstance;
    }

    public Sailboat(ConsoleColor foregroundColor1, ConsoleColor foregroundColor2)
    {
        consoleLogSingleton = ConsoleLogSingleton.GetInstance;
        _foregroundColro1 = foregroundColor1;
        _foregroundColor2 = foregroundColor2;

    }

    public int RentalId { get; set; }
    public string CurrentRenter { get; set; }
    public decimal PricePerDay { get; set; }

    public virtual void PrepareToSail()
    {
        consoleLogSingleton.WriteLine("Make sure to have a proper rudder", _foregroundColro1, false);
        consoleLogSingleton.WriteLine("and also proper mast", true);
        consoleLogSingleton.WriteLine();
    }

    public virtual void CustomMessage(string text)
    {
        consoleLogSingleton.WriteLine(text, _foregroundColor2);
        consoleLogSingleton.WriteLine("**********", _foregroundColor2, true);
    }
}