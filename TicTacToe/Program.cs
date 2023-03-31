namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game();
        }
        public static void Game()
        {
            Console.Title = "TicTacToe";
            var gameUI = new GameUI();
            gameUI.StartGame();
        }
    }
}