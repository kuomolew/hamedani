﻿using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main()
        {
            var numbers = new List<int>() { 1,2,3,4};
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine($"Index of 1: { numbers.IndexOf(1)}");
            Console.WriteLine($"Last index of 1: { numbers.LastIndexOf(1)}");
            Console.WriteLine($"Count of list: { numbers.Count}");

            //numbers.Remove(1);
            //foreach (var number in numbers)
            //{
            //    if (number == 1)
            //        numbers.Remove(number);
            //}

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Clear();
            Console.WriteLine($"Count of list: { numbers.Count}");

        }
    }
}
