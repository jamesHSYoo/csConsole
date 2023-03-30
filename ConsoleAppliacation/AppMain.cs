using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace ConsoleApplication
{
    class AppMain
    {
        static void Main(String[] args)
        {
            CalculationService calculationService = new CalculationService("Main");

            Console.WriteLine(calculationService.add(1, 1));

            Thread.Sleep(100000);
        }
    }
}