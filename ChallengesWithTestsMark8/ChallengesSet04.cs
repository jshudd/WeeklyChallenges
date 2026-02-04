using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
		}

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strings = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return strings.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var nums = new List<int>() { number1, number2, number3, number4 };
            return nums.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) && (sideLength2 + sideLength3 > sideLength1) && (sideLength3 + sideLength1 > sideLength2);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
