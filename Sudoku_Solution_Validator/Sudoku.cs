using System;

namespace Sudoku_Solution_Validator
{
    public class Sudoku
    {
        private static int S = 9;

        public static bool IsValidSudoku(int[,] board)
        {
            //this stores the unique values from 1 - 9 (the previously defined S)

            bool[] unique = new bool[S + 1];

            //checks each row of the array
            for (int row = 0; row < S; row++)
            {
                //initialize the unique array to false
                Array.Fill(unique, false);

                //checks the collumns of the current row
                for (int col = 0; col < S; col++)
                {
                    //stores the board values in B
                    int B = board[row, col];

                    //checks for duplicate value in current row
                    if (unique[B])
                    {
                        return false;
                    }
                    unique[B] = true;
                }
            }

            //checks every collumn of the array
            for (int col = 0; col < S; col++)
            {
                //initialize the unique array to false
                Array.Fill(unique, false);

                //checks each row of current collumn
                for (int row = 0; row < S; row++)
                {
                    //stores the board values
                    int b = board[col, row];
                     
                    //checks for duplicates in current col
                    if (unique[b])
                    {
                        return false;
                    }
                    unique[b] = true;
                }
            }
            //checks each 3*3 block of the array, works in steps of 3

            //firstRow stores the first row of each block
            for (int firstRow = 0; firstRow < S - 2; firstRow += 3)
            {
                //firstCol stores the first column of each block
                for (int firstCol = 0; firstCol < S - 2; firstCol += 3)
                {
                    //initialize to false
                    Array.Fill(unique, false);

                    //traversing the current block
                    for (int rowNr = 0; rowNr < 3; rowNr++)
                    {
                        for (int colNr = 0; colNr < 3; colNr++)
                        {
                            int X = firstRow + rowNr;
                            int Y = firstCol + colNr;
                            int B = board[X, Y];

                            //checks for duplicates in current block
                            if (unique[B])
                            {
                                return false;
                            }

                            unique[B] = true;
                        }
                    }
                }
            }
            //if all requirements are met
            return true;
        }
    }
}
