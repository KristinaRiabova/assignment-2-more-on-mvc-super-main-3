using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiGame.Models
{
    public class Bot : IBot
    {
        private Board board;
        private char player;
        public Bot(Board board, char player) 
        { 
            this.board = board;
            this.player = player;
        }
        public string ChooseMove()
        {
            Thread.Sleep(3000);
            List<string> moves = new List<string>();
            for (int i = 0; i < Board.Size; i++)
            {
                for (int j = 0;j < Board.Size; j++)
                {
                    if (board.IsValidMove(i, j, player))
                    {
                        string m = "";
                        m += (char)(j + 'A');
                        m += (char)(i + '1');
                        moves.Add(m);
                    }
                }
            }
            if (moves.Count == 0) { return "skip"; }
            Random rand = new Random();
            int num = rand.Next(0, moves.Count());
            return "move " + moves[num].ToString();
        }
    }
}
