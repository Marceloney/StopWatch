using System;


namespace StopWatch
{
    class Program
    {
        static void Main (string[] agrs)
        {   
            Console.Clear();
            Star(6);
        

        }

        static void Star(int time)
        {
            Console.Clear();

            int currentTime = 0;
            
            while(currentTime != time)
            {   
                Console.Clear();
                Console.WriteLine();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            System.Console.WriteLine("StopWatch finalizado!");
            Thread.Sleep(2500);
        }
    }
}
