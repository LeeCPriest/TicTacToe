namespace TicTacToe
{
    public interface IPlayer
    {
        int GamesWon { get; }

        PlayerChar pChar { get; }

        string PlayerName { get; }

        int[] GetMove();

        void UpdateWinCount();
    }
}