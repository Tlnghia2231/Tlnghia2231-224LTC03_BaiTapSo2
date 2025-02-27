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

        public Point(int x_231, int y_231, PointColor color_231)
        {
            X = x_231;
            Y = y_231;
            Color = color_231;
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
            Point point1_231 = new Point(2, 3, PointColor.LightBlue);
            Point point2_231 = new Point(5, 7, PointColor.Gold);
            Console.WriteLine("Danh sach cac diem:");
            point1_231.ShowInfo();
            point2_231.ShowInfo();

            Rectangle rectangle = new Rectangle(point1_231, point2_231);

            Console.WriteLine("\n");
            Console.WriteLine("Thonh tin hinh chu nhat:");
            rectangle.ShowInfo();
        }
    }
}
