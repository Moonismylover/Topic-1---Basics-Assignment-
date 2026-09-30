using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_1___Basics__Assignment_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Topic 1 - Basics (Assignment)";

            string firstName = "Angelpreet";
            string favMovie = "The Matrix";

            // SECTION 1: STRING MANIPULATION

            // a. Personalized greeting
            String greeting = $"Hello, I am {firstName}, and I will be going to watch {favMovie} this afternoon!";
            Console.WriteLine(greeting.ToLower());
            Console.WriteLine();

            // b. Store the movie title in all capitals
            Console.WriteLine(favMovie.ToUpper());
            Console.WriteLine();

            // c. Use the .Contains() method
            Console.WriteLine(favMovie.Contains("THE"));
            Console.WriteLine();

            // d. Use the .Replace() method
            Console.WriteLine(favMovie.Replace('A', '@'));
            Console.WriteLine(favMovie.Replace('E', '3'));
            Console.WriteLine();

            // SECTION 2: STRING MANIPULATION

            // a. Store a favourite quote in a variable 
            string favQuote = "Worlds change when eyes meet.";
            Console.WriteLine(favQuote);
            Console.WriteLine();

            // b. Deal with lower/upper case problems
            Console.WriteLine(favQuote.Replace("a", "").Replace("e", "").Replace("u", "").Replace("i", "").Replace("o", "").ToUpper());
            Console.WriteLine();

            // SECTION 3: ASCII ART

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // a) Print two pictures side by side. (ARRAYS!!!)

            string[] coffeeMug =
            {
                "─▄▀─▄▀",
                "──▀──▀",
                "█▀▀▀▀▀█▄",
                "█░░░░░█─█",
                "▀▄▄▄▄▄▀▀"
            };

            string[] dog =
            {
                "██   ██ ██",
                "██   ██ ██",
                "███████ ██",
                "██   ██ ██",
                "██   ██ ██"
            };

            Console.WriteLine($"{coffeeMug[0]}     {dog[0]}");
            Console.WriteLine($"{coffeeMug[1]}     {dog[1]}");
            Console.WriteLine($"{coffeeMug[2]}   {dog[2]}");
            Console.WriteLine($"{coffeeMug[3]}  {dog[3]}");
            Console.WriteLine($"{coffeeMug[4]}   {dog[4]}");

        }
    }
}



//3. Use the internet to find some ASCII art. Have your program print out TWO different ASCII art
//images.
//a. For full marks, print out 2 pictures side by side.
//You may use a combination of Console.Write() and Console.WriteLine()
//statements to print each line of the images on the same line.