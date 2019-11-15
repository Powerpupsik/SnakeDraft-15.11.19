using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class MyPoint
    {
                     
        public int x;
        public int y;
        public char symbol;




        public MyPoint(int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;

        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }



    }
}
