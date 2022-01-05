using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class figure
    {
      protected  List<point> pointlist;
        public void Draw()
        {
            foreach (point point in pointlist)
            {
                point.Draw();
            }
        }
    }
}
