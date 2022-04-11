using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;
        private int[] _boardPositions = new int[] {2, 3, 4, 5, 6, 7, 8, 9, 10};
        private int _rounds;
        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();
        }

        private void PlayMove(PlayerEnum player)
        {
            Console.SetCursorPosition(2, 19);

            if (player == PlayerEnum.X)
                Console.Write("Player X");
            else
                Console.Write("Player O");

            Console.SetCursorPosition(2, 20);
            Console.Write("  ");
            Console.SetCursorPosition(2, 20);
            Console.WriteLine("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 21);

            Console.Write(" ");
            Console.SetCursorPosition(2, 21);
            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();

            int rowNumber = int.Parse(row);
            int columnNumber = int.Parse(column);
            int arrayPos = (rowNumber * 3) + columnNumber;
                // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
                _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);

                // store move in array
                int rowNumber = int.Parse(
                    row);
                int columnNumber = int.Parse(column);
                int arrayPos = (rowNumber * 3) + columnNumber;
                // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardPositions[arrayPos] = (int)player;
           _boardRenderer.AddMove(rowNumber, columnNumber, player, true);
        }
                int rowNumber = int.Parse(
                    row);
                int columnNumber = int.Parse(column);
                int arrayPos = (rowNumber * 3) + columnNumber;
                // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardPositions[arrayPos] = (int)player;
           _boardRenderer.AddMove(rowNumber, columnNumber, player, true);
        }

        public bool CheckIfPlayerWins(PlayerEnum player)
        {
            int playerValue = (int)player;

            if ((_boardPositions[0] == playerValue) && (_boardPositions[1] == playerValue) && (_boardPositions[2] == playerValue))
            {
                else
                    _boardRenderer.AddMove(rowNumber, columnNumber, PlayerEnum.O, true);

            
        }   // I really don't like this int design decision we made.  int doesn't look good.  Next class we can change to an enum
        public bool CheckIfPlayerWins(int player)
        {
            if ((_boardPositions[0] == player) && (_boardPositions[1] == player) && (_boardPositions[2] == player))
                return true;
            }

            if ((_boardPositions[0] == playerValue) && (_boardPositions[4] == playerValue) && (_boardPositions[8] == playerValue))
            {
                return true;
            }

            if ((_boardPositions[3] == playerValue) && (_boardPositions[4] == playerValue) && (_boardPositions[5] == playerValue))
            {
                return true;
            }

            if ((_boardPositions[6] == playerValue) && (_boardPositions[7] == playerValue) && (_boardPositions[8] == playerValue))
            {
                return true;
            }

            if ((_boardPositions[0] == playerValue) && (_boardPositions[3] == playerValue) && (_boardPositions[6] == playerValue))
            {
                return true;
            }

            if ((_boardPositions[2] == playerValue) && (_boardPositions[5] == playerValue) && (_boardPositions[8] == playerValue))
            {
                return true;
            }

            if ((_boardPositions[0] == playerValue) && (_boardPositions[4] == playerValue) && (_boardPositions[8] == playerValue))
            {
                return true;
            }

            if ((_boardPositions[2] == playerValue) && (_boardPositions[4] == playerValue) && (_boardPositions[6] == playerValue))
                // play O

                PlayerMove(playerEnum.O);
                playerOWins = CheckIfPlayerWins(PlayerEnum.O); ;
        {
            int _rounds = 0;
            bool playerXWins = false;
            bool playerOWins = false;

            while (_rounds < 4)
            {

                    break;
                }


                // play o

                //Change to Enum
                PlayerMove(playerEnum(2));
                //Change to Enum
                playerOWins = CheckIfPlayerWins(2);

                if (playerOWins)
                {
                    Console.WriteLine("Player O Wins!!!");

                    break;
                }
                // checkif x won

                // if x won, exit

                // check if o won 

                // if o won exit

                _rounds++;
            }
            if (!playerXWins && !playerOWins)
                Console.WriteLine("The game is tied!");
        }
    }
}               