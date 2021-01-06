using ConsoleApp.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.ForLoop
{
    public class Pyramid
    {
        public static void RepeaterDesc(int layer)
        {
            for (int i = 1; i < layer; i++)
            {
                for (int Number = 1; Number <= layer - i; Number++)
                {
                    Console.Write(Number);
                }
                Console.WriteLine();
            }
        }

        public static void RepeaterAsc(int layer)
        {
            for (int i = 1; i < layer; i++)
            {
                for (int Space = 1; Space < layer - i; Space++)
                    Console.Write(" ");
                for (int Number = 1; Number <= i; Number++)
                    Console.Write(Number);
                Console.WriteLine();
            }
        }

        public static void RepeatPyramid(int layer)
        {
            int numberoflayer = layer, Space, Number;
            for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pramid  
            {
                for (Space = 1; Space <= (numberoflayer - i); Space++) // Loop For Space  
                    Console.Write(" ");
                for (Number = 1; Number <= i; Number++) //increase the value  
                    Console.Write(Number);
                for (Number = (i - 1); Number >= 1; Number--) //decrease the value  
                    Console.Write(Number);
                Console.WriteLine();
            }
        }
    }
}
