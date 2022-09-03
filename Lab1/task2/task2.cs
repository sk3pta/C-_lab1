/*
 * Создайте класс с именем Rectangle.
В теле класса создайте два поля, описывающие длины сторон double side1, side2.
Создайте пользовательский конструктор Rectangle(double sideA, double sideB), 
в теле которого поля sideA и sideB инициализируются значениями аргументов.
Создайте два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().
Создайте два свойства double Area и double Perimeter с одним методом доступа get.
Напишите программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь. Покройте тестами методы класса Rectangle.
.*/

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


    public double AreaCalculator() { return side1 * side2; }

    public double PerimeterCalculator() { return 2 * side1 + 2 * side2; }

    public double Area
    {
        get { return this.AreaCalculator(); }
    }

    public double Perimeter
    {
        get { return this.PerimeterCalculator(); }
    }

}


public class Task2
{
    public static void Main(string[] args)
    {
        Rectangle rec = new Rectangle(1,2);

    }
}