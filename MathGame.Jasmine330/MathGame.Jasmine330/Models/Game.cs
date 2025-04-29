namespace MathGame.Jasmine330.Models;

internal class Game
{
    //private int _score;

    //public int Scor
    //{
    //    get { return _score; }
    //    set { _score = value; }
    //}

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
