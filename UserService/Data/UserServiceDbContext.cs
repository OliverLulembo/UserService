using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UserService.Data
{
    public class UserServiceDbContext : IdentityDbContext<User> 
    {
        public UserServiceDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
