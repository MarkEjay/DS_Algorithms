using System;
using System.Collections.Generic;
using System.IO;

namespace MaximumPairwiseProduct
{
    class Program
    {
       public static int MaxPairwiseProduct(List<int> numbers)
        {
            int product = 0;
            int n = numbers.Count;
            for(int i=1; i<n; ++i)
            {
                for(int j = i+1; j < n; ++j)
                {
                    product = Math.Max(product, numbers[i] * numbers[j]);
                }
            }
            return product;
        }

      
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int input = Convert.ToInt32(n);

            List<int> lst = new List<int>(input);
            for(int i=0; i<input; ++i)
            {
                string lstVal = Console.ReadLine();
                int res = Convert.ToInt32(lstVal);
                lst.Add(i);
            }
            int prod = MaxPairwiseProduct( lst);
            Console.WriteLine("Result: " + prod);
            
        }
    }
}
