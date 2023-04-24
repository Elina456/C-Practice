using System;
using System.Collections.Generic;
using System;
namespace Practice
{
         class List
        { 
             static void Main(string[] args)
        {
          var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (var name in names)
          {
           Console.WriteLine($"Hello {name.ToUpper()}!");
           }

          Console.WriteLine();
          names.Add("Elona");
          names.Add("Elisha");
           names.Remove("Khushi");
            foreach (var name in names)
           {
              Console.WriteLine($"Hello {name.ToUpper()}!");
              }
         Console.WriteLine($"My name is {names[0]}.");
          Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
//Count//
          Console.WriteLine($"The list has {names.Count} people in it");
        var index = names.IndexOf("Felipe");
         if (index != -1)
        {
           Console.WriteLine($"The name {names[index]} is at index {index}");
       } 
         var notFound = names.IndexOf("Not Found");
         Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
        names.Sort();
        foreach (var name in names)
        {
         Console.WriteLine($"Hello {name.ToUpper()}!");
       }
//Fibonacci Sequence//
        var fibonacciNumbers = new List<int> {1, 1};
        var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
        var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

         fibonacciNumbers.Add(previous + previous2);

         foreach(var item in fibonacciNumbers)
         {
             Console.WriteLine(item);
         }
            var fibonacciNumbers1 = new List<int> {1, 1};

         while (fibonacciNumbers1.Count < 20)
        {
             var previous3 = fibonacciNumbers1[fibonacciNumbers1.Count - 1];
            var previous4 = fibonacciNumbers1[fibonacciNumbers1.Count - 2];

            fibonacciNumbers.Add(previous3 + previous4);
     }
         foreach(var item2 in fibonacciNumbers1)
        {
             Console.WriteLine(item2);
          }
        }

        }

}
