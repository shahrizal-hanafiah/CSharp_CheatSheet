using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.ForLoop
{
    public class Password
    {
        public static void GenerateStrongPassword(int length)
        {
            var password = "";
            Encoding ascii = Encoding.ASCII;
            var random = new Random();
            bool symbol = false;
            bool number = false;
            bool smallAlphabet = false;
            bool capital = false;
            length = length < 8 ? 8 : length;
            for (int i = length; i >= 0; i--)
            {
                int unicode = random.Next(33, 122);
                if (unicode >= 48 && unicode <= 57)
                    symbol = true;
                if (unicode >= 33 && unicode <= 47)
                    number = true;
                if (unicode >= 97 && unicode <= 122)
                    smallAlphabet = true;
                if (unicode >= 65 && unicode <= 90)
                    capital = true;
                if (i < length - 4)
                {
                    if (symbol == false)
                    {
                        unicode = random.Next(48, 57);
                        symbol = true;
                    }
                    if (number == false)
                    {
                        unicode = random.Next(33, 47);
                        number = true;
                    }
                    if (smallAlphabet == false)
                    {
                        unicode = random.Next(97, 122);
                        smallAlphabet = true;
                    }
                    if (capital == false)
                    {
                        unicode = random.Next(65, 90);
                        capital = true;
                    }
                }
                password += (char)unicode;
            }
            Console.WriteLine(password);
        }
    }
}
