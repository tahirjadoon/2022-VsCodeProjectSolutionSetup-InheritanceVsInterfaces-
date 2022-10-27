using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace II.Library.BetterOO;

public class Truck : LandVehicle, IRental
{
    private static ConsoleColor _foregroundColro1 = ConsoleColor.Yellow;
    private static ConsoleColor _foregroundColor2 = ConsoleColor.DarkYellow;

    public Truck() : base(_foregroundColro1, _foregroundColor2)
    {
    }

    public Truck(ConsoleColor foregroundColor1, ConsoleColor foregroundColor2) : base(foregroundColor1, foregroundColor2)
    {
        _foregroundColro1 = foregroundColor1;
        _foregroundColor2 = foregroundColor2;
    }

    public int RentalId { get; set; }
    public string CurrentRenter { get; set; }
    public decimal PricePerDay { get; set; }

    public TruckType Style { get; set; }
}