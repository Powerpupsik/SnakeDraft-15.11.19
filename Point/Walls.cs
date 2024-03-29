﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{

    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '#');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight-1,'#');
            VerticalLine leftLine = new VerticalLine(0, mapHeight-1, 0,'#');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth-2, '#');
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        public void DrawWalls()
        {
            foreach(Figure wall in wallList)
            {
                wall.DrawFigure();
            }
        }

        public bool IsHitByFigure(Figure figure)
        {
            foreach(Figure wall in wallList)
            {
                if (wall.IsHitByfigure(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void SnakeBlock()
        {

            
            Random rnd = new Random();
            //Error ja valesti snakeBlock = rnd.Next();


        }
    }
}
