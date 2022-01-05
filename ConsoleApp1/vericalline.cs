using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class vericalline : figure
    {

        public vericalline(int yUp, int yDown, int x, char symb)
        {
            pointlist = new List<point>();
            for(int i = yUp; i <= yDown; i++)
            {
                point p = new point(x, i, symb);
                pointlist.Add(p);
            }
                   
        }
        }
    }

