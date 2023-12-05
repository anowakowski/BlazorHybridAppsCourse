using Microsoft.AspNetCore.Components.Authorization;

namespace CoffeeBrowser.Library.Auth
{
    public interface ICustomAuthenticationStateProvider
    {
        Task<AuthenticationState> GetAuthenticationStateAsync();
        Task LogInAsync();
        void Logout();
    }
}