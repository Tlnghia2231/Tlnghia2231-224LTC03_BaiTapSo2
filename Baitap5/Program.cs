namespace Baitap5
{
    enum PointColor
    {
        LightBlue,
        BloodRed,
        Gold
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }

        public Point(int x, int y, PointColor color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Point(" + X + ", " + Y + ") - Color: " + Color);
        }
    }

    class Rectangle
    {
        public Point UpperLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle(Point upperLeft, Point bottomRight)
        {
            UpperLeft = upperLeft;
            BottomRight = bottomRight;
        }

        public void ShowInfo()
        {
            Console.Write("Upper Left: ");
            UpperLeft.ShowInfo();
            Console.Write("Bottom Right: ");
            BottomRight.ShowInfo();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(2, 3, PointColor.LightBlue);
            Point point2 = new Point(5, 7, PointColor.Gold);
            Console.WriteLine("Danh sach cac diem:");
            point1.ShowInfo();
            point2.ShowInfo();

            Rectangle rectangle = new Rectangle(point1, point2);

            Console.WriteLine("\n");
            Console.WriteLine("Thonh tin hinh chu nhat:");
            rectangle.ShowInfo();
        }
    }
}
