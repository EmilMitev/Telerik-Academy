/* Problem 7.
    * Using delegates write a class Timer that can execute certain method at each t seconds.
 */
namespace _07.Timer
{
    using System;
    using System.Threading;

    public delegate void Timer(int t);

    internal class Program
    {
        private static void Main(string[] args)
        {
            Timer t = delegate(int time)
            {
                int temp = 0;
                while (true)
                {
                    temp += time / 1000;
                    Thread.Sleep(time);
                    Console.WriteLine("{0}", temp);
                }
            };
            t(1000);
        }
    }
}
