using MathGame.Jasmine330.Models;

namespace MathGame.Jasmine330
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name.ToUpper()}. Its {date.DayOfWeek}. This is your maths's game. That's great your're working on improving yourself.");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play todya? Choose from the options below:
            V - View Previous Games
            A - Addition
            S - Subtraction
            M - Multiplication
            D - Division
            R - Random Game
            Q - Quit");

                Console.WriteLine("___________________________________");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;

                    case "a":
                        gameEngine.MathGame("Addition game was selected.", GameType.Addition);
                        break;

                    case "s":
                        gameEngine.MathGame("Subtraction game was selected.", GameType.Subtraction);
                        break;

                    case "m":
                        gameEngine.MathGame("Multiplication game was selected.", GameType.Multiplication);
                        break;

                    case "d":
                        gameEngine.MathGame("Division game was selected.", GameType.Division);
                        break;

                    case "r":
                        gameEngine.MathGame("Random game was selected.", GameType.RandomGame);
                        break;

                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Output");
                        break;
                }
            } while (isGameOn);

        }

    }
}
