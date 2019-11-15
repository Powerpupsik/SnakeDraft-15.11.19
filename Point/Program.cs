using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25); //märkide arv, mis sinna mahub

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '*');
            upLine.DrawHorizontalLine();
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '*');
            downLine.DrawHorizontalLine();
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '*');
            leftLine.DrawVerticalLine();
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '*');
            rightLine.DrawVerticalLine();




            /*HorizontalLine hrLine = new HorizontalLine(5, 10, 10, '*');
            hrLine.DrawHorizontalLine();

            VerticalLine vrLine = new VerticalLine(11, 20, 5, '*');
            vrLine.DrawVerticalLine();*/


            /*Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            for (int i = 5; i < 10; i++)
            {
                MyPoint newPoint = new MyPoint(i, 5, '*');
                newPoint.Draw();
                MyPoint newPoint2 = new MyPoint(5, i, '#');
                newPoint2.Draw();
            }*/


            /*Point p1 = new Point(10, 10, '*');
            p1.Draw();

            Point p2 = new Point(11, 10, '*');
            p2.Draw();

            Point p3 = new Point(12, 10, '*');
            p3.Draw();

            Point p4 = new Point(13, 10, '*');
            p4.Draw();

            Point p5 = new Point(14, 10, '*');
            p5.Draw();

            Point p6 = new Point(15, 10, '*');
            p6.Draw();*/



            Console.ReadLine();


        }

        

        
    }
}
