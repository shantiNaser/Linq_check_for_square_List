using System.Collections.Generic;
using System.Linq;

namespace Linq1
{
    public class Exercise1
    {

        // The following method should return true if each element in the squares sequence
        // is equal to the square of the corresponding element in the numbers sequence.
        // Try to write the entire method using only LINQ method calls, and without writing
        // any loops.

        // [1,2,3,4]
        // [1,4,9,16]

        public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            return numbers.Select(num => num * num).SequenceEqual(squares);
        }
    }
}
