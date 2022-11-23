using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // saves user's input as animalGuess
            Console.WriteLine("Hello! Guess what animal I am thinking of.");
            string animalGuess = Console.ReadLine();
            bool animal = animalGuess == "tiger";

            do
            {   // responds o user's guess and allows them to keep trying
                // until they are correct
                switch (animalGuess)
                {
                    case "dog":
                        Console.WriteLine("Dog is incorrect. Try again!");
                        Console.WriteLine("Hello! Guess what animal I am thinking of.");
                        animalGuess = Console.ReadLine();
                        break;

                    case "cat":
                        Console.WriteLine("Cat is incorrect. Try again!");
                        Console.WriteLine("Guess what animal I am thinking of.");
                        animalGuess = Console.ReadLine();
                        break;

                    case "elephant":
                        Console.WriteLine("Elephant is incorrect. Try again!");
                        Console.WriteLine("Guess what animal I am thinking of.");
                        animalGuess = Console.ReadLine();
                        break;

                    case "mouse":
                        Console.WriteLine("Mouse is incorrect. Try again!");
                        Console.WriteLine("Guess what animal I am thinking of.");
                        animalGuess = Console.ReadLine();
                        break;

                    case "tiger":
                        Console.WriteLine("Tiger is correct! Great Job!");
                        Console.ReadLine();
                        animal = true;
                        break;

                    default:
                        Console.WriteLine("That is incorrect. Try again!");
                        Console.WriteLine("Guess what animal I am thinking of.");
                        animalGuess = Console.ReadLine();
                        break;
                }
            }
            // will keep loop going while "animal" is false
            while (!animal);
        }
    }
}
