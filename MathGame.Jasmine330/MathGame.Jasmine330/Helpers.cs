using MathGame.Jasmine330.Models;

namespace MathGame.Jasmine330
{
    internal class Helpers
    {
        public static Random random = new Random();
        public static List<Game> games = new ();

        internal static int[] GetDivisionNumbers()
        { 
           var firstNumber = random.Next(0, 99);
           var secondNumber = random.Next(1, 99);

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(0, 99);
                secondNumber = random.Next(1, 99);
            }

            var result = new int[2]
            {
                firstNumber,
                secondNumber
            };

            return result;
        }

        internal static void AddToHistory(int gameScore, GameType gameType, TimeSpan timeTaken)
        {
                games.Add(new Game
                {
                    Date = DateTime.Now,
                    Score = gameScore,
                    Type = gameType,
                    Time = timeTaken
                });
            
                
        }

        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Game History");
            Console.WriteLine("_______________________________________\n");

            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: \t{game.Score}pts \t\t Time Taken: {game.Time.ToString("mm\\:ss\\.fff")}");
            }
            Console.WriteLine("_______________________________________\n");
            Console.WriteLine("Press any key to retrun to Main Menu");
            Console.ReadLine();
        }

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again.");
                result = Console.ReadLine();
            }

            return result;
        }

        internal static string GetName()
        {
            Console.WriteLine("Please type your name");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be empty");
                name = Console.ReadLine();
            }

            return name;
        }

        internal static int[] GetNumbers()
        {
            var random = new Random();
            int[] result = new int[2];

            result[0] = random.Next(0, 9);
            result[1] = random.Next(0, 9);

            return result;
        }
    }
}
