using System;
using System.Collections.Generic;
using Linq1;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Exercise 1 From This Command 
            // unComment The Group you need to Test

            // Group1
            var L1 = new List<int>() { 1, 2, 3, 4, 5 };
            var L2 = new List<int>() { 1, 4, 9, 16, 25 };

            // Group2
            // var L1 = new List<int>() { 1, 2, 5 };
            //  var L2 = new List<int>() { 1, 4, 9 };

            // Group3
            // var L1 = new List<int>() { };
            //  var L2 = new List<int>() { };

            Console.WriteLine($"Is L2 is a square List For L1 ===> {L1.TestForSquares(L2)}");

            // Test For Exercise 2 ....
            // unComment the Line you need to Test

            var L10 = new List<string> { "he", "she", "it", "we", "you", "they" };
            // var L10 = new List<string> { "hop", "top", "stop", "cop", "lop", "chop" };
            // var L10 = new List<string> { "elastic", "elaborate", "elephant", "iris", "ibis", "incredible" };


            System.Console.WriteLine(L10.GetTheLastWord());

        }
    }
}
