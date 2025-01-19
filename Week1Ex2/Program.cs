using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // print out the prompt to ask for the first name
            Console.WriteLine("What is your first name?");
            // declare a string varable to hold the user input
            string first = Console.ReadLine();
            // print out the prompt to ask for the last name
            Console.WriteLine("What is your last name?");
            // declare a string varable to hold the user input
            string last = Console.ReadLine();
            // print out the prompt to ask for age
            Console.WriteLine("What is your age?");
            // declare a string varable to hold the user input
            string age = Console.ReadLine();
            // print out the prompt to ask for the fav color
            Console.WriteLine("What is your favorite color?");
            // declare a string varable to hold the user input for color
            string color = Console.ReadLine();
            // print out the prompt to ask for the name, age and color
            Console.WriteLine("Hello, " + first + " " + last + "!" + " You are " + age + " years old " + "and your favorite color is " + color + ".");
            // declare a string varable to hold the user input
            Console.ReadLine();
        }
    }
}
