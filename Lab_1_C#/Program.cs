internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите длину, ширину и " +
                          "высоту параллелепипеда");
        float a = FloatNumbers.CorrectInput("Длина: ");
        float b = FloatNumbers.CorrectInput("Ширина: ");
        float c = FloatNumbers.CorrectInput("Высота: ");

        Parallelepiped Parallelepiped1 = new Parallelepiped(a, b, c);
        Console.WriteLine("Объём: " 
                         + Parallelepiped1.CalculateVolume());

        Console.WriteLine("Площадь поверхности: " 
                         + Parallelepiped1.CalculateSurfaceArea());

        // Тест копирования и приведения к целому
        Parallelepiped Parallelepiped2 = new Parallelepiped(Parallelepiped1);
        Parallelepiped2.ConvertToInteger();
        Console.WriteLine("Параметры параллелепипеда в целых числах" 
                         + Parallelepiped2);
    }
}
