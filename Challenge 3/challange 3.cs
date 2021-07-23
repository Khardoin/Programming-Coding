using System;

namespace Challenge_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // notes
            // if and else statments
            // == is egual to
            // != is not equal to
            // > is greater than
            // < is less than
            // >= is greater than or equal to
            // <= is less than or equal to
            // && is and
            // || is or

            // example

            //Console.WriteLine("welcome! Tickets are 5$. Please insert cash.");

            //int cash = Convert.ToInt32(Console.ReadLine());

            //if(cash < 5) // creates a true or false statement, if the condition is true, the next line of code is read
            //{
               //Console.WriteLine("That's not enough money.");
            //}
            //else if (cash == 5) // if the if statement condition was false, but the else if condition was true, the line of code under the else if statement is read
            //{
                //Console.WriteLine("Here is your ticket.");
            //}
            //else // if the (if/else if) statement conditions where false, the line of code under the else statement is read
            //{
               // int change = cash - 5;
                //Console.WriteLine("Here is your ticket and " + change + " dollars in change."); 
            //}

            // new example

            //int age;
            //int height;

            //Console.Write("Please input age: ");
            //age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please input height: ");
            //height = Convert.ToInt32(Console.ReadLine());

            //if (age >= 18 ||  height >= 160){ // adding the && or || lets you chain conditions together
                //Console.WriteLine("You can enter!");
            //}else{
                //Console.WriteLine("You don't meet the requirements.");
            //}

            // new example, switches

            //Console.Write("Input a number between 1 and 5: ");

            //int num = Convert.ToInt32(Console.ReadLine());

            //switch (num){
                //case 1:
                    //Console.WriteLine("One");
                    //break;
                //case 2:
                    //Console.WriteLine("Two");
                    //break;
                //case 3:
                    //Console.WriteLine("Three");
                    //break;
                //case 4:
                    //Console.WriteLine("Four");
                    //break;
                //case 5:
                    //Console.WriteLine("Five");
                    //break;
                //default:
                    //Console.WriteLine("Default");
                    //break;
                //}

                Console.WriteLine("Please answer the following problems.");
                Console.WriteLine("What is 1 + 1?");
                int ans1 = Convert.ToInt32(Console.ReadLine());

                if (ans1 == 2){
                    Console.WriteLine("Correct!");
                }else{
                    Console.WriteLine("Incorrect!");
                }

                Console.WriteLine("What is 10 - 6?");
                int ans2 = Convert.ToInt32(Console.ReadLine());

                if (ans2 == 4) {
                    Console.WriteLine("You got it!");
                }else{
                    Console.WriteLine("No good!");
                }

                Console.WriteLine("What is 11 * 62?");
                int ans3 = Convert.ToInt32(Console.ReadLine());

                if (ans3 == 682){
                    Console.WriteLine("Way to go!");
                }else{
                    Console.WriteLine("Try again!");
                }

                Console.WriteLine("What is 1,069,853 / 56.875?");
                double ans4 = Convert.ToDouble(Console.ReadLine());

                if (ans4 == 18810.6021978022){
                    Console.WriteLine("Nice job cheating I guess...");
                }else if (ans4 <18810.6021978022){
                    Console.WriteLine("Close, but a little low.");
                }else if (ans4 > 18810.6021978022){
                    Console.WriteLine("Almost! You where a little too high.");
                }


            Console.ReadKey();
        }
    }
}
