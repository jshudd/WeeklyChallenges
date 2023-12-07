using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);

            //var alpha = "abcdefghijklmnopqrstuvwxyz";
            //return alpha.Contains(char.ToLower(c));

            //Alternative Answer
            //return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //if(vals.Length % 2 == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return (vals.Length % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            //if(number % 2 == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            //if (num % 2 != 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //if (numbers == null || numbers.Count() == 0)
            //{
            //    return 0;
            //}

            //double min = 0;
            //double max = 0;

            //foreach (var num in numbers)
            //{
            //    if (num > max)
            //    {
            //        max = num;
            //    }

            //    if (num < min)
            //    {
            //        min = num;
            //    }

            //    //Handles Count of 1 
            //    if (numbers.Count() <= 1)
            //    {
            //        min = num;
            //    }
            //}

            //return min + max;

            //Alternate answer
            return (numbers == null || numbers.Count() == 0) ? 0 : numbers.Min() + numbers.Max();

            //Nate Seilaff's answer
            //return numbers?.Any() ?? false ? numbers.Min() + numbers.Max() : new double { };
            //return numbers?.Any() ?? false ? numbers.Min() + numbers.Max() : 0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //if (str1.Length < str2.Length)
            //{
            //    return str1.Length;
            //}
            //else
            //{
            //    return str2.Length;
            //}

            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            //if (numbers == null)
            //{
            //    return 0;
            //}

            //var sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //return sum;

            //Linq
            //return numbers?.Sum() ?? 0;

            //ternary version
            //Show 1st
            //return numbers.Sum();
            return (numbers == null) ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            //if (numbers == null)
            //{
            //    return 0;
            //}

            //var evenSum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        evenSum += numbers[i];
            //    }
            //}

            //return evenSum;

            return numbers?.Where(x => x % 2 == 0).Sum() ?? 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            //if (numbers == null)
            //{
            //    return false;
            //}

            //var sum = 0;

            //for (var i = 0; i < numbers.Count; i++)
            //{
            //    sum += numbers[i];
            //}

            //return (sum % 2 != 0);

            //Couldn't get null coalescing to work; below works with null
            return (numbers == null) ? false : (numbers.Sum() % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //if (number <= 0)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return number / 2;
            //}

            //ternary
            return (number <= 0) ? 0 : number / 2;
        }
    }
}
