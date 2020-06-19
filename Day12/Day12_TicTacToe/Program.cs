using System;

namespace Day12_TicTacToe
{
    enum FieldEnum
    {
        Empty,
        X,
        O        
    }

    class Program
    {
        static void Main(string[] args)
        {
            FieldEnum[,] board = new FieldEnum[3, 3];
            var currentPlayer = FieldEnum.X;
            var gameFinished = false;

            Console.WriteLine("Hello! Welcome to the legendary game of Tic-Tac-Toe!");
            Console.WriteLine("This game is for 2 players.");

            string firstPlayer = GetPlayerName("Please enter player nr.1 name (X): ");
            string secondPlayer = GetPlayerName("Please enter player nr.2 name (O): ");

            Console.WriteLine("Game begins!");

            PrintBoard(board);

            do
            {
                Console.WriteLine();
                Console.WriteLine($"Turn for player {currentPlayer}");
                Console.Write("Please enter a row number: ");
                string rowInput = Console.ReadLine();
                Console.Write("Please enter a column number: ");
                string colInput = Console.ReadLine();

                //Special programmers exit with keyword STOP
                if (rowInput == "STOP" || colInput == "STOP")
                {
                    Console.WriteLine("Game was ended by the master!");
                    break;
                }

                //Checking whether the row and column input is not empty
                if (string.IsNullOrEmpty(rowInput) || string.IsNullOrEmpty(colInput))
                {
                    WriteError("Please don't enter empty values!");
                    continue;
                }

                //Checking whether the input of row and columns can be converted to a number
                int i, j;
                bool rowConversion = !int.TryParse(rowInput, out i);
                bool colConversion = !int.TryParse(colInput, out j);
                if (rowConversion || colConversion)
                {
                    WriteError("Please enter valid number values!");
                    continue;
                }

                //We have to check if the numbers are in the correct range
                if (i > 3 || j > 3 || i < 1 || j < 1)
                {
                    WriteError("Please enter the numbers in the range [1-3]");
                    continue;
                }

                if (board[i - 1, j - 1] != FieldEnum.Empty)
                {
                    WriteError("This field is already taken, choose another!");
                    continue;
                }

                board[i - 1, j - 1] = currentPlayer;
                PrintBoard(board);

                //change the current player
                currentPlayer = currentPlayer == FieldEnum.X ? FieldEnum.O : FieldEnum.X;

                gameFinished = IsGameFinished(board);
            } while (!gameFinished);            
        }        

        private static bool IsGameFinished(FieldEnum[,] board)
        {
            return false;
        }

        private static void WriteError(string message)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void PrintBoard(FieldEnum[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    switch (board[i, j])
                    {
                        case FieldEnum.Empty:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("_ ");
                            break;
                        case FieldEnum.X:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("X ");
                            break;
                        case FieldEnum.O:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("O ");
                            break;
                        default:
                            break;
                    }
                }

                Console.WriteLine();
            }

            Console.ResetColor();
        }

        private static string GetPlayerName(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}

//if (currentPlayer == FieldEnum.X)
//{
//    currentPlayer = FieldEnum.O;
//}
//else
//{
//    currentPlayer = FieldEnum.X;
//}
//the lines above does the same as the line below
//currentPlayer = currentPlayer == FieldEnum.X? FieldEnum.O : FieldEnum.X;
