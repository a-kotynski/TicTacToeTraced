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
            Console.WriteLine(
                $"_____________\n" +
                $"|_X_|___|_O_|\n" +
                $"|_X_|___|_O_|\n" +
                $"|_X_|___|_O_|");
        }
    }
}