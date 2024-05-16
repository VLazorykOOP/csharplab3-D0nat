class Worker
{

    protected string name;
    protected int age;
    protected string department;


    public Worker(string name, int age, string department)
    {
        this.name = name;
        this.age = age;
        this.department = department;
    }


    public virtual void Show()
    {
        Console.WriteLine($"Ім'я: {name}");
        Console.WriteLine($"Вік: {age}");
        Console.WriteLine($"Відділ: {department}");
    }
}