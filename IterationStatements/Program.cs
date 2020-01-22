using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONE- Create a List called "numbers"
            var number = new List<int>();

            //Create a variable of type int with an initializer of 0
            var i = 0;
            


            // Create a do-while loop
            {
                // Increment your variable by 1
                // Then add your variable to "numbers"
            }
            // While your variable is less than 100
            do
            {
                i++;
                number.Add(i);

            } while (i < 100);

            {
                // Increment your variable by 1
                // Then add your variable to "numbers"

            }


            while (i < 200)
            {
                i++;
                number.Add(i);
            }
                

            


            Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console
            foreach (var num in number)
            {

                Console.WriteLine(num);
            }

            {

            }
            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of j to 199
            // in your conditional, as long as j is less than or equal to the length of "numbers"
            // and as long as j is greater than or equal to 0
            // Decrement j by 1
            {
                // Write to the console "numbers" at index j
            }
            for (int j = 199; j <= number.Count && j >= 0; j--)
            {
                Console.WriteLine(number[j]);
            }
            Console.WriteLine(number.Count);
        }
    }
}

