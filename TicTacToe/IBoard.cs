namespace TicTacToe
{
    public interface IBoard
    {
        GameResult gameResult { get; set; }

        bool AddMove(IPlayer player, int value, int[] position);
        void InitBoard();
        void IsGameOver(ref IPlayer player);
    }
}