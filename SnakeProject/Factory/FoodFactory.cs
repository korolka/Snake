using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject.Factory
{
    public static class FoodFactory
    {
        static Random random = new Random();
        public static Point GetRandomFood(int spaceWidth, int spaceHeigth, char symbol)
        {
            spaceHeigth = random.Next(2, spaceHeigth - 2);
            spaceWidth = random.Next(2, spaceWidth - 2);

            return new Point(spaceWidth, spaceHeigth, symbol);
        }
    }
}
