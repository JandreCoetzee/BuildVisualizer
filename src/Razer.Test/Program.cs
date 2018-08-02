using System;

namespace Razer.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var events = new ChromaEvent();
            events.Pulse(null, null);

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
