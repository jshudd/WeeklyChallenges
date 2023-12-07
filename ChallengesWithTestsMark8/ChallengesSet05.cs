using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            //Amoriss' answer
            //startNumber++;

            //while (startNumber % n != 0)
            //{
            //    startNumber++;
            //}
            //return startNumber;

            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            //or foreach okay
            //for (int i = 0; i < businesses.Length; i++)
            //    {
            //        if (businesses[i].TotalRevenue == 0)
            //        {
            //            businesses[i].Name = "CLOSED";
            //        }
            //    }

            businesses.Where(x => x.TotalRevenue == 0).ToList().ForEach(x => x.Name = "CLOSED");
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            //if (numbers == null || numbers.Length == 0)
            //{
            //    return false;
            //}

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < numbers[i - 1])
            //    {
            //        return false;
            //    }
            //}

            //return true;

            //From Morgan
            return numbers == null || numbers.Length == 0 ? false :
                !numbers.Skip(1)
                .Select((item, index) => numbers[index] <= numbers[index + 1])
                .Any(x => x == false);
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            //if (numbers == null || numbers.Length == 0)
            //{
            //    return 0;
            //}

            //int sum = 0;

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i - 1] % 2 == 0)
            //    {
            //        sum += numbers[i];
            //    }
            //}

            //return sum;

            //From Morgan
            return numbers == null ? 0 : numbers
                .Skip(1)
                .Where((item, index) => numbers[index] % 2 == 0)
                .Sum();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
                //return string.Empty;
            }

            string sentence = "";

            foreach (string word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }

            if (sentence.Length == 0)
            {
                return "";
            }

            //sentence = sentence.Substring(0, sentence.Length - 1);
            sentence = sentence.Trim();
            sentence += ".";
            return sentence;

            //return string.Join(' ', words) + ".";

            //currently passes all but 1 test
            //return (words == null || words.Length == 0) ? "" : words.Aggregate((x, y) => x.Trim() + " " + y.Trim()) + ".";

            //IT WORKS!!! CRAZY THO 
            //return (words == null || words.Length == 0 ||
            //    (words.Aggregate((x, y) => x.Trim() + " " + y.Trim()) + ".")
            //    .Count() == 2) ? "" : words
            //    .Aggregate((x, y) => x.Trim() + " " + y.Trim()) + ".";

            //From Morgan - Works too
            //return words != null && (String.Join(" ", words.Select(x => x.Trim())
            //    .Where(x => x.Length > 0)) + ".").Length > 1 ?
            //    String.Join(" ", words.Select(x => x.Trim())
            //    .Where(x => x.Length > 0)) + "." : "";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            //if (elements == null || elements.Count == 0)
            //{
            //    return new double[0];
            //}

            //List<double> everyFourth = new List<double>();

            //for (int i = 3; i < elements.Count; i += 4)
            //{
            //    everyFourth.Add(elements[i]);
            //}

            //return everyFourth.ToArray();

            //From Morgan
            return elements == null ? new double[0] : elements.Where((item, index) => (index + 1) % 4 == 0).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return false;

            //Found online
            //var result = nums.Select((n1, idx) => new {n1, n2 = nums.Take(idx).FirstOrDefault(n2 => n1 + n2 == targetNumber)}).Where(pair => pair.n2 != 0);

            //return nums.Select((n1, idx) => new { n1, n2 = nums.Take(idx).FirstOrDefault(n2 => n1 + n2 == targetNumber) }).Where(pair => pair.n2 != 0);

            //Doesn't work yet
            //return nums.Select((n1, n2) => n1 + n2 == targetNumber).Any();
        }
    }
}
