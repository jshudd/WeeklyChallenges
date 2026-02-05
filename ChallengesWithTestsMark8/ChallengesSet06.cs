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
			if (num <= 1) return false;
			if (num == 2) return true;
			if (num % 2 == 0) return false;

			for (int i = 3; i * i <= num; i += 2)
				if (num % i == 0)
					return false;

			return true;
		}

		public int IndexOfLastUniqueLetter(string str)
		{
			//Dict version
			//if (string.IsNullOrEmpty(str))
			//             return -1;

			//         var counts = new Dictionary<char,int>();

			//         foreach (var c in str)
			//         {
			//             if (counts.ContainsKey(c))
			//                 counts[c]++;
			//             else
			//                 counts[c] = 1;
			//         }

			//         for (var i = str.Length - 1; i >= 0; i--)
			//         {
			//             if (counts[str[i]] == 1)
			//                 return i;
			//         }
			//         return -1;

			//LINQ version
			return str
		.Select((c, i) => new { c, i })
		.Where(x => str
		.Count(ch => ch == x.c) == 1)
		.Select(x => x.i)
		.DefaultIfEmpty(-1)
		.Last();
		}

		public int MaxConsecutiveCount(int[] numbers)
		{
			var count = 1;
			var result = 1;

			for (var i = 1; i < numbers.Length; i++)
			{
				if (numbers[i] != numbers[i - 1])
				{
					if (count > result)
					{
						result = count;
						count = 1;
					}
				}
				else
				{
					count++;
				}

			}
			
			return result;
		}

		public double[] GetEveryNthElement(List<double> elements, int n)
		{
			throw new NotImplementedException();
		}
	}
}
