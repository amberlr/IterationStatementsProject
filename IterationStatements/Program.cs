using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0 - DONE

            var k = 0;

            // Create a do-while loop - DONE
            do
            {
                // Increment your variable by 1 - DONE
                k++;
                // Then add your variable to "numbers" - DONE
                numbers.Add(k);
            } while (k < 100);
            // While your variable is less than 100 - DONE


            // Create a while loop - DONE
            // While your variable is less than 200 - DONE
            while (k < 200)
            {
                // Increment your variable by 1 -DONE
                k++;
                // Then add your variable to "numbers" - DONE
                numbers.Add(k);
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop - DONE
            // Write your variable to the console - DONE
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(""); //is this just for a space between 200 and Decrease: ?
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count)
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for(var i = 199; i <= numbers.Count && i >= 0; i--) //Count is a property that tells us how many things exist in the numbers List
            {
                // Write to the console "numbers" at index i
                Console.WriteLine($"{i}");
            }
        }
    }
}
