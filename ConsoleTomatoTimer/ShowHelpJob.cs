using System;

namespace ConsoleTomatoTimer
{
    class ShowHelpJob : IJob
    {
        public void Perform()
        {
            Console.WriteLine("Console Tomato Timer");
            Console.WriteLine("  Set timer in minues (25 by default):");
            Console.WriteLine("    --timer [min]");
            Console.WriteLine("  Silent mode:");
            Console.WriteLine("    --silent");
            Console.WriteLine("  This help:");
            Console.WriteLine("    --help");
        }
    }
}
