using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
 {
     static class Palette
    {
       public static Dictionary<int, char> Symbol = new Dictionary<int, char>()
        {
            [176] = '░', [177] = '▒', [178] = '▓', [179] = '│', [180] = '┤', [181] = '╡',
            [182] = '╢', [183] = '╖', [184] = '╕', [185] = '╣', [186] = '║', [187] = '╗',
            [188] = '╝', [189] = '╜', [190] = '╛', [191] = '┐', [192] = '└', [193] = '┴',
            [194] = '┬', [195] = '├', [196] = '─', [197] = '┼', [198] = '╞', [199] = '╟',
            [200] = '╚', [201] = '╔', [202] = '╩', [203] = '╦', [204] = '╠', [205] = '═',
            [206] = '╬', [207] = '╧', [208] = '╨', [209] = '╤', [210] = '╥', [211] = '╙',
            [212] = '╘', [213] = '╒', [214] = '╫', [215] = '╫', [216] = '╪', [217] = '┘',
            [218] = '┌', [219] = '█', [220] = '▄', [221] = '▌', [222] = '▀', [0] =' '
        };


        public static List<ConsoleColor> Colors = new List<ConsoleColor>()
        {
              ConsoleColor.Cyan, ConsoleColor.Blue,  ConsoleColor.DarkCyan, ConsoleColor.DarkBlue ,
              ConsoleColor.Green, ConsoleColor.DarkGreen,ConsoleColor.Yellow, ConsoleColor.DarkYellow,
              ConsoleColor.Red, ConsoleColor.DarkRed,ConsoleColor.DarkMagenta, ConsoleColor.Magenta,
              ConsoleColor.White, ConsoleColor.Gray, ConsoleColor.DarkGray, ConsoleColor.Black
        };

        public static void test()
        {
            Console.ForegroundColor = Colors[1];
            Console.BackgroundColor = Colors[7];
            Console.WriteLine(Symbol[177]);
        }

        
    }
}
