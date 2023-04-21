using GF2D.Core;
using GF2D;

namespace Example
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            GameState.main = typeof(Example); // Main class

            var game = new Game();
            game.ShowDialog();
        }
    }
}