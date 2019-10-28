using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {   // ------------------------------- //
            // ----- THREE BASIC ARRAYS ----- //
            // ----------------------------- //
            // 1. Create an array to hold integer values 0 through 9
            int[] zeroNine = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int x = 0; x < zeroNine.Length; x++)
            {
                Console.WriteLine("\n" + zeroNine[x]);
            }

            // 2. Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            for (int x = 0; x < names.Length; x++)
            {
                Console.WriteLine("\n" + names[x]);
            }

            // 3. Create an array of length 10 that alternates between true and false values, starting with true
            bool[] trueFalse = new bool[] { true, false, true, false, true, false, true, false, true, false };
            for (int x = 0; x < trueFalse.Length; x++)
            {
                Console.WriteLine("\n" + trueFalse[x]);
            }

            // ---------------------------- //
            // ----- LIST OF FLAVORS ----- //
            // -------------------------- //
            // 1. Create a list of ice cream flavors that holds at least 5 different flabors (feel free to add more than 5!)
            List<string> iceCream = new List<string>();
            iceCream.Add("Rocky Road");
            iceCream.Add("Mint Chocolate Chip");
            iceCream.Add("Chocolate");
            iceCream.Add("Vanilla Bean");
            iceCream.Add("Coffee");
            iceCream.Add("Cookie Dough");
            iceCream.Add("Butter Pecan");
            iceCream.Add("Moose Tracks");
            iceCream.Add("Strawberry");
            iceCream.Add("Neapolitan");

            Console.WriteLine("\n" + "10 Flavors of Ice Cream:");
            foreach (string cream in iceCream)
            {
                Console.WriteLine("-" + cream);
            }

            // 2. Output the length of this list after building it
            Console.WriteLine("\n" + $"There are {iceCream.Count} flavors of Ice Cream.");

            // 3. Output the third flavor in the list, then remove this value
            // -- OUTPUT
            Console.WriteLine("\n" + $"The third value is {iceCream[2]}");

            // -- REMOVE
            iceCream.RemoveAt(2);
            Console.WriteLine("\n" + "Updated Flavors of Ice Cream are now...");
            foreach (string cream in iceCream)
            {
                Console.WriteLine("-" + cream);
            }

            // Output the new length of the list (It should just be one fewer)
            Console.WriteLine("\n" + $"There are now {iceCream.Count} flavors of ice cream");

            // --------------------------------- //
            // ----- USER INFO DICTIONARY ----- //
            // ------------------------------- //
            // Create a dictionary that will store both string keys as well as string values 
            Dictionary<string, string> newNames = new Dictionary<string, string>();
            for (int x = 0; x < names.Length; x++)
            {
                Random rand = new Random();
                newNames.Add(names[x], iceCream[rand.Next(0, 9)]);
            }
            foreach (var entry in newNames)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }

        }
    }
}
