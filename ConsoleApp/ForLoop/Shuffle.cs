using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.ForLoop
{
    public class Shuffle
    {
        public static void Cards(string[] cards)
        {
            var random = new Random();
            for (int i = cards.Length - 1; i >= 0; i--)
            {
                var randomCard = random.Next(0, i + 1);

                var current = cards[i];
                cards[i] = cards[randomCard];
                cards[randomCard] = current;
                Console.Write(i == 0 ? cards[i] : cards[i] + ",");
            }
            Console.WriteLine();
        }
    }
}
