using System.Collections.Generic;
using System.Linq;

namespace Linq1
{
    public static class Exercise2
    {
        // Given a sequence of words, get rid of any that don't have the character 'e' in them,
        // then sort the remaining words alphabetically, then return the following phrase using
        // only the final word in the resulting sequence:
        //    -> "The last word is <word>"
        // If there are no words with the character 'e' in them, then return null.
        //
        // TRY to do it all using only LINQ statements. No loops or if statements.
        public static string GetTheLastWord(this IEnumerable<string> words)
        {
            // using Lambda expression Syntax
            // return $"The last word is {words.Where(st => st.Contains("e")).OrderBy(st => st).Select(st => st).ToArray().LastOrDefault()}";
            string g = words.Where(st => st.Contains("e")).OrderBy(st => st).Select(st => st).ToArray().LastOrDefault();
            if (g == null)
            {
                return "null";
            }
            else
            {
                return $"The last word is <{g}>";
            }

            // using Query Syntax
            // var Query = from word in words
            //             where word.Contains("e")
            //             orderby word ascending
            //             select word;

            // if (Query.LastOrDefault() == null)
            // {
            //     return null;
            // }
            // else
            // {
            //     return $"The last word is {Query.LastOrDefault()}";
            // }

            // The Coreect solution in Query syntax





        }
    }


}