﻿using Algorithm.AutoGenerator;
using Common;
using System;

namespace AlgorithmSln
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine(int.Parse('1'.ToString()));

            Console.WriteLine("Hello World!");

            EasyGen easyGen = new EasyGen("Myclass", "myFun");
            //easyGen.Generate();

            MediumGen mediumGen = new MediumGen("PermutationsII", "PermuteUnique");
            mediumGen.Generate();

            Console.WriteLine($"completed.");
        }
    }
}
