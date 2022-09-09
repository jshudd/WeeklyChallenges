using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //for (int i = 0; i < vals.Length; i++)
            //{
            //    if(vals[i] == false)
            //    {
            //        return true;
            //    }
            //}

            //return false;

            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //HOW DOES THIS WORK?? ANSWER: Tests are flawed
            //if (numbers == null || numbers.Count() == 0)
            //{
            //    return false;
            //}

            //var sum = numbers.Sum();

            //return (sum % 2 != 0);

            //regular answer
            //if (numbers == null)
            //{
            //    return false;
            //}

            //var odds = new List<int>();

            //foreach (var num in numbers)
            //{
            //    if (num % 2 != 0)
            //    {
            //        odds.Add(num);
            //    }
            //}

            //var sumOdds = odds.Sum();

            //return (sumOdds % 2 != 0);

            return (numbers == null) ? false : (numbers.Where(x => x % 2 != 0).Sum() % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //var isLower = false;
            //var isUpper = false;
            //var isNumber = false;

            //for (int i = 0; i < password.Length; i++)
            //{
            //    if (char.IsLower(password[i]))
            //    {
            //        isLower = true;
            //    }

            //    if (char.IsUpper(password[i]))
            //    {
            //        isUpper = true;
            //    }

            //    if (char.IsNumber(password[i]))
            //    {
            //        isNumber = true;
            //    }
            //}

            //if(isLower == true && isUpper == true && isNumber == true)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return (password.Any(char.IsLower)
                && password.Any(char.IsUpper)
                && password.Any(char.IsNumber));
        }

        public char GetFirstLetterOfString(string val)
        {
            //return val[0];
            return val.First(); //LINQ
        }

        public char GetLastLetterOfString(string val)
        {
            //return val[val.Length - 1];

            //return val[^1];

            return val.Last(); //LINQ
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            //if(divisor == 0)
            //{
            //    return 0;
            //}

            //return dividend / divisor;

            return (divisor == 0) ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            //return nums[nums.Length - 1] - nums[0];

            return nums[^1] - nums[0];

            //return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            //var list = new List<int>();

            //for (int i = 0; i < 100; i++)
            //{
            //    if(i % 2 != 0)
            //    {
            //        list.Add(i);
            //    }
            //}

            //return list.ToArray();

            return Enumerable.Range(0, 100).Where(x => x % 2 != 0).ToArray();
        }

        //CANNOT BE DONE WITH LINQ :-(
        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
                       
        }

        //Not included for students anymore vvv

        //public char FindMissingLetter(char[] array)
        //{
        //    char[] letters = "abcdefghijklmnopqrxtuvwxyz".ToCharArray();

        //    if (char.IsUpper(array[0]))
        //    {
        //        letters = "abcdefghijklmnopqrxtuvwxyz".ToUpper().ToCharArray();
        //    }
            
        //    var place = 0;


        //    for (int j = 0; j < letters.Length; j++)
        //    {
        //        if (array[0] == letters[j])
        //        {
        //            place = j;
        //            break;
        //        }
        //    }

        //    char missing = ' ';

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] != letters[place])
        //        {
        //            missing = letters[place];
        //            break;
        //        }
        //        place++;
        //    }

        //    return missing;
        //}
    }
}
