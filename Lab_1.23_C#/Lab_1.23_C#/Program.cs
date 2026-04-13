internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты точки A: ");
        double x = Point.CorrectInput("x: ");
        double y = Point.CorrectInput("y: ");
        Point A = new Point(x, y);

        double distance = A.CalculateDistance();
        Console.WriteLine("Расстояние до начала координат: " + distance);

        // Тест унарных операций
        A++;
        Console.WriteLine("A++ (увеличили x): " + A);
        A--;
        Console.WriteLine("A-- (уменьшили x): " + A);

        // Тест приведения типов
        int xInt = (int)A; // Явное
        double yDouble = A; // Неявное
        Console.WriteLine("Явный (целое x): " + xInt);
        Console.WriteLine("Неявный (координата y) : " + yDouble);

        Console.WriteLine("Введите координаты точки B: ");
        double x2 = Point.CorrectInput("x: ");
        double y2 = Point.CorrectInput("y: ");
        Point B = new Point(x2, y2);

        // Тест бинарных операций
        double dist = A + B;
        Console.WriteLine("Расстояние между A и B: " + dist);

        Point C = A + 10;
        Console.WriteLine("Правосторонняя (p1 + 5): " + C);

        Point D = 5 + A;
        Console.WriteLine($"Левосторонняя (5 + p1): " + D);
    }
}