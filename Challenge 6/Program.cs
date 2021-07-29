using System;

namespace Challenge_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintNumber();
            //MeetAlien();
            //Square(4) //in this, the 4 becomes the int number, which is times by itself for the int result
            //int result = multiply(3, 8);
            //Console.WriteLine("The result is: " + result);

            //if (result % 2 == 0)
            //{
                //Console.WriteLine(result + " is an even number!");
            //}else
            //{
                //Console.WriteLine(result + " is an uneven number!");
            //}

            string wordCount = Console.ReadLine();
            int count = wordCount.Split(" ").Length;
            Console.WriteLine("There are " + count + " words");
            

            //kepps console open until any key is pressed
            Console.ReadKey();
        }

        //Methods are created outside of Main. To create one you type void above or below the main method
        //  you then type the name of your method, an open and close parenthesis, and then curly brackets
        //for example

        //static void PrintNumber()
        //{
            //Random numGen = new Random();
            //int number = numGen.Next(0, 10);
            //Console.WriteLine(number);
        //}

        //in C# methods are also called functions, the words are interchangable.

        // example

        //static void MeetAlien()
        //{
            //Random numberGen = new Random();

            //string name = "X-" + numberGen.Next(10, 9999);
            //int age = numberGen.Next(21, 500);

            //Console.WriteLine("Hi, I'm " + name);
            //Console.WriteLine("I'm " + age + " years old.");
            //Console.WriteLine("Oh, and I'm an alien!");
        //}

        //parameters go inside he parenthises of the method. parameters are used as the first step of getting a return resault
        //inside of the curly brakets you can use the parameter just like any other variable

        // example

        // static void Square(int number)  in this the int number is the parameter
        //{
            //int result = number * number;  and in this the variable uses int number to form the int result
        //}

        // a return value is what happens when the calculaion is completed, for example when int result has its solution
        // to generate a return value, you must replace the void in the method with int
        //you then add return under the variable in the method, and type what you want returned, in this case it is result

        // example

        // static int Square(int number)  in this the int number is the parameter
        //{
            //int result = number * number;  and in this the variable uses int number to form the int result
            //return result;
        //}

        //static int multiply(int num01, int num02)
        //{
            //int result = num01 * num02;
            //return result;
        //}
    }
}
