using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class horizontalline : figure
    {
    
        public horizontalline(int xleft, int xright, int y ,char symb)
        {
            pointlist = new List<point>();
            for(int i = xleft; i <= xright; i++)
            {
                point p = new point(i, y, symb);
                pointlist.Add(p);
            }
    
        }
     
        }
    }

