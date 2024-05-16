class Administration : Worker
{
    // Додаткове поле
    private string role;

    // Конструктор
    public Administration(string name, int age, string department, string role) : base(name, age, department)
    {
        this.role = role;
    }

    // Перевизначений метод Show()
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Роль: {role}");
    }
}