﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>()
            {
                3, 4, 5, 6, 7, 20 ,50
            };
            //LINQ Query using Method Syntax
            var MethodSyntax = integerList.Where(obj => obj > 5).ToList();
           
            foreach (var item in MethodSyntax)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
