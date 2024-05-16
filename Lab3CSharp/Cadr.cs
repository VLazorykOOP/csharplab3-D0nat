class Cadr : Worker
{
    // Додаткове поле
    private string position;

    // Конструктор
    public Cadr(string name, int age, string department, string position) : base(name, age, department)
    {
        this.position = position;
    }

    // Перевизначений метод Show()
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Посада: {position}");
    }
}
