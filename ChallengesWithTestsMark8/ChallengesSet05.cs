using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var result = startNumber+1;
            while (result % n != 0)
            {
                result++;
            }            
            return result;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            //foreach (var bus in businesses)
            //{
            //    if (bus.TotalRevenue <= 0)
            //        bus.Name = "CLOSED";
            //}

            businesses.ToList().Where(x => x.TotalRevenue == 0).ToList().ForEach(y => y.Name = "CLOSED");
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return false;

            var test = true;
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return test;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
                return 0;

            var sum = 0;
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                    sum += numbers[i+1];
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null)
                return string.Empty;

            var sentence = "";
            for (var i = 0;i < words.Length;i++)
            {
                if (words[i].Trim() != string.Empty)
                sentence += $"{words[i].Trim()} ";
            }
            sentence = sentence.Trim();

            if (sentence.Length > 0)
                sentence += ".";

            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
