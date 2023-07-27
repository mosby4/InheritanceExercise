using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal--DONE
            // give this class 4 members that all Animals have in common--DONE


            // Create a class Bird--DONE
            // give this class 4 members that are specific to Bird--Done
            // Set this class to inherit from your Animal Class--Done 

            // Create a class Reptile--Done 
            // give this class 4 members that are specific to Reptile--Done 
            // Set this class to inherit from your Animal Class--Done 

            var Cockatoo = new Bird();
            Cockatoo.isFlightful = true;
            Cockatoo.beak = "curved and robust";
            Cockatoo.size = "petit";
            Cockatoo.tweet = "Can Talk";

            var GilaMonster = new Reptile()
            {
                isColdBlooded = true,
                skin = "dry and bumpy",
                lungs = 2,
                fertilizeEggs = "Internal fertilization",
            };
            Console.WriteLine($"These are the qualaties of my new pet: " +
                $"Can Fly ={Cockatoo.isFlightful} it's beak is {Cockatoo.beak}, " +
                $"it's {Cockatoo.size }, and {Cockatoo.tweet}!");
            Console.WriteLine();
            Console.WriteLine($"I seen the most interesting Gilla Monster. Here a few characteristics: " +
                $"Is cold blooded = {GilaMonster}, " +
                $"skin = {GilaMonster.skin }, It has {GilaMonster.lungs}, and does {GilaMonster.fertilizeEggs}. ");


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
