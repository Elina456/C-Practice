using System;
namespace PracticeC
{
         class Program
        { 
             static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // String//
            string a = "Elina";
            Console.WriteLine(a);
            a = "Elisha";
            Console.WriteLine(a);
            Console.WriteLine("Hello " + a);
            Console.WriteLine($"Hello {a}");
            string b = "Ram";
            string c = "Sita";
            Console.WriteLine($"My friends are {b} and {c}");
            //String.Length//
            Console.WriteLine($"The name {b} has {b.Length} letters.");
            Console.WriteLine($"The name {c} has {c.Length} letters.");


            //Trim//
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            //Replace//
            string d = "Hello World!";
            Console.WriteLine(d);
            d = d.Replace("Hello", "Greetings");
            Console.WriteLine(d);
            //make a string ALL CAPS or all lower case//
            Console.WriteLine(d.ToUpper());
            Console.WriteLine(d.ToLower());

            //Contains return true or false that is boolean value//
            string e = "You say goodbye, and I say hello";
            Console.WriteLine(e.Contains("goodbye"));
            Console.WriteLine(e.Contains("greetings"));

            //StartsWith and EndsWith that also search for sub-strings in a string.//
            string f = "You say goodbye, and I say hello";
            Console.WriteLine(f.StartsWith("You"));
            Console.WriteLine(f.StartsWith("goodbye"));

            Console.WriteLine(f.EndsWith("hello"));
            Console.WriteLine(f.EndsWith("goodbye"));
            NumbersandInteger n = new NumbersandInteger();
            n.Display();
            n.Operation();
            n.Division();
            n.Decimal();
            n.Area();
            n.Double();
            n.MaximumInt();
            //for loop//
            for (int counter = 0; counter < 10; counter++)
           {
            Console.WriteLine($"Hello World! The counter is {counter}");
           }

           for (int row = 1; row < 11; row++)
          {
           for (char column = 'a'; column < 'k'; column++)
           {
                Console.WriteLine($"The cell is ({row}, {column})");
            }
          }

          //Combine Branches and Loops//
          {
          int sum = 0;
          
         for (int number = 1; number < 21; number++)
          {
            if (number % 3 == 0)
            {
              sum = sum + number;
            }
         }
        Console.WriteLine($"The sum is {sum}");
        }
       
       BranhesandLoops bl =new BranhesandLoops();
       bl.DoWhile();
       bl.Greater();
       bl.More();
       bl.While();

        }
    }

    
}