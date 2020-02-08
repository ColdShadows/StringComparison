using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringComparison
{
    public static class StringComparer
    {
        public static IEnumerable<char> GetCommonCharacters(string firstInput, string secondInput)
        {
            if (firstInput == null)
            {
                throw new ArgumentNullException(nameof(firstInput));
            }

            if (secondInput == null)
            {
                throw new ArgumentNullException(nameof(secondInput));
            }

            // var firstInputCharacters = GetCharactersFromString()

            List<char> firstCharacters = new List<char>();
            firstCharacters.AddRange(firstInput);

            List<char> secondCharacters = new List<char>();
            secondCharacters.AddRange(secondInput);

            List<char> commonCharacters = new List<char>();

            foreach(var c in firstCharacters)
            {
                if(secondCharacters.Contains(c) && !commonCharacters.Any(cc => cc == c))
                {
                    commonCharacters.Add(c);
                }
            }

            return commonCharacters;
        }
    }
}
