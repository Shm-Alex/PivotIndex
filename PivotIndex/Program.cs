using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPivotIndex
{
    internal class Program
    {
        public static int PivotIndex(int[] nums)
        {
            int leftSum = 0;
            int rightSum = nums.Sum();
            for (int i = 0; i < nums.Length; i++) 
            {
                rightSum -= nums[i];
                if (leftSum == rightSum) return i;
                leftSum+= nums[i];
                
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PivotIndex(new int[] { 1, 7, 3, 6, 5, 6 } ));
            Console.WriteLine(PivotIndex(new int[] { 1, 2, 3 }));
            Console.WriteLine(PivotIndex(new int[] { 2,1,-1 }));
            Console.ReadLine();
        }
    }
}
