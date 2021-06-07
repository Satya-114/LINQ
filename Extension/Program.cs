﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> EvenNumbers = Enumerable.Where(intList, n => n % 2 == 0);
            foreach(var item in EvenNumbers)
            
                {
                Console.WriteLine(item);
                } 

            Console.ReadKey();
        }
    }
}
