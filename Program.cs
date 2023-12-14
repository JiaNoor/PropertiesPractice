namespace PropertiesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var pizza = new Pizza();
            /*Console.WriteLine("I ate " + pizza.Name + " pizza");*/
            //pizza.Name = "Test"; //cannot be set if property is read only
            //pizza.Name = null;
            //pizza.OnSale = false; //The onsale cannot be accessed here b/c th set ancessor is private

            Console.WriteLine("I ate " + pizza.Name + " pizza. The pizza is " + (pizza.OnSale ? "on sale" : "not on sale"));
        }
    }
}
