using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeDraft
{
    


    class Program
    {
    class Point
    {
        public int x;
        public int y;
        public char symbol;


          

        public Point(int _x, int _y, char _symbol) 
        {
            int x = _x;
            int y = _y;
            char symbol= _symbol;

        }

        public void Draw()
        {
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
        }
        
    }
        static void Main(string[] args)
        {
            /* Console.SetWindowSize(25, 25);
             Console.SetBufferSize(25, 25);*/

            //Taustavärv; peab tegema enne teisi asju ära
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Point p1 = new Point(10, 10, '*');
            p1.Draw();

            Point p2 = new Point(14, 22, '#');
            p2.Draw();

            /*int x1 = 0;
            int y1 = 0;
            char symbol1 = '*';*/
            /*Draw(p1.x, p1.y, p1.symbol);*/
            /*Console.SetCursorPosition(x1, y1);*/
            
            /*Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(symbol);*/


            /*int x2 = 14;
            int y2 = 22;
            char symbol2 = '#';
            Draw(x2, y2, symbol2);
            /*Console.SetCursorPosition(x2, y2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(symbol1);*/

            Console.ReadLine();
        }

        public static void Draw(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }


    }
}