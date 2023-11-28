namespace CoffeeBrowser.MAUI.Data
{
    public interface ICoffeeService
    {
        Task<IEnumerable<Coffee>?> LoadCoffeesAsync();
    }
}