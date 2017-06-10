using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTomatoTimer
{
    class ShowHelpJob : IJob
    {
        public void Perform()
        {
            Console.WriteLine("Console Tomato Timer");
            Console.WriteLine("  Set timer in minues (25 by default):");
            Console.WriteLine("    --timer [min]");
        }
    }
}
