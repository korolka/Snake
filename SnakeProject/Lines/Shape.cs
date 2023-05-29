namespace SnakeProject.Lines
{
    public class Shape
    {
        protected List<Point> points;
        public void DrawLine()
        {
            foreach (Point point in points)
            {
                point.DrawPoint();
            }
        }

        public bool Collision(Shape shape)
        {
            foreach(var item in points)
            {
                if(shape.ComparePoint(item))
                    return true;
            }
            return false;
        }

        private bool ComparePoint(Point point)
        {
            foreach(var item in points)
            {
                if(point.ComparePoints(item))
                    return true;
            }
            return false;
        }
    }
}
