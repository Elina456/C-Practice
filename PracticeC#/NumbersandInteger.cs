using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
    public class NumbersandInteger
    {
       
      public void Display(){
        int a = 18;
        int b = 6;
        int c = a + b;
       Console.WriteLine(c);
       int d = a - b;
       Console.WriteLine(d);
       int e = a*b;
       Console.WriteLine(e);
       int f = a/b;
       Console.WriteLine(f);

      }
      public void Operation(){
        int a = 5;
        int b = 4;
        int c = 2;
        int d = a + b * c;
        Console.WriteLine(d);
        int e = (a + b) - 6 * c + (12 * 4) / 3 + 12;
        Console.WriteLine(e);
      }
      
      public void Division(){
        int a = 7;
       int b = 4;
        int c = 3;
      int d = (a + b) / c;
       int e = (a + b) % c;
      Console.WriteLine($"quotient: {d}");
      Console.WriteLine($"remainder: {e}");
      }

      public void MaximumInt(){
        int max = int.MaxValue;
        int min = int.MinValue;
       Console.WriteLine($"The range of integers is {min} to {max}");
       int what = max + 3;
       Console.WriteLine($"An example of overflow: {what}");
      }
      public void Double(){
        double a = 5;
       double b = 4;
       double c = 2;
       double d = (a + b) / c;
       Console.WriteLine(d);
       double max = double.MaxValue;
       double min = double.MinValue;
       Console.WriteLine($"The range of double is {min} to {max}");
      }

      public void Decimal(){
        decimal min = decimal.MinValue;
        decimal max = decimal.MaxValue;
        Console.WriteLine($"The range of the decimal type is {min} to {max}");
        double a = 1.0;
       double b = 3.0;
       Console.WriteLine(a / b);
       decimal c = 1.0M;
        decimal d = 3.0M;
       Console.WriteLine(c / d);
      }

      public void Area(){
        double radius = 2.50;
       double area = Math.PI * radius * radius;
        Console.WriteLine(area);
      }
       
    }
