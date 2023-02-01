using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class Pixel
    {
        public int x = 0;
        public int y = 0;
        public ConsoleColor FColor = ConsoleColor.White;
        public ConsoleColor BColor = ConsoleColor.Black;
        public char symbol = '▓';

        public void PXPrint()
        {
            Console.ForegroundColor = FColor;
            Console.BackgroundColor = BColor;
            Console.Write(symbol);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
}
