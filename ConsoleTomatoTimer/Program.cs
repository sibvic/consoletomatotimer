using System;

namespace ConsoleTomatoTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            new StartTimerJob().Perform();
        }
    }
}