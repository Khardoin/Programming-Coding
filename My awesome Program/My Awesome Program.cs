using System;

namespace My_awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {

            // = making a comment that doesnt affect the code
            // this block of code changes the apperance of the console
            Console.Title = "skynet"; // Changes the name displayed in the title box of the Conole
            Console.ForegroundColor = ConsoleColor.Green; // Changes the name of the Fore ground color in the console, in this case the text
            Console.WindowHeight = 40; // Changes the window height to a specific number of lines

            // this block of code starts the conversation

            //reomved line from video 1 Console.WriteLine("Hello World!"); // writes out the words "Hello World" in the console
            Console.WriteLine("Hello, What's your name?"); // writes out the words "Hello, What's your name?" in the console

            Console.ReadLine(); // Allows the user to inout text from the console

            Console.WriteLine("My name is RX-9000. \nI'm an AI sent from the future to destroy mankind."); // \n creates a new line of text with out using the .Writeline command
            Console.WriteLine("What is your favorite color?");

            Console.ReadLine();

            Console.WriteLine("Cool, Mine is destruction!");

            Console.ReadKey(); // makes the console wait for a keystroke befoe doing anything
        }
    }
}
