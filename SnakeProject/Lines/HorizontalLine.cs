using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject.Lines
{
    public class HorizontalLine : Shape
    {  
        public HorizontalLine(int left, int top, int count, char symbol)
        {
            points = new List<Point>();

            for (int i = left; i < count; i++)
            {
                Point point = new Point(i, top, symbol);
                points.Add(point);
            }
        }
    }
}
