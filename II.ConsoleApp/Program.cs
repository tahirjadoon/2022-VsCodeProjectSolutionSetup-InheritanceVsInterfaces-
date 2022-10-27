/*
    Inheritance is not code sharing
    Is-a relationship
    Need to share common logic
    Sharing just properties or method signature is not enough
    Inheritance can put you in a corner
    You need to ask the question: What is the point?
*/

using System.Collections.Generic;
using II.Library;
using II.Library.BetterOO;

//singleton class use for console colors
var consoleHelper = ConsoleLogSingleton.GetInstance;

//call rentals to run BetterOO
Rentals();

//end of the testing
consoleHelper.Write("Press any key to exit", ConsoleColor.Red);
Console.ReadKey();
consoleHelper.WriteLine();

void Rentals()
{
    var rentals = new List<IRental>();

    //add truck rental
    rentals.Add(new Truck() { CurrentRenter = "Truck Renter", Style = TruckType.LongBed });
    rentals.Add(new Sailboat() { CurrentRenter = "Sailboat Renter" });
    rentals.Add(new Car() { CurrentRenter = "Car Rental", Style = CarType.Sedan });

    foreach (var r in rentals)
    {
        if (r is Truck t)
        {
            //can access the base class properties via t
            t.CustomMessage("Trucks Info");
            t.StartEngine();
            t.StopEngine();

        }
        if (r is Sailboat s)
        {
            s.CustomMessage("Sailboat");
            s.PrepareToSail();
        }
        if (r is Car c)
        {
            //can access the base class properties via t
            c.CustomMessage("Trucks Info");
            c.StartEngine();
            c.StopEngine();
        }
    }
}

