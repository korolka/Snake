using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject.Helpers
{
    public static class ColorHelper
    {
        public static ConsoleColor GetRandomColor(int numberOfColor)
        {
            switch (numberOfColor)
            {
                case 1: 
                    return ConsoleColor.Green;
                case 2:
                    return ConsoleColor.Red;
                case 3:
                    return ConsoleColor.Yellow;
                case 4:
                    return ConsoleColor.Cyan;
                case 5:
                    return ConsoleColor.Magenta;
                default:
                    return ConsoleColor.White;
            }
        }
    }
}
