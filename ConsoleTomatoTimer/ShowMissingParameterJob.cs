using System;

namespace ConsoleTomatoTimer
{
    class ShowMissingParameterJob : IJob
    {
        string _parameterName;
        public ShowMissingParameterJob(string parameterName)
        {
            _parameterName = parameterName;
        }

        public void Perform()
        {
            Console.WriteLine("{0} parameter value is missing", _parameterName);
        }
    }
}
