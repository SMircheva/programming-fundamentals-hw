using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n-1; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine(nums[i]);
                }
                else
                {
                    Console.Write(nums[i] + " ");
                }
            }
        }
    }
}
