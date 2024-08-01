using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IWayCsTraining
{
    class AsyncProgramming
    {
        public static async void SchoolDay()
        {
            var watch = new Stopwatch();
            watch.Start();

            await MorningAssembly();
            Class11();
            Class12();

            //Task.WaitAll(MorningAssembly(), Class11(), Class12());

            watch.Stop();
            //Console.WriteLine($"Total Execution Time: {watch.ElapsedMilliseconds} ms");
        }

        public static async Task MorningAssembly()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("\nMorning Assembly Started");
                Thread.Sleep(10000);
                Console.WriteLine("\nMorning Assembly Ended");
            });
        }

        public static async Task Class11()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("\nClass 11 Started");
                Thread.Sleep(5000);
                Console.WriteLine("\nClass 11 Ended");
            });
        }

        public static async Task Class12()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("\nClass 12 Started");
                Thread.Sleep(7000);
                Console.WriteLine("\nClass 12 Ended");
            });
        }
    }
}
