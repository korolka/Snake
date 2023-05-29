using SnakeProject.User_Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject.UI
{
    public class UIService
    {
        private GamePlay gamePlay = new GamePlay();
        private UserService userService = new UserService();
        private User user = new User();
        public void GetMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(60, 10);
            Console.WriteLine("Welcome to snake");
            Console.WriteLine("Press enter to start game");
            Console.WriteLine("Press C to create the user");
            Console.WriteLine("Press S to show all scores");
            Console.WriteLine("Press ESC to quite the game");
        }

        public void GetCommand(ConsoleKey key) 
        {
            switch (key)
            {
                case ConsoleKey.Enter:
                    StartGame();
                    break;
                case ConsoleKey.C:
                    CreateUserForm();
                    break;
                case ConsoleKey.S:
                    ScoreBoard();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    GetMenu();
                    break;
            }
        }

        private void ScoreBoard()
        {
            Console.Clear();
            var users = userService.GetUsers();

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name} = {user.Score}");
            }
            Console.WriteLine("Press backspace to menu");
        }

        private void CreateUserForm()
        {
            Console.Clear();

            label:
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            try
            {
               user = userService.CreateUser(name);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                goto label;
            }

            Console.WriteLine("User was saved");
            Console.WriteLine("Press backspace to menu");
        }

        private void StartGame()
        {
            Console.Clear();
            gamePlay.StartGame(user);
            ShowGameOver();
        }

        public void ShowGameOver()
        {
            Console.Clear();    
            Console.WriteLine("Game over");
            Console.WriteLine("To try again press ENTER");
            Console.WriteLine("Back to menu press Backspace");
        }
    }
}
