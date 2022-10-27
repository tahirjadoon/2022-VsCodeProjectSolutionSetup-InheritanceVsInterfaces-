using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace II.Library.BetterOO
{
    public class LandVehicle
    {
        public readonly ConsoleLogSingleton consoleLogSingleton;
        private readonly ConsoleColor _foregroundColro1;
        private readonly ConsoleColor _foregroundColor2;

        public LandVehicle()
        {
            consoleLogSingleton = ConsoleLogSingleton.GetInstance;
            _foregroundColro1 = ConsoleColor.Magenta;
            _foregroundColor2 = ConsoleColor.DarkMagenta;
        }

        public LandVehicle(ConsoleColor foregroundColor1, ConsoleColor foregroundColor2)
        {
            consoleLogSingleton = ConsoleLogSingleton.GetInstance;
            _foregroundColro1 = foregroundColor1;
            _foregroundColor2 = foregroundColor2;
        }

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

        public virtual void CustomMessage(string text)
        {
            consoleLogSingleton.WriteLine(text, _foregroundColor2);
            consoleLogSingleton.WriteLine("**********", _foregroundColor2, true);
        }
    }
}