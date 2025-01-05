using System;
using System.Collections.Generic;

namespace ex9_1_Kolekcje__SIMPSEQ_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {-2, -1, 0, 1, 4};
            int[] b = new int[] {-3, -2, -1, 1, 2, 3};
            Print(a, b);
        }
        public static void Print(int[] a, int[] b){
            string result = "";
            var resultListA = new HashSet<int>(a);
            resultListA.ExceptWith(b);
            var resultListB = new HashSet<int>(b);
            resultListB.ExceptWith(a);
            var resultList = new List<int>(resultListA);
            resultList.AddRange(resultListB);
            
            resultList.Sort();
            if(resultList.Count == 0){
                result = "EMPTY";
                Console.WriteLine(result);
            }
            else{
                result = string.Join(" ", resultList);
                Console.WriteLine(result);
            }
        }
    }
}