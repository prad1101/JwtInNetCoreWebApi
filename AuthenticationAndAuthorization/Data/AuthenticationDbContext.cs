using Microsoft.EntityFrameworkCore;

namespace AuthenticationAndAuthorization.Data
{
    public class AuthenticationDbContext:DbContext
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options):base(options)
        {

        }
    }
}
