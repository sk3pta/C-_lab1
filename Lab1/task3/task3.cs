namespace task3
{
    public class Point
    {
        private int x;
        private int y;
        private string name;

        public Point(int x, int y, string name)
        { this.x = x; this.y = y; this.name = name; }

        public int X
        { get { return x; } }

        public int Y
        { get { return y; } }

        public string Name
        { get { return name; } }
    }

    public class Figure
    {
        private List<Point> points = new List<Point>();

        /*
        public Figure(Point p1, Point p2, Point p3)
        {
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            points.Add(p4);
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            points.Add(p4);
            points.Add(p5);
        }

        */

        public Figure(params Point[] par)
        {
            points = new List<Point>();
            for (int x = 0; x < par.Length; ++x)
            {
                points.Add(new Point(par[x].X, par[x].Y, par[x].Name));
            }
        }



        public static double Length(Point p1, Point p2)
        {
            return System.Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }

        private double PerimeterCalculator(List<Point> points)
        {
            double perimeter = 0.0;

            for (int i = 0; i < points.Count - 1; ++i)
            {
                perimeter += Length(points[i], points[i + 1]);
            }

            perimeter += Length(points[0] , points[points.Count -1 ]);

            return perimeter;
        }

        //Props

        public double Perimeter
        { get { return PerimeterCalculator(this.points); } }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            string? input = null;

            Console.Write("What's the figure name?");
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return;
            string figureName = input;

            int pointAmounts = 0;
            Console.Write("How many points does the figure have ?  [3 - 5]");
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return;

            if (!int.TryParse(input, out pointAmounts) || pointAmounts >= 5 && pointAmounts <= 3)
            {
                return;
            }

            List<Point> points = new List<Point>();
            for (byte i = 0; i < pointAmounts; ++i)
            {
                Console.Write("Point (x,y) ? [ INPUT FORMAT : x y ] \n");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input)) return;
                points.Add(new Point(int.Parse(input.Split(" ")[0])
                                    ,int.Parse(input.Split(" ")[1]),
                                     figureName)
                    );
            }

            Figure fig;
       
            if (points.Count == 3) {   fig = new Figure(points[0], points[1], points[2]);
            }
            else if (points.Count == 4) {  fig = new Figure(points[0], points[1], points[2], points[3]); }
            else  {  fig = new Figure(points[0], points[1], points[2], points[3], points[4]); }


            Console.WriteLine($"Figure {figureName} has been created!" + $"It's perimeter equals {fig.Perimeter:.##}");




        }
    }
}