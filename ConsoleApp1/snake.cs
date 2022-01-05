using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class snake : figure
    {
        direction direction;
        public snake(point tail, int length, direction _direction)
        {
            direction = _direction;
            pointlist = new List<point>();
            for (int i = 0; i < length; i++)
            {
                point p = new point(tail);
                p.Move(i, direction);
                pointlist.Add(p);
            }
        }
        public void Move()
        {
            point tail = pointlist.First();
            pointlist.Remove(tail);
            tail.Clear();
            point head = getnextpoint();
            pointlist.Add(head);
            head.Draw();
        }
        public point getnextpoint()
        {
            point head = pointlist.Last();
            point nextpoint = new point(head);
            nextpoint.Move(1, direction);
            return nextpoint;
        }
        public void handlekeys(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = direction.RIGHT;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = direction.DOWN;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = direction.UP;
            }
        }
            public bool Eat(point food)
            {
            point head = getnextpoint();
            if(head.ishit(food))
            {
                food.symb = head.symb;
                pointlist.Add(food);
                return true;
            }
            else
            {
                return false;
            }
            }

        }
    }

