namespace PropertiesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var pizza = new Pizza();
            Console.WriteLine("I ate " + pizza.Name + " pizza");
            pizza.Name = "Test";
            Console.WriteLine("I ate "+pizza.Name+" pizza");
        }
    }
}
