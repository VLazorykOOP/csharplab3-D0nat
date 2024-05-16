class Worker
{
    // Поля
    protected string name;
    protected int age;
    protected string department;

    // Конструктор
    public Worker(string name, int age, string department)
    {
        this.name = name;
        this.age = age;
        this.department = department;
    }

    // Метод для виведення даних про об'єкт класу
    public virtual void Show()
    {
        Console.WriteLine($"Ім'я: {name}");
        Console.WriteLine($"Вік: {age}");
        Console.WriteLine($"Відділ: {department}");
    }
}