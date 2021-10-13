using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Game_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This a my first Mad Libs game!\n" +
                "Plese fill out all of the questiona below for a funny halloween story at the end.\n" +
                "Please fill out nummbers 1-11. ");
           
            Console.WriteLine("\n1.Enter a Holiday:");
            string holiday = Console.ReadLine();
            Console.WriteLine("\n2.Enter a Noun:");
            string noun = Console.ReadLine();
            Console.WriteLine("\n3.Enter a Place:");
            string place = Console.ReadLine();
            Console.WriteLine("\n4.Enter a Person:");
            string person = Console.ReadLine();
            Console.WriteLine("\n5.Enter a Adjective:");
            string adjective = Console.ReadLine();
            Console.WriteLine("\n6.Enter a Body Part(Plural):");
            string bodyParts = Console.ReadLine();
            Console.WriteLine("\n7.Enter a Verb:");
            string verb = Console.ReadLine();
            Console.WriteLine("\n8.Enter a Adjective:");
            string adjective1 = Console.ReadLine();
            Console.WriteLine("\n9.Enter a Noun:");
            string noun1 = Console.ReadLine();
            Console.WriteLine("\n10.Enter Food:");
            string food = Console.ReadLine();
            Console.WriteLine("\n11.Enter a Plural Noun:");
            string pluralNoun = Console.ReadLine();
           

            
            Console.WriteLine("This is your Halloween Mad Lib:\n");

            string story = $"\nI can't believe it's already {holiday}!\n" +
                $"I can't wait to put on my {noun} and visit every {place} in my neighborhood.\n" +
                $"This year, I am going to dress up as {person} with {adjective} {bodyParts}.\n" +
                $"Before I {verb}, I make sure to grab my {adjective1} {noun1} to hold all of my {food}.\n" +
                $"Finally, all of my {pluralNoun} are ready to go!";

           
            Console.WriteLine(story);
            Console.ReadLine();
        }
    }
}
