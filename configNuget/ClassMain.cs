namespace configNuget
{
    public class ClassMain
    {
        System.Diagnostics.Stopwatch stopwatch;

        public ClassMain()
        {
            stopwatch = new System.Diagnostics.Stopwatch();
        }

        private void StartStopWatch()
        {
            stopwatch.Start();
        }

        private string StopWatch(string delay="s")
        {
            stopwatch.Stop();

            if (delay == "s")
            {
                return stopwatch.Elapsed.TotalSeconds.ToString();
            }
            else
            {
                return stopwatch.Elapsed.TotalMinutes.ToString();
            }
        }
    }
}