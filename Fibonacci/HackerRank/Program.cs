using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    class Program
       
    {
        static void Main(string[] args)
        {
            //stairCase(6);
            // int[] arr = { 1, 3, 5, 7, 9 };
            List<int> lst = new List<int> { 1,2,3,4,5 };
            // string time = "2:23:10PM";
            int[] arr = { 1, 4, 5 };

            // Console.WriteLine(TwoSum(lst, 9));
            //   TwoSum(arr,9).ForEach(Console.WriteLine);
            // Array.ForEach(TwoSum(arr, 9), Console.WriteLine);
            //  reverseString("cat");
            Console.WriteLine(palindrome("level"));



        }

        public static void stairCase(int n)
        {
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                counter++;
                for (int k = n-1; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= counter - 1; j++)
                {
                    Console.Write("#");
                }

               Console.WriteLine();
            }
        }

        public static void miniMaxSum(int[] arr)
        {
            Array.Sort(arr);
            Int64 min = 0;
            int minArr = arr.Length - 1;
            Int64 max = 0;

            for (int i=0; i< minArr; i++)
            {
                min += arr[i];
            }
            for(int j=1; j<arr.Length; j++)
            {
                max += arr[j];
            }
            Console.WriteLine(min+" " + max);

            
        }

        public static int birthdayCakeCandles(List<int> candles)
        {
            int maxCandle = candles.Max();
            int count = 0;

            for(int i=0; i<candles.Count; i++)
            {
                if(maxCandle == candles[i])
                {
                    count += 1;
                }
            }

            return count;
        }

        public static string timeConversion(string s)
        {
            string ret = " ";
            string sVal = s;         
            int newHour = 0;
            string hh = sVal.Split(":")[0];
            string mm = sVal.Split(":")[1];
            string ss = sVal.Split(":")[2];
            if (sVal.Contains("AM"))
            {
               
                newHour = Convert.ToInt32(hh);
                if(newHour == 12)
                {
                    newHour = 00;
                    ret = newHour + ":" + mm + ":" + ss;
                }
                else
                {
                    ret = newHour + ":" + mm + ":" + ss;
                }
            }
            if(sVal.Contains("PM"))
            {
               
                newHour = Convert.ToInt32(hh);
                if (newHour < 12)
                {
                    newHour += 12;
                    ret = newHour + ":" + mm + ":" + ss;
                }
                else
                {
                    ret = newHour + ":" + mm + ":" + ss;

                }
            }
            return ret;
        }

        public static int maxPairwise(List<int> lst)
        {
            //add the value of two maximum value
            int result = 0;
            for(int i=0; i<lst.Count; i++)
            {
                for(int j = i+1; j<lst.Count; j++)
                {
                    if(lst[i]*lst[j] > result)
                    {
                        result = lst[i] * lst[j];
                    }
                }
            }
            return result;

        }

        //leetcode
        public static int[] TwoSum(int[]nums, int target)
        {
            /*  List<int> result = new List<int>();
              for(int i=0; i<lst.Count; i++)
              {
                  for(int j = i+1; j < lst.Count; j++)
                  {
                      if (lst[i] + lst[j] == target)
                      {
                          result.Add(i);
                          result.Add(j);
                      }
                  }
              }
              return result;*/
            int[] result = { 0, 0 };
            for(int i=0; i<nums.Length; i++)
            {
                for(int j=i+1; j<nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }

            }
            return result;

        }

        public static void reverseString(string words)
        {
            for(int i = words.Length-1; i>=0; i--)
            {
                Console.Write(words[i]);
            }
        }

        //palindrome
        public static bool  palindrome(string words)
        {
            bool isValid = false;
            List<char> wordLst = new List<char>();
            List<char> compare = new List<char>();
            for(int i = 0; i<words.Length; i++)
            {
                if (Char.IsLetter(words[i]))
                {
                    wordLst.Add(words[i]);
                }
                else
                {
                    continue;
                }
            }
            for(int i = words.Length-1; i>= 0; i--)
            {
                if (Char.IsLetter(words[i]))
                {
                    compare.Add(words[i]);
                }
                else
                {
                    continue;
                }
            }

            isValid = wordLst.Equals(compare);

            return isValid;
        }
    }
}
