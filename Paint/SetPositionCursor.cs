using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Paint
{
    public class SetPositionCursor
    {
       
        public char buffer = '░';
        public int upPos = 2;
        public int downPos = 49;
        public int leftPos = 0;
        public int rightPos = 0;
        public ConsoleKey upKey = ConsoleKey.UpArrow;
        public ConsoleKey downKey = ConsoleKey.DownArrow;
        public ConsoleKey leftKey;
        public ConsoleKey rightKey;
        public SetPositionCursor() {
           
        }

        public SetPositionCursor(int Up, int Down)
        {
            upPos = Up;
            downPos = Down;
        }

        public SetPositionCursor(int Up, int Down,ConsoleKey upKey, ConsoleKey downKey)
        {
            upPos = Up;
            downPos = Down;

            
            this.upKey = upKey;
            this.downKey = downKey;
        }

        public void SetFrame(int up, int down, int left, int right)
        {
            upPos = up;
            downPos = down;
            leftPos = left;
            rightPos = right;
        }

        public void SetControl(ConsoleKey upKey, ConsoleKey downKey, ConsoleKey leftKey, ConsoleKey rightKey)
        {
            this.leftKey = leftKey;
            this.rightKey = rightKey;
            this.upKey = upKey;
            this.downKey = downKey;
        }

        public void PositionCursor(Cursor cursor, Workspace workspace, ConsoleKey chekKey)
        {
                        
            
            if (chekKey == downKey && cursor._y < downPos)
            {
                Console.SetCursorPosition(cursor._x, cursor._y);
                Console.Write(buffer);

                Console.SetCursorPosition(cursor._x, ++cursor._y);
                buffer = workspace.Window[cursor._y, cursor._x].symbol;
                Console.Write(cursor._symbol);

            }
            if (chekKey == upKey && cursor._y > upPos)
            {               
                Console.SetCursorPosition(cursor._x, cursor._y);
                Console.Write(buffer);
                Console.SetCursorPosition(cursor._x, --cursor._y);
                buffer = workspace.Window[cursor._y, cursor._x].symbol;
                Console.Write(cursor._symbol);
            }
            if (chekKey == rightKey && cursor._x < rightPos)
            {
                Console.SetCursorPosition(cursor._x, cursor._y);
                Console.Write(buffer);
                Console.SetCursorPosition(++cursor._x, cursor._y);
                buffer = workspace.Window[cursor._y, cursor._x].symbol;
                Console.Write(cursor._symbol);
            }
            if (chekKey == leftKey && cursor._x > leftPos)
            {
                Console.SetCursorPosition(cursor._x, cursor._y);
                Console.Write(buffer);
                Console.SetCursorPosition(--cursor._x, cursor._y);
                buffer = workspace.Window[cursor._y, cursor._x].symbol;
                Console.Write(cursor._symbol);
            }
        }

        public void PositionBrush(Cursor cursor, Image image, ConsoleKey chekKey)
        {
            if (chekKey == downKey && cursor._y < downPos)
            {
                Console.SetCursorPosition(cursor._x, cursor._y);
                Console.Write(buffer);

                Console.SetCursorPosition(cursor._x, ++cursor._y);
                buffer = image.image[cursor._y - 1, cursor._x - 7].symbol;
                Console.Write(cursor._symbol);

            }
            if (chekKey == upKey && cursor._y > upPos)
            {
                Console.SetCursorPosition(cursor._x, cursor._y);
                Console.Write(buffer);
                Console.SetCursorPosition(cursor._x, --cursor._y);
                buffer = image.image[cursor._y - 1, cursor._x - 7].symbol;
                Console.Write(cursor._symbol);
            }
            if (chekKey == rightKey && cursor._x < rightPos)
            {
                Console.SetCursorPosition(cursor._x, cursor._y);
                Console.Write(buffer);
                Console.SetCursorPosition(++cursor._x, cursor._y);
                buffer = image.image[cursor._y - 1, cursor._x - 7].symbol;
                Console.Write(cursor._symbol);
            }
            if (chekKey == leftKey && cursor._x > leftPos)
            {
                Console.SetCursorPosition(cursor._x, cursor._y);
                Console.Write(buffer);
                Console.SetCursorPosition(--cursor._x, cursor._y);
                buffer = image.image[cursor._y-1, cursor._x-7].symbol;
                Console.Write(cursor._symbol);
            }

        }

        
    }


    public class SetPositionBrush : SetPositionCursor
    {
        public Pixel PXBuffer = new Pixel();

        public void PositionCursor(Cursor cursor, Image image, ConsoleKey chekKey)
        {

            if (chekKey == downKey && cursor._y < downPos)
            {
                Console.SetCursorPosition(cursor._x, cursor._y);
                PXBuffer.PXPrint();

                Console.SetCursorPosition(cursor._x, ++cursor._y);
             

                PXBuffer = image.image[cursor._y - 1, cursor._x - 7];
                Console.Write(cursor._symbol);
            }
            if (chekKey == upKey && cursor._y > upPos)
            {

                Console.SetCursorPosition(cursor._x, cursor._y);
                PXBuffer.PXPrint();

                Console.SetCursorPosition(cursor._x, --cursor._y);


                PXBuffer = image.image[cursor._y - 1, cursor._x - 7];
                Console.Write(cursor._symbol);

            }
            if (chekKey == rightKey && cursor._x < rightPos)
            {
                Console.SetCursorPosition(cursor._x, cursor._y);
                PXBuffer.PXPrint();

                Console.SetCursorPosition(++cursor._x, cursor._y);


                PXBuffer = image.image[cursor._y - 1, cursor._x - 7];
                Console.Write(cursor._symbol);
            }
            if (chekKey == leftKey && cursor._x > leftPos)
            {
                Console.SetCursorPosition(cursor._x, cursor._y);
                PXBuffer.PXPrint();

                Console.SetCursorPosition(--cursor._x, cursor._y);
             

                PXBuffer = image.image[cursor._y - 1, cursor._x - 7];
                Console.Write(cursor._symbol);
            }
        }

    }

}
