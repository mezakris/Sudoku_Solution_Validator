using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku_Solution_Validator;

namespace Sudoku_Validation_Test
{
    [TestClass]
    public class ValidityTest
    {
        int[,] goodBoard ={
            { 7, 9, 2, 1, 5, 4, 3, 8, 6 },
            { 6, 4, 3, 8, 2, 7, 1, 5, 9 },
            { 8, 5, 1, 3, 9, 6, 7, 2, 4 },
            { 2, 6, 5, 9, 7, 3, 8, 4, 1 },
            { 4, 8, 9, 5, 6, 1, 2, 7, 3 },
            { 3, 1, 7, 4, 8, 2, 9, 6, 5 },
            { 1, 3, 6, 7, 4, 8, 5, 9, 2 },
            { 9, 7, 4, 2, 1, 5, 6, 3, 8 },
            { 5, 2, 8, 6, 3, 9, 4, 1, 7,}
        };

        int[,] incompleteBoard ={
            { 7, 9, 2, 1, 5, 4, 3, 8, 6 },
            { 6, 4, 0, 8, 0, 7, 1, 5, 9 },
            { 8, 5, 1, 3, 0, 6, 7, 2, 4 },
            { 2, 6, 0, 9, 7, 3, 8, 4, 1 },
            { 4, 8, 9, 5, 6, 0, 2, 7, 0 },
            { 3, 0, 7, 4, 8, 0, 0, 6, 5 },
            { 1, 0, 6, 7, 4, 8, 5, 9, 2 },
            { 9, 0, 4, 0, 1, 5, 6, 3, 8 },
            { 5, 2, 8, 0, 3, 9, 4, 1, 7,}
        };

        int[,] badBoard ={
            { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            { 6, 4, 3, 8, 2, 7, 1, 5, 9 },
            { 8, 5, 1, 3, 9, 6, 7, 2, 4 },
            { 2, 6, 5, 9, 7, 3, 8, 4, 1 },
            { 4, 8, 9, 5, 6, 1, 2, 7, 3 },
            { 3, 1, 7, 4, 8, 2, 9, 6, 5 },
            { 1, 3, 6, 7, 4, 8, 5, 9, 2 },
            { 9, 7, 4, 2, 1, 5, 6, 3, 8 },
            { 5, 2, 8, 6, 3, 9, 4, 1, 7,}
        };

        [TestMethod]
        public void Test_Method_For_Good_Board()
        {
            bool actualValue = Sudoku.IsValidSudoku(goodBoard) && Board.ValidityCheck(goodBoard, 9);
            Assert.AreEqual(true,actualValue);
        }

        [TestMethod]
        public void Test_Method_For_Bad_Board()
        {
            bool actualValue = Sudoku.IsValidSudoku(badBoard) && Board.ValidityCheck(badBoard, 9);
            Assert.AreEqual(false,actualValue);
        }

        [TestMethod]
        public void Test_Method_For_Incomplete_Board()
        {
            bool actualValue = Sudoku.IsValidSudoku(incompleteBoard) && Board.ValidityCheck(incompleteBoard, 9);
            Assert.AreEqual(true, actualValue);
        }

        [TestMethod]
        public void Test_Sudoku_Array_Length()
        {
            var actualLength = goodBoard.Length;
            Assert.AreEqual(81,actualLength);
        }
    }
}
