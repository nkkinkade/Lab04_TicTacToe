using System;
using TicTacToe.Classes;

namespace TicTacToe
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Tic Tac Toe!");
            // TODO: Call that method in your Main method.
            StartGame();
        }

        // TODO: Setup your game. Create a new method that creates your players and instantiates the game class.
        public static void StartGame()
        {
            bool play = true;

            while (play == true)
            {
                Console.WriteLine("Player 1, please enter your name.");
                string input1 = Console.ReadLine();
                Console.WriteLine("Player 2, please enter enter name.");
                string input2 = Console.ReadLine();
                Player player1 = new Player();
                Player player2 = new Player();
                player1.Name = input1;
                player2.Name = input2;
                player1.Marker = "x";
                player2.Marker = "O";
                Game newGame = new Game(player1, player2);
                Player winner = newGame.Play();
                if (winner.Name != "Draw")
                {
                    // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player.
                    Console.WriteLine($"Congratulations, {winner.Name}, you win!");
                }
                else
                {
                    //If it's a draw, tell them that there is no winner.
                    Console.WriteLine("It's a draw. No winner this game.");
                }

                Console.WriteLine("Play another round? Y/N");
                string input = Console.ReadLine().ToLower();
                if (input == "y" || input == "1" || input == "yes")
                {
                    play = true;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
            }
        }
    }
}