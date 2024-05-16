class Cadr : Worker
{

    private string position;
    //

    public Cadr(string name, int age, string department, string position) : base(name, age, department)
    {
        this.position = position;
    }


    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Посада: {position}");
    }
}
