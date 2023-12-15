namespace PropertiesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //var pizza = new Pizza() { Name = "Itallian" }; //need to give name of pizza at contruction time

            //pizza.Name = "Test";  //could not be set if property has only init feature
            /*Console.WriteLine("I ate " + pizza.Name + " pizza");*/
            //pizza.Name = "Test"; //cannot be set if property is read only
            //pizza.Name = null;
            //pizza.OnSale = false; //The onsale cannot be accessed here b/c th set ancessor is private

            var pizza = new Pizza();
            pizza.Place = "Itallian";
            pizza.Flavor = "Bbq";
            Console.WriteLine("I ate " + pizza.Name + " pizza. The pizza is " + (pizza.OnSale ? "on sale" : "not on sale") + " with Id: "+ pizza.PizzaId);

            var pizza2 = new Pizza();
            pizza2.Place = "Arabic";
            pizza2.Flavor = "Fajita";
            pizza2.PizzaId = 2;
            Console.WriteLine("I ate " + pizza2.Name + " pizza. The pizza is " + (pizza2.OnSale ? "on sale" : "not on sale") + " with Id: " + pizza2.PizzaId);
        }
    }
}
