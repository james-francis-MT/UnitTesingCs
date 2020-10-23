using System;

namespace UnitTestingCs
{
    class Program
    {
        static void Main(string[] args)
        {
            LogAnalyzer la = new LogAnalyzer();
            Console.WriteLine(la.IsValidLogFileName(""));
        }
    }
}
