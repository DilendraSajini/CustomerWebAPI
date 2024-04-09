using RestaurantFrontEnd.Services.Models;

namespace RestaurantFrontEnd.Services.Services
{
    internal interface ISigninService
    {
        void LoginWithBasicCredentials(Login login);
        void LoginWithWindowsCredentials();
    }
}
