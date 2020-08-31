using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
	class Board
	{
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		public void DisplayBoard()
		{

			//TODO: Output the board to the console

			for (int i = 0; i < 3; i++)
			{
				string line = "";
				for (int x = 0; x < 3; x++)
				{
					line = $"{line} | {GameBoard[i, x]}";
				}
				Console.WriteLine($"{line} |");
			}
		}
	}
}