using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Figure
    {


        protected List<MyPoint> pointList = new List<MyPoint>();

        public void DrawFigure()
        {
            foreach(MyPoint point in pointList)
            {
                point.Draw();
            }
        }

        public bool IsHitByPoint(MyPoint point)
        {
            foreach(MyPoint p in pointList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsHitByfigure(Figure figure)
        {
            foreach(MyPoint point in pointList)
            {
                if (figure.IsHitByPoint(point))
                {
                    return true;
                }
                
            }
            return false;

        }



    }

    
}
