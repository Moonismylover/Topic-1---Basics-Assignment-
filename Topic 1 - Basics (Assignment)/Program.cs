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

            // a. Personalized greeting
            String greeting = $"Hello, I am {firstName}, and I will be going to watch the {favMovie} this afternoon!";
            Console.WriteLine(greeting.ToLower());
            Console.WriteLine();

            // b. Store the movie title in all capitals
            Console.WriteLine(favMovie.ToUpper());
            Console.WriteLine();

            // c. Use the .Contains() method
            Console.WriteLine(favMovie.Contains("THE"));
            Console.WriteLine();

            // d. Use the .Replace() method
            Console.WriteLine(favMovie.Replace('A', '@'))



        }
    }
}


//c. Use the .Contains() method to determine whether the movie title (now all capital
//letters) contains the word “THE” in it. Print out ‘True’, or ‘False’.
//d. Use the .Replace() method to replace the letter “A” with “@” and “E” with “3”.
//Once done, print the new string.

//2.Make a variable with an appropriate name that stores your favourite quote from a movie, TV
//show or song (or any other source you like). The quote must be at least a short sentence.
//a. Remove all of the vowels from the quote by replacing then with the empty string (“”).
//b. You must decide how you will deal with capital and lowercase letters.
//3. Use the internet to find some ASCII art. Have your program print out TWO different ASCII art
//images.
//a. For full marks, print out 2 pictures side by side.
//You may use a combination of Console.Write() and Console.WriteLine()
//statements to print each line of the images on the same line.