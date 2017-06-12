using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleTomatoTimer
{
    class StartTimerJob : IJob
    {
        public int TimerLengthInMinues { get; set; } = 25;

        public bool Silent { get; set; } = false;

        public void Perform()
        {
            Console.WriteLine("Starting timer ({0} minutes)", TimerLengthInMinues);

            var timerEvent = new ManualResetEvent(false);

            int elapsedMinutes = 0;
            var timer = new Timer(new TimerCallback((obj) => 
            {
                ++elapsedMinutes;
                timerEvent.Set();
            }), null, 60000, 60000);

            while (elapsedMinutes < TimerLengthInMinues)
            {
                timerEvent.WaitOne();
                if (!Silent)
                {
                    Console.WriteLine("{1} elapsed, {0} remained", TimerLengthInMinues - elapsedMinutes, elapsedMinutes);
                }
                timerEvent.Reset();
            }
            timer.Dispose();
            Console.WriteLine("Done!");
        }
    }
}
