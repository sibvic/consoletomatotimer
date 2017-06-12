using System;

namespace ConsoleTomatoTimer
{
    class ShowUnknownParameterJob : IJob
    {
        string _parameter;
        public ShowUnknownParameterJob(string parameter)
        {
            _parameter = parameter;
        }

        public void Perform()
        {
            Console.WriteLine("Unknwon parameter: {0}", _parameter);
        }
    }
}
