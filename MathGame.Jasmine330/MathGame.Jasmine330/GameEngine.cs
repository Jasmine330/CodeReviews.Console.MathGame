using MathGame.Jasmine330.Models;

namespace MathGame.Jasmine330
{
    internal class GameEngine
    {
        internal void MathGame(string message, GameType gameType)
        {
            Console.Clear();
            Console.WriteLine(message);
            var score = 0;
            var timeTaken = new TimeSpan();


            for (int i = 0; i < 5; i++)
            {
                var startTime = DateTime.Now;
                GameType currentGameType = gameType;

                if (currentGameType == GameType.RandomGame)
                {
                    currentGameType = (GameType)Helpers.random.Next(0, 4);
                }

                var firstNumber = 0;
                var secondNumber = 0;

                if (currentGameType == GameType.Division)
                {
                    var divisionNumbers = Helpers.GetDivisionNumbers();
                    firstNumber = divisionNumbers[0];
                    secondNumber = divisionNumbers[1];
                }
                else
                {
                    var numbers = Helpers.GetNumbers();
                    firstNumber = numbers[0];
                    secondNumber = numbers[1];

                }

                string operatorSymbol = currentGameType switch
                {
                    GameType.Addition => "+",
                    GameType.Subtraction => "-",
                    GameType.Multiplication => "*",
                    GameType.Division => "/",
                    _ => throw new ArgumentOutOfRangeException("Invalid Operation")
                };

                Console.Clear();
                Console.WriteLine($"{currentGameType} game");
                Console.WriteLine($"{firstNumber} {operatorSymbol} {secondNumber}?");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                int correctAnswer = currentGameType switch
                {
                    GameType.Addition => firstNumber + secondNumber,
                    GameType.Subtraction => firstNumber - secondNumber,
                    GameType.Multiplication => firstNumber * secondNumber,
                    GameType.Division => firstNumber / secondNumber,
                    _ => throw new ArgumentException("Invalid operation")
                };

                if (int.Parse(result) == correctAnswer)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question!");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect! Type any key for the next question!");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over! Your score is {score}. Press any key to go the Main Menu.");
                    Console.ReadLine();
                }
                var endTime = DateTime.Now;
                timeTaken = endTime - startTime;
                Helpers.AddToHistory(score, currentGameType, timeTaken);

            }
        }
    }
}
