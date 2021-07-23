using System;

namespace Challenge_4
{
    class Program
    {
        static void Main(string[] args)
        {
             //for loops are used to repeat code over and over
               //for (int i = 0; i < 10;  ){   the first part inside the parentheses until the ; happens before the loop starts,
                                        // the second part is the condition that triggers the loop to keep running, also ended with a ;
                                        // the third part is what happens after the loop is run, in this case i++ means the iteration int will increase by 1
                   //Console.WriteLine(i+1) the i stands for iteration, iterations usually start at 0
               //}

               // example 2

               //for (int i = 0; i < 10; i++)  //the ++ is short hand for add 1
               //{
                   //Console.WriteLine(i + 1);
               //} //  creates a list from 1 to 10

               //example 3

               //for (int i = 1; i <= 10; i++)
               //{
                   //Console.WriteLine(i);
               //} // this for loop operates the exact same way as the one above it, but with a variation on the code

               //example 4
               
               //for (int i = 10; i > 0; i--) // the -- means subtract 1
               //{
                   //Console.WriteLine(i);
               //} // this for loop counts down from 10 to 1

               // example 5

               //Console.Write("How many cool numbers do you want: ");

                   //int count = Convert.ToInt32(Console.ReadLine()); //convert.toint32 convers whatever is typed into the read line to an interger

               //for (int i = 1; i <= count; i++)
               //{
                   //double result = Math.Pow(2, i); // uses the math class to times i by the power of 2
                   //Console.WriteLine(i);
               //} // this for loop generates numbers to the power of 2

            // example 6


            // while loops 

            //Random numberGen = new Random(); // this creates a random number generator

            //int roll = 0;
            //int attempts = 0;

            //Console.WriteLine("Press any key to roll the die.");

            //while(roll !=6){ // ! means not
                //Console.ReadKey();
                //roll = numberGen.Next(1, 7); // the 1 is inclusive, the 7 is exclusive so the random numbers are only 1-6
                //Console.WriteLine("You rolled: " + roll);
                //attempts++;
            //}

            //Console.WriteLine("It took you " + attempts + " attempts to roll a six.");

            // example 7

            Random numberGen = new Random();

            int die1 = 0;
            int die2 = 0;
            int attempts = 0;

            Console.WriteLine("Press any key to roll the dice.");

            while(die1 + die2 !=7){
                Console.ReadKey();
                die1 = numberGen.Next(1, 7);
                die2 = numberGen.Next(1, 7); 
                int roll = die1 + die2;
                Console.WriteLine("First die: " + die1);
                Console.WriteLine(" Second die: " + die2);
                Console.WriteLine("You rolled a " + roll + "!");
                attempts++;
            }

            Console.WriteLine("It took you " + attempts + " attempts to roll Big Red.");

            //ExampleCode exCode = new ExampleCode();
            //int exampleNumber = exCode.getnumber();
            //exCode.AmeliaTitty();
               Console.ReadKey(); // keeps the program from auto closing
        }
    }
}
