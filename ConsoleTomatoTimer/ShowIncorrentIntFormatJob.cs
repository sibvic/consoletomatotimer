using System;

namespace ConsoleTomatoTimer
{
    class ShowIncorrentIntFormatJob : IJob
    {
        string _parameterName;
        public ShowIncorrentIntFormatJob(string parameterName)
        {
            _parameterName = parameterName;
        }

        public void Perform()
        {
            Console.WriteLine("Incorrent number format for the parameter {0}", _parameterName);
        }
    }
}
