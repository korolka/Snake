namespace SnakeProject
{
    public class Point
    {
        private int left;
        private int top;
        private char symbol;

        public char Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public Point(Point snakeTail)
        {
            left = snakeTail.left;
            top = snakeTail.top;
            symbol = snakeTail.symbol;

        }

        public Point(int left, int top, char symbol)
        {
            this.left = left;
            this.top = top;
            this.symbol = symbol;
        }

        public void DrawPoint()
        {
            Console.SetCursorPosition(left, top);
            Console.Write(symbol);
        }

        public void SetDirection(int i, DirectionEnum direction)
        {
            switch (direction)
            {
                case DirectionEnum.Left:
                    left = left - i;
                    break;
                case DirectionEnum.Right:
                    left = left + i;
                    break;
                case DirectionEnum.Up:
                    top = top - i;
                    break;
                case DirectionEnum.Down:
                    top = top + i;
                    break;
            }
        }

        public void ClearPoint()
        {
            symbol = ' ';
            DrawPoint();
        }

        public bool ComparePoints(Point point)
        {
            return point.left == left && point.top == top;
        }
    }
}
