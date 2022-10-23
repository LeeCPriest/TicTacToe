namespace TicTacToe
{
    public interface IBoard
    {
        GameResult gameResult { get; }

        bool AddMove(IPlayer player, int value, int[] position);

        void IsGameOver(ref IPlayer player);

        bool PlayAgain();
    }
}