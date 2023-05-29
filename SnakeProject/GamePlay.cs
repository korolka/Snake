using SnakeProject.Factory;
using SnakeProject.Helpers;
using SnakeProject.Installers;
using SnakeProject.User_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject
{
    public class GamePlay
    {
        UserService userService = new UserService();
        public void StartGame(User user)
        {
            if(user == null)
                user = new User();
            int score = 0;

            LineInstaller lineInstaller = new LineInstaller();
            lineInstaller.DrawShape();

            Point food = FoodFactory.GetRandomFood(119, 20, '+');
            Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
            food.DrawPoint();
            Console.ResetColor();

            Snake snake = new Snake();
            snake.CreateSnake(6, new Point(5, 5, 'z'), DirectionEnum.Right);
            snake.DrawLine();

            ScoreHelper.GetScore(score);

            while (true)
            {
                if (lineInstaller.Collision(snake) || snake.CollisionOwnTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    score++;
                    ScoreHelper.GetScore(score);
                    food = FoodFactory.GetRandomFood(119, 20, '+');
                    Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
                    food.DrawPoint();
                    Console.ResetColor();
                }
                Thread.Sleep(100);
                snake.Move();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.PressKey(key.Key);
                }
            }
            user.Score = score;
            userService.SaveScore(user);
        }
    }
}
