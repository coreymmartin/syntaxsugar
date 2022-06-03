using System;
using System.Collections.Generic;
using System.Text;

namespace syntaxsugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : (answer == 9) ? $"{answer} is equal to nine" : $"{answer} is greater than nine";
            Console.WriteLine(response);
        }
    }
}
