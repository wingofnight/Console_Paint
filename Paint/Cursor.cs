using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Paint
{
    public  class Cursor
    {
        public char _symbol = '►';
        public int _x = 0;
        public int _y = 0;

        public Cursor() { }

        public Cursor(int x, int y, char symbol)
        {
           _symbol = symbol;
           _x = x;
           _y = y;
        }

        public Cursor(int x, int y)
        {
            _x = x;
            _y = y;
        }


    }
}
