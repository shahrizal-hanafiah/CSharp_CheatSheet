using ConsoleApp.ForLoop;
using ConsoleApp.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            ForLoop();
            Footer.display();
        }

        static void ForLoop()
        {
            /*Start:Generate random password, minimum N length,contains @least 1 alphanumeric,1 symbol,1 capital letter and 1 letter case*/
            //Password.GenerateStrongPassword(8);
            /*Start:Generate random password, minimum N length,contains @least 1 alphanumeric,1 symbol,1 capital letter and 1 letter case*/


            /*Start: Shuffling cards*/
            //string[] cards = { "1Love", "2Spade", "3Diamond", "Ace", "King", "Queen", "Joker" };
            //Shuffle.Cards(cards);
            /*End: Shuffling cards*/


            /*Start:Display Pyramid Descending*/
            int layer = 5;
            Pyramid.RepeaterDesc(layer);
            /*End: Display Pyramid Descending*/

            /*Start:Display Pyramid Ascending*/
            //layer = 5;
            //Pyramid.RepeaterAsc(layer);
            /*End: Display Pyramid Ascending*/

            /*Start:Display Pictorial Pyramid Ascending*/
            //layer = 5;
            //Pyramid.RepeatPyramid(layer);
            /*End: Display Pictorial Pyramid Ascending*/
        }

    }
}
