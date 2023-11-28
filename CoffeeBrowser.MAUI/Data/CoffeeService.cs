namespace CoffeeBrowser.MAUI.Data
{
    public class CoffeeService : ICoffeeService
    {
        public async Task<IEnumerable<Coffee>> LoadCoffeesAsync()
        {
            var coffees = new[]
            {
                new Coffee("Cappucino", "Coffee with mil foam"),
                new Coffee("Doppio", "Double espresso")
            };

            await Task.Delay(50);

            return coffees;
        }        
    }
}
