namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Model model = new Model();
            Console.WriteLine(model.cars.Count());
        }
    }
}
