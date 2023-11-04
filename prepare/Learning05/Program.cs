// // // for (int i = 0; i < 10; i++){
// // //     if (i == 4)
// // //     {
// // //         break;
// // //     }
// // //     Console.WriteLine(i);
// // // }


// // // int s= 0;

// // // while (s ==9)
// // // {
    
// // //     s++;
// // //     Console.WriteLine(s);
// // // }

// //         Console.WriteLine("Random number between 1 and 60: " + randomNumber);
// //         Random randomGenerator = new Random();
// //         int magicNumber = randomGenerator.Next(1, 3);

// //         int guess = -1;
      
// //         // We could also use a do-while loop here...
// //         while (guess != magicNumber)
// //         {
// //             Console.Write("What is your guess? ");
// //             guess = int.Parse(Console.ReadLine());

// //             Console.Write("What guess? ");
// //         


// Random  randomGenerator = new Random();
// int magicNumber = randomGenerator.Next(1,6);
// int guess = 1;

// while (guess != magicNumber)
// {
//     Console.Write("What is your guess? ");
//     guess = int.Parse(Console.ReadLine());

//     if (guess < magicNumber)
//     {
//         Console.WriteLine("high");
//     }

//     else if (guess > magicNumber)
//     {
//         Console.WriteLine("low");
//     }

//     else{
//         Console.WriteLine("good");
//     }

// }
// List<string>magicNumber = new List

using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}