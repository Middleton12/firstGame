using MadLib_ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Game_Console
{
    class ProgramUI
    {
        public void RunMenu()
        {

            Console.WriteLine("This a my first Mad Libs game!\n" +
                "Plese fill out all of the questiona below for a funny halloween story at the end.\n" +
                "Please fill out nummbers 1-11.\n");


            Console.WriteLine("Please press 1 to stat!");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Story story = CreateMadLibStory();
                    ShowMadLibStory(story);
                    break;

                   default:
                    Console.WriteLine("Please enter any key to start.\n");
                    Console.ReadKey();
                    break;
            }
        }
        public Story CreateMadLibStory()
        {
            Story story = new Story();
            Console.WriteLine("Enter a Holiday");
            story.Holiday = Console.ReadLine();
            Console.WriteLine("Enter a Noun");
            story.Noun = Console.ReadLine();
            Console.WriteLine("Enter a Place");
            story.Place = Console.ReadLine();
            Console.WriteLine("Enter a Person");
            story.Person = Console.ReadLine();
            Console.WriteLine("Enter a Adjective");
            story.Adjective = Console.ReadLine();
            Console.WriteLine("Enter Body Parts");
            story.BodyParts = Console.ReadLine();
            Console.WriteLine("Enter a Verb");
            story.Verb = Console.ReadLine();
            Console.WriteLine("Enter a Adjective");
            story.Adjective1 = Console.ReadLine();
            Console.WriteLine("Enter a Noun");
            story.Noun1 = Console.ReadLine();
            Console.WriteLine("Enter a Food");
            story.Food = Console.ReadLine();
            Console.WriteLine("Enter a Plural Noun");
            story.PluralNoun = Console.ReadLine();

            return story;


        }
        public void ShowMadLibStory(Story story)
        {
            Console.WriteLine($"\nI can't believe it's already {story.Holiday}!\n" +
            $"I can't wait to put on my {story.Noun} and visit every {story.Place} in my neighborhood.\n" +
            $"This year, I am going to dress up as {story.Person} with {story.Adjective} {story.BodyParts}.\n" +
            $"Before I {story.Verb}, I make sure to grab my {story.Adjective1} {story.Noun1} to hold all of my {story.Food}.\n" +
            $"Finally, all of my {story.PluralNoun} are ready to go!");


        }
    }
}

