internal class FloatNumbers
{
    // Приватные поля в стиле 
    private float _number1;
    private float _number2;
    private float _number3;

    // Конструктор с параметрами
    public FloatNumbers(float number1, float number2, float number3)
    {
        _number1 = number1;
        _number2 = number2;
        _number3 = number3;
    }

    // Конструктор копирования
    public FloatNumbers(FloatNumbers FloatNumbers)
    {
        this._number1 = FloatNumbers._number1;
        this._number2 = FloatNumbers._number2;
        this._number3 = FloatNumbers._number3;
    }

    // Свойства
    public float Number1
    {
        get
        {
            return this._number1;
        }
    }

    public float Number2
    {
        get
        {
            return this._number2;
        }
    }

    public float Number3
    {
        get
        {
            return this._number3;
        }
    }

    public static float CorrectInput(string number)
    {
        float result;
        while (true)
        {
            Console.Write(number);
            string input = Console.ReadLine();

            if ((float.TryParse(input, out result)) && (result >= 0))
            {
                return result;
            }

            Console.WriteLine("Ошибка. Введите положительное " +
                              "вещественное число.");
        }
    }

    // Метод для приведения полей к целому типу (явное приведение)
    public void ConvertToInteger()
    {
        _number1 = (int)_number1;
        _number2 = (int)_number2;
        _number3 = (int)_number3;
    }

    // Перегрузка метода ToString()
    public override string ToString()
    {
        return _number1 + " " + _number2 + " " + _number3;
    }
}

// Дочерний класс: Параллелепипед
internal class Parallelepiped : FloatNumbers
{
    public Parallelepiped(float length, float width, float height)
        : base(length, width, height) { }

    public Parallelepiped(Parallelepiped other) : base(other) { }

    // Метод 1: Объем (V = a * b * c)
    public float CalculateVolume()
    {
        return Number1 * Number2 * Number3;
    }

    // Метод 2: Площадь поверхности (S = 2 * (ab + bc + ac))
    public float CalculateSurfaceArea()
    {
        return 2 * (Number1 * Number2 + Number2 * 
                    Number3 + Number1 * Number3);
    }

    public override string ToString()
    {
        return "\nДлина: " + Number1 + " Ширина: " + Number2 + 
               " Высота: " + Number3;
    }
}
