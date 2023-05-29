using SnakeProject.Lines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject.Installers
{
    public class LineInstaller
    {
        private List<Shape> shapes;

        public LineInstaller()
        {
            shapes = new List<Shape>();

            HorizontalLine upLine = new HorizontalLine(0, 0, 120, '-');
            HorizontalLine downLine = new HorizontalLine(0, 20, 120, '-');

            VerticalLine leftLine = new VerticalLine(0, 1, 20, '|');
            VerticalLine rightLine = new VerticalLine(119, 1, 20, '|');

            shapes.AddRange(new List<Shape> { upLine, downLine, leftLine, rightLine });
        }

        public void DrawShape()
        {
            foreach (Shape shape in shapes)
            {
                shape.DrawLine();
            }
        }

        public bool Collision(Shape shape)
        {
            foreach(var item in shapes)
            {
                if(item.Collision(shape))
                    return true;
            }
            return false;
        }
    }
}
