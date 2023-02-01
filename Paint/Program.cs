using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Paint
{
    internal class Program
    {
        public static Cursor cursorPaint = new Cursor(70,25, '┼');

        public static Cursor cursorSymbol = new Cursor(2, 2);
        public static Cursor cursorFColor = new Cursor(134, 16);
        public static Cursor cursorBColor = new Cursor(134, 40);

        public static Cursor FooterSymbol = new Cursor(137, 48);
        public static Cursor FooterForeground = new Cursor(137, 44, '█');
        public static Cursor FooterBackground = new Cursor(137, 46, ' ');
        

     
        static void PrintCursor(Cursor cursor)
        {
            Console.SetCursorPosition(cursor._x, cursor._y);
            Console.Write(cursor._symbol);
        }



        static void ChangeFooter()
        {
            int x = cursorSymbol._y + 174 < 223 ? cursorSymbol._y + 174 : 0;
            int y = cursorFColor._y - 4;
            int z = cursorBColor._y - 25;

            Console.ForegroundColor = Palette.Colors[y];
            Brush.pixel.FColor = Palette.Colors[y];
            PrintCursor(FooterForeground); 

            Console.BackgroundColor = Palette.Colors[z];
            Brush.pixel.BColor = Palette.Colors[z];
            PrintCursor(FooterBackground);

            FooterSymbol._symbol = Palette.Symbol[x];
            Brush.pixel.symbol =   Palette.Symbol[x];
            PrintCursor(FooterSymbol);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

        }

        static void Main()
        {
         

            Console.SetWindowSize(151, 56);
            Workspace workspace = new Workspace();
           
            SetPositionCursor setSymbol = new SetPositionCursor(2,49, ConsoleKey.D5, ConsoleKey.D6);
            SetPositionCursor setFColor = new SetPositionCursor(4,19, ConsoleKey.D1, ConsoleKey.D2);
            SetPositionCursor setBColor = new SetPositionCursor(25, 40, ConsoleKey.D3, ConsoleKey.D4);

           

            Image image = new Image();

            

            SetPositionBrush setBrush = new SetPositionBrush();

            setBrush.SetFrame(1, 50, 7, 129);
            setBrush.SetControl(ConsoleKey.UpArrow, ConsoleKey.DownArrow, ConsoleKey.LeftArrow, ConsoleKey.RightArrow);

            workspace.PrintUI();
            workspace.WindowUpdate();
            workspace.PrintWindow();
            image.UpdateImage();
            

            Console.CursorVisible = false;
           
            PrintCursor(cursorSymbol);
            PrintCursor(cursorFColor);
            PrintCursor(cursorBColor); 
            PrintCursor(cursorPaint);
            
            while (true) {
                ConsoleKeyInfo getch = Console.ReadKey(true);
                ConsoleKey key = getch.Key;
              
                setSymbol.PositionCursor(cursorSymbol, workspace, key);
                setFColor.PositionCursor(cursorFColor, workspace, key);
                setBColor.PositionCursor(cursorBColor, workspace, key);
               
                 setBrush.PositionCursor(cursorPaint, image, key);
                ChangeFooter();

                if(key == ConsoleKey.Spacebar)
                {
                    
                    Pixel pixel2 = new Pixel();
                    
                    pixel2.BColor = Brush.pixel.BColor;
                    pixel2.FColor = Brush.pixel.FColor;
                    pixel2.symbol = Brush.pixel.symbol;
                    
                    setBrush.PXBuffer = Brush.pixel;
                   
                    image.BrushPixel(cursorPaint, pixel2);
                    image.UpdateImage();
                }


            }
           
            Console.ReadLine();

            
        }

      

    }
}
