class Rectangle
{
    // Поля
    protected int a, b; // сторони
    private readonly int c; // колір

    // Конструктор
    public Rectangle(int sideA, int sideB, int color)
    {
        a = sideA;
        b = sideB;
        c = color;
    }

    // Методи
    public void PrintSides()
    {
        Console.WriteLine($"Сторони прямокутника: {a}, {b}");
    }

    public int CalculatePerimeter()
    {
        return 2 * (a + b);
    }

    public int CalculateArea()
    {
        return a * b;
    }

    public bool IsSquare()
    {
        return a == b;
    }

    // Властивості
    public int SideA
    {
        get { return a; }
        set { a = value; }
    }

    public int SideB
    {
        get { return b; }
        set { b = value; }
    }

    public int Color
    {
        get { return c; }
    }
}

