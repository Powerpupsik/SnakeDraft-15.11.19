using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class VerticalLine : Figure
    {
        
        
            

            public VerticalLine(int yUp, int yDown, int x, char symbol) // JÄRJEKORD ON OLULINE!!! X enne!
            {

                for (int i = yUp; i <= yDown; i++)
                {
                    MyPoint newPoint = new MyPoint(x, i, symbol);
                    pointList.Add(newPoint);

                }
            }

           /* public void DrawVerticalLine()
            {
                foreach (MyPoint point in pointList)
                {
                    point.Draw();
                }
            }*/
        
    }
}
