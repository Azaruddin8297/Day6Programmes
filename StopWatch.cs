using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrames2
{
    internal class StopWatch
    {
        public static void call()   {
        Stopwatch stopwatch = new Stopwatch();
        Console.WriteLine("Press any key to start the stopwatch...");
        Console.ReadKey();
        stopwatch.Start();

        Console.WriteLine("Press any key to stop the stopwatch...");
        Console.ReadKey();
        stopwatch.Stop();

        TimeSpan elapsed = stopwatch.Elapsed;
            // Console.WriteLine("Elapsed time: {0:hh\\:mm\\:ss\\.fff} ", elapsed);
            Console.WriteLine(elapsed);
    }
}
}
