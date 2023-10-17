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
            Cockatoo.IsFlightful = true;
            Cockatoo.Beak = "curved and robust";
            Cockatoo.Size = "petit";
            Cockatoo.Tweet = "Can Talk";

            var GilaMonster = new Reptile()
            {
                IsColdBlooded = true,
                Skin = "dry and bumpy",
                Lungs = 2,
                FertilizeEggs = "Internal fertilization",
                Fur = "fur",
            };
            Console.WriteLine($"These are the qualaties of my new pet Cockatoo: " +
                $"Can Fly ={Cockatoo.IsFlightful} it's beak is {Cockatoo.Beak}, " +
                $"it's {Cockatoo.Size }, and {Cockatoo.Tweet}!");
            Console.WriteLine();
            Console.WriteLine($"I seen the most interesting Gilla Monster. Here a few characteristics: " +
                $"Is cold blooded = {GilaMonster.IsColdBlooded}, " +
                $"skin = {GilaMonster.Skin } it does not have {GilaMonster.Fur}, It has {GilaMonster.Lungs} lungs, and does {GilaMonster.FertilizeEggs}. ");


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
