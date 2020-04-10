using System;

namespace fib
{
    class Program
    {
        static void Main(string[] args)
        {
            long f1 = 0, f2 = 1, f;
            if (!Array.Exists(args, x => x == "-b"))
            {
                Console.WriteLine("Fibonacci Sequence Generator: @rezamoradix");
                Console.WriteLine("example: fib.exe 20");
                Console.WriteLine("example: fib.exe 20 -b (for bare format)");
                Console.WriteLine(" ");
            }

            // Fibonacci inital numbers
            Console.Write("0 1 ");

            int max = 20;
            Array.Find(args, x => Int32.TryParse(x, out max));
            for (int i = 0; i < max; i++)
            {
                f = f1 + f2;
                Console.Write(f + " ");
                f1 = f2;
                f2 = f;
            }
        }
    }
}
