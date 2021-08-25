using Common;
using System;

namespace AlgorithmSln
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int temp = -4518;
            RevertInteger s = new RevertInteger();
            Console.WriteLine(s.Reverse(temp));
        }
    }
}
