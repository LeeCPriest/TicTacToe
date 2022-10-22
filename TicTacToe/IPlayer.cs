namespace TicTacToe
{
    public interface IPlayer
    {
        int GamesWon { get; set; }
        PlayerChar pChar { get; set; }

        int[] GetMove(string PlayerName);
    }
}