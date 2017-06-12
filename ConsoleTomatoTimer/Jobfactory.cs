namespace ConsoleTomatoTimer
{
    class JobFactory
    {
        public static IJob Create(string[] args)
        {
            var startTimerJob = new StartTimerJob();
            var items = new ItemIterator(args);
            while (items.MoveNext())
            {
                switch (items.Value)
                {
                    case "--help":
                        return new ShowHelpJob();
                    case "--timer":
                        if (!items.MoveNext())
                        {
                            return new ShowMissingParameterJob("--timer");
                        }
                        int length;
                        if (!int.TryParse(items.Value, out length))
                        {
                            return new ShowIncorrentIntFormatJob("--timer");
                        }
                        startTimerJob.TimerLengthInMinues = length;
                        break;
                    case "--silent":
                        startTimerJob.Silent = true;
                        break;
                    default:
                        return new ShowUnknownParameterJob(items.Value);
                }
            }
            
            return startTimerJob;
        }
    }
}
