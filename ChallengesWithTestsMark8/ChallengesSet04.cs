using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

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
            return objs.Where(x => x == null).ToList().Count > (objs.Length/2);

            //var nulls = new List<object>();
            //foreach (var  obj in objs)
            //{
            //    if (obj == null)
            //        nulls.Add(obj);
            //}
            //return nulls.Count > objs.Length/2;
        }

        public double AverageEvens(int[] numbers)
        {
            //return numbers == null || numbers.Length == 0 ? 0 : numbers.Where(x => x % 2 == 0).Average();

            if (numbers == null)
            {
                return 0;
            }

            var evens = new List<double>();
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                    evens.Add(num);
            }
            return evens == null || evens.Count == 0 ? 0 : evens.Average();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
