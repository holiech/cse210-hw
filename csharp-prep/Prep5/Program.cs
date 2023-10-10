// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         DisplayWelcomeMessage();

//         string userName = PromptUserName();
//         int userNumber = PromptUserNumber();

//         int squaredNumber = SquareNumber(userNumber);

//         DisplayResult(userName, squaredNumber);
//     }

//     static void DisplayWelcomeMessage()
//     {
//         Console.WriteLine("Welcome to the program!");
//     }

//     static string PromptUserName()
//     {
//         Console.Write("Please enter your name: ");
//         string name = Console.ReadLine();

//         return name;
//     }

//     static int PromptUserNumber()
//     {
//         Console.Write("Please enter your favorite number: ");
//         int number = int.Parse(Console.ReadLine());

//         return number;
//     }

//     static int SquareNumber(int number)
//     {
//         int square = number * number;
//         return square;
//     }

//     static void DisplayResult(string name, int square)
//     {
//         Console.WriteLine($"{name}, the square of your number is {square}");
//     }
// }

// for (int i = 0; i < 100; i++)
// {
//     Console.WriteLine(i);
// }
using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // For Part 3, where we use a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}