using System;
using FluentDate;
using FluentDateTime;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
	    var currentDate = DateTime.Now.NextYear();
            var generator = new FibonacciGenerator();
            foreach (var digit in generator.Generate(15))
            {
                Console.WriteLine(digit);
            }
	
	    Console.WriteLine($"There are {args.Length} args\n\t{String.Join("\n\t", args)}");
            foreach (var arg in args)
            {
                if (arg == "--someArg")
                    Console.WriteLine("Processing --someArg...");
            }  
        }
    }
}
