using AuthenticationAndAuthorization.Models.Domain;

namespace AuthenticationAndAuthorization.Repostitary
{
    public interface ITokenHandlers
    {
        Task<string> CreateTokenAsync(User user);
    }
}
