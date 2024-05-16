class Engineer : Worker
{
    // Додаткове поле
    private string specialization;

    // Конструктор
    public Engineer(string name, int age, string department, string specialization) : base(name, age, department)
    {
        this.specialization = specialization;
    }

    // Перевизначений метод Show()
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Спеціалізація: {specialization}");
    }
}