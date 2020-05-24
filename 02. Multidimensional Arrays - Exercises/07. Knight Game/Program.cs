using System;

namespace _07._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            var chessBoard = new char[matrixSize, matrixSize];

            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[row, col] = input[col];
                }
            }

            int killerRow = 0;
            int killerCol = 0;
            int knightsCount = 0;

            while (true)
            {
                int maxAttacks = int.MinValue;

                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        int currenKnightAttacks = 0;

                        if (chessBoard[row, col] == 'K')
                        {
                            // -2, 1
                            if (IsInside(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                            {
                                currenKnightAttacks++;
                            }
                            //-2, -1
                            if (IsInside(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                            {
                                currenKnightAttacks++;
                            }
                            //-1, 2
                            if (IsInside(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                            {
                                currenKnightAttacks++;
                            }
                            //-1, -2
                            if (IsInside(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                            {
                                currenKnightAttacks++;
                            }
                            //1, 2
                            if (IsInside(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                            {
                                currenKnightAttacks++;
                            }
                            //1, -2
                            if (IsInside(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                            {
                                currenKnightAttacks++;
                            }
                            //2, 1
                            if (IsInside(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                            {
                                currenKnightAttacks++;
                            }
                            //2, -1
                            if (IsInside(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                            {
                                currenKnightAttacks++;
                            }
                        }

                        if (currenKnightAttacks > maxAttacks)
                        {
                            maxAttacks = currenKnightAttacks;
                            killerRow = row;
                            killerCol = col;
                        }
                    }
                }
                if (maxAttacks > 0)
                {
                    chessBoard[killerRow, killerCol] = '0';
                    knightsCount++;
                }
                else
                {
                    Console.WriteLine(knightsCount);
                    break;
                }
            }

        }

        private static bool IsInside(char[,] chessBoard, int row, int col)
        {
            return row >= 0 && row < chessBoard.GetLength(0) &&
                   col >= 0 && col < chessBoard.GetLength(1);
        }
    }
}
