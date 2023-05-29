using SnakeProject.Lines;

namespace SnakeProject
{
    public class Snake : Shape
    {
        DirectionEnum direction;
        public Snake()
        {
            points = new List<Point>();
        }
        public void CreateSnake(int lenght, Point snakeTail, DirectionEnum direction)
        {
            this.direction = direction;
            for (int i = 0; i < lenght; i++)
            {
                Point point = new Point(snakeTail);
                point.SetDirection(i, direction);

                points.Add(point);
            }
        }

        public void Move()
        {
            Point tail = points.First();
            points.Remove(tail);

            Point head = new Point(points.Last());
            head.SetDirection(1, direction);
            points.Add(head);

            tail.ClearPoint();
            head.DrawPoint();
        }

        public void PressKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = DirectionEnum.Left;
            else if (key == ConsoleKey.RightArrow)
                direction = DirectionEnum.Right;
            else if (key == ConsoleKey.UpArrow)
                direction = DirectionEnum.Up;
            else if (key == ConsoleKey.DownArrow)
                direction = DirectionEnum.Down;
        }

        public bool Eat(Point point)
        {
            Point head = new Point(points.Last());
            head.SetDirection(1, direction);

            if (head.ComparePoints(point))
            {
                point.Symbol = head.Symbol;
                points.Add(point);
                return true;
            }
            return false;
        }

        public bool CollisionOwnTail()
        {
            Point head = points.Last();

            for (int i = 0; i < points.Count - 1; i++)
            {
                if (head.ComparePoints(points[i]))
                    return true;
            }
            return false;
        }
    }
}
