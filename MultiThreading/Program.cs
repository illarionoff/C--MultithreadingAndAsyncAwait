using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin Main");

            #region Threading
            //Thread thread = new Thread(new ThreadStart(DoWork));
            //thread.Start();

            //Thread threadToo = new Thread(new ParameterizedThreadStart(DoWorkToo));
            //threadToo.Start(int.MaxValue);
            #endregion

            #region Async/Await

            DoWorkAsync();
            int j = 0;
            for (int i = 0; i < 100; i++)
            {
                j++;
                if (j % 10 == 0)
                {
                    Console.WriteLine("Main");
                }
            }

            #endregion
        }

        static async Task DoWorkAsync()
        {
            Console.WriteLine("Begin Async");
            await Task.Run(() => DoWork());
            Console.WriteLine("Do work Async");
        }

        static void DoWork()
        {
            int j = 0;
            for (int i = 0; i < 100; i++)
            {
                j++;
                if (j % 10 == 0)
                {
                    Console.WriteLine("DoWork");
                }
            }
        }

        static void DoWorkToo(object max)
        {
            int j = 0;
            for (int i = 0; i < (int)max; i++)
            {
                j++;
                if (j % 10000 == 0)
                {
                    Console.WriteLine("DoWorkToo");
                }
                {

                }
            }
        }
    }
}
