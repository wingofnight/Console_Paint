using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class UI
    {
        public static int _line = 52;
        public static int _column = 140;
        public Pixel[,] Window = new Pixel[_line, _column];
        public delegate void Funk(int i, int j);
       
        public UI()
        {
            
        }

        public UI(int _line, int _column)
        {
             Window = new Pixel[_line, _column];
        }


       public void HLine(int from, int where, int height, int symbol)
        {
            for (int i = from; i < where; i++)
            {
                 Window[height, i].symbol = Palette.Symbol[symbol];
            }
        }

       public void VLine(int from, int where, int width, int symbol)
        {
            for (int i = from; i < where; i++)
            {
                  Window[i, width].symbol = Palette.Symbol[symbol];
            }
        }

       public void PrintUI()
        {
            void InicializationWindow(int i, int j){ Window[i, j] = new Pixel(); Window[i, j].symbol = Palette.Symbol[176]; }
            WorkInWindow(InicializationWindow);
         
             HLine(1, 139, 0, 205);
             HLine(1, 139, 51, 205);
             VLine(1, 51, 0, 186);
             VLine(1, 51, 139, 186);

            Window[0, 0].symbol = Palette.Symbol[201];
            Window[51, 0].symbol = Palette.Symbol[200];
            Window[0, 139].symbol = Palette.Symbol[187];
            Window[51, 139].symbol = Palette.Symbol[188];

        }

        
        
       public void WorkInWindow(Funk D_funk)
        {

            for (int i = 0; i < 52; i++)
            {
                for (int j = 0; j < 140; j++)
                {
                   D_funk(i,j);
                }
            }

        }

        public void PrintPoint(int line, int row, int symbol)
        {
           Window[line,row].symbol = Palette.Symbol[symbol];
        }

        public void PrintPoint(int line, int row, char symbol)
        {
            Window[line, row].symbol = symbol;
        }

        public void WriteText(int line, int row, string text)
        {
            foreach (var item in text)
            {
                Window[line, row].symbol = item;
                row++;
            }

        }

        public void WriteVerticalText(int line, int row, string text)
        {            
            foreach (var item in text)
            {
                Window[line, row].symbol = item;
                line++;
            }
        }

        public void WindowApdate()
        {

        }

        public void PrintWindow()
        {
            for (int i = 0; i < 52; i++)
            {
                for (int j = 0; j < 140; j++)
                {
                    if (Window[i, j].FColor != ConsoleColor.White)
                    {
                        Console.ForegroundColor = Window[i, j].FColor;
                    }
                    if (Window[i, j].BColor != ConsoleColor.Black)
                    {
                        Console.BackgroundColor = Window[i, j].BColor;
                    }
                    Console.Write(Window[i, j].symbol);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine();

            }
        }

    }


    public class Workspace:UI
    {
        
        public void WindowUpdate()
        {
            PrintPoint(0, 6, 203);
            PrintPoint(51, 6, 202);
            PrintPoint(0, 130, 203);
            PrintPoint(51, 130, 202);
            VLine(1, 51, 6, 186);
            VLine(1, 51, 130, 186);
            WriteText(0, 60, "SpriteEditor v.0.3");
            Symbols();
            PalletesFront();
            HLine( 131, 139 ,21, 205);
            PrintPoint(21,130 , 204);
            PrintPoint( 21, 139, 185);

            PalletesBack();
            HLine(131, 139, 42, 205);
            PrintPoint(42, 130, 204);
            PrintPoint(42, 139, 185);
           PalletesFooter();
        }


        private void Symbols()
        {
            int line = 2;
            foreach (var item in Palette.Symbol.Values)
            {                  
                  Window[line, 3].symbol = item;
                  Window[line, 3].FColor = ConsoleColor.Cyan;
                line++;
            }
        }

        private void PalletesFront()
        {
            WriteText(2, 133, "Front");
            int line = 4;
            foreach (var item in Palette.Colors)
            {
                Window[line, 135].symbol = Palette.Symbol[219];
                Window[line, 135].FColor = item;
                line++;
            }
        }

        private void PalletesBack()
        {
            WriteText(23, 133, "Back");
            int line = 25;
            foreach (var item in Palette.Colors)
            {
                Window[line, 135].symbol = Palette.Symbol[0];
                Window[line, 135].BColor = item;
                line++;
            }
        }

        public void PalletesFooter()
        {
            
            Window[44, 137].FColor = ConsoleColor.White;
            Window[44, 137].symbol = Palette.Symbol[219];
            WriteText(44, 132, "F = ");
           
            Window[46, 137].BColor = ConsoleColor.Black;
            Window[46, 137].symbol = Palette.Symbol[0];
            WriteText(46, 132, "B = ");
           
            Window[48, 137].FColor = ConsoleColor.Cyan;
            Window[48, 137].BColor = ConsoleColor.Yellow;
            Window[48, 137].symbol = Palette.Symbol[176];
            WriteText(48, 132, "S = ");

        }

    }


}
