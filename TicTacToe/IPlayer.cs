namespace TicTacToe
{
    public interface IPlayer
    {
        int GamesWon { get; set; }

        PlayerChar pChar { get; }

        string PlayerName { get; }

        int[] GetMove();

        //void UpdateWinCount();
    }
}