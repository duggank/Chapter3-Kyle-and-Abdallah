using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. This is Staples or whatever. Choose P for pine, O for oak, or M for mahogany.");
            Console.WriteLine("Pine costs $100, oak tables cost $225, and mahogany costs $310.");
            Console.Write("Which would you like to select?: ");
            string input;
            input = Console.ReadLine();
            if (input == "P")
            {
                Console.WriteLine("That'll be $100!");
            }
            else if (input == "O")
            {
                Console.WriteLine("That'll be $225!");
            }
            else if (input == "M")
            {
                Console.WriteLine("That'll be $310!");
            }
            else if (input == "POM")
            {
                Console.WriteLine("That'll be $635!");
            }
            else
                Console.WriteLine("Seriously brah?!");

        }
    }
}
