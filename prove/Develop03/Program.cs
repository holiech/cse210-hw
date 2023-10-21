using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Scripture Memorizer");
        Console.WriteLine();

        //myscripture library
        Reference reference1 = new Reference("John", 3, 16);
        string text1 = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        Reference reference2 = new Reference("Psalm", 23, 1);
        string text2 = "The LORD is my shepherd, I shall not want.";

        Reference reference3 = new Reference("Matthew", 5, 14);
        string text3 = "You are the light of the world. A city set on a hill cannot be hidden.";

        Reference reference4 = new Reference("Genesis", 1, 1);
        string text4 = "In the beginning, God created the heavens and the earth.";

        Reference reference5 = new Reference("Proverbs", 3, 5, 6);
        string text5 = "Trust in the LORD with all your heart and lean not on your own understanding.";

        Reference reference6 = new Reference("Romans", 8, 28);
        string text6 = "And we know that in all things God works for the good of those who love him.";

        Reference reference7 = new Reference("1 Corinthians", 13, 4);
        string text7 = "Love is patient, love is kind. It does not envy, it does not boast, it is not proud.";

        Reference reference8 = new Reference("Ephesians", 2, 8);
        string text8 = "For it is by grace you have been saved, through faith, and this is not from yourselves, it is the gift of God.";

        Reference reference9 = new Reference("Isaiah", 40, 31);
        string text9 = "But those who hope in the LORD will renew their strength. They will soar on wings like eagles; they will run and not grow weary, they will walk and not be faint.";

        Reference reference10 = new Reference("John", 14, 6);
        string text10 = "Jesus answered, 'I am the way and the truth and the life. No one comes to the Father except through me.'";

        Scripture[] scriptures = new Scripture[]
        {
            new Scripture(reference1, text1),
            new Scripture(reference2, text2),
            new Scripture(reference3, text3),
            new Scripture(reference4, text4),
            new Scripture(reference5, text5),
            new Scripture(reference6, text6),
            new Scripture(reference7, text7),
            new Scripture(reference8, text8),
            new Scripture(reference9, text9),
            new Scripture(reference10, text10)
        };
        
        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Display all available scripture references");
            Console.WriteLine("2. Randomly select a scripture to work on");
            Console.WriteLine("3. Quit");

            string choice = Console.ReadLine().ToLower();

            if (choice == "1")
            {
                Console.WriteLine("Available Scripture References:");
                foreach (Scripture scripture in scriptures)
                {
                    Console.WriteLine(scripture.Reference.ToString());
                }
            }
            else if (choice == "2")
            {
                Random random = new Random();
                Scripture selectedScripture = scriptures[random.Next(scriptures.Length)];

                selectedScripture.DisplayScripture();
                Console.WriteLine("Press Enter to begin memorizing the scripture...");
                Console.ReadLine();

                while (!selectedScripture.AllWordsHidden())
                {
                    selectedScripture.HideWords(3);
                    selectedScripture.DisplayScripture();

                    Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                    {
                        break;
                    }
                }

                if (selectedScripture.AllWordsHidden())
                {
                    Console.WriteLine("Congratulations! You've memorized the scripture.");
                }
            }
            else if (choice == "3")
            {
                break; // Quit the program..............
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }
        }
    }
}
