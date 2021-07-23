using System;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Tavern Interaction";
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Barkeeper - Hello stranger, what can I do for you?");

            Console.ForegroundColor = ConsoleColor.Green; 
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You don't say? well, I think that can be arranged!");

            Console.ForegroundColor = ConsoleColor.Green; 
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Thug - I don't like the cutuva jib boy, get lost, we don't need weaklings around these parts");

            Console.ForegroundColor = ConsoleColor.Green; 
            Console.ReadLine();


            Console.ReadKey();
        }
    }
}
