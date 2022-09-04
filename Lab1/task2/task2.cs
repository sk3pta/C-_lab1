/*
 * Создайте класс с именем Rectangle.
В теле класса создайте два поля, описывающие длины сторон double side1, side2.
Создайте пользовательский конструктор Rectangle(double sideA, double sideB),
в теле которого поля sideA и sideB инициализируются значениями аргументов.
Создайте два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().
Создайте два свойства double Area и double Perimeter с одним методом доступа get.
Напишите программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь. Покройте тестами методы класса Rectangle.
.*/

namespace task2
{
    public class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double sideA, double sideB)
        {
            this.side1 = sideA;
            this.side2 = sideB;
        }

        public Rectangle()
        {
            this.side1 = 0;
            this.side2 = 0;
        }

        private double AreaCalculator()
        { return side1 * side2; }

        private double PerimeterCalculator()
        { return 2 * side1 + 2 * side2; }

        public double Area
        {
            get { return this.AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return this.PerimeterCalculator(); }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("First : ? \n");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return;
            double sizeA = double.Parse(input);

            Console.WriteLine("Second : ? \n");
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return;
            double sizeB = Convert.ToDouble(Console.ReadLine());
            Rectangle rec = new Rectangle(sizeA, sizeB);

            Console.WriteLine($"Area {rec.Area} | Perimeter {rec.Perimeter}");
        }
    }
}