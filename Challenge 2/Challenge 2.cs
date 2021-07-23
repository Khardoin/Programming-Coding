using System;

namespace Challange_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num01; // int is a variable that is used to represent a whole number i.e. 5
            double num02; // Double is a variable that is used to represent a decimal number i.e. 3.5
            double num03;
            double sum01;

            Console.Write("Input a number: ");
            num01 = Convert.ToDouble( Console.ReadLine() ) ; 

            Console.Write("Input a second number: ");
            num02 = Convert.ToDouble( Console.ReadLine() ) ;

            Console.Write("Input a Third number: ");
            num03 = Convert.ToDouble( Console.ReadLine() ) ;

            sum01 = (num01 + num02 +num03);
            Console.WriteLine("The sum is " + sum01);

            double average = (num01 + num02 + num03) / 3;
            Console.WriteLine("The average is " + average);
            
            Console.ReadKey(); // This makes the Console stay open until a key is pressed
        }
    }
}
