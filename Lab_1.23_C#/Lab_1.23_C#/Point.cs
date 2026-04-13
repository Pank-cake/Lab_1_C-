internal class Point
{
    private double _x;
    private double _y;

    // с параметрами
    public Point(double x, double y)
    {
        this._x = x;
        this._y = y;
    }

    // свойства
    public static double CorrectInput(string number)
    {
        double result;
        while (true)
        {
            Console.Write(number);
            string input = Console.ReadLine();

            if (double.TryParse(input, out result))
            {
                return result;
            }

            Console.WriteLine("Ошибка. Введите вещественное число.");
        }
    }

    public double CalculateDistance()
    {
        return Math.Sqrt(_x * _x + _y * _y);
    }

    // Унарные операции
    public static Point operator ++(Point p)
    {
        return new Point(p._x + 1, p._y);
    }

    public static Point operator --(Point p)
    {
        return new Point(p._x - 1, p._y);
    }

    // Операции приведения 
    // Явное приведение
    public static explicit operator int(Point p)
    {
        return (int)p._x;
    }
    // Неявное приведение
    public static implicit operator double(Point p)
    {
        return p._y;
    }

    // Бинарные операции
    public static double operator +(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p2._x - p1._x, 2) 
                       + Math.Pow(p2._y - p1._y, 2));
    }

    // Правосторонняя операция: Point + int (увеличивает x)
    public static Point operator +(Point p, int value)
    {
        return new Point(p._x + value, p._y);
    }

    // Левосторонняя операция: int + Point (увеличивает x)
    public static Point operator +(int value, Point p)
    {
        return new Point(p._x + value, p._y);
    }

    public override string ToString()
    {
        return "Точка с координатами: " + "(" + _x + ";" + _y + ")";
    }
}