using SnakeProject.Factory;
using SnakeProject.Helpers;
using SnakeProject.Installers;
using SnakeProject.UI;

namespace SnakeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UIService uI = new UIService();
            uI.GetMenu();

            while (true)
            {   
                ConsoleKeyInfo key = Console.ReadKey();
                uI.GetCommand(key.Key);
            }
        }
    }
}