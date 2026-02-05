using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            //if (words == null)
            //    return false;

            //if (ignoreCase)
            //{
            //    return words.Contains(word, StringComparer.OrdinalIgnoreCase);
            //}
            //else
            //{
            //    return words.Contains(word);
            //}

            return words == null ? false : ignoreCase ? words.Contains(word, StringComparer.OrdinalIgnoreCase) : words.Contains(word);
        }

        public bool IsPrimeNumber(int num)
        {
            throw new NotImplementedException();
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
