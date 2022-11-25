using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            // PART 1 ASSIGNMENT

            // creating an array of strings
            string[] stringArray = { "Everything in your fantasy world will be the color: ", "The sky is ", "The grass is ", "All of the buildings are ", "Even the townspeople are the color " };

            // asking the user to input text
            Console.WriteLine("Please enter your favorite color:");
            string favoriteColor = Console.ReadLine();
            Console.ReadLine();

            // adds user input to end of each string in array
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + favoriteColor;
            }

            // iterates through second loop and prints each string one at a time
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
                Console.ReadLine();
            }




            // PART 2 ASSIGNMENT

            // creating an infinte loop
            // and fixing infinite loop
            // added "Console.ReadLine();" and "break;" to while loop so only one "true" will print
            // to console
            bool myBool = true;

            while (myBool)
            {
                Console.WriteLine(myBool);
                Console.ReadLine();
                break;
            }

            // PART 3 ASSIGNMENT

            // creating loop using < operator
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            // creating loop using <= operator
            for (int i = 0; i <= 20; i = i + 4)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();



            // PART 4 ASSIGNMENT

            // creating list of unique strings
            List<string> stringList = new List<string>();
            stringList.Add("basketball");
            stringList.Add("soccer");
            stringList.Add("baseball");
            stringList.Add("hockey");
            stringList.Add("football");
            stringList.Add("tennis");


            // saves user text
            Console.WriteLine("Please enter a sport to see if it is on the list:");
            string userSport = Console.ReadLine();


            // creating while loop to check user answer and find index position
            // will either display correct or incorrect message
            bool userGuess = false;

            do
            {
                switch (userSport)
                {
                    case "basketball":
                        int index1 = stringList.FindIndex(a => a.Contains("basketball"));
                        Console.WriteLine("Correct! Basketball is number " + index1 + " in our index!");
                        Console.ReadLine();
                        userGuess = true;
                        break;

                    case "soccer":
                        int index2 = stringList.FindIndex(a => a.Contains("soccer"));
                        Console.WriteLine("Correct! Soccer is number " + index2 + " in our index!");
                        Console.ReadLine();
                        userGuess = true;
                        break;

                    case "baseball":
                        int index3 = stringList.FindIndex(a => a.Contains("baseball"));
                        Console.WriteLine("Correct! Baseball is number " + index3 + " in our index!");
                        Console.ReadLine();
                        userGuess = true;
                        break;

                    case "hockey":
                        int index4 = stringList.FindIndex(a => a.Contains("hockey"));
                        Console.WriteLine("Correct! Hockey is number " + index4 + " in our index!");
                        Console.ReadLine();
                        userGuess = true;
                        break;

                    case "football":
                        int index5 = stringList.FindIndex(a => a.Contains("football"));
                        Console.WriteLine("Correct! Football is number " + index5 + " in our index!");
                        Console.ReadLine();
                        userGuess = true;
                        break;

                    case "tennis":
                        int index6 = stringList.FindIndex(a => a.Contains("tennis"));
                        Console.WriteLine("Correct! Tennis is number " + index6 + " in our index!");
                        Console.ReadLine();
                        userGuess = true;
                        break;

                    default:
                        Console.WriteLine("That sport is not on the list!");
                        Console.WriteLine("Please enter a sport to see if it is on the list:");
                        userSport = Console.ReadLine();
                        break;
                }
            }
            while (!userGuess);



            // PART 5 ASSIGNMENT
            // creating a list of strings with two identicals
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("texas");
            listOfStrings.Add("georgia");
            listOfStrings.Add("kentucky");
            listOfStrings.Add("delaware");
            listOfStrings.Add("florida");
            listOfStrings.Add("florida");

            // saves user input
            Console.WriteLine("Please enter a Southern state to see how many indicies there are of it on the list!");
            string southernState = Console.ReadLine();

            bool userStringGuess = false;

            // creating loop to find indicies and display to console
            do
            {
                switch (southernState)
                {
                    case "texas":
                        int index = listOfStrings.FindIndex(a => a.Contains("texas"));
                        Console.WriteLine("The state \"Texas\" is at position " + index + " in the index.");
                        Console.ReadLine();
                        userStringGuess = true;
                        break;

                    case "georgia":
                        int index2 = listOfStrings.FindIndex(a => a.Contains("georgia"));
                        Console.WriteLine("The state \"Georgia\" is at position " + index2 + " in the index.");
                        Console.ReadLine();
                        userStringGuess = true;
                        break;

                    case "kentucky":
                        int index3 = listOfStrings.FindIndex(a => a.Contains("kentucky"));
                        Console.WriteLine("The state \"Kentucky\" is at position " + index3 + " in the index.");
                        Console.ReadLine();
                        userStringGuess = true;
                        break;

                    case "delaware":
                        int index4 = listOfStrings.FindIndex(a => a.Contains("delaware"));
                        Console.WriteLine("The state \"Delaware\" is at position " + index4 + " in the index.");
                        Console.ReadLine();
                        userStringGuess = true;
                        break;

                    case "florida":
                        int index5 = listOfStrings.FindIndex(a => a.Contains("florida"));
                        int index6 = listOfStrings.FindLastIndex(a => a.Contains("florida"));
                        Console.WriteLine("The state \"Florida\" is at positions " + index5 + " and " + index6 + " in the index.");
                        Console.ReadLine();
                        userStringGuess = true;
                        break;

                    default:
                        Console.WriteLine("That state is not on the list!");
                        Console.WriteLine("Please enter a Southern state to see how many indicies there are of it on the list!");
                        southernState = Console.ReadLine();
                        break;
                }
            }
            while (!userStringGuess);


            // PART 6 ASSIGNMENT

            // creating new list of strings with denticals
            List<string> fruitsList = new List<string>();
            fruitsList.Add("apple");
            fruitsList.Add("pear");
            fruitsList.Add("orange");
            fruitsList.Add("mango");
            fruitsList.Add("apple");
            fruitsList.Add("kiwi");
            
            // finding the duplicates in the list of strings
            IEnumerable<string> duplicates = fruitsList.GroupBy(x => x)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key);

            // creating foreach loop in order to print strings and
            // indicate whether they are unique or duplicate
            foreach ( string fruit in fruitsList)
            {
                Console.Write(fruitsList[0] + " is unique");
                Console.ReadLine();
                Console.Write(fruitsList[1] + " is unique");
                Console.ReadLine();
                Console.Write(fruitsList[2] + " is unique");
                Console.ReadLine();
                Console.Write(fruitsList[3] + " is unique");
                Console.ReadLine();
                Console.Write(String.Join(", ", duplicates) + " is a duplicate");
                Console.ReadLine();
                Console.Write(fruitsList[5] + " is unique");
                Console.ReadLine();
                return;
            }
        }
    }
}
