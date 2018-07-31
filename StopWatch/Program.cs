using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch sw = new StopWatch();            

            while(true)
            {
                Console.WriteLine("Press S for start, E for end: ");

                if (Console.ReadKey().Key.Equals(ConsoleKey.S))
                {
                    try
                    {
                        sw.Start();
                        Console.WriteLine("Stopwatch started!!!");
                    }
                    catch(InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                    
                }

                if (Console.ReadKey().Key.Equals(ConsoleKey.E))
                {
                    try
                    {
                        sw.Stop();
                        Console.WriteLine("Stopwatch ended!!! Result:  " + sw.GetValue());
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

           }
                      
            
        }
    }

    internal class StopWatch
    {
        private DateTime startDatetime;
        private DateTime endDatetime;

        private bool isStarted;

        public StopWatch()
        {}

        public StopWatch(DateTime dateTime)
        {}

        internal void Start()
        {
            if(isStarted)
            {
                throw new InvalidOperationException("StopWatch is already started!");
                
            }

            startDatetime = DateTime.Now;

            isStarted = true;
        }

        internal void Stop()
        {
            if(!isStarted)
            {
                throw new InvalidOperationException("First start stopwatch");
            }

            endDatetime = DateTime.Now;
            isStarted = false;
        }

        internal TimeSpan GetValue()
        {
           
            return endDatetime - startDatetime;
        }
    }
}
