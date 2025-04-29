namespace MathGame.Jasmine330.Models;

internal class Game
{
    public DateTime Date { get; set; }
    public int Score { get; set; }
    public GameType Type{ get; set; }
    public TimeSpan Time { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division, 
    RandomGame
}
