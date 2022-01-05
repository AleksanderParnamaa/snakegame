using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class foodgenerator
    {
        int mapWidth;
        int mapHeight;
        char symb;
        Random rnd = new Random();
        public foodgenerator(int _mapWidth, int _mapHeight, char _symb)
        {
            mapWidth = _mapWidth;
            mapHeight = _mapHeight;
            symb = _symb;
        }
        public point GenerateFood()
        {
            int x = rnd.Next(2, mapWidth - 2);
            int y = rnd.Next(2, mapHeight - 2);
            return new point(x, y, symb);
        }
    }
}
