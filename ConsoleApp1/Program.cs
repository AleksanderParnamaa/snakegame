using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(10, 10, '*');
            point p2 = new point(11, 10, '*');
            horizontalline hline = new horizontalline(10, 15, 5, '*');
            hline.Draw();
            vericalline vline = new vericalline(6, 16, 10, '@');
            vline.Draw();
            horizontalline top = new horizontalline(0, 80, 0, '#');
            top.Draw();
            vericalline left = new vericalline(0, 25, 0, '#');
            left.Draw();
            horizontalline bottom = new horizontalline(0, 80, 25, '$');
            bottom.Draw();
            vericalline right = new vericalline(0, 25, 80, '$');
            right.Draw();
            point snaketail = new point(15, 15, 's');
            snake snake = new snake(snaketail, 5, direction.RIGHT);
            snake.Draw();
            foodgenerator foodgenerator = new foodgenerator(80, 25, '$');
            point food = foodgenerator.GenerateFood();
            food.Draw();
          while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodgenerator.GenerateFood();
                    food.Draw();
                }
                else 
                {
                    snake.Move();
                }
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.handlekeys(key.Key);
                }
                Thread.Sleep(300);
                snake.Move();
            }
            Console.ReadLine();
        }
    }
}
