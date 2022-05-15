using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solution_Validator
{
    public class Board
    {
        private int[,] _board;

        public Board(int[,] board)
        {
            _board = board;
        }

        //checks for duplicate in current row
        public static bool NotInRow(int[,] board, int row)
        {
            //For storing the unique chars already detected
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < 9; i++)
            {
                //if number was seen, return false
                if (hs.Contains(board[row, i]))
                {
                    return false;
                }
                //if number is new, add to hashset
                if (board[row, i] != 0)
                {
                    hs.Add(board[row, i]);
                }
            }
            return true;
        }

        public static bool NotInCollumn(int[,] board, int col)
        {
            //hashset for the unique chars
            HashSet<int> hs = new HashSet<int>();


            for (int i = 0; i < 9; i++)
            {
                //if number has been seen in col, return false
                if (hs.Contains(board[i, col]))
                {
                    return false;
                }
                //if new number, add to hashset
                if (board[i, col] != 0)
                {
                    hs.Add(board[i, col]);
                }
            }

            return true;
        }

        public static bool NotInSquare(int[,] board, int startRow, int startCol)
        {
            HashSet<int> hs = new HashSet<int>();

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    int i = board[row + startRow, col + startCol];

                    if (hs.Contains(i))
                    {
                        return false;
                    }

                    if (i != 0)
                    {
                        hs.Add(i);
                    }
                }
            }

            return true;
        }

        public static bool IsValid(int[,] board, int row, int col)
        {
            return NotInRow(board, row) && NotInCollumn(board, col) && NotInSquare(board, row - row % 3, col - col % 3);
        }

        public static bool ValidityCheck(int[,] board, int i)
        {
            for (int j = 0; j < i; j++)
            {
                for (int n = 0; n < i; n++)
                {
                    if (!IsValid(board, j, n))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
