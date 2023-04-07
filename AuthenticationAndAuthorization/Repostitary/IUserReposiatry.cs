using AuthenticationAndAuthorization.Models.Domain;

namespace AuthenticationAndAuthorization.Repostitary
{
    public interface IUserReposiatry
    {
        Task<User> Authenticate(string username,string password);
    }
}
