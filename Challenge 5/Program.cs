using System;
using System.Collections.Generic;

namespace Challenge_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays are created using []
            // to create an array you type in the type of array[], and then the array name = and then {};
            // for example 
            // string[] favourites = 
            // { "Varys",
            //   "Cersie",
            //   "Tyrion",
            //   "Bronn"
            // };
            // items in an array are referred to as an index, and the first item always has an index of 0.
            //      the next item would be 1, then 2, then 3 etc. 
            // Console.Write(favourites[2]); would write out Tyrion
            
            // exapmle 1

            //string[] movies = {"Lord of the Rings", "Fight Club", "Intersteller", "Gladiator"};
            
            // i needs to be less than the number of items in the array
            //for (int i = 0; i < 4; i++)
            // a better practice is the follwoing
            //for (int i = 0; i < movies.Length; i++) 
            //
            //{
            //    int rank = i + 1;
            //    Console.WriteLine(rank + ". " + movies[i]);
            //}

            // by placing i < movies.Length; in the for loop, you change the size of the array to fit the amount of items in the index

            // example 2

            // for arrays that need to have information put into them by a user

            //string[] movies = new string[4];

            //Console.WriteLine("Type in four movies: ");

            //for (int i = 0; i < movies.Length; i++)
            //{
            //    movies[i] = Console.ReadLine();
            //}

            //Console.WriteLine("\nHere they are alphabetically: ");

            //Array.Sort(movies);

            //for (int i = 0; i < movies.Length; i++)
            //{
            //    Console.WriteLine(movies[i]);
            //}

            // example 3

            // using lists

            // To use lists, you have to use a seperate namespace, by typing in (using System.Collecetions.Generic;) at the top of the script
            // to create a list, you type in List then the <, then the type of list, then the >, and the list name
            // for example 

            //List<string> shoppingList = new List<string>();

            // To add items to your list you type in the name of the list .Add()
            // for example

            //  shoppingList.Add("Dreams");
            //  shoppingList.Add("Miracles");
            //  shoppingList.Add("Rainbows");
            //  shoppingList.Add("Pony");

            // to generate the list you would create a for loop like with an array, but i < shoppingList.Count instead of .Length
            // for example

            //for (int i = 0; i < shoppingList.Count; i++)
            //{
            //    Console.WriteLine(shoppingList[i]);
            //}

            // to remove items from a list, you would type the name of the list .Remove("the item");
            // you can also remove items by their index number by typing the name of the list .RemoveAt(index number);
            // for example
            
            //shoppingList.Remove("Dreams");
            //shoppinglist.RemoveAt(1);

            // thiese two lines of code remove Dreams and Rainbows from the list. 
            //Note that removing Dreams Changed the index of Rainbows from 2 to 1

            //Console writeLine("----------------------"); 
            //This line just seperates the list between the original and the List after the iteams are removed, sice they are displayed on the same Console.

            //for (int i = 0; i < shoppingList.Count; i++)
            //{
            //    Console.WriteLine(shoppingList[i]);
            //}

            

            Console.Write("How many Children are in the Class? ");

            int classSize = Convert.ToInt32(Console.ReadLine());

            string[] classNames = new string[classSize];

            Console.WriteLine("What are their names?");

            for (int i = 0; i < classNames.Length; i++)
            {
                classNames[i] = Console.ReadLine();
            }

            Console.WriteLine("\nSorting Alphbetically...\n");

            Array.Sort(classNames);

            for (int i = 0; i < classNames.Length; i++)
            {
                Console.WriteLine(classNames[i]);
            }





            //keeps terminal open until a key is pressed
            Console.ReadKey();
        }
    }
}
