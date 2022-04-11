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
        private int[] _boardPositions = new int[9];
        private int _rounds;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10, 6);
            _boardRenderer.Render();
        }

        // I really don't like this int design decision we made.  int doesn't look good.  Next class we can change to an enum
        private void PlayerMove(playerEnum player)
        {
            // This method needs error handling as it accepts incorrect input from user
            // We can revist this also in the Exception Handling class and gracefully recover from errors.


            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE
            // ask user for row and column


            Console.SetCursorPosition(2, 19);

                
                if (player == PlayerEnum.O)

                    Console.Write("Player X");
                else
                    Console.Write("Player O");

                Console.SetCursorPosition(2, 20);
                Console.WriteLine("Please Enter Row");

                var row = Console.ReadLine();

                Console.SetCursorPosition(2, 22);
                Console.Write("Please Enter Column: ");

                var column = Console.ReadLine();

                public void Run();
                var column = Console.ReadLine();

                int rowNumber = int.Parse(row);

                int columnNumber = int.Parse(column);

                int arrayPos = (rowNumber * 3) + columnNumber;

                _boardPositions[arrayPos] = (int) player;

                //  add move to the board

                if (player == 1)
                    _boardRenderer.AddMove(rowNumber, columnNumber, PlayerEnum.X, true);
                else
                    _boardRenderer.AddMove(rowNumber, columnNumber, PlayerEnum.O, true);

            
        }   // I really don't like this int design decision we made.  int doesn't look good.  Next class we can change to an enum
        public bool CheckIfPlayerWins(PlayerEnum player)
        {
            if ((_boardPositions[0] == player) && (_boardPositions[1] == player) && (_boardPositions[2] == player))
                return true;

            if ((_boardPositions[0] == player) && (_boardPositions[4] == player) && (_boardPositions[8] == player))
                return true;

            if ((_boardPositions[3] == player) && (_boardPositions[4] == player) && (_boardPositions[5] == player))
                return true;

            if ((_boardPositions[6] == player) && (_boardPositions[7] == player) && (_boardPositions[8] == player))
                return true;

            if ((_boardPositions[0] == player) && (_boardPositions[3] == player) && (_boardPositions[6] == player))
                return true;

            if ((_boardPositions[2] == player) && (_boardPositions[5] == player) && (_boardPositions[8] == player))
                return true;

            if ((_boardPositions[0] == player) && (_boardPositions[4] == player) && (_boardPositions[8] == player))
                return true;

            if ((_boardPositions[2] == player) && (_boardPositions[4] == player) && (_boardPositions[6] == player))
                return true;

            return false;
        }

        public void Run()
        {
            _rounds = 0;
            bool playerXWins = false;
            bool playerOWins = false;

            while (_rounds < 4)
            {
                // play X

                PlayerMove(playerEnum.X);
                playerXWins = CheckIfPlayerWins(PlayerEnum.X);

                if (playerXWins)
                {
                    Console.WriteLine("Player X Wins!!!");

                    break;
                }

                // play O

                PlayerMove(playerEnum.O);
                playerOWins = CheckIfPlayerWins(PlayerEnum.O); ;

                if (playerOWins)
                {
                    Console.WriteLine("Player O Wins!!!");

                    break;
                }
               
                _rounds++;
            }
        
            if (!playerXWins && !playerOWins)
                Console.WriteLine("The game is draw!");
        }
    }
}
    
