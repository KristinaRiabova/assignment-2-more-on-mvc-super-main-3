using System;
using System.Collections.Generic;

namespace ReversiGame.Models
{
    public class Board
    {
        public const int Size = 8;
        private readonly char[,] grid;

        public Board()
        {
            grid = new char[Size, Size];
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    grid[i, j] = '.';
                }
            }
            grid[3, 3] = 'O';
            grid[3, 4] = 'X';
            grid[4, 3] = 'X';
            grid[4, 4] = 'O';
        }

        public bool IsValidMove(int row, int col, char player)
        {
            // Logic to validate moves (placeholder)
            return row >= 0 && row < Size && col >= 0 && col < Size && grid[row, col] == '.';
        }

        public void MakeMove(int row, int col, char player)
        {
            grid[row, col] = player;
            // Logic to flip opponent pieces
        }

        public char[,] GetGrid() => grid;
    }
}