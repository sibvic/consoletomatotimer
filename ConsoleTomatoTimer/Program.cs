namespace ConsoleTomatoTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            var job = JobFactory.Create(args);
            job.Perform();
        }
    }
}