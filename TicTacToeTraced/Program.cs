using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.youtube.com/watch?v=STuWW6pksXs
//This a developer's internal monologue. Pay attention to:
//- questions asked
//- assumptions made
//- constant program testing

/* TicTacToe analysis
 
 * 2 players: X and O
 * someone wins and someone loses
 * board where you click somewhere - first player gets to play, then another one
 * the board consists of a 3x3 grid with a space to separate the slots for Xs and Os
  
My take:
 * board as an array (list)
 * assign each slot to the array coordinate
 * create shit ton of if statements to declare the outcome of each game
 * ???
 * profit
 
 * What w need:
 * a board
            Console.WriteLine("| X |  | O |");
 
 
 */
namespace TicTacToeTraced
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3, 3];
            //board[0, 0] = 'X';
            //board[1, 0] = '_';
            //board[2, 0] = 'X';
            //board[0, 1] = '_';
            //board[1, 1] = '_';
            //board[2, 1] = '_';
            //board[0, 2] = '_';
            //board[1, 2] = 'X';
            //board[2, 2] = 'O';

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (board[row, column] == null)
                    {
                        Console.Write("_");
                    }
                    Console.Write($"| {board[row, column]} |");
                    //Console.Write($"| {board[row,column]} |");
                }
                Console.WriteLine();
            }
            //That one is good, but for loops above are more efficient
            //Console.WriteLine(
            //    $" _________\n" +
            //    $"|_{board[0, 0]}_|_{board[0, 1]}_|_{board[0, 2]}_|\n" +
            //    $"|_{board[1, 0]}_|_{board[1, 1]}_|_{board[1, 2]}_|\n" +
            //    $"|_{board[2, 0]}_|_{board[2, 1]}_|_{board[2, 2]}_|");
        }
    }
}