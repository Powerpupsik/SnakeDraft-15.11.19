using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace Point
{
    class HorizontalLine
    {
        public List<MyPoint> pointList = new List<MyPoint>();

        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            for(int i= xLeft; i <= xRight; i++)
            {
                MyPoint newPoint = new MyPoint(i, y, symbol);
                pointList.Add(newPoint);

            }
        }

        

        public void DrawHorizontalLine()
        {
            foreach(MyPoint point in pointList)
            {
                point.Draw();
            }
        }
    }

   
    
}
