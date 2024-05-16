class Administration : Worker
{

    private string role;


    public Administration(string name, int age, string department, string role) : base(name, age, department)
    {
        this.role = role;
    }


    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Роль: {role}");
    }
}