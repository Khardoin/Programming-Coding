using System;
using System.Collections;
using System.Collections.Generic;

namespace Challenge_7
{
    class Wizard
    {
        public string name;
        public string favoriteSpell;
        private int spellSlots;
        public int health;
        private float experiance;
        public int damage;

        public static int Count; // It is standard practice to always capatalize the first letter in a static variable. the C in count in this case

        public Wizard(string _name, string _favoriteSpell)
        {
            name = _name;
            favoriteSpell = _favoriteSpell;
            health = 10;
            spellSlots = 2;
            experiance = 0f;

            Count++;
        }

        public void CastSpell(Wizard target)
        {   
            if (spellSlots > 0)
            {
                Console.WriteLine(name + " casts " + favoriteSpell);
                spellSlots--;
                experiance += 0.3f;
                damage = 2;
                target.health -= damage;
                target.reportHealth();
                
            }
            else
            {
                Console.WriteLine(name + " is out of spell slots!");
            }
        }

        public void reportHealth()
        {
            Console.WriteLine(name + "'s health is " + health);
        }

        public void Meditate()
        {
            Console.WriteLine(name + " meditates to regain spell slots and health.");
            spellSlots = 2;
            health += 1;
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            //Cat cat01 = new Cat();
            //Cat cat02 = new Cat();

            //cat01.name = "Cat Stevens";
            //cat01.age = 1;

            //cat01.Meow();

            //Console.ReadKey();


            //cat02.name = "meowly Cyrus";
            //cat02.age = 12;

            //cat02.Meow();

            //Console.ReadKey();

            List<Wizard> Wizards = new List<Wizard>();

            Wizards.Add(new Wizard("Parry Hotter", "Unexpecto Patronum"));
         
            Wizards.Add(new Wizard("Glindalf Merlionson", "Abracadabra"));

            Console.ReadKey();

            //Wizards[0].CastSpell(Wizards[1]);

            //Console.ReadKey();

            //Wizards[1].CastSpell(Wizards[0]);

            //Console.ReadKey();

            //Console.WriteLine(Wizard.Count);

            string playerInput = Console.ReadLine();

            switch (playerInput.ToUpper())
            {
                case "ATTACK":
                break;

                
                default:
                break;
            }

            
            
            Console.ReadKey();
        }
    }

    class Cat 
    {   // a class is a piece of code that is used to describe an object
        //for instance if you wanted to put a cat into a video game you created, you would create a Cat class,
        // and then put in various pieces of information to decsribe what a cat is. in this case, a name and age.
        // by doing this we are creating a blueprint of a cat, and when we wanted to spawn a cat into the game
        // we would do so using the blueprint.
        //This is called creating an instance of the class. in this example those are cat01 and cat02
        //The various peices of information can be called using the dot (.) function in the method,
        // in this case .name and .age folloed by an = and whatever the values are
        //Class constructors allow us to choose what happens when a class is created,
        // without having to use a bunch of lines and the . functions
        //An access modifier defines where the variables and methods can be accessed from,
        // examples of this are public and private and static
        // public means we can acess the variable or method outside of the class, using the . function
        // private means we can only access the variable or method inside the class itself. the . function will display it
        // Static will share the variable or method between all instances of the class
        // removing an access modifier will default the variable or method to private
        

        //public string name;
        
        //public int age;

        //public void Meow()
        //{
            //Console.Write(name + " says meow!");
        //}
    }
}
