using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers == null ? false : numbers.Sum() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
        }

        public char GetFirstLetterOfString(string val)
        {
            //return val[0];
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            //return val[val.Length - 1];
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend/divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            //return nums[^1] - nums[0];

            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
			var ints = new List<int>();

			for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    ints.Add(i);
                }
            }
            return ints.ToArray();

            //return Enumerable.Range(1, 99).Where(n => n % 2 != 0).ToArray();
		}

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
