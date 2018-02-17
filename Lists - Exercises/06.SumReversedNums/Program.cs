﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumReversedNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                List<char> num = numbers[i].ToString().ToList();
                num.Reverse();
                sum += int.Parse(string.Join("", num));
            }

            Console.WriteLine(sum);
        }
    }
}
