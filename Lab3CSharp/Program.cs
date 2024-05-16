using System.Drawing;

namespace Lab3CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] rectangles = new Rectangle[4];
            rectangles[0] = new Rectangle(3, 4, 1);
            rectangles[1] = new Rectangle(5, 5, 2);
            rectangles[2] = new Rectangle(2, 6, 3);
            rectangles[3] = new Rectangle(4, 4, 4);

            int squareCount = 0;

            foreach (Rectangle rect in rectangles)
            {
                rect.PrintSides();
                Console.WriteLine($"Периметр: {rect.CalculatePerimeter()}");
                Console.WriteLine($"Площа: {rect.CalculateArea()}");
                if (rect.IsSquare())
                {
                    squareCount++;
                }
            }

            Console.WriteLine($"Кількість квадратів: {squareCount}");



            Worker[] workers = new Worker[4];
            workers[0] = new Cadr("Іван Петров", 30, "Кадри", "Головний кадровик");
            workers[1] = new Engineer("Марія Іванова", 35, "Технічний відділ", "Інженер-проектувальник");
            workers[2] = new Engineer("Олексій Сидоров", 40, "Технічний відділ", "Інженер-конструктор");
            workers[3] = new Administration("Ольга Ковальчук", 45, "Адміністрація", "Директор");

            foreach (Worker worker in workers)
            {
                Console.WriteLine("----------");
                worker.Show();
                Console.WriteLine("----------\n");
            }
        }
    }
}